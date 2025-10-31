# Leonardo Pattern Design Software - Documentazione Dettagliata

**VERSIONE 3.1.0**

**CONCESSA A USO DIMOSTRATIVO**

Sviluppatore: LEONARDO GUASQUI  
Contatti: leonardo@guasqui.it  
Sito Web: www.guasqui.it  
Tutti i diritti riservati.

---

## INDICE

1. [Struttura del Software](#struttura-del-software)
2. [Gestione Licenza](#1-gestione-licenza)
3. [Elaborazione Pezzi AAMA](#2-elaborazione-pezzi-aama)
4. [Gestione Testo e Attributi](#3-gestione-testo-e-attributi)
5. [Inserimento Blocchi e Simboli](#4-inserimento-blocchi-e-simboli)
6. [Disegno Geometrico](#5-disegno-geometrico)
7. [Gestione Dati Pezzi](#6-gestione-dati-pezzi)
8. [Estrazione Modaris](#7-estrazione-modaris)
9. [Modifica Avanzata](#8-modifica-avanzata)
10. [Utilità e Calcolo](#9-utilità-e-calcolo)
11. [Gestione Polilinee](#10-gestione-polilinee)
12. [Preparazione Stampa e Nesting](#11-preparazione-stampa-e-nesting)
13. [Gestione Tacche](#12-gestione-tacche)
14. [Gestione Layer e Colori](#13-gestione-layer-e-colori)
15. [Gestione Offset](#14-gestione-offset)
16. [Scorciatoie da Tastiera](#scorciatoie-da-tastiera)
17. [Configurazione](#configurazione)

---

## Compatibilità

Leonardo Pattern Design Software è stato sviluppato principalmente per funzionare in ambiente **ZWCAD**, dove offre piena compatibilità e integrazione con tutti i comandi specifici del programma. Questo garantisce un'esperienza utente fluida e accesso a funzionalità avanzate che potrebbero non essere disponibili in altre piattaforme.

Tuttavia, il software può essere installato e utilizzato anche su **AutoCAD**. In questo caso, la compatibilità è **parziale**. Alcune funzionalità specifiche, specialmente quelle legate a comandi ZWCAD proprietari o a interazioni molto specifiche con l'interfaccia, potrebbero non funzionare correttamente o presentare comportamenti diversi. Si consiglia di testare le funzionalità chiave in un ambiente AutoCAD prima di utilizzare il software in produzione.

---

## 1. GESTIONE LICENZA

La gestione della licenza è un aspetto fondamentale del software. Senza una licenza valida, il software non funzionerà correttamente. Questa sezione descrive i comandi necessari per attivare, verificare e gestire lo stato della licenza.

### Dettagli Tecnici del Sistema di Licenza

Il sistema di licenza implementa un algoritmo di cifratura avanzato:

- **ID Sistema**: Generato tramite hash delle variabili d'ambiente (`PROCESSOR_IDENTIFIER`, `COMPUTERNAME`, `USERPROFILE`)
- **Codice Licenza**: Stringa di 10 caratteri utilizzando il charset "gsqlrd491c"
- **Algoritmo**:
  - Matrice di trasformazione creata dall'ID macchina
  - Token base (`gsqlrd491c`) trasformato due volte con matrici diverse
  - Cifratura finale salvata con shift +7 in `C:/Leonardo/license.dat`
- **Validazione**: Il codice inserito deve corrispondere esattamente al codice calcolato per l'ID macchina

![licenza.png](INSTALLAZIONE/licenza.png)

| Comando | Icona | Descrizione |
|---------|-------|-------------|
| `c:activate-license` | ![activate-license.bmp](INSTALLAZIONE/menu/LEONARDO/activate-license.bmp) | Avvia il processo per attivare la tua licenza software. Questo comando richiederà il codice di attivazione fornito dallo sviluppatore. |
| `c:show-system-id` | ![show-system-id.bmp](INSTALLAZIONE/menu/LEONARDO/show-system-id.bmp) | Visualizza l'identificativo unico del tuo sistema, utile per il supporto. Questo ID è necessario per ottenere il codice di attivazione. |
| `c:reset-license` | ![reset-license.bmp](INSTALLAZIONE/menu/LEONARDO/reset-license.bmp) | Resetta lo stato della licenza (utilizzato solo per scopi di diagnostica). Questo comando dovrebbe essere utilizzato solo su richiesta dello sviluppatore. |

---

## 2. ELABORAZIONE PEZZI AAMA

I comandi in questa sezione sono centrali per il processo di preparazione dei pezzi per il nesting e la produzione.Questi comandi sono progettati per convertire le sagome grezze in pezzi pronti per le macchine da taglio o plotter.

### Processori AAMA Principali

| Comando | Icona | Descrizione |
|---------|-------|-------------|
| `c:aama` | ![AAMA.BMP](INSTALLAZIONE/menu/LEONARDO/AAMA.BMP) | **Processore principale AAMA**. Workflow tecnico:<br>1. Seleziona polilinee sui layer `ENDCUT`, `OUTCUT`, `TAVOLA_DI_STAMPA_TAGLIO`, `TAVOLA_DI_STAMPA`, `PIT_DIS_TA_CONT`, `PIT_DIS_AREA`<br>2. Estrae dati dai blocchi PITDATIT/DATIT (attributo `TESTO1` = nome pezzo)<br>3. Estrae materiale da PITDATIM/DATIM (attributi `MATERIALE`, `NPEZZI`, `TIPOLOGIA`)<br>4. Rimuove prefissi materiale (I-, A-, D-, F-)<br>5. Gestisce layer speciali: 201 (drill1/giallo), 202 (drill2/verde), 100 (drillp/ciano), 90 (proiezione/fucsia), 91 (marcatura/ciano)<br>6. Crea testo formato: `@NOME;MATERIALE[QTA]TIPOLOGIA`<br>7. Genera blocco con nome random e lo sposta su layer 1<br>8. Esporta in DXF includendo tutti i layer (1, 11, 201, 202, 100, 90, 91) |
| `c:aamar` | ![aamar.bmp](INSTALLAZIONE/menu/LEONARDO/aamar.bmp) | Processa le sagome di "RIFILO" applicando un materiale standard. Questo comando è specifico per i pezzi di rifilo. Estrae la geometria e applica automaticamente un materiale standard precedentemente definito. |
| `c:Modaris-AAMA` | ![Modaris-AAMA.bmp](INSTALLAZIONE/menu/LEONARDO/Modaris-AAMA.bmp) | Elabora i blocchi Modaris v3.0 e li converte in elaborabili. Questo comando è pensato per integrare i dati provenienti da sistemi CAD Modaris, estraendone le informazioni e preparandole per il flusso AAMA. |

### Comandi RIFILO

I comandi specifici per la gestione dei pezzi di RIFILO consentono di applicare standard uniformi. Questi comandi sono strettamente legati al comando `c:aamar` e consentono di definire i valori standard da applicare.

| Comando | Descrizione |
|---------|-------------|
| `c:aamar_material` | Imposta il materiale standard per le sagome RIFILO. Questo valore verrà applicato automaticamente dal comando `c:aamar`. |
| `c:aamar_tipologia` | Imposta la tipologia standard per le sagome RIFILO. |
| `c:aamar_quantita` | Imposta la quantità standard per le sagome RIFILO. |
| `c:aamar_spacing` | Definisce la spaziatura tra i blocchi RIFILO. Questo valore influisce sull'output del comando `c:aama` quando vengono creati i blocchi. |
| `c:aamar_settings` | Visualizza le impostazioni correnti per i comandi RIFILO. Utile per controllare cosa è stato impostato. |

### Funzioni di Nesting

I comandi di nesting sono essenziali per posizionare i pezzi in modo efficiente sul materiale, minimizzando lo spreco. Il nesting è il processo di posizionamento ottimale delle sagome all'interno di un'area data (la tavola di materiale), tenendo conto di margini, rotazioni e spaziature.

| Comando | Icona | Descrizione |
|---------|-------|-------------|
| `c:nestinglinea` | ![nestinglinea.bmp](INSTALLAZIONE/menu/LEONARDO/nestinglinea.bmp) | Posiziona i pezzi in linea o su più righe, ordinandoli per dimensione. Utile per una disposizione manuale controllata. |
| `c:nesting1` | ![nesting1.bmp](INSTALLAZIONE/menu/LEONARDO/nesting1.bmp) | Esegue un nesting semplificato su una singola linea orizzontale. |
| `c:nestingarea` | ![nestingarea.bmp](INSTALLAZIONE/menu/LEONARDO/nestingarea.bmp) | Definisce un'area di lavoro temporanea per il nesting tramite un rettangolo. |
| `c:nesting3` | ![nesting.bmp](INSTALLAZIONE/menu/LEONARDO/nesting.bmp) | Esegue un nesting avanzato, gestendo l'overflow e creando nuove tavole se necessario. Questo è il comando principale per il nesting automatico. |
| `c:nesting` | | Esegue il nesting (posizionamento automatico) dei pezzi selezionati. |

### Altri Comandi di Elaborazione

| Comando | Icona | Descrizione |
|---------|-------|-------------|
| `c:DIMA` | ![DIMA_ATOM.bmp](INSTALLAZIONE/menu/LEONARDO/DIMA_ATOM.bmp) | Crea una dima da un layer specifico, applicando un offset. Utile per generare sagome di controllo o di base. |
| `c:geber` | ![geber.bmp](INSTALLAZIONE/menu/LEONARDO/geber.bmp) | Converte in batch i blocchi tacca in oggetti punto. |
| `c:set_geber_tolerance` | ![set_geber_tolerance.bmp](INSTALLAZIONE/menu/LEONARDO/set_geber_tolerance.bmp) | Imposta le tolleranze globali per la conversione delle tacche. |
| `c:ofi` | ![ofi.bmp](INSTALLAZIONE/menu/LEONARDO/ofi.bmp) | Esegue un offset "RINGRANO" (sposta l'originale su layer "0" e l'offset su "OUTCUT"). |
| `c:blocchi_in_punti` | ![blocchi_in_punti.bmp](INSTALLAZIONE/menu/LEONARDO/blocchi_in_punti.bmp) | Converte i blocchi "PitRTak" in oggetti punto. |

### Utilità AAMA

| Comando | Icona | Descrizione |
|---|---|---|
| `C:AAMA_ESTRAI` | ![aama_estrai.bmp](INSTALLAZIONE/menu/LEONARDO/aama_estrai.bmp) | Esporta tutti gli oggetti sul layer "1" in un file DXF e poi li cancella dal disegno corrente. |
| `C:drill1` | ![drill1.bmp](INSTALLAZIONE/menu/LEONARDO/drill1.bmp) | Sposta un PUNTO selezionato sul layer 201 (Giallo). |
| `C:drill2` | ![drill2.bmp](INSTALLAZIONE/menu/LEONARDO/drill2.bmp) | Sposta un PUNTO selezionato sul layer 202 (Verde). |
| `C:drillp` | ![drillp.bmp](INSTALLAZIONE/menu/LEONARDO/drillp.bmp) | Sposta un PUNTO selezionato sul layer 100 (Ciano). |
| `C:marcatura` | ![MARCATURA.bmp](INSTALLAZIONE/menu/LEONARDO/MARCATURA.bmp) | Sposta un oggetto selezionato sul layer 91 (Ciano). |
| `C:proiezione` | ![PROIEZIONE.bmp](INSTALLAZIONE/menu/LEONARDO/PROIEZIONE.bmp) | Sposta un oggetto selezionato sul layer 90 (Fucsia). |

---

## 3. GESTIONE TESTO E ATTRIBUTI

I comandi in questa sezione consentono di gestire il testo all'interno del disegno, allineandolo, ruotandolo e inserendo testi predefiniti. La gestione del testo è cruciale per etichettare i pezzi, indicare caratteristiche specifiche e fornire informazioni aggiuntive visibili nel disegno.

### Allineamento e Rotazione

| Comando | Icona | Descrizione |
|---------|-------|-------------|
| `c:ATC` | ![ATC.bmp](INSTALLAZIONE/menu/LEONARDO/ATC.bmp) | **Align Text to Curve v1.2** . Allinea dinamicamente testo a curve con controlli avanzati:<br>• Compatibile con: Line, LWPolyline, 2D Polyline, 3D Polyline, Arc, Circle, Ellipse, Spline (anche nested)<br>• **Controlli dinamici**: [+/-] offset incrementale, [O] offset esatto, [</>] rotazione ±45°, [R] rotazione esatta, [Y] toggle readability (anti-capovolgimento), [B] toggle background mask (solo MText)<br>• **Parametri**: offset come fattore altezza testo, rotazione relativa alla curva, justification configurabile<br>• **Settings**: Dialog DCL per configurare tipo oggetto (Text/MText), justification, offset factor, rotation, readability, background mask, multiple text mode<br>• Salva configurazioni ` |
| `c:ZR` | ![Zero.bmp](INSTALLAZIONE/menu/LEONARDO/Zero.bmp) | Azzera la rotazione di testo, blocchi o MLeader. |
| `c:EDT` | ![EDT.bmp](INSTALLAZIONE/menu/LEONARDO/EDT.bmp) | Ruota il testo in base a un angolo definito da due punti. |

### Inserimento Testi Predefiniti (Diciture)

Questa serie di comandi consente di inserire rapidamente testi standard utilizzati frequentemente nel settore. Questi testi predefiniti sono memorizzati internamente e vengono inseriti come testo normale.

| Comando | Icona | Descrizione |
|---------|-------|-------------|
| `c:EDG` | ![EDG.bmp](INSTALLAZIONE/menu/LEONARDO/EDG.bmp) | Inserisce il testo predefinito "COSTOLA". |
| `c:FIL` | ![FIL.bmp](INSTALLAZIONE/menu/LEONARDO/FIL.bmp) | Inserisce il testo predefinito "FILO". |
| `c:SCA` | ![SCA.bmp](INSTALLAZIONE/menu/LEONARDO/SCA.bmp) | Inserisce il testo predefinito "SCARNIRE". |
| `c:SOT` | ![SOT.bmp](INSTALLAZIONE/menu/LEONARDO/SOT.bmp) | Inserisce il testo predefinito "SOTTOMETTITURA". |
| `c:RIM` | ![RIM.bmp](INSTALLAZIONE/menu/LEONARDO/RIM.bmp) | Inserisce il testo predefinito "RIMBOCCO". |
| `c:TAL` | ![TAL.bmp](INSTALLAZIONE/menu/LEONARDO/TAL.bmp) | Inserisce il testo predefinito "TALYN". |
| `c:SAL` | ![SAL.bmp](INSTALLAZIONE/menu/LEONARDO/SAL.bmp) | Inserisce il testo predefinito "SALPA". |
| `c:ANT` | ![ANT.bmp](INSTALLAZIONE/menu/LEONARDO/ANT.bmp) | Inserisce il testo predefinito "ANTISTRAPPO". |
| `c:BOM` | ![BOM.bmp](INSTALLAZIONE/menu/LEONARDO/BOM.bmp) | Inserisce il testo predefinito "BOMBATURA". |
| `c:RIN` | ![RIN.bmp](INSTALLAZIONE/menu/LEONARDO/RIN.bmp) | Inserisce il testo predefinito "RINFORZO". |
| `c:BOR` | ![BOR.bmp](INSTALLAZIONE/menu/LEONARDO/BOR.bmp) | Inserisce il testo predefinito "BORDATURA". |
| `c:VAL` | ![VAL.bmp](INSTALLAZIONE/menu/LEONARDO/VAL.bmp) | Inserisce il testo predefinito "VALIGIAIA". |
| `c:C5` | ![C5.bmp](INSTALLAZIONE/menu/LEONARDO/C5.bmp) | Inserisce il testo predefinito "CUC.ROV. 5MM". |
| `c:C5P` | ![C5P.bmp](INSTALLAZIONE/menu/LEONARDO/C5P.bmp) | Inserisce il testo predefinito "CUC.ROV. 5MM CON PIPING". |
| `c:C7` | ![C7.bmp](INSTALLAZIONE/menu/LEONARDO/C7.bmp) | Inserisce il testo predefinito "CUC.ROV. 7MM". |
| `c:C7P` | ![C7P.bmp](INSTALLAZIONE/menu/LEONARDO/C7P.bmp) | Inserisce il testo predefinito "CUC.ROV. 7MM CON PIPING". |

### Modifica Testi

| Comando | Icona | Descrizione |
|---------|-------|-------------|
| `c:chg` | ![chg.bmp](INSTALLAZIONE/menu/LEONARDO/chg.bmp) | Sostituisce una stringa di testo esistente con una nuova all'interno degli oggetti testo su una selezione multipla. |
| `c:TCASE` | ![TCASE.bmp](INSTALLAZIONE/menu/LEONARDO/TCASE.bmp) | Converte il testo selezionato in MAIUSCOLO o minuscolo o Titolo. |

---

## 4. INSERIMENTO BLOCCHI E SIMBOLI

Questa sezione raccoglie i comandi per l'inserimento rapido di blocchi standard utilizzati per indicare particolari, numerazioni e spessori. I blocchi sono oggetti complessi composti da geometria e attributi, e sono fondamentali per mantenere uno standard visivo e informativo nel disegno.

### Blocchi di Indicazione

| Comando | Icona | Descrizione |
|---------|-------|-------------|
| `c:VR` | ![VR.bmp](INSTALLAZIONE/menu/LEONARDO/VR.bmp) | Inserisce un blocco di indicazione "verticale" per indicare la direzione di resistenza materiale. |
| `c:OR` | ![OR.bmp](INSTALLAZIONE/menu/LEONARDO/OR.bmp) | Inserisce un blocco di indicazione "orizzontale". |
| `c:WAR` | ![WAR.bmp](INSTALLAZIONE/menu/LEONARDO/WAR.bmp) | Inserisce un blocco di "ATTENZIONE". |
| `c:EQ` | ![EQ.bmp](INSTALLAZIONE/menu/LEONARDO/EQ.bmp) | Inserisce un blocco per "EQUALIZZARE". |
| `c:TABT` | ![TABT.bmp](INSTALLAZIONE/menu/LEONARDO/TABT.bmp) | Inserisce un blocco per la "tabella_testi". |
| `c:PEL` | ![PELLE.BMP](INSTALLAZIONE/menu/LEONARDO/PELLE.BMP) | Inserisce un blocco per indicare "PELLE". |
| `c:FOD` | ![FOD.BMP](INSTALLAZIONE/menu/LEONARDO/FOD.BMP) | Inserisce un blocco per indicare "fodera". |

### Blocchi di Numerazione

| Comando | Icona | Descrizione |
|---------|-------|-------------|
| `c:conta` | ![conta.bmp](INSTALLAZIONE/menu/LEONARDO/conta.bmp) | Inserisce blocchi numerati in modo progressivo. |

### Altri Blocchi

| Comando | Icona | Descrizione |
|---------|-------|-------------|
| `c:NUM` | ![NUM_ART.bmp](INSTALLAZIONE/menu/LEONARDO/NUM_ART.bmp) | Inserisce un blocco per il numero dell'articolo. |
| `c:SPESSORE` | ![SPESSORE.BMP](INSTALLAZIONE/menu/LEONARDO/SPESSORE.BMP) | Inserisce un blocco per indicare lo spessore del materiale, con prefisso "SP.". |
| `c:LEO_FUST` | ![leo_fust.bmp](INSTALLAZIONE/menu/LEONARDO/leo_fust.bmp) | Inserisce indicazione dimensione foro. |

---

## 5. DISEGNO GEOMETRICO

I comandi in questa sezione facilitano la creazione di forme geometriche di base, utili per la creazione di tavole di stampa o per disegni ausiliari. Questi comandi semplificano la creazione di rettangoli standard, forme specifiche come trapezi o passanti, e linee con angolazioni fisse.

| Comando | Icona | Descrizione |
|---------|-------|-------------|
| `c:centro` | ![centro.bmp](INSTALLAZIONE/menu/LEONARDO/centro.bmp) | Disegna linee perfettamente verticale  |
| `c:LEORETTANGOLO` | ![RECT.bmp](INSTALLAZIONE/menu/LEONARDO/RECT.bmp) | Disegna un rettangolo definendo il punto di inserimento (centrale), la larghezza e l'altezza. |
| `c:LeoA3` | ![tavola-vuota.BMP](INSTALLAZIONE/menu/LEONARDO/tavola-vuota.BMP) | Disegna un rettangolo in formato A3 (297 x 420). |
| `c:LeoA4` | ![TAVOLA_STAMPA_A4.BMP](INSTALLAZIONE/menu/LEONARDO/TAVOLA_STAMPA_A4.bmp) | Disegna un rettangolo in formato A4 (210 x 297). |
| `c:LeoUM` | ![TAVOLA_STAMPA_VUOTA.bmp](INSTALLAZIONE/menu/LEONARDO/TAVOLA_STAMPA_VUOTA.bmp) | Disegna un rettangolo standard (650 x 950). |
| `c:LeoUM2` | ![leoum2.bmp](INSTALLAZIONE/menu/LEONARDO/leoum2.bmp) | Disegna un rettangolo standard (1300 x 950). |
| `c:LeoUM4` | ![leoum4.bmp](INSTALLAZIONE/menu/LEONARDO/leoum4.bmp) | Disegna un rettangolo standard (1300 x 1800). |
| `c:LeoRACRETT` | ![rettangoloraccordato.bmp](INSTALLAZIONE/menu/LEONARDO/rettangoloraccordato.bmp) | Disegna un rettangolo con angoli raccordati. |
| `c:Passante` | ![Pass.bmp](INSTALLAZIONE/menu/LEONARDO/Pass.bmp) | Calcola e disegna un passante per tracolla di lunghezza perfetta. |
| `c:TRAPI` | ![TRAPI.bmp](INSTALLAZIONE/menu/LEONARDO/TRAPI.bmp) | Disegna un trapezio definendo le basi e l'altezza. |
| `C:TRAPL` | ![TRAPL.bmp](INSTALLAZIONE/menu/LEONARDO/TRAPL.bmp) | Disegna un trapezio isoscele data la base inferiore, la base superiore e la lunghezza del lato obliquo. |
| `C:sar` | ![sar.bmp](INSTALLAZIONE/menu/LEONARDO/sar.bmp) | Disegna una freccia (Leader) e permette di riposizionarla dinamicamente. |
| `C:DUERETTANGOLI` | | Disegna due rettangoli collegati calcolando la distanza verticale in base alla *lunghezza della linea obliqua* inserita. |
| `C:DUERETTANGOLIRAC` | | Come `DUERETTANGOLI`, ma aggiunge raccordi (fillet) personalizzabili ai 4 angoli di connessione. |
| `C:FASCIAFIANCOMAX` | | Simile a `DUERETTANGOLI`, ma applica raccordi *massimi* (tangenti) solo agli angoli superiori. |
| `C:FASCIAFIANCOUI` | ![fasciafiancoui.bmp](INSTALLAZIONE/menu/LEONARDO/fasciafiancoui.bmp) | È la versione con interfaccia grafica (DCL) di `FASCIAFIANCOMAX`. |
| `C:DISEGNAFASCIAFIANCO` | ![disegnafasciafianco.bmp](INSTALLAZIONE/menu/LEONARDO/disegnafasciafianco.bmp) | Disegna due rettangoli collegati calcolando la geometria basandosi sulla *lunghezza dell'arco* di connessione. |
| `C:FASCIAFIANCOextUI` | ![fasciafiancoextui.bmp](INSTALLAZIONE/menu/LEONARDO/fasciafiancoextui.bmp) | È la versione con interfaccia grafica (DCL) di `DISEGNAFASCIAFIANCO`. |

---

## 6. GESTIONE DATI PEZZI

Questa sezione è dedicata all'inserimento e alla modifica dei dati principali associati ai pezzi, come nome e materiale. Questi dati sono fondamentali per la produzione e per il calcolo dei consumi.

![nome-pezzo.png](INSTALLAZIONE/nome-pezzo.png)![materiali.png](INSTALLAZIONE/materiali.png)

### Inserimento Dati

| Comando | Icona | Descrizione |
|---------|-------|-------------|
| `c:MAT` | ![MATERIALE.BMP](INSTALLAZIONE/menu/LEONARDO/MATERIALE.BMP) | Apre una finestra di dialogo per inserire il materiale. |
| `c:NOM` | ![NOME_PEZZO.BMP](INSTALLAZIONE/menu/LEONARDO/NOME_PEZZO.BMP) | **Dialog composizione nome pezzo** (file: `Nome_pezzo.lsp` + `Nome_pezzo.DCL`):<br>• **3 liste popup**: Nome1.txt (es. RINF., NETTO, SBOZZO, FORMA, DIMA, FUSTELLA), Nome2.txt (es. QUADRANTE, FIANCO, FONDO, TASCA, PATTINA), Nome3.txt (es. DAVANTI, DIETRO, INTERNO, ESTERNO)<br>• **Opzione input manuale**: Checkbox per bypassare le liste e digitare nome completo<br>• **Output**: Inserisce blocco `DATIT` con attributi (TIPOLOGIA="", TESTO1=nome_composto, IDFISSO=1, CODICE="0000", NU1-7=0)<br>• **File dati**: `C:/LEONARDO/Common/Nome1.txt`, `Nome2.txt`, `Nome3.txt` (caricati dinamicamente, fallback su valori default) |
| `c:NUM` | ![NUM_ART.bmp](INSTALLAZIONE/menu/LEONARDO/NUM_ART.bmp) | Inserisce il numero dell'articolo. |
| `c:SPESSORE` | ![SPESSORE.BMP](INSTALLAZIONE/menu/LEONARDO/SPESSORE.BMP) | Inserisce lo spessore del materiale. |

### Modifica Dati

| Comando | Icona | Descrizione |
|---------|-------|-------------|
| `c:ED-MAT` | ![ed_materiale.bmp](INSTALLAZIONE/menu/LEONARDO/ed_materiale.bmp) | Modifica il materiale, la quantità e la tipologia ( valido per x articoli) di un materiale tramite una finestra di dialogo. |
| `c:ED-NOM` | ![ed_nome_pezzo.bmp](INSTALLAZIONE/menu/LEONARDO/ed_nome_pezzo.bmp) | Modifica il nome del pezzo tramite una finestra di dialogo. |
| `c:ED-MATERIALE` | ![ed_numero_materiale.bmp](INSTALLAZIONE/menu/LEONARDO/ed_numero_materiale.bmp) | Modifica rapidamente la quantità e la tipologia di un materiale. |
| `c:ED-INFUST` | ![ed-INFUST.bmp](INSTALLAZIONE/menu/LEONARDO/ed-INFUST.bmp) | Aggiunge il prefisso "Infustitura" al nome del pezzo. |
| `c:ED-FOD` | ![ed-FOD.bmp](INSTALLAZIONE/menu/LEONARDO/ed-FOD.bmp) | Aggiunge il prefisso "Fodera" al nome del pezzo. |
| `c:ED-RIF` | ![ed-RIF.bmp](INSTALLAZIONE/menu/LEONARDO/ed-RIF.bmp) | Aggiunge il prefisso "Rifilo" al nome del pezzo. |
| `c:ED-SBOZ` | ![ed-SBOZ.bmp](INSTALLAZIONE/menu/LEONARDO/ed-SBOZ.bmp) | Aggiunge il prefisso "Taglio" al nome del pezzo. |

---

## 7. ESTRAZIONE MODARIS

I comandi in questa sezione sono specifici per l'elaborazione e l'estrazione di dati da blocchi Modaris. Modaris è un sistema CAD leader nel settore calzaturiero e pellettiero, e questi comandi permettono di importare e convertire i dati in un formato compatibile con il flusso di lavoro di Leonardo.

| Comando | Icona | Descrizione |
|---------|-------|-------------|
| `c:CONP` | ![CONP.bmp](INSTALLAZIONE/menu/LEONARDO/CONP.bmp) | Calcola il centroide delle polilinee sul layer "0" e inserisce un punto. |
| `c:CONP_C` | ![conp_c.bmp](INSTALLAZIONE/menu/LEONARDO/conp_c.bmp) | Converte i cerchi sul layer "0" in punti al loro centro. |
| `c:estrai-multipli` | ![estrai-multipli.bmp](INSTALLAZIONE/menu/LEONARDO/estrai-multipli.bmp) | Esegue l'estrazione in batch, inserendo DATIT/DATIM, esplodendo e pulendo gli attributi. |
| `c:estrai-singolo` | ![estrai-singolo.bmp](INSTALLAZIONE/menu/LEONARDO/estrai-singolo.bmp) | Esegue l'estrazione di un singolo blocco con pulizia completa. |

---

## 8. MODIFICA AVANZATA

Questa sezione contiene comandi per operazioni di modifica complesse, come la selezione concatenata, il taglio avanzato e la gestione dei gap. Questi strumenti sono utili per correggere e ottimizzare la geometria del disegno.

| Comando | Icona | Descrizione |
|---------|-------|-------------|
| `c:CS` | ![cs.BMP](INSTALLAZIONE/menu/LEONARDO/cs.BMP) | **Chain Selection v1.1** . Selezione concatenata intelligente:<br>• Seleziona automaticamente tutti gli oggetti connessi per endpoint (tolleranza 1e-8)<br>• Compatibile con: Line, Arc, LWPolyline aperta, Spline aperta, 2D Polyline aperta, Elliptical Arc<br>• Esclude automaticamente layer congelati, bloccati o spenti<br>• |
| `c:CookieCutter2` | ![cook.bmp](INSTALLAZIONE/menu/LEONARDO/cook.bmp) | **Cookie Cutter v1.2** (by Joe Burke). Trim avanzato con esplosione automatica:<br>• Trim object: Circle, Polyline chiusa, Ellipse chiusa, Spline chiusa<br>• **Workflow**: 1) Verifica self-intersection (tramite AddRegion test), 2) Offset interno/esterno per determinare lato trim, 3) Esplode automaticamente blocchi/hatches/regioni intersecanti, 4) Opzione "Erase all inside/outside" per eliminazione completa<br>• **Gestione hatch solidi**: prompt per convertire in ANSI31 pattern con scala auto-calcolata<br>• **Trim ricorsivo**: taglia anche oggetti generati dal trim precedente<br>• Nasconde xref, ignora oggetti annotation (text, dimensions, leaders, tables) |
| `c:RACCORDA_0` | ![RAGGIO_0.BMP](INSTALLAZIONE/menu/LEONARDO/RAGGIO_0.BMP) | Raccorda due entità con un raggio di 0. |
| `c:SPEZZA_PUNTO` | ![Zero.bmp](INSTALLAZIONE/menu/LEONARDO/Zero.bmp) | Interrompe una linea, polilinea o arco nel punto selezionato. |
| `c:splitcir` | ![splitcir.bmp](INSTALLAZIONE/menu/LEONARDO/splitcir.bmp) | Interrompe un cerchio e lo trasforma in polilinea  |
| `c:TROVA_GAP` | ![TROVA_GAP.bmp](INSTALLAZIONE/menu/LEONARDO/TROVA_GAP.bmp) | Cerca i gap ( misure molto piccole fra le quali due linee non si toccano ma dovrebbero farlo) tra le entità selezionate e disegna un cerchio sul layer "GAP" per una facile individuazione. |
| `c:QM` | ![Quic.bmp](INSTALLAZIONE/menu/LEONARDO/Quic.bmp) | Esegue uno specchia rapido degli oggetti. |
| `C:BLOCCO_RAPIDO` | ![blocco_rapido.bmp](INSTALLAZIONE/menu/LEONARDO/blocco_rapido.bmp) | Crea rapidamente un blocco con un nome casuale dagli oggetti selezionati e lo inserisce. |
| `C:cbp` | ![cbp.bmp](INSTALLAZIONE/menu/LEONARDO/cbp.bmp) | Cambia il Punto Base di una definizione di blocco senza modificare la posizione degli inserimenti esistenti. |
| `C:cbpr` | ![cbpr.bmp](INSTALLAZIONE/menu/LEONARDO/cbpr.bmp) | Cambia il Punto Base di un blocco e Riloca tutti gli inserimenti per mantenere la loro posizione visiva. |
| `C:pell` | | Alias per `el2pl` (converte Ellissi in Polilinee). |
| `C:test-multipli` | | Alias per `MA-test`, testa gli attributi dei blocchi Modaris. |

---

## 9. UTILITÀ E CALCOLO

I comandi in questa sezione offrono funzionalità di utilità generale e calcolo, come la gestione del archivio materiali e il calcolo dei consumi. Questi strumenti sono essenziali per la pianificazione della produzione e la gestione dei costi.

![gnames.png](INSTALLAZIONE/gnames.png)![gmats.png](INSTALLAZIONE/gmats.png)

| Comando | Icona | Descrizione |
|---------|-------|-------------|
| `c:HexDecConverter` | ![HexDecConverter.bmp](INSTALLAZIONE/menu/LEONARDO/HexDecConverter.bmp) | Converte il testo tra formato esadecimale (0x) e decimale. |
| `c:font_test` | ![font_test.bmp](INSTALLAZIONE/menu/LEONARDO/font_test.bmp) | Crea righe di testo per testare i font .shx da una directory. |
| `c:gestmat` | ![gestmat.bmp](INSTALLAZIONE/menu/LEONARDO/gestmat.bmp) | Gestisce le liste dei materiali tramite un'interfaccia a finestra di dialogo. |
| `c:gnames` | ![gnames.bmp](INSTALLAZIONE/menu/LEONARDO/gnames.bmp) | Gestisce le liste dei nomi dei pezzi (Nome1/2/3.txt) tramite una finestra di dialogo. |
| `c:NOG` | ![NOG.bmp](INSTALLAZIONE/menu/LEONARDO/NOG.bmp) | **Calcolo Consumi Materiali v7**. Sistema avanzato di calcolo con configurazione per categoria:<br>• **File configurazione**: `nog_config.txt` (formato: `Categoria;Offset;ScartoSagoma%;ScartoTotale%;ScartoGlobale%`)<br>• **Categorie standard**: A-Pelle, I-Infustiture, D-Tele, F-Fodere, G-Accessori, Altri<br>• **Metodo calcolo**: Bounding Box (rettangolo di delimitazione) invece di area reale polilinea<br>• **Parametri per categoria**: Offset (mm), Scarto Sagoma %, Scarto Totale %, Scarto Globale %<br>• **Formula**: `ConsumoFinale = (Area + 2×Offset)² × Quantità × (1+ScartoSagoma%) × (1+ScartoTotale%) / Tipologia × NumPezzi × (1+ScartoGlobale%)`<br>• **Output CSV**: Formato italiano (virgola decimale), colonne: Categoria, Materiale, Componente, Unità, Qtà, Area Orig, Area Offset, Offset, Scarto Sagoma, Scarto Totale, Scarto Globale, Tipologia, Larghezza/Altezza (orig e offset), Consumi vari, Consumo Totale<br>• Gestisce attributi TIPOLOGIA per divisione consumi (es. 2 pezzi da stesso taglio) |
| `c:NOG-CONFIG` | | Modifica la configurazione generale per il calcolo dei consumi (per categorie di materiale). |
| `c:NOG-ADDMAT` | | Aggiunge o aggiorna i parametri di un materiale specifico (per nome completo). |
| `c:sostmat` | ![sostmat.bmp](INSTALLAZIONE/menu/LEONARDO/sostmat.bmp) | Sostituisce il materiale in batch, mantenendo quantità e tipologia. |
| `c:mat1` | ![mat1.bmp](INSTALLAZIONE/menu/LEONARDO/mat1.bmp) | Visualizza e zooma sui pezzi in base al materiale selezionato. |
| `c:mat1-get` | | Seleziona tutti i blocchi con un materiale specifico. |
| `C:NOGG` | ![nogg.bmp](INSTALLAZIONE/menu/LEONARDO/nogg.bmp) | Versione alternativa di `NOG` che calcola l'area geometrica *reale* della polilinea e applica un offset geometrico. |
| `C:seleziona-permat` | ![seleziona-permat.bmp](INSTALLAZIONE/menu/LEONARDO/seleziona-permat.bmp) | Seleziona (evidenzia) tutte le sagome associate a un materiale specifico. |
| `C:perp2ent` | ![perp2ent.bmp](INSTALLAZIONE/menu/LEONARDO/perp2ent.bmp) | Disegna linee perpendicolari da un punto selezionato a un'entità. |
| `C:inizializza` | ![inizializza.bmp](INSTALLAZIONE/menu/LEONARDO/inizializza.bmp) | Carica le librerie `.dll` esterne (cercafust.dll, quadrantearchi.dll, fasciafiancofondo.dll). |

![sostmat.png](INSTALLAZIONE/sostmat.png)![mat1.png](INSTALLAZIONE/mat1.png)

---

## 10. GESTIONE POLILINEE

Questa sezione raccoglie i comandi per la gestione, l'unione, la conversione e la visualizzazione delle direzioni delle polilinee. Le polilinee sono l'elemento geometrico base per rappresentare i contorni dei pezzi.

![poliauto.png](INSTALLAZIONE/poliauto.png)

### Selezione e Unione

| Comando | Icona | Descrizione |
|---------|-------|-------------|
| `c:leo-poliauto` | ![leo-poliauto.bmp](INSTALLAZIONE/menu/LEONARDO/leo-poliauto.bmp) | Esegue una selezione concatenata con unione automatica delle polilinee. |
| `c:JoinAll` | ![JoinAll.bmp](INSTALLAZIONE/menu/LEONARDO/JoinAll.bmp) | Unisce linee, archi e polilinee. |
| `c:PC` | ![CHIUDI_TAGLIO.BMP](INSTALLAZIONE/menu/LEONARDO/CHIUDI_TAGLIO.BMP) | Chiude le polilaperte. |
| `c:PJ` | ![PJ.bmp](INSTALLAZIONE/menu/LEONARDO/PJ.bmp) | Unisce linee, archi e polilinee. |
| `c:Y` | ![Y.bmp](INSTALLAZIONE/menu/LEONARDO/Y.bmp) | Filtra e congiunge linee e archi in polilinee leggere. |
| `C:pljoinfuzz` | ![JOINFUZZ.BMP](INSTALLAZIONE/menu/LEONARDO/JOINFUZZ.BMP) | Congiunge (Join) polilinee, linee e archi che sono vicini (entro una tolleranza), anche se non si toccano. |

### Conversione

| Comando | Icona | Descrizione |
|---------|-------|-------------|
| `c:el2pl` | ![Spl2.bmp](INSTALLAZIONE/menu/LEONARDO/Spl2.bmp) | Converte un'ellisse o un arco ellittico in una polilinea. |
| `c:s2p` | ![SP2P.BMP](INSTALLAZIONE/menu/LEONARDO/SP2P.BMP) | Converte una spline in polilinee, definendo il numero di segmenti. |

### Direzione e Visualizzazione

| Comando | Icona | Descrizione |
|---------|-------|-------------|
| `c:PLDREV_SETCOLOR` | ![PLDREV_SETCOLOR.bmp](INSTALLAZIONE/menu/LEONARDO/PLDREV_SETCOLOR.bmp) | Imposta colore frecce direzione (1-7: Rosso, Giallo, Verde, Ciano, Blu, Magenta, Bianco). Default: 4 (Ciano) |
| `c:PLDREV_SETPOS` | ![PLDREV_SETPOS.bmp](INSTALLAZIONE/menu/LEONARDO/PLDREV_SETPOS.bmp) | Imposta posizione frecce: [Interne/Esterne]. Default: Esterne |
| `c:PLD` | ![INIZIO_DIREZIONE.bmp](INSTALLAZIONE/menu/LEONARDO/INIZIO_DIREZIONE.bmp) | **Visualizzazione e inversione direzione polilinea**:<br>• **Marcatore inizio**: X + Quadrato sul punto di partenza (param 0)<br>• **Frecce direzione**: Visualizzate lungo la polilinea con offset proporzionale a VIEWSIZE/12<br>• **Algoritmo rotazione**: Calcola area signed (Shoelace formula). Se area < 0 → rotazione oraria (+1), altrimenti antioraria (-1)<br>• **Inversione LWPOLYLINE**: Riordina vertici (coordinate), inverte bulge (cambia segno e ordine)<br>• **Gestione archi**: Ogni arco (bulge≠0) viene tracciato con suddivisione angolare (2.5° per segmento)<br>• Prompt: [S/N] per confermare inversione |
| `c:PLDREV_SHOW_DIRECTION` | ![PLDREV_SHOW_DIRECTION.bmp](INSTALLAZIONE/menu/LEONARDO/PLDREV_SHOW_DIRECTION.bmp) | Alias di `c:PLD` - Mostra direzione e punto inizio con frecce dinamiche |
| `c:RvrsLine` | ![INVERTI_DIREZIONE.bmp](INSTALLAZIONE/menu/LEONARDO/INVERTI_DIREZIONE.bmp) | Inverte la direzione di linee, polilinee o LWPolyline (stessa logica di PLD ma senza visualizzazione) |

---

## 11. PREPARAZIONE STAMPA E NESTING

I comandi in questa sezione sono dedicati alla preparazione dei disegni per la stampa o per il nesting, inclusa la creazione di sbozzi e tavole. Questa è la fase finale del processo di design, dove i pezzi vengono organizzati per la produzione.

### Preparazione Sbozzi

| Comando | Icona | Descrizione |
|---------|-------|-------------|
| `c:SBOZZO` | ![SBOZZO.bmp](INSTALLAZIONE/menu/LEONARDO/SBOZZO.bmp) | Crea uno sbozzo: cancella le tacche, applica un offset alla polilinea e sposta su OUTCUT. |
| `c:CopyArray` | ![sbozzomultiplo.bmp](INSTALLAZIONE/menu/LEONARDO/sbozzomultiplo.bmp) | Crea un array rettangolare con sbozzo e un bounding box complessivo. |
| `c:SBOZZO_BOUND` | ![sbozzo_bound.bmp](INSTALLAZIONE/menu/LEONARDO/sbozzo_bound.bmp) | Disegna un bounding box rettangolare per le polilinee. |
| `c:SBOZZO_RETT` | ![SBOZZO_RETT.BMP](INSTALLAZIONE/menu/LEONARDO/SBOZZO_RETT.BMP) | Crea un bounding box, applica un offset e avvia il processo di NESTING3. |

### Tavole di Stampa

| Comando | Icona | Descrizione |
|---------|-------|-------------|
| `c:PRESTAMPA` | ![PRESTAMPA.bmp](INSTALLAZIONE/menu/LEONARDO/PRESTAMPA.bmp) | Prepara le polilinee sul layer "TAVOLA_DI_STAMPA_TAGLIO" e crea blocchi con centroide. |
| `c:TAVOLA_DI_STAMPA_ANTIBUG` | ![TAVOLA_STAMPA.bmp](INSTALLAZIONE/menu/LEONARDO/TAVOLA_STAMPA.bmp) | Prepara le sagome e avvia il processo di NESTING3. |
| `c:TAVOLA_DI_STAMPA_A3` | ![TAVOLA_STAMPA_A3.bmp](INSTALLAZIONE/menu/LEONARDO/TAVOLA_STAMPA_A3.bmp) | Prepara le sagome per il formato A3 e avvia il processo di NESTING3. |

---

## 12. GESTIONE TACCHE

Questa sezione è interamente dedicata alla gestione delle tacche, inclusi inserimento, copia, modifica e conversione. Le tacche sono elementi cruciali per l'assemblaggio dei pezzi.

![tacche.png](INSTALLAZIONE/tacche.png)

### Inserimento e Copia Tacche

**File:** `inserisci_tacca.lsp`, `tacca_da_misura.lsp`, `tacca_dapoli.lsp`, `copia_tacche.lsp`, `misuratrt.lsp`

| Comando | File | Icona | Descrizione |
|---------|------|-------|-------------|
| `c:INSERISCI_TACCA` | inserisci_tacca.lsp | ![TakP.bmp](INSTALLAZIONE/menu/LEONARDO/TakP.bmp) | Inserisce blocco tacca sulla polilinea con orientamento automatico:<br>• Prompt scelta [I]nterna o [E]sterna (default Interna)<br>• **Algoritmo orientamento**: Calcola `vlax-curve-getfirstderiv` (tangente) al punto closest sulla curva, poi applica rotazione di 180° (π) per tacche interne, 0° per esterne<br>• Loop continuo fino a ESC<br>• Blocco utilizzato: `"tacca"` con scala 1 |
| `c:tacca_da_misura` | tacca_da_misura.lsp | ![TACCA_DISTANZA.BMP](INSTALLAZIONE/menu/LEONARDO/TACCA_DISTANZA.BMP) | Inserisce tacca a distanza specifica da punto partenza |
| `c:tacca_dapoli` | tacca_dapoli.lsp | ![TACCA_dapoli.BMP](INSTALLAZIONE/menu/LEONARDO/TACCA_dapoli.BMP) | Copia distanza tra due punti su polilinea sorgente e inserisce tacca su destinazione |
| `c:COPIA_TACCHE` | copia_tacche.lsp | ![COPIA_TACCHE.BMP](INSTALLAZIONE/menu/LEONARDO/COPIA_TACCHE.BMP) | Copia tacche da polilinea sorgente a destinazione |
| `c:MISURATRT` | misuratrt.lsp | ![MISURA_TRATTO.BMP](INSTALLAZIONE/menu/LEONARDO/MISURA_TRATTO.BMP) | Misura tratto su polilinea e inserisce valore come testo |

### Modifica Tacche

**File:** `inverti tacca.lsp`, `ribalta tacca.lsp`, `riposiziona_tacche.lsp`, `METTI_V.lsp`

| Comando | File | Icona | Descrizione |
|---------|------|-------|-------------|
| `c:TACCA_RIBALTA` | ribalta tacca.lsp | ![RIBALTA.BMP](INSTALLAZIONE/menu/LEONARDO/RIBALTA.BMP) | Ribalta direzione tacche selezionate |
| `c:riposiziona_tacche` | riposiziona_tacche.lsp | ![riposiziona.BMP](INSTALLAZIONE/menu/LEONARDO/riposiziona.BMP) | Riposiziona tacche su nuova polilinea |
| `c:METTI_V` | METTI_V.lsp | ![METTI_V.bmp](INSTALLAZIONE/menu/LEONARDO/METTI_V.bmp) | Inserisce rientranza a 'V' su polilinea |
| `C:Dima_tacche_atom` | dima_tacche_atom.lsp | | Crea una dima (offset) e converte i blocchi "tacca" in intagli a V sulla polilinea esterna. |
| `C:TACCA` | TACCA.lsp | | Comando principale per inserire tacche (a distanze multiple o copiando posizioni). |
| `C:INSERISCI_BLOCCHI` | inserisci_blocchi_distanza.lsp | ![inserisci_blocchi.bmp](INSTALLAZIONE/menu/LEONARDO/inserisci_blocchi.bmp) | Inserisce un blocco più volte lungo una polilinea a una distanza specifica, orientandolo automaticamente. |
| `C:METTI_V_AUTO` | METTI_V_AUTO.lsp | ![METTI_V_AUTO.bmp](INSTALLAZIONE/menu/LEONARDO/METTI_V_AUTO.bmp) | Trova automaticamente tutti i blocchi "tacca" vicini a una polilinea e li sostituisce con intagli a V. |
| `C:ribalta_tacche` | ribalta_tacche.lsp | ![RIBALTA.BMP](INSTALLAZIONE/menu/LEONARDO/RIBALTA.BMP) | Ruota (ribalta) i blocchi "tacca" selezionati di 180 gradi. |

### Conversione Tacche

**File:** `sostituisci tacche.lsp`

| Comando | Icona | Descrizione |
|---------|-------|-------------|
| `c:sostituisci_tacche` | ![SOS_TACCHE.bmp](INSTALLAZIONE/menu/LEONARDO/SOS_TACCHE.bmp) | **Menu principale conversioni**. Prompt: `[T]acche=>tagliate, t[A]gliate=>tacche, p[U]nti=>tacche, tacche=>[P]unti, [M]ozart=>standard, standard=>moza[R]t`<br>• Algoritmo comune: 1) Seleziona blocchi sorgente (filter su nome blocco), 2) Seleziona polilinea target, 3) Per ogni blocco: trova punto closest su polilinea, calcola first derivative per orientamento, inserisce nuovo blocco con rotazione calcolata, elimina vecchio blocco |
| `c:tacche_in_tagliate` | ![tacche_in_tagliate.bmp](INSTALLAZIONE/menu/LEONARDO/tacche_in_tagliate.bmp) | Converte `"tacca"` → `"tacca_t"` (rotazione +180°) |
| `c:tagliate_in_tacche` | ![tagliate_in_tacche.bmp](INSTALLAZIONE/menu/LEONARDO/tagliate_in_tacche.bmp) | Converte `"tacca_t"` → `"tacca"` (rotazione +180°) |
| `c:tacche_in_punti` | ![tacche_in_punti.bmp](INSTALLAZIONE/menu/LEONARDO/tacche_in_punti.bmp) | Converte `"tacca"` → oggetto POINT (elimina blocco) |
| `c:punti_in_tacche` | ![punti_in_tacche.bmp](INSTALLAZIONE/menu/LEONARDO/punti_in_tacche.bmp) | Converte POINT → `"tacca"` (rotazione +180°, elimina punto) |
| `c:mozart_in_tacche` | ![mozart_in_tacche.bmp](INSTALLAZIONE/menu/LEONARDO/mozart_in_tacche.bmp) | Converte `"PitTacCT"` (Mozart) → `"tacca"` (rotazione +180°) |
| `c:tacche_in_mozart` | ![tacche_in_mozart.bmp](INSTALLAZIONE/menu/LEONARDO/tacche_in_mozart.bmp) | Converte `"tacca"` → `"PitTacCT"` (Mozart, rotazione +90°) |

---

## 13. GESTIONE LAYER E COLORI

I comandi in questa sezione semplificano lo spostamento degli oggetti su layer specifici e la modifica rapida del colore. La gestione dei layer e dei colori è fondamentale per mantenere l'ordine e la chiarezza del disegno.

### Gestione Layer di Taglio

**File:** `DEFLINEA.LSP`

Tutti i comandi operano su **oggetti pre-selezionati** (utilizzo di `ssgetfirst` per ottenere la selezione corrente).

| Comando | Icona | Descrizione | Layer | Colore |
|---------|-------|-------------|-------|--------|
| `c:ENDCUT` | ![ENDCUT.bmp](INSTALLAZIONE/menu/LEONARDO/ENDCUT.bmp) | Sposta oggetti pre-selezionati su layer taglio rifilo. **Tecnica**: Usa `_chprop` per cambiare Layer → ENDCUT e Color → BYLAYER | ENDCUT | 4 (Ciano) |
| `c:OUTCUT` | ![OUTCUT.bmp](INSTALLAZIONE/menu/LEONARDO/OUTCUT.bmp) | Sposta oggetti pre-selezionati su layer taglio esterno/perimetro | OUTCUT | 1 (Rosso) |
| `c:INTCUT` | ![INTCUT.bmp](INSTALLAZIONE/menu/LEONARDO/INTCUT.bmp) | Sposta oggetti pre-selezionati su layer taglio interno (fori, finestre) | INTCUT | 5 (Blu) |
| `c:PENNA` | ![PENNA.bmp](INSTALLAZIONE/menu/LEONARDO/PENNA.bmp) | Ripristina oggetti pre-selezionati su layer "0" (disegno/costruzione) con colore BYLAYER | 0 | BYLAYER |

**Inizializzazione automatica**: I layer ENDCUT, OUTCUT, INTCUT, TAVOLA_DI_STAMPA, TAVOLA_DI_STAMPA_TAGLIO vengono creati automaticamente all'avvio se non esistono, con i colori standard assegnati.


### Gestione Colori Rapida


| Comando | Icona | Descrizione | Colore ACI |
|---------|-------|-------------|------------|
| `c:BBB` | ![bianco.bmp](INSTALLAZIONE/menu/LEONARDO/bianco.bmp) | Cambia colore oggetto in Bianco/Nero e sposta su layer "0" | 254 |
| `c:GGG` | ![giallo.bmp](INSTALLAZIONE/menu/LEONARDO/giallo.bmp) | Cambia colore oggetto in Giallo e sposta su layer "0" | 2 |
| `c:AAA` | ![arancio.bmp](INSTALLAZIONE/menu/LEONARDO/arancio.bmp) | Cambia colore oggetto in Arancio e sposta su layer "0" | 30 |
| `c:VVV` | ![verde.bmp](INSTALLAZIONE/menu/LEONARDO/verde.bmp) | Cambia colore oggetto in Verde e sposta su layer "0" | 3 |
| `c:FFF` | ![fuxia.bmp](INSTALLAZIONE/menu/LEONARDO/fuxia.bmp) | Cambia colore oggetto in Fucsia/Magenta e sposta su layer "0" | 6 |

**Nota:** Tutti i comandi operano sugli oggetti pre-selezionati.

---

## 14. GESTIONE OFFSET

I comandi in questa sezione applicano offset con tipi di linea specifici, particolarmente utili per le linee di cucitura. L'offset è una tecnica fondamentale per creare sagome di controllo o linee di cucitura parallele.

### Offset con Tipo Linea



| Comando | Icona | Descrizione |
|---------|-------|-------------|
| `c:oft_2` | ![Of2T.BMP](INSTALLAZIONE/menu/LEONARDO/Of2T.BMP) | Offset 2 unità con tipo linea CUCITURA (scala 0.3) |
| `c:oft_3` | ![OF3T.BMP](INSTALLAZIONE/menu/LEONARDO/OF3T.BMP) | Offset 3 unità con tipo linea CUCITURA |
| `c:oft_4` | ![OF4T.BMP](INSTALLAZIONE/menu/LEONARDO/OF4T.BMP) | Offset 4 unità con tipo linea CUCITURA |
| `c:oft_5` | ![OF5T.BMP](INSTALLAZIONE/menu/LEONARDO/OF5T.BMP) | Offset 5 unità con tipo linea CUCITURA |
| `c:oft_6` | ![oft_6.bmp](INSTALLAZIONE/menu/LEONARDO/oft_6.bmp) | Offset 6 unità con tipo linea CUCITURA |
| `c:oft_8` | ![OF8T.BMP](INSTALLAZIONE/menu/LEONARDO/OF8T.BMP) | Offset 8 unità con tipo linea CUCITURA |
| `c:oft_10` | ![OFT10T.bmp](INSTALLAZIONE/menu/LEONARDO/OFT10T.bmp) | Offset 10 unità con tipo linea CUCITURA |
| `c:oft` | ![OFt.bmp](INSTALLAZIONE/menu/LEONARDO/OFt.bmp) | Offset distanza personalizzata con tipo linea CUCITURA |

### Gestione Tipo Linea



| Comando | Icona | Descrizione |
|---------|-------|-------------|
| `c:CUCITURA` | ![Cuci.bmp](INSTALLAZIONE/menu/LEONARDO/Cuci.bmp) | Imposta tipo linea CUCITURA (layer 0, scala 0.3) |
| `c:CONTINUA` | ![Cont.bmp](INSTALLAZIONE/menu/LEONARDO/Cont.bmp) | Ripristina tipo linea BYLAYER (continuo) |

---

## SCORCIATOIE DA TASTIERA

Per visualizzare tutte le scorciatoie, digitare **ALIASEDIT** nella riga di comando.

### Scorciatoie Principali

| Tasto | Comando | Descrizione |
|-------|---------|-------------|
| **Q** | ALIGN | Allinea |
| **QQ** | DIMLINEAR | Quota lineare |
| **W** | TRIM | Taglia (con SHIFT estende) |
| **E** | EXPLODE | Esplodi |
| **ES** | EXTEND | Estendi |
| **EP** | PEDIT | Edita polilinea |
| **EX** | EXTRIM | Taglio esterno/interno a polilinea |
| **R** | FILLET | Raccorda |
| **RA** | FILLETRAD | Imposta raggio raccordo |
| **RR** | ROTATE | Ruota |
| **RT** | RECTANG | Rettangolo |
| **T** | TEXT | Testo |
| **TT** | INSERISCI_TACCA | Inserisci tacca |
| **Y** | PJ | Creazione polilinea |
| **O** | OFFSET | Offset |
| **PL** | PLINE | Polilinea |
| **PC** | PC | Chiudi polilinea |
| **A** | ARC | Arco |
| **S** | MOVE | Sposta |
| **SS** | SELECTSIMILAR | Seleziona simili |
| **SC** | SCALE | Scala |
| **SAR** | SAR | Disegna freccia |
| **SAL** | SAL | Inserisce testo "SALPA" |
| **D** | ERASE | Cancella |
| **F** | MIRROR | Specchia |
| **G** | COPY | Copia |
| **H** | SPEZZA_PUNTO | Spezza nel punto |
| **L** | LINE | Linea |
| **Z** | POINT | Punto |
| **X** | MATCHPROP | Copia proprietà |
| **XL** | XLINE | Linea infinita |
| **C** | CIRCLE | Cerchio |
| **CS** | CS | Chain Selection |
| **CP** | PC | Chiudi polilinea |
| **MT** | MTEXT | Testo multilinea |
| **BR** | BLOCCO_RAPIDO | Blocco rapido |

### Scorciatoie Colori

| Tasto | Comando | Colore |
|-------|---------|--------|
| **AAA** | AAA | Arancio (30) |
| **BBB** | BBB | Bianco (254) |
| **FFF** | FFF | Fucsia (6) |
| **GGG** | GGG | Giallo (2) |
| **VVV** | VVV | Verde (3) |

### Scorciatoie Layer

| Tasto | Comando | Descrizione |
|-------|---------|-------------|
| **V** | INTCUT | Taglio interno |
| **B** | OUTCUT | Taglio rifilo |
| **N** | PENNA | Penna (layer "0") |
| **M** | ENDCUT | Linea di taglio |

### Scorciatoie Dati Pezzi

| Tasto | Comando | Descrizione |
|-------|---------|-------------|
| **NN** | NOM | Nome pezzo |
| **MM** | MAT | Materiale |

### Scorciatoie Cucitura

| Tasto | Comando | Descrizione |
|-------|---------|-------------|
| **C5** | C5 | Testo "CUC.ROV.5MM" |
| **C5P** | C5P | Testo "CUC.ROV.5MM CON PIPING" |
| **C7** | C7 | Testo "CUC.ROV.7MM" |
| **C7P** | C7P | Testo "CUC.ROV.7MM CON PIPING" |

### Acceleratori (Ctrl+Tasto)

| Combinazione | Comando | Descrizione |
|-------------|---------|-------------|
| **Ctrl+Q** | DIMALIGNED | Quota allineata |
| **Ctrl+E** | EXTEND | Estendi |
| **Ctrl+W** | TRIM | Taglia |

### Tasti Funzione

| Tasto | Comando | Descrizione |
|-------|---------|-------------|
| **F5** | CONTINUA | Linea continua |
| **F6** | CUCITURA | Cucitura |

---

## CONFIGURAZIONE

### File di Configurazione

**Directory:** `LEONARDO/INSTALLAZIONE/common/`

| File | Descrizione |
|------|-------------|
| `Pelle.txt` | Lista materiali in pelle |
| `Nome1.txt` | Lista nomi predefiniti - Gruppo 1 |
| `Nome2.txt` | Lista nomi predefiniti - Gruppo 2 |
| `Nome3.txt` | Lista nomi predefiniti - Gruppo 3 |
| `nog_config.txt` | Configurazione calcolo consumi materiali |
| `license.dat` | File licenza (generato automaticamente) |

**Directory:** `LEONARDO/INSTALLAZIONE/menu/LEONARDO/`

| File | Tipo | Descrizione |
|------|------|-------------|
| `LEONARDO 0.mns` | Menu Sorgente | File menu editabile (25.257 bytes) |
| `LEONARDO 0.menuc` | Menu Compilato | File menu compilato (26.773 bytes) |
| `LEONARDO 0.menur` | Menu Risorsa | Risorse menu - icone (647.906 bytes) |

---

## RIEPILOGO COMANDI

### Totale Comandi per Categoria

- **Gestione Licenza:** 3 comandi
- **Elaborazione Pezzi AAMA:** 35 comandi
- **Gestione Testo:** 21 comandi
- **Inserimento Blocchi:** 11 comandi
- **Disegno Geometrico:** 18 comandi
- **Gestione Dati Pezzi:** 12 comandi
- **Estrazione Modaris:** 4 comandi
- **Modifica Avanzata:** 13 comandi
- **Utilità e Calcolo:** 14 comandi
- **Gestione Polilinee:** 14 comandi
- **Preparazione Stampa:** 7 comandi
- **Gestione Tacche:** 23 comandi
- **Gestione Layer e Colori:** 9 comandi
- **Gestione Offset:** 10 comandi

**TOTALE COMANDI DOCUMENTATI:** 194 comandi

---

## COMPATIBILITÀ ZWCAD

Il menu include riferimenti a comandi specifici ZWCAD:

- **ZWRC_ARCSER**, **ZWRC_ARCCON** (archi)
- **ZWRC_SN2BCK** (porta dietro)
- **ZWRC_BREAKATPT** (spezza in punto)
- **ZWRC_POLYGO**, **ZWRC_RECTAN** (forme base)
- **ZWRC_LIST**, **ZWRC_DIST**, **ZWRC_AREA** (interrogazione)
- **ZWRC_IMGATT** (immagini)

---

## CONCLUSIONI

Leonardo Pattern Design Software è un sistema completo per il design di pattern nel settore calzaturiero e pellettiero, con oltre 194 comandi specializzati, interfacce intuitive e piena compatibilità con i principali software CAD.

### Supporto Tecnico

**Email:** leonardo@guasqui.it  
**Sito Web:** www.guasqui.it

---

## NOTE TECNICHE IMPLEMENTATIVE

### Architettura File

**Struttura cartelle wolfang/core/**:
- `blocchi e testo/` - Gestione testo, blocchi, diciture
- `disegna/` - Forme geometriche, rettangoli, trapezi, passanti
- `inserimenti materiale e diciture/` - Dialog DCL per materiale e nome pezzo
- `modifica/` - Chain selection, cookie cutter, gap detection, quick mirror
- `plugin/` - AAMA, consumi (NOG), gestione materiali, conversioni
- `polilinea/` - Join, close, direzione, conversione ellipse/spline
- `stampa/` - Nesting, sbozzo, tavole di stampa, dime
- `tacche/` - Inserimento, copia, conversione, riposizionamento tacche
- `tipolinea/` - Gestione layer (ENDCUT/OUTCUT/INTCUT), offset con tipo linea

### Convenzioni Codifica

**Nomi blocchi standard**:
- `DATIT` / `PITDATIT` - Blocco nome pezzo (attributo TESTO1)
- `DATIM` / `PITDATIM` - Blocco materiale (attributi MATERIALE, NPEZZI, TIPOLOGIA)
- `tacca` - Tacca standard interna
- `tacca_t` - Tacca tagliata
- `PitTacCT` - Tacca formato Mozart
- `PitRTak` - Tacca formato generico

**Layer standard**:
- Layer `0` - Disegno/costruzione
- Layer `1` - Output processato AAMA
- Layer `11` - Tagli interni processati
- Layer `201`, `202`, `100` - Punti drill (giallo, verde, ciano)
- Layer `90`, `91` - Proiezione (fucsia), Marcatura (ciano)
- Layer `ENDCUT` (4-ciano), `OUTCUT` (1-rosso), `INTCUT` (5-blu)
- Layer `TAVOLA_DI_STAMPA`, `TAVOLA_DI_STAMPA_TAGLIO`

**Prefissi materiali**:
- `A-` Pelle (rimosso da AAMA)
- `I-` Infustiture (rimosso da AAMA)
- `D-` Tele (rimosso da AAMA)
- `F-` Fodere (rimosso da AAMA)
- `G-` Accessori

### Algoritmi Chiave

**Orientamento tacche**: Usa `vlax-curve-getfirstderiv` per calcolare tangente alla curva, poi applica rotazione base (0° o 180°)

**Direzione polilinea**: Shoelace formula per calcolare area signed, segno determina rotazione (CW/CCW)

**Bounding box consumi**: Usa rettangolo di delimitazione invece di area reale per calcolo più conservativo

**Chain selection**: Tolleranza 1e-8 per confronto punti floating point

**Cookie cutter offset**: Distanza offset = (diagonal bounding box) / 1500, con divisione ulteriore /12 se unità decimali

### Dipendenze Esterne

**Librerie .dll** (opzionali):
- `cercafust.dll` - Ricerca fustelle
- `quadrantearchi.dll` - Gestione quadranti archi
- `fasciafiancofondo.dll` - Calcolo geometria fascia fianco

**File configurazione**:
- `C:/Leonardo/license.dat` - Licenza (cifrata)
- `C:/LEONARDO/Common/Pelle.txt` - Lista materiali pelle
- `C:/LEONARDO/Common/Nome1.txt`, `Nome2.txt`, `Nome3.txt` - Nomi pezzi
- `{DWGPREFIX}/nog_config.txt` - Configurazione consumi
- `{Support}/LMAC_ATC_V1-2.cfg` - Configurazione Align Text to Curve


---

**Tutti i diritti riservati - Leonardo Guasqui**
**Versione documento:** Definitiva per GitHub (con dettagli tecnici implementativi)
**Versione software:** 3.1.0
**Data ultima revisione:** 2025
