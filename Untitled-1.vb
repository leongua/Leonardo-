' ============================================================================
' DISEGNATORE FIGURE QUADRANGOLARI PARAMETRICHE
' File unico per ZWCAD 2015+
' Versione corretta: anteprima più grande e fix eLockViolation
' ============================================================================

Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Windows.Forms
Imports System.Xml.Serialization

' Imports per ZWCAD 2015
Imports ZwSoft.ZwCAD.ApplicationServices
Imports ZwSoft.ZwCAD.DatabaseServices
Imports ZwSoft.ZwCAD.EditorInput
Imports ZwSoft.ZwCAD.Geometry
Imports ZwSoft.ZwCAD.Runtime
Imports ZwCAD_App = ZwSoft.ZwCAD.ApplicationServices.Application

<Assembly: CommandClass(GetType(DisegnatoreQuadrangoli.Commands))>

Namespace DisegnatoreQuadrangoli

    ' ========================================================================
    ' COMMANDS - ENTRY POINT
    ' ========================================================================
    Public Class Commands
        ' Variabile statica per memorizzare i parametri tra le chiamate
        Private Shared parametriDaDisegnare As ParametriFigura = Nothing

        <CommandMethod("DISEGNAQUADRANGOLO")>
        Public Sub DisegnaQuadrangolo()
            Try
                ' Se ci sono parametri da disegnare, disegna e pulisci
                If parametriDaDisegnare IsNot Nothing Then
                    DisegnoCAD.DisegnaInCAD(parametriDaDisegnare)
                    parametriDaDisegnare = Nothing
                    Return
                End If

                ' Altrimenti mostra il form
                Dim frm As New FormDisegnatoreQuadrangoli()
                ZwCAD_App.ShowModelessDialog(frm)
            Catch ex As System.Exception
                ZwCAD_App.ShowAlertDialog("Errore: " & ex.Message)
            End Try
        End Sub

        Public Shared Sub ImpostaParametriEDisegna(param As ParametriFigura)
            parametriDaDisegnare = param
        End Sub
    End Class

    ' ========================================================================
    ' MODELS - CLASSI DATI
    ' ========================================================================

    Public Enum TipoLato
        Dritto = 0
        Arco = 1
    End Enum

    ''' <summary>
    ''' Parametri completi della figura quadrangolare
    ''' </summary>
    Public Class ParametriFigura
        ' ===== DIMENSIONI BASE (misure teoriche sul dritto) =====
        Public Property LarghezzaSuperiore As Double = 100
        Public Property LarghezzaInferiore As Double = 150
        Public Property Altezza As Double = 80

        ' ===== RACCORDI ANGOLARI (4 indipendenti) =====
        Public Property RaggioSupSx As Double = 5
        Public Property RaggioSupDx As Double = 5
        Public Property RaggioInfSx As Double = 8
        Public Property RaggioInfDx As Double = 8

        ' ===== CONFIGURAZIONE LATO SUPERIORE =====
        Public Property TipoLatoSuperiore As TipoLato = TipoLato.Dritto
        Public Property SporgenzaSuperiore As Double = 0

        ' ===== CONFIGURAZIONE LATO INFERIORE =====
        Public Property TipoLatoInferiore As TipoLato = TipoLato.Dritto
        Public Property SporgenzaInferiore As Double = 0

        ' ===== CONFIGURAZIONE LATI LATERALI (simmetrici) =====
        Public Property TipoLatiLaterali As TipoLato = TipoLato.Dritto
        Public Property SporgenzaLaterali As Double = 0

        ' ===== OPZIONI CAD =====
        Public Property LayerDestinazione As String = "0"
        Public Property ColoreLinea As Integer = 256
        Public Property CreaComeBlocco As Boolean = False
        Public Property NomeBlocco As String = "FIGURA_001"

        Public Function Clone() As ParametriFigura
            Return DirectCast(Me.MemberwiseClone(), ParametriFigura)
        End Function
    End Class

    Public Class PresetFigura
        Public Property Nome As String
        Public Property Parametri As ParametriFigura
        Public Property DataCreazione As DateTime

        Public Sub New()
            DataCreazione = DateTime.Now
        End Sub
    End Class

    Public Class RisultatoValidazione
        Public Property Valido As Boolean
        Public Property Messaggio As String

        Public Sub New(valido As Boolean, messaggio As String)
            Me.Valido = valido
            Me.Messaggio = messaggio
        End Sub
    End Class

    ' ========================================================================
    ' GEOMETRIA HELPER
    ' ========================================================================
    Public Module GeometriaHelper

        Public Function To2d(p As Point3d) As Point2d
            Return New Point2d(p.X, p.Y)
        End Function

        Public Function CalcolaCentroCirconferenza(p1 As Point3d, p2 As Point3d, p3 As Point3d) As Point3d
            Dim ax As Double = p1.X, ay As Double = p1.Y
            Dim bx As Double = p2.X, by As Double = p2.Y
            Dim cx As Double = p3.X, cy As Double = p3.Y

            Dim d As Double = 2 * (ax * (by - cy) + bx * (cy - ay) + cx * (ay - by))

            If Math.Abs(d) < 0.000001 Then
                Return New Point3d((p1.X + p3.X) / 2, (p1.Y + p3.Y) / 2, 0)
            End If

            Dim ux As Double = ((ax * ax + ay * ay) * (by - cy) +
                                (bx * bx + by * by) * (cy - ay) +
                                (cx * cx + cy * cy) * (ay - by)) / d

            Dim uy As Double = ((ax * ax + ay * ay) * (cx - bx) +
                                (bx * bx + by * by) * (ax - cx) +
                                (cx * cx + cy * cy) * (bx - ax)) / d

            Return New Point3d(ux, uy, 0)
        End Function

        Public Function CalcolaBulgePer3Punti(p1 As Point3d, p2 As Point3d, p3 As Point3d) As Double
            Try
                Dim centro As Point3d = CalcolaCentroCirconferenza(p1, p2, p3)
                Dim v1 As Vector3d = (p1 - centro).GetNormal()
                Dim v3 As Vector3d = (p3 - centro).GetNormal()

                Dim angolo As Double = Math.Atan2(v3.Y, v3.X) - Math.Atan2(v1.Y, v1.X)

                If angolo > Math.PI Then angolo -= 2 * Math.PI
                If angolo < -Math.PI Then angolo += 2 * Math.PI

                Dim vMedio As Vector3d = (p2 - centro).GetNormal()
                Dim angoloMedio As Double = Math.Atan2(vMedio.Y, vMedio.X)
                Dim angoloInizio As Double = Math.Atan2(v1.Y, v1.X)
                Dim angoloFine As Double = Math.Atan2(v3.Y, v3.X)

                Dim deltaInizioMedio As Double = angoloMedio - angoloInizio
                Dim deltaInizioFine As Double = angoloFine - angoloInizio

                If deltaInizioMedio < 0 Then deltaInizioMedio += 2 * Math.PI
                If deltaInizioFine < 0 Then deltaInizioFine += 2 * Math.PI

                If deltaInizioMedio > deltaInizioFine Then
                    angolo = -angolo
                End If

                Return Math.Tan(angolo / 4)
            Catch
                Return 0
            End Try
        End Function

        Public Function CalcolaPuntoMedioConSporgenza(p1 As Point3d, p2 As Point3d, sporgenza As Double) As Point3d
            Dim pMedio As New Point3d((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2, 0)
            If Math.Abs(sporgenza) < 0.001 Then Return pMedio

            Dim dir As New Vector3d(p2.X - p1.X, p2.Y - p1.Y, 0)
            If dir.Length < 0.001 Then Return pMedio

            dir = dir.GetNormal()
            Dim normale As New Vector3d(-dir.Y, dir.X, 0)

            Return New Point3d(pMedio.X + normale.X * sporgenza,
                              pMedio.Y + normale.Y * sporgenza, 0)
        End Function

    End Module

    ' ========================================================================
    ' DISEGNO CAD
    ' ========================================================================
    Public Module DisegnoCAD

        Public Function CreaPolilineaParametrica(param As ParametriFigura, puntoInserimento As Point3d) As Polyline
            Dim poly As New Polyline()

            Try
                ' Vertici principali della figura
                Dim P0 As New Point3d(-param.LarghezzaInferiore / 2, 0, 0)
                Dim P1 As New Point3d(param.LarghezzaInferiore / 2, 0, 0)
                Dim P2 As New Point3d(param.LarghezzaSuperiore / 2, param.Altezza, 0)
                Dim P3 As New Point3d(-param.LarghezzaSuperiore / 2, param.Altezza, 0)

                ' Punti dopo i raccordi angolari
                ' LATO INFERIORE: da sinistra (dopo raccordo P0) a destra (prima raccordo P1)
                Dim P0_inf_end As New Point3d(P0.X + param.RaggioInfSx, P0.Y, 0)
                Dim P1_inf_start As New Point3d(P1.X - param.RaggioInfDx, P1.Y, 0)
                
                ' LATO DESTRO: dal basso (dopo raccordo P1) all'alto (prima raccordo P2)
                Dim P1_lat_start As New Point3d(P1.X, P1.Y + param.RaggioInfDx, 0)
                Dim P2_lat_end As New Point3d(P2.X, P2.Y - param.RaggioSupDx, 0)
                
                ' LATO SUPERIORE: da destra (dopo raccordo P2) a sinistra (prima raccordo P3)
                Dim P2_sup_end As New Point3d(P2.X - param.RaggioSupDx, P2.Y, 0)
                Dim P3_sup_start As New Point3d(P3.X + param.RaggioSupSx, P3.Y, 0)
                
                ' LATO SINISTRO: dall'alto (dopo raccordo P3) al basso (prima raccordo P0)
                Dim P3_lat_end As New Point3d(P3.X, P3.Y - param.RaggioSupSx, 0)
                Dim P0_lat_start As New Point3d(P0.X, P0.Y + param.RaggioInfSx, 0)

                Dim idx As Integer = 0

                ' ========== LATO INFERIORE (P0 → P1) ==========
                poly.AddVertexAt(idx, To2d(P0_inf_end), 0, 0, 0)
                
                ' Calcola bulge per sporgenza inferiore se necessario
                Dim bulgeInf As Double = 0
                If param.TipoLatoInferiore = TipoLato.Arco AndAlso Math.Abs(param.SporgenzaInferiore) > 0.001 Then
                    Dim pMedio As Point3d = CalcolaPuntoMedioConSporgenza(P0_inf_end, P1_inf_start, param.SporgenzaInferiore)
                    bulgeInf = CalcolaBulgePer3Punti(P0_inf_end, pMedio, P1_inf_start)
                End If
                poly.SetBulgeAt(idx, bulgeInf)
                idx += 1

                ' ========== RACCORDO P1 (angolo inf dx) ==========
                poly.AddVertexAt(idx, To2d(P1_inf_start), 0, 0, 0)
                If param.RaggioInfDx > 0.001 Then
                    poly.SetBulgeAt(idx, Math.Tan(Math.PI / 8)) ' Raccordo 90°
                End If
                idx += 1

                ' ========== LATO DESTRO (P1 → P2) ==========
                poly.AddVertexAt(idx, To2d(P1_lat_start), 0, 0, 0)
                
                ' Calcola bulge per sporgenza laterale se necessario
                Dim bulgeLat As Double = 0
                If param.TipoLatiLaterali = TipoLato.Arco AndAlso Math.Abs(param.SporgenzaLaterali) > 0.001 Then
                    Dim pMedio As Point3d = CalcolaPuntoMedioConSporgenza(P1_lat_start, P2_lat_end, param.SporgenzaLaterali)
                    bulgeLat = CalcolaBulgePer3Punti(P1_lat_start, pMedio, P2_lat_end)
                End If
                poly.SetBulgeAt(idx, bulgeLat)
                idx += 1

                ' ========== RACCORDO P2 (angolo sup dx) ==========
                poly.AddVertexAt(idx, To2d(P2_lat_end), 0, 0, 0)
                If param.RaggioSupDx > 0.001 Then
                    poly.SetBulgeAt(idx, Math.Tan(Math.PI / 8)) ' Raccordo 90°
                End If
                idx += 1

                ' ========== LATO SUPERIORE (P2 → P3) ==========
                poly.AddVertexAt(idx, To2d(P2_sup_end), 0, 0, 0)
                
                ' Calcola bulge per sporgenza superiore se necessario
                Dim bulgeSup As Double = 0
                If param.TipoLatoSuperiore = TipoLato.Arco AndAlso Math.Abs(param.SporgenzaSuperiore) > 0.001 Then
                    Dim pMedio As Point3d = CalcolaPuntoMedioConSporgenza(P2_sup_end, P3_sup_start, param.SporgenzaSuperiore)
                    bulgeSup = CalcolaBulgePer3Punti(P2_sup_end, pMedio, P3_sup_start)
                End If
                poly.SetBulgeAt(idx, bulgeSup)
                idx += 1

                ' ========== RACCORDO P3 (angolo sup sx) ==========
                poly.AddVertexAt(idx, To2d(P3_sup_start), 0, 0, 0)
                If param.RaggioSupSx > 0.001 Then
                    poly.SetBulgeAt(idx, Math.Tan(Math.PI / 8)) ' Raccordo 90°
                End If
                idx += 1

                ' ========== LATO SINISTRO (P3 → P0) ==========
                poly.AddVertexAt(idx, To2d(P3_lat_end), 0, 0, 0)
                
                ' Calcola bulge per sporgenza laterale sinistra (simmetrica)
                Dim bulgeLatSx As Double = 0
                If param.TipoLatiLaterali = TipoLato.Arco AndAlso Math.Abs(param.SporgenzaLaterali) > 0.001 Then
                    Dim pMedio As Point3d = CalcolaPuntoMedioConSporgenza(P3_lat_end, P0_lat_start, -param.SporgenzaLaterali)
                    bulgeLatSx = CalcolaBulgePer3Punti(P3_lat_end, pMedio, P0_lat_start)
                End If
                poly.SetBulgeAt(idx, bulgeLatSx)
                idx += 1

                ' ========== RACCORDO P0 (angolo inf sx) ==========
                poly.AddVertexAt(idx, To2d(P0_lat_start), 0, 0, 0)
                If param.RaggioInfSx > 0.001 Then
                    poly.SetBulgeAt(idx, Math.Tan(Math.PI / 8)) ' Raccordo 90°
                End If

                poly.Closed = True

                ' Trasla al punto di inserimento
                Dim mat As Matrix3d = Matrix3d.Displacement(New Vector3d(puntoInserimento.X, puntoInserimento.Y, puntoInserimento.Z))
                poly.TransformBy(mat)

                poly.Layer = param.LayerDestinazione
                poly.ColorIndex = param.ColoreLinea

            Catch ex As System.Exception
                Throw New System.Exception("Errore creazione polilinea: " & ex.Message)
            End Try

            Return poly
        End Function

        Public Function DisegnaInCAD(param As ParametriFigura) As Boolean
            Dim doc As Document = ZwCAD_App.DocumentManager.MdiActiveDocument
            Dim ed As Editor = doc.Editor
            Dim db As Database = doc.Database

            Try
                Dim ppo As New PromptPointOptions(vbLf & "Seleziona punto di inserimento: ")
                ppo.AllowNone = False

                Dim ppr As PromptPointResult = ed.GetPoint(ppo)
                If ppr.Status <> PromptStatus.OK Then Return False

                Dim puntoInserimento As Point3d = ppr.Value

                ' Usa il DocumentLock per evitare eLockViolation
                Using docLock As DocumentLock = doc.LockDocument()
                    Dim poly As Polyline = CreaPolilineaParametrica(param, puntoInserimento)

                    Using tr As Transaction = db.TransactionManager.StartTransaction()
                        Dim bt As BlockTable = DirectCast(tr.GetObject(db.BlockTableId, OpenMode.ForRead), BlockTable)
                        Dim btr As BlockTableRecord = DirectCast(tr.GetObject(bt(BlockTableRecord.ModelSpace), OpenMode.ForWrite), BlockTableRecord)

                        If param.CreaComeBlocco Then
                            Dim bloccoId As ObjectId = CreaBlocco(db, param.NomeBlocco, poly, puntoInserimento, tr)
                            If Not bloccoId.IsNull Then
                                Dim br As New BlockReference(puntoInserimento, bloccoId)
                                btr.AppendEntity(br)
                                tr.AddNewlyCreatedDBObject(br, True)
                            End If
                        Else
                            btr.AppendEntity(poly)
                            tr.AddNewlyCreatedDBObject(poly, True)
                        End If

                        tr.Commit()
                    End Using
                End Using

                ed.WriteMessage(vbLf & "✓ Figura creata con successo!")
                Return True

            Catch ex As System.Exception
                ed.WriteMessage(vbLf & "❌ Errore: " & ex.Message)
                Return False
            End Try
        End Function

        Private Function CreaBlocco(db As Database, nomeBlocco As String, poly As Polyline,
                                   origine As Point3d, tr As Transaction) As ObjectId
            Try
                Dim bt As BlockTable = DirectCast(tr.GetObject(db.BlockTableId, OpenMode.ForWrite), BlockTable)

                Dim nomeFinale As String = nomeBlocco
                Dim counter As Integer = 1
                While bt.Has(nomeFinale)
                    nomeFinale = nomeBlocco & "_" & counter.ToString()
                    counter += 1
                End While

                Dim btr As New BlockTableRecord()
                btr.Name = nomeFinale
                btr.Origin = origine

                Dim btrId As ObjectId = bt.Add(btr)
                tr.AddNewlyCreatedDBObject(btr, True)

                btr.AppendEntity(poly)
                tr.AddNewlyCreatedDBObject(poly, True)

                Return btrId

            Catch
                Return ObjectId.Null
            End Try
        End Function

    End Module

    ' ========================================================================
    ' FORM PRINCIPALE
    ' ========================================================================
    Public Class FormDisegnatoreQuadrangoli
        Inherits Form

        ' Controlli dimensioni
        Private WithEvents numLarghSup As NumericUpDown
        Private WithEvents numLarghInf As NumericUpDown
        Private WithEvents numAltezza As NumericUpDown

        ' Controlli raccordi
        Private WithEvents numRaggioSupSx As NumericUpDown
        Private WithEvents numRaggioSupDx As NumericUpDown
        Private WithEvents numRaggioInfSx As NumericUpDown
        Private WithEvents numRaggioInfDx As NumericUpDown

        ' Controlli radio button
        Private WithEvents rbSupDritto As RadioButton
        Private WithEvents rbSupArco As RadioButton
        Private WithEvents rbInfDritto As RadioButton
        Private WithEvents rbInfArco As RadioButton
        Private WithEvents rbLatDritti As RadioButton
        Private WithEvents rbLatArco As RadioButton

        ' Controlli sporgenze
        Private WithEvents numSporgSup As NumericUpDown
        Private WithEvents numSporgInf As NumericUpDown
        Private WithEvents numSporgLat As NumericUpDown

        ' Anteprima
        Private WithEvents picAnteprima As PictureBox
        Private WithEvents lblInfo As Label

        ' Opzioni CAD
        Private WithEvents txtLayer As TextBox
        Private WithEvents chkComesBlocco As CheckBox
        Private WithEvents txtNomeBlocco As TextBox

        ' Pulsanti
        Private WithEvents btnDisegna As Button
        Private WithEvents btnSalvaPreset As Button
        Private WithEvents btnCaricaPreset As Button
        Private WithEvents btnChiudi As Button

        Private parametri As ParametriFigura

        Public Sub New()
            parametri = New ParametriFigura()
            InitializeComponent()
            CaricaParametriInControlli()
            AggiornaAnteprima()
        End Sub

        Private Sub InitializeComponent()
            Me.Text = "🎨 Disegnatore Figure Quadrangolari"
            Me.Size = New Size(900, 800)
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.FormBorderStyle = FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.BackColor = Color.White

            Dim y As Integer = 15

            ' Titolo
            Dim lblTitolo As New Label()
            lblTitolo.Text = "📐 DISEGNATORE FIGURE QUADRANGOLARI"
            lblTitolo.Location = New Point(20, y)
            lblTitolo.Size = New Size(850, 30)
            lblTitolo.Font = New Font("Segoe UI", 14, FontStyle.Bold)
            lblTitolo.ForeColor = Color.FromArgb(0, 120, 215)
            Me.Controls.Add(lblTitolo)
            y += 40

            ' Gruppo Dimensioni
            Dim grpDim As New GroupBox()
            grpDim.Text = "  📏 Dimensioni  "
            grpDim.Location = New Point(20, y)
            grpDim.Size = New Size(420, 120)
            grpDim.Font = New Font("Segoe UI", 9, FontStyle.Bold)

            numLarghSup = New NumericUpDown()
            numLarghSup.Location = New Point(160, 28)
            numLarghSup.Size = New Size(100, 25)
            numLarghSup.DecimalPlaces = 2
            numLarghSup.Minimum = 1
            numLarghSup.Maximum = 10000
            numLarghSup.Value = 100

            numLarghInf = New NumericUpDown()
            numLarghInf.Location = New Point(160, 58)
            numLarghInf.Size = New Size(100, 25)
            numLarghInf.DecimalPlaces = 2
            numLarghInf.Minimum = 1
            numLarghInf.Maximum = 10000
            numLarghInf.Value = 150

            numAltezza = New NumericUpDown()
            numAltezza.Location = New Point(160, 88)
            numAltezza.Size = New Size(100, 25)
            numAltezza.DecimalPlaces = 2
            numAltezza.Minimum = 1
            numAltezza.Maximum = 10000
            numAltezza.Value = 80

            Dim lblLSup As New Label()
            lblLSup.Text = "Largh. Superiore:"
            lblLSup.Location = New Point(15, 30)
            lblLSup.Size = New Size(140, 20)
            lblLSup.Font = New Font("Segoe UI", 9)

            Dim lblLInf As New Label()
            lblLInf.Text = "Largh. Inferiore:"
            lblLInf.Location = New Point(15, 60)
            lblLInf.Size = New Size(140, 20)
            lblLInf.Font = New Font("Segoe UI", 9)

            Dim lblAlt As New Label()
            lblAlt.Text = "Altezza:"
            lblAlt.Location = New Point(15, 90)
            lblAlt.Size = New Size(140, 20)
            lblAlt.Font = New Font("Segoe UI", 9)

            grpDim.Controls.Add(lblLSup)
            grpDim.Controls.Add(numLarghSup)
            grpDim.Controls.Add(lblLInf)
            grpDim.Controls.Add(numLarghInf)
            grpDim.Controls.Add(lblAlt)
            grpDim.Controls.Add(numAltezza)
            Me.Controls.Add(grpDim)

            ' Gruppo Raccordi
            Dim grpRacc As New GroupBox()
            grpRacc.Text = "  🔘 Raccordi  "
            grpRacc.Location = New Point(450, y)
            grpRacc.Size = New Size(420, 120)
            grpRacc.Font = New Font("Segoe UI", 9, FontStyle.Bold)

            numRaggioSupSx = New NumericUpDown()
            numRaggioSupSx.Location = New Point(80, 28)
            numRaggioSupSx.Size = New Size(70, 25)
            numRaggioSupSx.DecimalPlaces = 2
            numRaggioSupSx.Minimum = 0
            numRaggioSupSx.Maximum = 500
            numRaggioSupSx.Value = 5

            numRaggioSupDx = New NumericUpDown()
            numRaggioSupDx.Location = New Point(285, 28)
            numRaggioSupDx.Size = New Size(70, 25)
            numRaggioSupDx.DecimalPlaces = 2
            numRaggioSupDx.Minimum = 0
            numRaggioSupDx.Maximum = 500
            numRaggioSupDx.Value = 5

            numRaggioInfSx = New NumericUpDown()
            numRaggioInfSx.Location = New Point(80, 68)
            numRaggioInfSx.Size = New Size(70, 25)
            numRaggioInfSx.DecimalPlaces = 2
            numRaggioInfSx.Minimum = 0
            numRaggioInfSx.Maximum = 500
            numRaggioInfSx.Value = 8

            numRaggioInfDx = New NumericUpDown()
            numRaggioInfDx.Location = New Point(285, 68)
            numRaggioInfDx.Size = New Size(70, 25)
            numRaggioInfDx.DecimalPlaces = 2
            numRaggioInfDx.Minimum = 0
            numRaggioInfDx.Maximum = 500
            numRaggioInfDx.Value = 8

            Dim lblRSupSx As New Label()
            lblRSupSx.Text = "Sup.Sx:"
            lblRSupSx.Location = New Point(15, 30)
            lblRSupSx.Size = New Size(60, 20)

            Dim lblRSupDx As New Label()
            lblRSupDx.Text = "Sup.Dx:"
            lblRSupDx.Location = New Point(220, 30)
            lblRSupDx.Size = New Size(60, 20)

            Dim lblRInfSx As New Label()
            lblRInfSx.Text = "Inf.Sx:"
            lblRInfSx.Location = New Point(15, 70)
            lblRInfSx.Size = New Size(60, 20)

            Dim lblRInfDx As New Label()
            lblRInfDx.Text = "Inf.Dx:"
            lblRInfDx.Location = New Point(220, 70)
            lblRInfDx.Size = New Size(60, 20)

            grpRacc.Controls.Add(lblRSupSx)
            grpRacc.Controls.Add(numRaggioSupSx)
            grpRacc.Controls.Add(lblRSupDx)
            grpRacc.Controls.Add(numRaggioSupDx)
            grpRacc.Controls.Add(lblRInfSx)
            grpRacc.Controls.Add(numRaggioInfSx)
            grpRacc.Controls.Add(lblRInfDx)
            grpRacc.Controls.Add(numRaggioInfDx)
            Me.Controls.Add(grpRacc)
            y += 130

            ' Gruppo Lato Superiore
            Dim grpSup As New GroupBox()
            grpSup.Text = "  ⬆️ Lato Superiore  "
            grpSup.Location = New Point(20, y)
            grpSup.Size = New Size(420, 90)
            grpSup.Font = New Font("Segoe UI", 9, FontStyle.Bold)

            rbSupDritto = New RadioButton()
            rbSupDritto.Text = "Dritto"
            rbSupDritto.Location = New Point(15, 30)
            rbSupDritto.Size = New Size(80, 20)
            rbSupDritto.Checked = True

            rbSupArco = New RadioButton()
            rbSupArco.Text = "Ad Arco"
            rbSupArco.Location = New Point(100, 30)
            rbSupArco.Size = New Size(80, 20)

            numSporgSup = New NumericUpDown()
            numSporgSup.Location = New Point(100, 58)
            numSporgSup.Size = New Size(80, 25)
            numSporgSup.DecimalPlaces = 2
            numSporgSup.Minimum = -500
            numSporgSup.Maximum = 500
            numSporgSup.Value = 0

            Dim lblSporgSup As New Label()
            lblSporgSup.Text = "Sporgenza:"
            lblSporgSup.Location = New Point(15, 60)
            lblSporgSup.Size = New Size(80, 20)

            grpSup.Controls.Add(rbSupDritto)
            grpSup.Controls.Add(rbSupArco)
            grpSup.Controls.Add(lblSporgSup)
            grpSup.Controls.Add(numSporgSup)
            Me.Controls.Add(grpSup)

            ' Gruppo Lato Inferiore
            Dim grpInf As New GroupBox()
            grpInf.Text = "  ⬇️ Lato Inferiore  "
            grpInf.Location = New Point(450, y)
            grpInf.Size = New Size(420, 90)
            grpInf.Font = New Font("Segoe UI", 9, FontStyle.Bold)

            rbInfDritto = New RadioButton()
            rbInfDritto.Text = "Dritto"
            rbInfDritto.Location = New Point(15, 30)
            rbInfDritto.Size = New Size(80, 20)
            rbInfDritto.Checked = True

            rbInfArco = New RadioButton()
            rbInfArco.Text = "Ad Arco"
            rbInfArco.Location = New Point(100, 30)
            rbInfArco.Size = New Size(80, 20)

            numSporgInf = New NumericUpDown()
            numSporgInf.Location = New Point(100, 58)
            numSporgInf.Size = New Size(80, 25)
            numSporgInf.DecimalPlaces = 2
            numSporgInf.Minimum = -500
            numSporgInf.Maximum = 500
            numSporgInf.Value = 0

            Dim lblSporgInf As New Label()
            lblSporgInf.Text = "Sporgenza:"
            lblSporgInf.Location = New Point(15, 60)
            lblSporgInf.Size = New Size(80, 20)

            grpInf.Controls.Add(rbInfDritto)
            grpInf.Controls.Add(rbInfArco)
            grpInf.Controls.Add(lblSporgInf)
            grpInf.Controls.Add(numSporgInf)
            Me.Controls.Add(grpInf)
            y += 100

            ' Gruppo Lati Laterali
            Dim grpLat As New GroupBox()
            grpLat.Text = "  ◀️▶️ Lati Laterali  "
            grpLat.Location = New Point(20, y)
            grpLat.Size = New Size(420, 90)
            grpLat.Font = New Font("Segoe UI", 9, FontStyle.Bold)

            rbLatDritti = New RadioButton()
            rbLatDritti.Text = "Dritti"
            rbLatDritti.Location = New Point(15, 30)
            rbLatDritti.Size = New Size(80, 20)
            rbLatDritti.Checked = True

            rbLatArco = New RadioButton()
            rbLatArco.Text = "Ad Arco"
            rbLatArco.Location = New Point(100, 30)
            rbLatArco.Size = New Size(80, 20)

            numSporgLat = New NumericUpDown()
            numSporgLat.Location = New Point(100, 58)
            numSporgLat.Size = New Size(80, 25)
            numSporgLat.DecimalPlaces = 2
            numSporgLat.Minimum = -500
            numSporgLat.Maximum = 500
            numSporgLat.Value = 0

            Dim lblSporgLat As New Label()
            lblSporgLat.Text = "Sporgenza:"
            lblSporgLat.Location = New Point(15, 60)
            lblSporgLat.Size = New Size(80, 20)

            grpLat.Controls.Add(rbLatDritti)
            grpLat.Controls.Add(rbLatArco)
            grpLat.Controls.Add(lblSporgLat)
            grpLat.Controls.Add(numSporgLat)
            Me.Controls.Add(grpLat)

            ' Gruppo Anteprima - AUMENTATO L'ALTEZZA
            Dim grpAnt As New GroupBox()
            grpAnt.Text = "  📊 Anteprima  "
            grpAnt.Location = New Point(450, y)
            grpAnt.Size = New Size(420, 360)
            grpAnt.Font = New Font("Segoe UI", 9, FontStyle.Bold)

            ' PictureBox più grande: 300px di altezza invece di 180px
            picAnteprima = New PictureBox()
            picAnteprima.Location = New Point(10, 25)
            picAnteprima.Size = New Size(400, 300)
            picAnteprima.BackColor = Color.FromArgb(250, 250, 250)
            picAnteprima.BorderStyle = BorderStyle.FixedSingle

            lblInfo = New Label()
            lblInfo.Location = New Point(10, 330)
            lblInfo.Size = New Size(400, 25)
            lblInfo.Font = New Font("Segoe UI", 8)
            lblInfo.ForeColor = Color.DarkBlue
            lblInfo.TextAlign = ContentAlignment.MiddleCenter

            grpAnt.Controls.Add(picAnteprima)
            grpAnt.Controls.Add(lblInfo)
            Me.Controls.Add(grpAnt)
            y += 370

            ' Gruppo Opzioni
            Dim grpOpt As New GroupBox()
            grpOpt.Text = "  ⚙️ Opzioni  "
            grpOpt.Location = New Point(20, y)
            grpOpt.Size = New Size(850, 80)
            grpOpt.Font = New Font("Segoe UI", 9, FontStyle.Bold)

            txtLayer = New TextBox()
            txtLayer.Location = New Point(70, 28)
            txtLayer.Size = New Size(120, 25)
            txtLayer.Text = "0"

            chkComesBlocco = New CheckBox()
            chkComesBlocco.Text = "Crea come Blocco"
            chkComesBlocco.Location = New Point(220, 30)
            chkComesBlocco.Size = New Size(150, 20)

            txtNomeBlocco = New TextBox()
            txtNomeBlocco.Location = New Point(450, 28)
            txtNomeBlocco.Size = New Size(150, 25)
            txtNomeBlocco.Text = "FIGURA_001"
            txtNomeBlocco.Enabled = False

            Dim lblLayer As New Label()
            lblLayer.Text = "Layer:"
            lblLayer.Location = New Point(15, 30)
            lblLayer.Size = New Size(50, 20)

            Dim lblNome As New Label()
            lblNome.Text = "Nome:"
            lblNome.Location = New Point(390, 30)
            lblNome.Size = New Size(50, 20)

            grpOpt.Controls.Add(lblLayer)
            grpOpt.Controls.Add(txtLayer)
            grpOpt.Controls.Add(chkComesBlocco)
            grpOpt.Controls.Add(lblNome)
            grpOpt.Controls.Add(txtNomeBlocco)
            Me.Controls.Add(grpOpt)
            y += 90

            ' Pulsanti
            btnDisegna = New Button()
            btnDisegna.Text = "✏️ DISEGNA"
            btnDisegna.Location = New Point(450, y)
            btnDisegna.Size = New Size(200, 50)
            btnDisegna.Font = New Font("Segoe UI", 12, FontStyle.Bold)
            btnDisegna.BackColor = Color.FromArgb(40, 167, 69)
            btnDisegna.ForeColor = Color.White
            btnDisegna.FlatStyle = FlatStyle.Flat
            btnDisegna.Cursor = Cursors.Hand

            btnSalvaPreset = New Button()
            btnSalvaPreset.Text = "💾 Salva"
            btnSalvaPreset.Location = New Point(20, y)
            btnSalvaPreset.Size = New Size(130, 45)
            btnSalvaPreset.Cursor = Cursors.Hand

            btnCaricaPreset = New Button()
            btnCaricaPreset.Text = "📂 Carica"
            btnCaricaPreset.Location = New Point(160, y)
            btnCaricaPreset.Size = New Size(100, 45)
            btnCaricaPreset.Cursor = Cursors.Hand

            btnChiudi = New Button()
            btnChiudi.Text = "❌ Chiudi"
            btnChiudi.Location = New Point(670, y)
            btnChiudi.Size = New Size(100, 50)
            btnChiudi.Cursor = Cursors.Hand

            Me.Controls.Add(btnDisegna)
            Me.Controls.Add(btnSalvaPreset)
            Me.Controls.Add(btnCaricaPreset)
            Me.Controls.Add(btnChiudi)
        End Sub

        Private Sub CaricaParametriInControlli()
            numLarghSup.Value = CDec(parametri.LarghezzaSuperiore)
            numLarghInf.Value = CDec(parametri.LarghezzaInferiore)
            numAltezza.Value = CDec(parametri.Altezza)
            numRaggioSupSx.Value = CDec(parametri.RaggioSupSx)
            numRaggioSupDx.Value = CDec(parametri.RaggioSupDx)
            numRaggioInfSx.Value = CDec(parametri.RaggioInfSx)
            numRaggioInfDx.Value = CDec(parametri.RaggioInfDx)
            rbSupDritto.Checked = (parametri.TipoLatoSuperiore = TipoLato.Dritto)
            rbSupArco.Checked = (parametri.TipoLatoSuperiore = TipoLato.Arco)
            numSporgSup.Value = CDec(parametri.SporgenzaSuperiore)
            rbInfDritto.Checked = (parametri.TipoLatoInferiore = TipoLato.Dritto)
            rbInfArco.Checked = (parametri.TipoLatoInferiore = TipoLato.Arco)
            numSporgInf.Value = CDec(parametri.SporgenzaInferiore)
            rbLatDritti.Checked = (parametri.TipoLatiLaterali = TipoLato.Dritto)
            rbLatArco.Checked = (parametri.TipoLatiLaterali = TipoLato.Arco)
            numSporgLat.Value = CDec(parametri.SporgenzaLaterali)
            txtLayer.Text = parametri.LayerDestinazione
            chkComesBlocco.Checked = parametri.CreaComeBlocco
            txtNomeBlocco.Text = parametri.NomeBlocco
            txtNomeBlocco.Enabled = chkComesBlocco.Checked
        End Sub

        Private Sub AggiornaParametriDaControlli()
            parametri.LarghezzaSuperiore = CDbl(numLarghSup.Value)
            parametri.LarghezzaInferiore = CDbl(numLarghInf.Value)
            parametri.Altezza = CDbl(numAltezza.Value)
            parametri.RaggioSupSx = CDbl(numRaggioSupSx.Value)
            parametri.RaggioSupDx = CDbl(numRaggioSupDx.Value)
            parametri.RaggioInfSx = CDbl(numRaggioInfSx.Value)
            parametri.RaggioInfDx = CDbl(numRaggioInfDx.Value)
            parametri.TipoLatoSuperiore = If(rbSupDritto.Checked, TipoLato.Dritto, TipoLato.Arco)
            parametri.SporgenzaSuperiore = CDbl(numSporgSup.Value)
            parametri.TipoLatoInferiore = If(rbInfDritto.Checked, TipoLato.Dritto, TipoLato.Arco)
            parametri.SporgenzaInferiore = CDbl(numSporgInf.Value)
            parametri.TipoLatiLaterali = If(rbLatDritti.Checked, TipoLato.Dritto, TipoLato.Arco)
            parametri.SporgenzaLaterali = CDbl(numSporgLat.Value)
            parametri.LayerDestinazione = txtLayer.Text
            parametri.CreaComeBlocco = chkComesBlocco.Checked
            parametri.NomeBlocco = txtNomeBlocco.Text
        End Sub

        Private Sub AggiornaAnteprima()
            If picAnteprima Is Nothing Then Return
            Try
                AggiornaParametriDaControlli()
                Dim validazione As RisultatoValidazione = ValidaParametri()
                If Not validazione.Valido Then
                    lblInfo.Text = "⚠️ " & validazione.Messaggio
                    lblInfo.ForeColor = Color.Red
                    btnDisegna.Enabled = False
                    Return
                End If
                lblInfo.Text = "✓ Parametri validi"
                lblInfo.ForeColor = Color.Green
                btnDisegna.Enabled = True
                DisegnaAnteprima()
            Catch ex As System.Exception
                lblInfo.Text = "❌ " & ex.Message
                lblInfo.ForeColor = Color.Red
                btnDisegna.Enabled = False
            End Try
        End Sub

        Private Sub DisegnaAnteprima()
            If picAnteprima.Image IsNot Nothing Then picAnteprima.Image.Dispose()
            Dim bmp As New Bitmap(picAnteprima.Width, picAnteprima.Height)
            Using g As Graphics = Graphics.FromImage(bmp)
                g.SmoothingMode = SmoothingMode.AntiAlias
                g.Clear(Color.FromArgb(250, 250, 250))

                ' Calcola dimensioni totali
                Dim margine As Double = 30
                Dim larghMax As Double = Math.Max(parametri.LarghezzaSuperiore, parametri.LarghezzaInferiore) + Math.Abs(parametri.SporgenzaLaterali) * 2
                Dim altMax As Double = parametri.Altezza + Math.Abs(parametri.SporgenzaSuperiore) + Math.Abs(parametri.SporgenzaInferiore)
                
                Dim scala As Double = Math.Min((picAnteprima.Width - 2 * margine) / larghMax, (picAnteprima.Height - 2 * margine) / altMax)
                
                Dim offsetX As Double = picAnteprima.Width / 2
                Dim offsetY As Double = picAnteprima.Height / 2 + (parametri.Altezza * scala) / 2

                Using pen As New Pen(Color.FromArgb(0, 120, 215), 2)
                    ' Vertici principali
                    Dim P0 As New PointF(CSng(-parametri.LarghezzaInferiore / 2 * scala + offsetX), CSng(offsetY))
                    Dim P1 As New PointF(CSng(parametri.LarghezzaInferiore / 2 * scala + offsetX), CSng(offsetY))
                    Dim P2 As New PointF(CSng(parametri.LarghezzaSuperiore / 2 * scala + offsetX), CSng(offsetY - parametri.Altezza * scala))
                    Dim P3 As New PointF(CSng(-parametri.LarghezzaSuperiore / 2 * scala + offsetX), CSng(offsetY - parametri.Altezza * scala))

                    ' Punti dopo i raccordi
                    Dim P0_inf_end As New PointF(P0.X + CSng(parametri.RaggioInfSx * scala), P0.Y)
                    Dim P1_inf_start As New PointF(P1.X - CSng(parametri.RaggioInfDx * scala), P1.Y)
                    Dim P1_lat_start As New PointF(P1.X, P1.Y + CSng(parametri.RaggioInfDx * scala))
                    Dim P2_lat_end As New PointF(P2.X, P2.Y - CSng(parametri.RaggioSupDx * scala))
                    Dim P2_sup_end As New PointF(P2.X - CSng(parametri.RaggioSupDx * scala), P2.Y)
                    Dim P3_sup_start As New PointF(P3.X + CSng(parametri.RaggioSupSx * scala), P3.Y)
                    Dim P3_lat_end As New PointF(P3.X, P3.Y - CSng(parametri.RaggioSupSx * scala))
                    Dim P0_lat_start As New PointF(P0.X, P0.Y + CSng(parametri.RaggioInfSx * scala))

                    Dim path As New GraphicsPath()
                    
                    ' Inizia dal punto P0_inf_end
                    path.StartFigure()
                    
                    ' ========== LATO INFERIORE ==========
                    If parametri.TipoLatoInferiore = TipoLato.Arco AndAlso Math.Abs(parametri.SporgenzaInferiore) > 0.1 Then
                        ' Arco con sporgenza
                        Dim pM As New PointF((P0_inf_end.X + P1_inf_start.X) / 2, P0_inf_end.Y + CSng(parametri.SporgenzaInferiore * scala))
                        For t As Double = 0 To 1 Step 0.05
                            Dim px As Single = CSng((1 - t) * (1 - t) * P0_inf_end.X + 2 * (1 - t) * t * pM.X + t * t * P1_inf_start.X)
                            Dim py As Single = CSng((1 - t) * (1 - t) * P0_inf_end.Y + 2 * (1 - t) * t * pM.Y + t * t * P1_inf_start.Y)
                            If t = 0 Then path.AddLine(P0_inf_end, New PointF(px, py)) Else path.AddLine(GetLastPoint(path), New PointF(px, py))
                        Next
                    Else
                        ' Linea dritta
                        path.AddLine(P0_inf_end, P1_inf_start)
                    End If
                    
                    ' ========== RACCORDO P1 ==========
                    If parametri.RaggioInfDx > 0.001 Then
                        Dim rect As New RectangleF(P1.X - CSng(parametri.RaggioInfDx * scala), P1.Y, CSng(parametri.RaggioInfDx * scala * 2), CSng(parametri.RaggioInfDx * scala * 2))
                        path.AddArc(rect, 180, 90)
                    Else
                        path.AddLine(P1_inf_start, P1_lat_start)
                    End If
                    
                    ' ========== LATO DESTRO ==========
                    If parametri.TipoLatiLaterali = TipoLato.Arco AndAlso Math.Abs(parametri.SporgenzaLaterali) > 0.1 Then
                        Dim pM As New PointF(P1_lat_start.X + CSng(parametri.SporgenzaLaterali * scala), (P1_lat_start.Y + P2_lat_end.Y) / 2)
                        For t As Double = 0 To 1 Step 0.05
                            Dim px As Single = CSng((1 - t) * (1 - t) * P1_lat_start.X + 2 * (1 - t) * t * pM.X + t * t * P2_lat_end.X)
                            Dim py As Single = CSng((1 - t) * (1 - t) * P1_lat_start.Y + 2 * (1 - t) * t * pM.Y + t * t * P2_lat_end.Y)
                            path.AddLine(GetLastPoint(path), New PointF(px, py))
                        Next
                    Else
                        path.AddLine(P1_lat_start, P2_lat_end)
                    End If
                    
                    ' ========== RACCORDO P2 ==========
                    If parametri.RaggioSupDx > 0.001 Then
                        Dim rect As New RectangleF(P2.X - CSng(parametri.RaggioSupDx * scala), P2.Y - CSng(parametri.RaggioSupDx * scala), CSng(parametri.RaggioSupDx * scala * 2), CSng(parametri.RaggioSupDx * scala * 2))
                        path.AddArc(rect, 90, 90)
                    Else
                        path.AddLine(P2_lat_end, P2_sup_end)
                    End If
                    
                    ' ========== LATO SUPERIORE ==========
                    If parametri.TipoLatoSuperiore = TipoLato.Arco AndAlso Math.Abs(parametri.SporgenzaSuperiore) > 0.1 Then
                        Dim pM As New PointF((P2_sup_end.X + P3_sup_start.X) / 2, P2_sup_end.Y - CSng(parametri.SporgenzaSuperiore * scala))
                        For t As Double = 0 To 1 Step 0.05
                            Dim px As Single = CSng((1 - t) * (1 - t) * P2_sup_end.X + 2 * (1 - t) * t * pM.X + t * t * P3_sup_start.X)
                            Dim py As Single = CSng((1 - t) * (1 - t) * P2_sup_end.Y + 2 * (1 - t) * t * pM.Y + t * t * P3_sup_start.Y)
                            path.AddLine(GetLastPoint(path), New PointF(px, py))
                        Next
                    Else
                        path.AddLine(P2_sup_end, P3_sup_start)
                    End If
                    
                    ' ========== RACCORDO P3 ==========
                    If parametri.RaggioSupSx > 0.001 Then
                        Dim rect As New RectangleF(P3.X - CSng(parametri.RaggioSupSx * scala), P3.Y - CSng(parametri.RaggioSupSx * scala), CSng(parametri.RaggioSupSx * scala * 2), CSng(parametri.RaggioSupSx * scala * 2))
                        path.AddArc(rect, 0, 90)
                    Else
                        path.AddLine(P3_sup_start, P3_lat_end)
                    End If
                    
                    ' ========== LATO SINISTRO ==========
                    If parametri.TipoLatiLaterali = TipoLato.Arco AndAlso Math.Abs(parametri.SporgenzaLaterali) > 0.1 Then
                        Dim pM As New PointF(P3_lat_end.X - CSng(parametri.SporgenzaLaterali * scala), (P3_lat_end.Y + P0_lat_start.Y) / 2)
                        For t As Double = 0 To 1 Step 0.05
                            Dim px As Single = CSng((1 - t) * (1 - t) * P3_lat_end.X + 2 * (1 - t) * t * pM.X + t * t * P0_lat_start.X)
                            Dim py As Single = CSng((1 - t) * (1 - t) * P3_lat_end.Y + 2 * (1 - t) * t * pM.Y + t * t * P0_lat_start.Y)
                            path.AddLine(GetLastPoint(path), New PointF(px, py))
                        Next
                    Else
                        path.AddLine(P3_lat_end, P0_lat_start)
                    End If
                    
                    ' ========== RACCORDO P0 ==========
                    If parametri.RaggioInfSx > 0.001 Then
                        Dim rect As New RectangleF(P0.X - CSng(parametri.RaggioInfSx * scala), P0.Y, CSng(parametri.RaggioInfSx * scala * 2), CSng(parametri.RaggioInfSx * scala * 2))
                        path.AddArc(rect, 270, 90)
                    Else
                        path.AddLine(P0_lat_start, P0_inf_end)
                    End If
                    
                    path.CloseFigure()
                    g.DrawPath(pen, path)

                    ' Assi di riferimento
                    Using penA As New Pen(Color.LightGray, 1) With {.DashStyle = DashStyle.Dash}
                        g.DrawLine(penA, CSng(offsetX), 0, CSng(offsetX), picAnteprima.Height)
                        g.DrawLine(penA, 0, CSng(offsetY), picAnteprima.Width, CSng(offsetY))
                    End Using
                End Using
            End Using
            picAnteprima.Image = bmp
        End Sub

        Private Function ValidaParametri() As RisultatoValidazione
            If parametri.LarghezzaSuperiore <= 0 Then Return New RisultatoValidazione(False, "Larghezza superiore > 0")
            If parametri.LarghezzaInferiore <= 0 Then Return New RisultatoValidazione(False, "Larghezza inferiore > 0")
            If parametri.Altezza <= 0 Then Return New RisultatoValidazione(False, "Altezza > 0")
            If parametri.RaggioSupSx + parametri.RaggioSupDx > parametri.LarghezzaSuperiore Then Return New RisultatoValidazione(False, "Raccordi superiori troppo grandi")
            If parametri.RaggioInfSx + parametri.RaggioInfDx > parametri.LarghezzaInferiore Then Return New RisultatoValidazione(False, "Raccordi inferiori troppo grandi")
            If Math.Max(parametri.RaggioSupSx, parametri.RaggioInfSx) * 2 > parametri.Altezza Then Return New RisultatoValidazione(False, "Raccordi sx troppo grandi")
            If Math.Max(parametri.RaggioSupDx, parametri.RaggioInfDx) * 2 > parametri.Altezza Then Return New RisultatoValidazione(False, "Raccordi dx troppo grandi")
            Return New RisultatoValidazione(True, "OK")
        End Function

        Private Sub Parametro_ValueChanged(sender As Object, e As EventArgs) Handles numLarghSup.ValueChanged, numLarghInf.ValueChanged, numAltezza.ValueChanged,
                numRaggioSupSx.ValueChanged, numRaggioSupDx.ValueChanged, numRaggioInfSx.ValueChanged, numRaggioInfDx.ValueChanged,
                numSporgSup.ValueChanged, numSporgInf.ValueChanged, numSporgLat.ValueChanged,
                rbSupDritto.CheckedChanged, rbSupArco.CheckedChanged, rbInfDritto.CheckedChanged, rbInfArco.CheckedChanged, rbLatDritti.CheckedChanged, rbLatArco.CheckedChanged
            AggiornaAnteprima()
        End Sub

        Private Sub chkComesBlocco_CheckedChanged(sender As Object, e As EventArgs) Handles chkComesBlocco.CheckedChanged
            txtNomeBlocco.Enabled = chkComesBlocco.Checked
        End Sub

        Private Sub btnDisegna_Click(sender As Object, e As EventArgs) Handles btnDisegna.Click
            Try
                AggiornaParametriDaControlli()
                Dim val As RisultatoValidazione = ValidaParametri()
                If Not val.Valido Then
                    MessageBox.Show(val.Messaggio, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                ' Chiudi il form PRIMA di disegnare per evitare eLockViolation
                Commands.ImpostaParametriEDisegna(parametri.Clone())
                Me.Close()
                
                ' Richiama il comando che ora disegnerà
                Dim doc As Document = ZwCAD_App.DocumentManager.MdiActiveDocument
                doc.SendStringToExecute("DISEGNAQUADRANGOLO" & vbCr, True, False, False)

            Catch ex As System.Exception
                MessageBox.Show("Errore: " & ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub btnSalvaPreset_Click(sender As Object, e As EventArgs) Handles btnSalvaPreset.Click
            Try
                Dim nome As String = InputBox("Nome preset:", "Salva", "Preset_" & DateTime.Now.ToString("HHmmss"))
                If String.IsNullOrEmpty(nome) Then Return

                AggiornaParametriDaControlli()

                Dim preset As New PresetFigura()
                preset.Nome = nome
                preset.Parametri = parametri.Clone()

                Dim sfd As New SaveFileDialog()
                sfd.Filter = "XML|*.xml"
                sfd.FileName = nome & ".xml"

                If sfd.ShowDialog() = DialogResult.OK Then
                    Dim serializer As New XmlSerializer(GetType(PresetFigura))
                    Using w As New StreamWriter(sfd.FileName)
                        serializer.Serialize(w, preset)
                    End Using
                    MessageBox.Show("✓ Salvato!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                sfd.Dispose()
            Catch ex As System.Exception
                MessageBox.Show("Errore: " & ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub btnCaricaPreset_Click(sender As Object, e As EventArgs) Handles btnCaricaPreset.Click
            Try
                Dim ofd As New OpenFileDialog()
                ofd.Filter = "XML|*.xml"

                If ofd.ShowDialog() = DialogResult.OK Then
                    Dim serializer As New XmlSerializer(GetType(PresetFigura))
                    Using r As New StreamReader(ofd.FileName)
                        Dim p As PresetFigura = DirectCast(serializer.Deserialize(r), PresetFigura)
                        parametri = p.Parametri.Clone()
                        CaricaParametriInControlli()
                        AggiornaAnteprima()
                    End Using
                    MessageBox.Show("✓ Caricato!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                ofd.Dispose()
            Catch ex As System.Exception
                MessageBox.Show("Errore: " & ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub btnChiudi_Click(sender As Object, e As EventArgs) Handles btnChiudi.Click
            Me.Close()
        End Sub

    End Class

End Namespace