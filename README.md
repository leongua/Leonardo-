# LEONARDO PATTERN DESIGN SOFTWARE

## GUIDA PER L'UTILIZZO - VERSIONE DEFINITIVA

**VERSIONE 1.3.0**

**CONCESSA A USO LUDICO E DIMOSTRATIVO**

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

## Struttura del Software

Il nucleo delle funzionalità di Leonardo Pattern Design Software risiede nella cartella **wolfang/core/**. Questa cartella contiene numerosi file LISP (.lsp) che definiscono i comandi e le logiche operative del programma.

### Tipologie di File

* **File LISP (.lsp)**: Contengono il codice sorgente per le funzioni personalizzate di AutoCAD/ZWCAD. Ogni comando è definito da una `(defun c:NOMECOMANDO ...)` nel codice LISP.

* **File DCL (.dcl)**: Definiscono l'interfaccia utente (finestre di dialogo):
    * MaterialManager1.dcl (per gestmat.lsp)
    * Nome_pezzo.dcl (per Nome_pezzo.lsp e ED-NOM.lsp)
    * Tabella-materiale.dcl (per Visualizza-per-mat.lsp)
    * SCAMBIO.dcl (per scambio.lsp)
    * Materialex.dcl e Materialenew.dcl (per ED-MAT.lsp e Materiale.lsp)
    * gestione_nomi.dcl (per gnames.lsp)

* **File di Menu (.mns, .menuc, .menur)**: Definiscono la struttura dei menu a tendina e delle barre degli strumenti

* **File di Configurazione (.txt)**: Liste di materiali, nomi, e altre configurazioni (es. Pelle.txt, Nome1.txt in INSTALLAZIONE/common/)

* **File Icone (.bmp)**: Localizzati in **INSTALLAZIONE/menu/LEONARDO/**

### Directory Principali

```
LEONARDO/
├── INSTALLAZIONE/
│   ├── menu/
│   │   └── LEONARDO/          # File icone (.bmp) e menu
│   └── common/                # File configurazione (.txt)
└── wolfang/
    └── core/                  # File LISP (.lsp) e DCL (.dcl)
```

### Compatibilità

- **AutoCAD** - Compatibilità completa
- **ZWCAD** - Compatibilità completa con comandi specifici

---

## 1. GESTIONE LICENZA

**File:** `Codice_licenza.lsp`

| Comando | Icona | Descrizione |
|---------|-------|-------------|
| `c:activate-license` | ![activate-license.bmp](INSTALLAZIONE/menu/LEONARDO/activate-license.bmp) | Avvia il processo di attivazione della licenza |
| `c:show-system-id` | ![show-system-id.bmp](INSTALLAZIONE/menu/LEONARDO/show-system-id.bmp) | Mostra l'ID univoco del sistema |
| `c:reset-license` | ![reset-license.bmp](INSTALLAZIONE/menu/LEONARDO/reset-license.bmp) | Resetta lo stato della licenza (solo debug) |

---

## 2. ELABORAZIONE PEZZI AAMA

### Processori AAMA Principali

**File:** `AAMA20.lsp`, `aama_rifilo2.LSP`, `MODARIS-AAMA.lsp`

| Comando | File | Icona | Descrizione |
|---------|------|-------|-------------|
| `c:aama` | AAMA20.lsp | ![AAMA.bmp](INSTALLAZIONE/menu/LEONARDO/AAMA.bmp) | Funzione principale AAMA per processare sagome e creare blocchi per nesting |
| `c:aamar` | aama_rifilo2.LSP | ![aamar.bmp](INSTALLAZIONE/menu/LEONARDO/aamar.bmp) | Processa sagome RIFILO con materiale standard |
| `c:Modaris-AAMA` | MODARIS-AAMA.lsp | ![Modaris-AAMA.bmp](INSTALLAZIONE/menu/LEONARDO/Modaris-AAMA.bmp) | Elabora blocchi Modaris v3.0 con centroide e dati |

### Comandi di Configurazione AAMA

**File:** `AAMA20.lsp`

| Comando | Descrizione |
|---------|-------------|
| `c:aama_spacing` | Imposta spaziatura tra blocchi (*AAMA-BLOCK-SPACING*) |
| `c:aama_debug` | Attiva/disattiva modalità debug (*AAMA-DEBUG-MODE*) |
| `c:aama_errors` | Visualizza log dettagliato errori |
| `c:aama_clear_errors` | Pulisce log errori registrati |
| `c:aama_settings` | Mostra tutte le impostazioni correnti |
| `c:aama_test` | Test su singola sagoma con debug attivo |

### Comandi RIFILO

**File:** `aama_rifilo2.LSP`

| Comando | Descrizione |
|---------|-------------|
| `c:aamar_init` | Inizializza variabili RIFILO a valori default |
| `c:aamar_material` | Imposta materiale standard |
| `c:aamar_tipologia` | Imposta tipologia standard |
| `c:aamar_quantita` | Imposta quantità standard |
| `c:aamar_spacing` | Imposta spaziatura blocchi RIFILO |
| `c:aamar_debug` | Attiva/disattiva debug RIFILO |
| `c:aamar_errors` | Visualizza log errori RIFILO |
| `c:aamar_clear_errors` | Pulisce log errori RIFILO |
| `c:aamar_settings` | Mostra impostazioni RIFILO correnti |
| `c:aamar_test` | Test RIFILO su singola sagoma |

### Comandi Test e Supporto

**File:** `MODARIS-AAMA.lsp`, `moschino punti batch6.lsp`, `AAMA_ESTRAI_2.lsp`

| Comando | File | Icona | Descrizione |
|---------|------|-------|-------------|
| `c:MA-test` | MODARIS-AAMA.lsp | ![MA-test.bmp](INSTALLAZIONE/menu/LEONARDO/MA-test.bmp) | Test attributi Modaris (PNAME, MNAME) e centroide |
| `c:MA-config` | MODARIS-AAMA.lsp | ![MA-config.bmp](INSTALLAZIONE/menu/LEONARDO/MA-config.bmp) | Visualizza parametri configurazione globali Modaris |
| `c:test-multipli` | moschino punti batch6.lsp | ![test-multipli.bmp](INSTALLAZIONE/menu/LEONARDO/test-multipli.bmp) | Test estrazione blocchi multipli |
| `c:AAMA_ESTRAI` | AAMA_ESTRAI_2.lsp | ![AAMA_ESTRAI.bmp](INSTALLAZIONE/menu/LEONARDO/AAMA_ESTRAI.bmp) | Esporta oggetti layer "1" in DXF e cancella dal disegno |

### Funzioni Nesting

**File:** `bl.lsp`, `nesting33.lsp`

| Comando | File | Icona | Descrizione |
|---------|------|-------|-------------|
| `c:nestinglinea` | bl.lsp | ![nestinglinea.bmp](INSTALLAZIONE/menu/LEONARDO/nestinglinea.bmp) | Posiziona pezzi in linea o multi-riga ordinati per dimensioni |
| `c:nesting1` | bl.lsp | ![nesting1.bmp](INSTALLAZIONE/menu/LEONARDO/nesting1.bmp) | Nesting semplificato in singola linea orizzontale |
| `c:nestingarea` | bl.lsp | ![nestingarea.bmp](INSTALLAZIONE/menu/LEONARDO/nestingarea.bmp) | Definisce area di lavoro con rettangolo temporaneo |
| `c:nesting3` | nesting33.lsp | ![nesting.bmp](INSTALLAZIONE/menu/LEONARDO/nesting.bmp) | Nesting avanzato con gestione overflow e creazione nuove tavole |

### Altri Comandi Elaborazione

**File:** `DIMA.lsp`, `geber.lsp`, `offset-delete-script2.lsp`, `sostituisci punti blocco.lsp`

| Comando | File | Icona | Descrizione |
|---------|------|-------|-------------|
| `c:DIMA` | DIMA.lsp | ![DIMA_ATOM.bmp](INSTALLAZIONE/menu/LEONARDO/DIMA_ATOM.bmp) | Crea dima da layer ENDCUT con offset su OUTCUT/INTCUT |
| `c:geber` | geber.lsp | ![geber.bmp](INSTALLAZIONE/menu/LEONARDO/geber.bmp) | Processore batch tacche: converte blocchi tacca in POINT su layer "4" |
| `c:set_geber_tolerance` | geber.lsp | ![set_geber_tolerance.bmp](INSTALLAZIONE/menu/LEONARDO/set_geber_tolerance.bmp) | Imposta tolleranze globali per conversione tacche |
| `c:ofi` | offset-delete-script2.lsp | ![ofi.bmp](INSTALLAZIONE/menu/LEONARDO/ofi.bmp) | OFFSET RINGRANO v4.0 - sposta originale su layer "0" e offset su "OUTCUT" |
| `c:OL` | offset-delete-script2.lsp | ![ofi.bmp](INSTALLAZIONE/menu/LEONARDO/ofi.bmp) | Alias per c:ofi |
| `c:OR` | offset-delete-script2.lsp | ![ofi.bmp](INSTALLAZIONE/menu/LEONARDO/ofi.bmp) | Alias per c:ofi |
| `c:O` | offset-delete-script2.lsp | ![ofi.bmp](INSTALLAZIONE/menu/LEONARDO/ofi.bmp) | Alias per c:ofi |
| `c:blocchi_in_punti` | sostituisci punti blocco.lsp | ![blocchi_in_punti.bmp](INSTALLAZIONE/menu/LEONARDO/blocchi_in_punti.bmp) | Converte blocchi "PitRTak" in oggetti POINT |

---

## 3. GESTIONE TESTO E ATTRIBUTI

### Allineamento e Rotazione

**File:** `AlignTextToCurveV1-2.lsp`, `ZeroRottaion.LSP`, `ruota testo.lsp`

| Comando | File | Icona | Descrizione |
|---------|------|-------|-------------|
| `c:ATC` | AlignTextToCurveV1-2.lsp | ![ATC.bmp](INSTALLAZIONE/menu/LEONARDO/ATC.bmp) | Allinea testo (esistente o nuovo) a curva selezionata |
| `c:ZR` | ZeroRottaion.LSP | ![Zero.bmp](INSTALLAZIONE/menu/LEONARDO/Zero.bmp) | Azzera rotazione di testo, blocchi o MLeader |
| `c:EDT` | ruota testo.lsp | ![EDT.bmp](INSTALLAZIONE/menu/LEONARDO/EDT.bmp) | Ruota testi basandosi su angolo definito da due punti |

### Inserimento Testi Predefiniti - Diciture

**File:** `DICITURE.lsp`

| Comando | Icona | Descrizione |
|---------|-------|-------------|
| `c:EDG` | ![EDG.bmp](INSTALLAZIONE/menu/LEONARDO/EDG.bmp) | Inserisce testo "COSTOLA" |
| `c:FIL` | ![FIL.bmp](INSTALLAZIONE/menu/LEONARDO/FIL.bmp) | Inserisce testo "FILO" |
| `c:SCA` | ![SCA.bmp](INSTALLAZIONE/menu/LEONARDO/SCA.bmp) | Inserisce testo "SCARNIRE" |
| `c:SOT` | ![SOT.bmp](INSTALLAZIONE/menu/LEONARDO/SOT.bmp) | Inserisce testo "SOTTOMETTITURA" |
| `c:RIM` | ![RIM.bmp](INSTALLAZIONE/menu/LEONARDO/RIM.bmp) | Inserisce testo "RIMBOCCO" |
| `c:TAL` | ![TAL.bmp](INSTALLAZIONE/menu/LEONARDO/TAL.bmp) | Inserisce testo "TALYN" |
| `c:SAL` | ![SAL.bmp](INSTALLAZIONE/menu/LEONARDO/SAL.bmp) | Inserisce testo "SALPA" |
| `c:ANT` | ![ANT.bmp](INSTALLAZIONE/menu/LEONARDO/ANT.bmp) | Inserisce testo "ANTISTRAPPO" |
| `c:BOM` | ![BOM.bmp](INSTALLAZIONE/menu/LEONARDO/BOM.bmp) | Inserisce testo "BOMBATURA" |
| `c:RIN` | ![RIN.bmp](INSTALLAZIONE/menu/LEONARDO/RIN.bmp) | Inserisce testo "RINFORZO" |
| `c:BOR` | ![BOR.bmp](INSTALLAZIONE/menu/LEONARDO/BOR.bmp) | Inserisce testo "BORDATURA" |
| `c:VAL` | ![VAL.bmp](INSTALLAZIONE/menu/LEONARDO/VAL.bmp) | Inserisce testo "VALIGIAIA" |
| `c:C5` | ![C5.bmp](INSTALLAZIONE/menu/LEONARDO/C5.bmp) | Inserisce testo "CUC.ROV. 5MM" |
| `c:C5P` | ![C5P.bmp](INSTALLAZIONE/menu/LEONARDO/C5P.bmp) | Inserisce testo "CUC.ROV. 5MM CON PIPING" |
| `c:C7` | ![C7.bmp](INSTALLAZIONE/menu/LEONARDO/C7.bmp) | Inserisce testo "CUC.ROV. 7MM" |
| `c:C7P` | ![C7P.bmp](INSTALLAZIONE/menu/LEONARDO/C7P.bmp) | Inserisce testo "CUC.ROV. 7MM CON PIPING" |

### Modifica Testi

**File:** `sost testo.lsp`, `TCASE.LSP`

| Comando | File | Icona | Descrizione |
|---------|------|-------|-------------|
| `c:chg` | sost testo.lsp | ![chg.bmp](INSTALLAZIONE/menu/LEONARDO/chg.bmp) | Sostituisce Old String con New String in oggetti TEXT |
| `c:TCASE` | TCASE.LSP | ![TCASE.bmp](INSTALLAZIONE/menu/LEONARDO/TCASE.bmp) | Converte testo in maiuscolo o minuscolo |

---

## 4. INSERIMENTO BLOCCHI E SIMBOLI

### Blocchi Indicazioni

**File:** `BLOCCHI.LSP`

| Comando | Icona | Descrizione |
|---------|-------|-------------|
| `c:VR` | ![VR.bmp](INSTALLAZIONE/menu/LEONARDO/VR.bmp) | Inserisce blocco "verticale" scala 1.5 |
| `c:OR` | ![OR.bmp](INSTALLAZIONE/menu/LEONARDO/OR.bmp) | Inserisce blocco "orizzontale" scala 1.5 |
| `c:WAR` | ![WAR.bmp](INSTALLAZIONE/menu/LEONARDO/WAR.bmp) | Inserisce blocco "ATTENZIONE" |
| `c:EQ` | ![EQ.bmp](INSTALLAZIONE/menu/LEONARDO/EQ.bmp) | Inserisce blocco "EQUALIZZARE" |
| `c:TABT` | ![TABT.bmp](INSTALLAZIONE/menu/LEONARDO/TABT.bmp) | Inserisce blocco "tabella_testi" |
| `c:PEL` | ![pelle.bmp](INSTALLAZIONE/menu/LEONARDO/pelle.bmp) | Inserisce blocco "PELLE" |
| `c:FOD` | ![FOD.BMP](INSTALLAZIONE/menu/LEONARDO/FOD.BMP) | Inserisce blocco "fodera" |

### Blocchi Numerazione

**File:** `conta.LSP`

| Comando | Icona | Descrizione |
|---------|-------|-------------|
| `c:conta` | ![conta.bmp](INSTALLAZIONE/menu/LEONARDO/conta.bmp) | Inserisce blocchi numerati progressivamente |

### Altri Blocchi

**File:** `numero_articolo.lsp`, `SPESSORE.LSP`, `LEO_FUST.lsp`

| Comando | File | Icona | Descrizione |
|---------|------|-------|-------------|
| `c:NUM` | numero_articolo.lsp | ![num_art.bmp](INSTALLAZIONE/menu/LEONARDO/num_art.bmp) | Inserisce blocco numero articolo |
| `c:SPESSORE` | SPESSORE.LSP | ![spessore.bmp](INSTALLAZIONE/menu/LEONARDO/spessore.bmp) | Inserisce blocco spessore materiale con prefisso "SP." |
| `c:LEO_FUST` | LEO_FUST.lsp | ![LEO_FUST.bmp](INSTALLAZIONE/menu/LEONARDO/LEO_FUST.bmp) | Inserisce blocco "Leo_Fust" (foro fustella) layer "0" colore 6 |

---

## 5. DISEGNO GEOMETRICO

**File:** `centro.lsp`, `LeoRettangolo.lsp`, `Passante.lsp`, `trapi.LSP`

| Comando | File | Icona | Descrizione |
|---------|------|-------|-------------|
| `c:centro` | centro.lsp | ![centro.bmp](INSTALLAZIONE/menu/LEONARDO/centro.bmp) | Disegna linee forzando angolo 90° dopo primo segmento |
| `c:LEORETTANGOLO` | LeoRettangolo.lsp | ![RECT.bmp](INSTALLAZIONE/menu/LEONARDO/RECT.bmp) | Disegna rettangolo definendo centro, larghezza e altezza |
| `c:LeoA3` | LeoRettangolo.lsp | ![tavola-vuota.BMP](INSTALLAZIONE/menu/LEONARDO/tavola-vuota.BMP) | Disegna rettangolo A3 (297 x 420) |
| `c:LeoA4` | LeoRettangolo.lsp | ![TAVOLA_STAMPA_A4.BMP](INSTALLAZIONE/menu/LEONARDO/TAVOLA_STAMPA_A4.BMP) | Disegna rettangolo A4 (210 x 297) |
| `c:LeoUM` | LeoRettangolo.lsp | ![TAVOLA_STAMPA_VUOTA.bmp](INSTALLAZIONE/menu/LEONARDO/TAVOLA_STAMPA_VUOTA.bmp) | Disegna rettangolo standard (650 x 950) |
| `c:LeoUM2` | LeoRettangolo.lsp | ![leoum2.bmp](INSTALLAZIONE/menu/LEONARDO/leoum2.bmp) | Disegna rettangolo standard (1300 x 950) |
| `c:LeoUM4` | LeoRettangolo.lsp | ![leoum4.bmp](INSTALLAZIONE/menu/LEONARDO/leoum4.bmp) | Disegna rettangolo standard (1300 x 1800) |
| `c:LeoRACRETT` | LeoRettangolo.lsp | ![rettangoloraccordato.bmp](INSTALLAZIONE/menu/LEONARDO/rettangoloraccordato.bmp) | Disegna rettangolo raccordato |
| `c:Passante` | Passante.lsp | ![Pass.bmp](INSTALLAZIONE/menu/LEONARDO/Pass.bmp) | Calcola e disegna passante tracolla |
| `c:TRAPI` | trapi.LSP | ![TRAPI.bmp](INSTALLAZIONE/menu/LEONARDO/TRAPI.bmp) | Disegna trapezio definendo basi e altezza |

---

## 6. GESTIONE DATI PEZZI

### Inserimento Dati

**File:** `Materiale.lsp`, `Nome_pezzo.lsp`, `numero_articolo.lsp`, `SPESSORE.LSP`

| Comando | File | Icona | Descrizione | Protezione |
|---------|------|-------|-------------|------------|
| `c:MAT` | Materiale.lsp | ![materiale.bmp](INSTALLAZIONE/menu/LEONARDO/materiale.bmp) | Apre dialogo DCL per inserimento materiale e calcolo AREANETTA | ✅ |
| `c:NOM` | Nome_pezzo.lsp | ![nome_pezzo.bmp](INSTALLAZIONE/menu/LEONARDO/nome_pezzo.bmp) | Apre dialogo DCL per composizione nome pezzo | ✅ |
| `c:NUM` | numero_articolo.lsp | ![num_art.bmp](INSTALLAZIONE/menu/LEONARDO/num_art.bmp) | Inserisce blocchi "NUM" e "RIF" con numero articolo | ❌ |
| `c:SPESSORE` | SPESSORE.LSP | ![spessore.bmp](INSTALLAZIONE/menu/LEONARDO/spessore.bmp) | Inserisce blocco spessore | ❌ |

### Modifica Dati

**File:** `ED-MAT.lsp`, `ED-NOM.lsp`, `ED-MATERIALE.lsp`, `ED-INFUST.lsp`

| Comando | File | Icona | Descrizione | Protezione |
|---------|------|-------|-------------|------------|
| `c:ED-MAT` | ED-MAT.lsp | ![ed_materiale.bmp](INSTALLAZIONE/menu/LEONARDO/ed_materiale.bmp) | Modifica Materiale/Quantità/Tipologia blocco DATIM via DCL | ❌ |
| `c:ED-NOM` | ED-NOM.lsp | ![ed_nome_pezzo.bmp](INSTALLAZIONE/menu/LEONARDO/ed_nome_pezzo.bmp) | Modifica nome pezzo tramite dialogo DCL | ❌ |
| `c:ED-MATERIALE` | ED-MATERIALE.lsp | ![ed_numero_materiale.bmp](INSTALLAZIONE/menu/LEONARDO/ed_numero_materiale.bmp) | Modifica rapida Quantità e Tipologia di DATIM | ✅ |
| `c:ED-INFUST` | ED-INFUST.lsp | ![ed-infust.bmp](INSTALLAZIONE/menu/LEONARDO/ed-infust.bmp) | Aggiunge prefisso "Infustitura" al nome pezzo | ❌ |
| `c:ED-FOD` | ED-INFUST.lsp | ![ed-fod.bmp](INSTALLAZIONE/menu/LEONARDO/ed-fod.bmp) | Aggiunge prefisso "Fodera" al nome pezzo | ❌ |
| `c:ED-RIF` | ED-INFUST.lsp | ![ed-rif.bmp](INSTALLAZIONE/menu/LEONARDO/ed-rif.bmp) | Aggiunge prefisso "Rifilo" al nome pezzo | ❌ |
| `c:ED-SBOZ` | ED-INFUST.lsp | ![ed-sboz.bmp](INSTALLAZIONE/menu/LEONARDO/ed-sboz.bmp) | Aggiunge prefisso "Taglio" al nome pezzo | ❌ |

---

## 7. ESTRAZIONE MODARIS

**File:** `CONP.lsp`, `CONP_C.lsp`, `MODARIS AAMA.lsp`, `moschino punti batch6.lsp`

| Comando | File | Icona | Descrizione |
|---------|------|-------|-------------|
| `c:CONP` | CONP.lsp | ![CONP.bmp](INSTALLAZIONE/menu/LEONARDO/CONP.bmp) | Calcola centroide polilinee layer "0" e inserisce POINT |
| `c:CONP_C` | CONP_C.lsp | ![CONP_C.bmp](INSTALLAZIONE/menu/LEONARDO/CONP_C.bmp) | Converte cerchi layer "0" in POINT nel centro |
| `c:estrai-multipli` | MODARIS AAMA.lsp | ![estrai-multipli.bmp](INSTALLAZIONE/menu/LEONARDO/estrai-multipli.bmp) | Estrazione batch: inserisce DATIT/DATIM, esplode, pulisce attributi |
| `c:estrai-singolo` | MODARIS AAMA.lsp | ![estrai-singolo.bmp](INSTALLAZIONE/menu/LEONARDO/estrai-singolo.bmp) | Estrazione singolo blocco con pulizia completa |

---

## 8. MODIFICA AVANZATA

**File:** `ChainSelV1-1.lsp`, `CookieCutter2 v1.2.lsp`, `RACCORDA_0.LSP`, `SPEZZA_PUNTO.LSP`, `splitCir.lsp`, `TROVA_GAP.lsp`, `QM.lsp`

| Comando | File | Icona | Descrizione | Protezione |
|---------|------|-------|-------------|------------|
| `c:CS` | ChainSelV1-1.lsp | ![cs.bmp](INSTALLAZIONE/menu/LEONARDO/cs.bmp) | Chain Selection: selezione automatica oggetti connessi | ✅ |
| `c:CookieCutter2` | CookieCutter2 v1.2.lsp | ![cook.bmp](INSTALLAZIONE/menu/LEONARDO/cook.bmp) | Cookie Cutter: trim avanzato con esplosione blocchi | ❌ |
| `c:CC` | CookieCutter2 v1.2.lsp | ![cook.bmp](INSTALLAZIONE/menu/LEONARDO/cook.bmp) | Shortcut per CookieCutter2 | ❌ |
| `c:RACCORDA_0` | RACCORDA_0.LSP | ![RAGGIO_0.BMP](INSTALLAZIONE/menu/LEONARDO/RAGGIO_0.BMP) | Raccorda con raggio 0 tra due entità | ❌ |
| `c:SPEZZA_PUNTO` | SPEZZA_PUNTO.LSP | ![Zero.bmp](INSTALLAZIONE/menu/LEONARDO/Zero.bmp) | Interrompe linea/polilinea/arco in punto selezionato | ✅ |
| `c:splitcir` | splitCir.lsp | ![splitcir.bmp](INSTALLAZIONE/menu/LEONARDO/splitcir.bmp) | Interrompe cerchio in due punti e disegna arco | ❌ |
| `c:TROVA_GAP` | TROVA_GAP.lsp | ![TROVA_GAP.bmp](INSTALLAZIONE/menu/LEONARDO/TROVA_GAP.bmp) | Cerca gap tra entità e disegna cerchio su layer "GAP" | ❌ |
| `c:QM` | QM.lsp | ![Quic.bmp](INSTALLAZIONE/menu/LEONARDO/Quic.bmp) | Mirror rapido di oggetti | ❌ |

---

## 9. UTILITÀ E CALCOLO

**File:** `convesadec4.lsp`, `elenca-font.lsp`, `gestmat.lsp`, `gnames.lsp`, `NOG.lsp`, `scambio.lsp`, `visualizza-per-mat.lsp`

| Comando | File | Icona | Descrizione | Protezione |
|---------|------|-------|-------------|------------|
| `c:HexDecConverter` | convesadec4.lsp | ![HexDecConverter.bmp](INSTALLAZIONE/menu/LEONARDO/HexDecConverter.bmp) | Converte testo tra esadecimale (0x) e decimale | ❌ |
| `c:font_test` | elenca-font.lsp | ![font_test.bmp](INSTALLAZIONE/menu/LEONARDO/font_test.bmp) | Crea righe testo per testare font .shx da directory | ❌ |
| `c:gestmat` | gestmat.lsp | ![gestmat.bmp](INSTALLAZIONE/menu/LEONARDO/gestmat.bmp) | Gestore Liste Materiali con interfaccia DCL | ❌ |
| `c:gnames` | gnames.lsp | ![gnames.bmp](INSTALLAZIONE/menu/LEONARDO/gnames.bmp) | Gestisce liste nomi pezzi (Nome1/2/3.txt) via DCL | ❌ |
| `c:NOG` | NOG.lsp | ![NOG.bmp](INSTALLAZIONE/menu/LEONARDO/NOG.bmp) | Calcolo Consumi Materiale: genera report CSV/Excel | ✅ |
| `c:sostmat` | scambio.lsp | ![sostmat.bmp](INSTALLAZIONE/menu/LEONARDO/sostmat.bmp) | Sostituzione materiale in batch mantenendo quantità/tipologia | ❌ |
| `c:mat1` | visualizza-per-mat.lsp | ![MAT1.bmp](INSTALLAZIONE/menu/LEONARDO/MAT1.bmp) | Visualizza e zoom su pezzi per materiale selezionato | ❌ |

---

## 10. GESTIONE POLILINEE

### Selezione e Unione

**File:** `chains.lsp`, `join.lsp`, `PC.lsp`, `PJ.LSP`, `y.LSP`

| Comando | File | Icona | Descrizione |
|---------|------|-------|-------------|
| `c:csj` | chains.lsp | ![csj.bmp](INSTALLAZIONE/menu/LEONARDO/csj.bmp) | Chain Selection con visualizzazione dinamica e frecce colorate |
| `c:leo-poliauto` | chains.lsp | ![leo-poliauto.bmp](INSTALLAZIONE/menu/LEONARDO/leo-poliauto.bmp) | Selezione concatenata con unione automatica |
| `c:JoinAll` | join.lsp | ![JoinAll.bmp](INSTALLAZIONE/menu/LEONARDO/JoinAll.bmp) | Unisce Linee/Archi/Polilinee con _.pedit M _j |
| `c:PC` | PC.lsp | ![CHIUDI_TAGLIO.BMP](INSTALLAZIONE/menu/LEONARDO/CHIUDI_TAGLIO.BMP) | Chiude polilinee leggere (LWPOLYLINE) aperte |
| `c:PJ` | PJ.LSP | ![PJ.bmp](INSTALLAZIONE/menu/LEONARDO/PJ.bmp) | Unisce Linee/Archi/Polilinee con ._pedit _m _j |
| `c:Y` | y.LSP | ![Y.bmp](INSTALLAZIONE/menu/LEONARDO/Y.bmp) | Filtra e congiunge Linee/Archi in Polilinee leggere |

### Conversione

**File:** `el2pl.lsp`, `spline-to-pline.lsp`

| Comando | File | Icona | Descrizione |
|---------|------|-------|-------------|
| `c:el2pl` | el2pl.lsp | ![Spl2.bmp](INSTALLAZIONE/menu/LEONARDO/Spl2.bmp) | Converte Ellisse o arco ellittico in Polilinea |
| `c:s2p` | spline-to-pline.lsp | ![SP2P.BMP](INSTALLAZIONE/menu/LEONARDO/SP2P.BMP) | Converte spline in polilinee con numero segmenti definito |

### Direzione e Visualizzazione

**File:** `PLD.lsp`, `PLDREV_SHOW_DIRECTION.lsp`

| Comando | File | Icona | Descrizione |
|---------|------|-------|-------------|
| `c:PLDREV_SETCOLOR` | PLD.lsp | ![PLDREV_SETCOLOR.bmp](INSTALLAZIONE/menu/LEONARDO/PLDREV_SETCOLOR.bmp) | Imposta colore frecce direzione |
| `c:PLDREV_SETPOS` | PLD.lsp | ![PLDREV_SETPOS.bmp](INSTALLAZIONE/menu/LEONARDO/PLDREV_SETPOS.bmp) | Imposta posizione frecce (Interne/Esterne) |
| `c:PLD` | PLD.lsp | ![INIZIO_DIREZIONE.bmp](INSTALLAZIONE/menu/LEONARDO/INIZIO_DIREZIONE.bmp) | Visualizza direzione polilinea con frecce e permette inversione |
| `c:PLDREV_SHOW_DIRECTION` | PLDREV_SHOW_DIRECTION.lsp | ![PLDREV_SHOW_DIRECTION.bmp](INSTALLAZIONE/menu/LEONARDO/PLDREV_SHOW_DIRECTION.bmp) | Mostra direzione rotazione e punto inizio polilinea |
| `c:RvrsLine` | PLDREV_SHOW_DIRECTION.lsp | ![INVERTI_DIREZIONE.bmp](INSTALLAZIONE/menu/LEONARDO/INVERTI_DIREZIONE.bmp) | Inverte direzione Linee/Polyline/LWPolyline |

---

## 11. PREPARAZIONE STAMPA E NESTING

### Preparazione Sbozzi

**File:** `sbozzo.lsp`, `sbozzomultiplo.lsp`, `sbozzo_bounding.lsp`, `sbozzo_rettangolare.lsp`

| Comando | File | Icona | Descrizione | Protezione |
|---------|------|-------|-------------|------------|
| `c:SBOZZO` | sbozzo.lsp | ![SBOZZO.bmp](INSTALLAZIONE/menu/LEONARDO/SBOZZO.bmp) | Crea sbozzo: cancella tacche, offset polilinea, sposta su OUTCUT | ❌ |
| `c:CopyArray` | sbozzomultiplo.lsp | ![sbozzomultiplo.bmp](INSTALLAZIONE/menu/LEONARDO/sbozzomultiplo.bmp) | Array rettangolare con sbozzo e bounding box complessivo | ✅ |
| `c:SBOZZO_BOUND` | sbozzo_bounding.lsp | ![SBOZZO_BOUND.bmp](INSTALLAZIONE/menu/LEONARDO/SBOZZO_BOUND.bmp) | Disegna bounding box rettangolare per polilinee | ❌ |
| `c:SBOZZO_RETT` | sbozzo_rettangolare.lsp | ![SBOZZO_RETT.BMP](INSTALLAZIONE/menu/LEONARDO/SBOZZO_RETT.BMP) | Crea bounding box, offset e avvia NESTING3 | ❌ |

### Tavole di Stampa

**File:** `PRESTAMPA.LSP`, `TAVOLA_DI_STAMPA.lsp`, `TAVOLA_DI_STAMPA_A3.lsp`

| Comando | File | Icona | Descrizione | Protezione |
|---------|------|-------|-------------|------------|
| `c:PRESTAMPA` | PRESTAMPA.LSP | ![PRESTAMPA.bmp](INSTALLAZIONE/menu/LEONARDO/PRESTAMPA.bmp) | Prepara polilinee su layer TAVOLA_DI_STAMPA_TAGLIO, crea blocchi con centroide | ❌ |
| `c:TAVOLA_DI_STAMPA_ANTIBUG` | TAVOLA_DI_STAMPA.lsp | ![TAVOLA_STAMPA.bmp](INSTALLAZIONE/menu/LEONARDO/TAVOLA_STAMPA.bmp) | Prepara sagome e avvia NESTING3 | ✅ |
| `c:TAVOLA_DI_STAMPA_A3` | TAVOLA_DI_STAMPA_A3.lsp | ![TAVOLA_STAMPA_A3.bmp](INSTALLAZIONE/menu/LEONARDO/TAVOLA_STAMPA_A3.bmp) | Prepara sagome per A3 e avvia NESTING3 | ❌ |

---

## 12. GESTIONE TACCHE

### Inserimento e Copia Tacche

**File:** `inserisci_tacca.lsp`, `tacca_da_misura.lsp`, `tacca_dapoli.lsp`, `copia_tacche.lsp`, `misuratrt.lsp`

| Comando | File | Icona | Descrizione |
|---------|------|-------|-------------|
| `c:INSERISCI_TACCA` | inserisci_tacca.lsp | ![TakP.bmp](INSTALLAZIONE/menu/LEONARDO/TakP.bmp) | Inserisce blocco tacca sulla polilinea |
| `c:tacca_da_misura` | tacca_da_misura.lsp | ![TACCA_DISTANZA.BMP](INSTALLAZIONE/menu/LEONARDO/TACCA_DISTANZA.BMP) | Inserisce tacca a distanza specifica da punto partenza |
| `c:tacca_dapoli` | tacca_dapoli.lsp | ![TACCA_dapoli.BMP](INSTALLAZIONE/menu/LEONARDO/TACCA_dapoli.BMP) | Copia distanza tra due punti su polilinea sorgente e inserisce tacca su destinazione |
| `c:COPIA_TACCHE` | copia_tacche.lsp | ![COPIA_TACCHE.BMP](INSTALLAZIONE/menu/LEONARDO/COPIA_TACCHE.BMP) | Copia tacche da polilinea sorgente a destinazione |
| `c:MISURATRT` | misuratrt.lsp | ![MISURA_TRATTO.BMP](INSTALLAZIONE/menu/LEONARDO/MISURA_TRATTO.BMP) | Misura tratto su polilinea e inserisce valore come testo |

### Modifica Tacche

**File:** `inverti tacca.lsp`, `ribalta tacca.lsp`, `riposiziona_tacche.lsp`, `METTI_V.lsp`

| Comando | File | Icona | Descrizione |
|---------|------|-------|-------------|
| `c:INVERTI_TACCA` | inverti tacca.lsp | ![INVERTI_TACCA.bmp](INSTALLAZIONE/menu/LEONARDO/INVERTI_TACCA.bmp) | Inverte direzione tacche selezionate |
| `c:TACCA_RIBALTA` | ribalta tacca.lsp | ![RIBALTA.BMP](INSTALLAZIONE/menu/LEONARDO/RIBALTA.BMP) | Ribalta tacche selezionate |
| `c:riposiziona_tacche` | riposiziona_tacche.lsp | ![riposiziona.BMP](INSTALLAZIONE/menu/LEONARDO/riposiziona.BMP) | Riposiziona tacche su nuova polilinea |
| `c:METTI_V` | METTI_V.lsp | ![METTI_V.bmp](INSTALLAZIONE/menu/LEONARDO/METTI_V.bmp) | Inserisce rientranza a 'V' su polilinea |

### Conversione Tacche

**File:** `sostituisci tacche.lsp`

| Comando | Icona | Descrizione |
|---------|-------|-------------|
| `c:sostituisci_tacche` | ![SOS_TACCHE.bmp](INSTALLAZIONE/menu/LEONARDO/SOS_TACCHE.bmp) | Menu scelta rapida per conversione tra tipi tacche/punti |
| `c:tacche_in_tagliate` | ![tacche_in_tagliate.bmp](INSTALLAZIONE/menu/LEONARDO/tacche_in_tagliate.bmp) | Converte tacche standard in tacche tagliate (tacca_t) |
| `c:tagliate_in_tacche` | ![tagliate_in_tacche.bmp](INSTALLAZIONE/menu/LEONARDO/tagliate_in_tacche.bmp) | Converte tacche tagliate in tacche standard |
| `c:tacche_in_punti` | ![tacche_in_punti.bmp](INSTALLAZIONE/menu/LEONARDO/tacche_in_punti.bmp) | Converte tacche/PitRTak in oggetti POINT |
| `c:punti_in_tacche` | ![punti_in_tacche.bmp](INSTALLAZIONE/menu/LEONARDO/punti_in_tacche.bmp) | Converte oggetti POINT in tacche standard |
| `c:mozart_in_tacche` | ![mozart_in_tacche.bmp](INSTALLAZIONE/menu/LEONARDO/mozart_in_tacche.bmp) | Converte blocchi PitTacCT (Mozart) in tacche standard |
| `c:tacche_in_mozart` | ![tacche_in_mozart.bmp](INSTALLAZIONE/menu/LEONARDO/tacche_in_mozart.bmp) | Converte tacche standard in blocchi PitTacCT (Mozart) |

---

## 13. GESTIONE LAYER E COLORI

### Gestione Layer di Taglio

**File:** `DEFLINEA.LSP`

| Comando | Icona | Descrizione | Layer | Colore |
|---------|-------|-------------|-------|--------|
| `c:ENDCUT` | ![ENDCUT.bmp](INSTALLAZIONE/menu/LEONARDO/ENDCUT.bmp) | Sposta su layer ENDCUT (crea layer se necessario) | ENDCUT | 4 (Ciano) |
| `c:OUTCUT` | ![OUTCUT.bmp](INSTALLAZIONE/menu/LEONARDO/OUTCUT.bmp) | Sposta su layer OUTCUT (taglio esterno/rifilo) | OUTCUT | 1 (Rosso) |
| `c:INTCUT` | ![INTCUT.bmp](INSTALLAZIONE/menu/LEONARDO/INTCUT.bmp) | Sposta su layer INTCUT (taglio interno) | INTCUT | 5 (Blu) |
| `c:PENNA` | ![Penna.bmp](INSTALLAZIONE/menu/LEONARDO/Penna.bmp) | Ripristina oggetti su layer "0" con colore BYLAYER | 0 | BYLAYER |

**Nota:** Tutti i comandi impostano automaticamente il colore su BYLAYER dopo lo spostamento.

### Gestione Colori Rapida

**File:** `CAMBIA_COLORE.LSP`

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

### Offset con Tipo Linea

**File:** `offset_trat.lsp`

| Comando | Icona | Descrizione |
|---------|-------|-------------|
| `c:oft_2` | ![OF2T.BMP](INSTALLAZIONE/menu/LEONARDO/OF2T.BMP) | Offset 2 unità con tipo linea CUCITURA (scala 0.3) |
| `c:oft_3` | ![OF3T.BMP](INSTALLAZIONE/menu/LEONARDO/OF3T.BMP) | Offset 3 unità con tipo linea CUCITURA |
| `c:oft_4` | ![OF4T.BMP](INSTALLAZIONE/menu/LEONARDO/OF4T.BMP) | Offset 4 unità con tipo linea CUCITURA |
| `c:oft_5` | ![OF5T.BMP](INSTALLAZIONE/menu/LEONARDO/OF5T.BMP) | Offset 5 unità con tipo linea CUCITURA |
| `c:oft_6` | ![oft_6.bmp](INSTALLAZIONE/menu/LEONARDO/oft_6.bmp) | Offset 6 unità con tipo linea CUCITURA |
| `c:oft_8` | ![OF8T.BMP](INSTALLAZIONE/menu/LEONARDO/OF8T.BMP) | Offset 8 unità con tipo linea CUCITURA |
| `c:oft_10` | ![OFT10T.bmp](INSTALLAZIONE/menu/LEONARDO/OFT10T.bmp) | Offset 10 unità con tipo linea CUCITURA |
| `c:oft` | ![OFt.bmp](INSTALLAZIONE/menu/LEONARDO/OFt.bmp) | Offset distanza personalizzata con tipo linea CUCITURA |

### Gestione Tipo Linea

**File:** `TIPOLINEA.lsp`

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

### File Interfacce DCL

**Directory:** `wolfang/core/`

| File DCL | Utilizzato da | Funzione |
|----------|---------------|----------|
| `MaterialManager1.dcl` | gestmat.lsp | Gestione archivio materiali |
| `Nome_pezzo.dcl` | Nome_pezzo.lsp, ED-NOM.lsp | Composizione nomi pezzo |
| `Tabella-materiale.dcl` | Visualizza-per-mat.lsp | Visualizzazione per materiale |
| `SCAMBIO.dcl` | scambio.lsp | Sostituzione materiali batch |
| `Materialex.dcl` | ED-MAT.lsp, Materiale.lsp | Gestione materiali (extended) |
| `Materialenew.dcl` | ED-MAT.lsp, Materiale.lsp | Gestione materiali (new) |
| `gestione_nomi.dcl` | gnames.lsp | Gestione archivio nomi |

### Struttura File Menu

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
- **Elaborazione Pezzi AAMA:** 28 comandi
- **Gestione Testo:** 21 comandi
- **Inserimento Blocchi:** 11 comandi
- **Disegno Geometrico:** 10 comandi
- **Gestione Dati Pezzi:** 12 comandi
- **Estrazione Modaris:** 4 comandi
- **Modifica Avanzata:** 8 comandi
- **Utilità e Calcolo:** 7 comandi
- **Gestione Polilinee:** 13 comandi
- **Preparazione Stampa:** 7 comandi
- **Gestione Tacche:** 18 comandi
- **Gestione Layer e Colori:** 9 comandi
- **Gestione Offset:** 10 comandi

**TOTALE COMANDI DOCUMENTATI:** 161 comandi

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

Leonardo Pattern Design Software è un sistema completo per il design di pattern nel settore calzaturiero e pellettiero, con oltre 160 comandi specializzati, interfacce intuitive e piena compatibilità con i principali software CAD.

### Supporto Tecnico

**Email:** leonardo@guasqui.it  
**Sito Web:** www.guasqui.it

---

**Tutti i diritti riservati - Leonardo Guasqui**  
**Versione documento:** Definitiva per GitHub  
**Versione software:** 1.3.0  
**Data ultima revisione:** 2025
