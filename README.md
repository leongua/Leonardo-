# Leonardo Pattern Design - Appendice Comandi

**Menu LEONARDO 1.18.2** - riferimento rapido di tutte le voci di menu e dei pulsanti.

Per ogni comando: l'icona del pulsante (se c'è), il nome da digitare (porta alla spiegazione nella [Guida Utente](README_UTENTE.md); i comandi di ZWCAD sono senza collegamento), dove si trova nel menu e nelle barre e che cosa fa.

> Pagina generata da `strumenti/genera_appendice.py` il 18/10/2026 a partire da `menu/LEONARDO/LEONARDO 0.mns` e dai sorgenti dei plugin: non modificarla a mano, rilancia lo script dopo ogni cambio del menu.

## Indice

- [Menu Disegno](#menu-disegno)
- [Menu Polilinee](#menu-polilinee)
- [Menu Blocchi e Testi](#menu-blocchi-e-testi)
- [Menu Offset](#menu-offset)
- [Menu Stampe e Nesting](#menu-stampe-e-nesting)
- [Menu Tipolinea e Layer](#menu-tipolinea-e-layer)
- [Menu Tacche](#menu-tacche)
- [Menu Materiali e Articoli](#menu-materiali-e-articoli)
- [Menu AAMA e Export](#menu-aama-e-export)
- [Menu Consumi e Report](#menu-consumi-e-report)
- [Menu Utilità](#menu-utilità)
- [Menu LEONARDO](#menu-leonardo)
- [Barre degli strumenti](#barre-degli-strumenti)
- [Comandi dei plugin senza voce di menu](#comandi-dei-plugin-senza-voce-di-menu)
- [Scorciatoie da tastiera](#scorciatoie-da-tastiera)

## Menu Disegno

### Forme Base

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
|  | `RECTANG` | Disegno → Forme Base → Rettangolo Standard | Disegno, Modifica Avanzata | Disegna un rettangolo standard |
| <img src="menu/LEONARDO/RECT.bmp" width="24" height="24" alt="RECT.bmp"> | [`LEORETTANGOLO`](README_UTENTE.md#cmd-leorettangolo) | Disegno → Forme Base → Rettangolo dal Centro | Modifica Avanzata | Rettangolo da punto centrale con larghezza e altezza |
| <img src="menu/LEONARDO/rettangoloraccordato.bmp" width="24" height="24" alt="rettangoloraccordato.bmp"> | [`LEORACRETT`](README_UTENTE.md#cmd-leoracrett) | Disegno → Forme Base → Rettangolo Raccordato | Modifica Avanzata | Rettangolo con angoli raccordati |
| <img src="menu/LEONARDO/tavola-vuota.BMP" width="24" height="24" alt="tavola-vuota.BMP"> | [`LEOA3`](README_UTENTE.md#cmd-leoa3) | Disegno → Forme Base → Rettangolo A3 (420x297) | Modifica Avanzata | Disegna il rettangolo di un foglio A3 orizzontale (420x297 mm) |
| <img src="menu/LEONARDO/TAVOLA_STAMPA_A4.bmp" width="24" height="24" alt="TAVOLA_STAMPA_A4.bmp"> | [`LEOA4`](README_UTENTE.md#cmd-leoa4) | Disegno → Forme Base → Rettangolo A4 (210x297) | Modifica Avanzata | Disegna rettangolo formato A4 (210x297mm) |
| <img src="menu/LEONARDO/TRAPI.bmp" width="24" height="24" alt="TRAPI.bmp"> | [`TRAPI`](README_UTENTE.md#cmd-trapi) | Disegno → Forme Base → Trapezio per Altezza | Modifica Avanzata | Trapezio isoscele definito per altezza |
| <img src="menu/LEONARDO/TRAPL.bmp" width="24" height="24" alt="TRAPL.bmp"> | [`TRAPL`](README_UTENTE.md#cmd-trapl) | Disegno → Forme Base → Trapezio per Lato | Modifica Avanzata | Trapezio isoscele definito per lato obliquo |
|  | `POLYGON` | Disegno → Forme Base → Poligono Regolare | Disegno, Modifica Avanzata | Disegna un poligono regolare |

### Forme Speciali

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/goldrect.bmp" width="24" height="24" alt="goldrect.bmp"> | [`GOLDRECT`](README_UTENTE.md#cmd-goldrect) | Disegno → Forme Speciali → Rettangolo Aureo | Modifica Avanzata | Rettangolo con proporzioni auree (sezione aurea) |
| <img src="menu/LEONARDO/goldspiral.bmp" width="24" height="24" alt="goldspiral.bmp"> | [`GOLDSPIRAL`](README_UTENTE.md#cmd-goldspiral) | Disegno → Forme Speciali → Spirale Aurea | Modifica Avanzata | Spirale aurea: a ogni quarto di giro si stringe della proporzione aurea |
| <img src="menu/LEONARDO/spirale.bmp" width="24" height="24" alt="spirale.bmp"> | [`SPIRALE`](README_UTENTE.md#cmd-spirale) | Disegno → Forme Speciali → Spirale Generica | Modifica Avanzata | Spirale generica con parametri personalizzabili |
| <img src="menu/LEONARDO/ovale.bmp" width="24" height="24" alt="ovale.bmp"> | [`OVALE`](README_UTENTE.md#cmd-ovale) | Disegno → Forme Speciali → Ovale | Modifica Avanzata | Disegna un ovale a capsula da larghezza e altezza (polilinea ad archi) |
| <img src="menu/LEONARDO/ovolo.bmp" width="24" height="24" alt="ovolo.bmp"> | [`OVOLO`](README_UTENTE.md#cmd-ovolo) | Disegno → Forme Speciali → Ovolo | Modifica Avanzata | Disegna un ovolo (uovo a quattro archi) da larghezza e altezza |
| <img src="menu/LEONARDO/ellisse.bmp" width="24" height="24" alt="ellisse.bmp"> | [`ELLISSE`](README_UTENTE.md#cmd-ellisse) | Disegno → Forme Speciali → Ellisse a Polilinea | Modifica Avanzata | Disegna un'ellisse come polilinea ad archi dai due semiassi |
| <img src="menu/LEONARDO/cicloide.bmp" width="24" height="24" alt="cicloide.bmp"> | [`CICLOIDE`](README_UTENTE.md#cmd-cicloide) | Disegno → Forme Speciali → Cicloide | Modifica Avanzata | Disegna uno o più archi di cicloide (polilinea ad archi) |
| <img src="menu/LEONARDO/triangolo.bmp" width="24" height="24" alt="triangolo.bmp"> | [`TRIANGOLO`](README_UTENTE.md#cmd-triangolo) | Disegno → Forme Speciali → Triangolo Isoscele | Modifica Avanzata | Disegna un triangolo isoscele da base e altezza |
| <img src="menu/LEONARDO/rombo.bmp" width="24" height="24" alt="rombo.bmp"> | [`ROMBO`](README_UTENTE.md#cmd-rombo) | Disegno → Forme Speciali → Rombo | Modifica Avanzata | Disegna un rombo dalle due diagonali |
| <img src="menu/LEONARDO/circonf.bmp" width="24" height="24" alt="circonf.bmp"> | [`CIRCONF`](README_UTENTE.md#cmd-circonf) | Disegno → Forme Speciali → Cerchio da Perimetro | Modifica Avanzata | Disegna un cerchio (polilinea) dato il perimetro e riporta raggio e diametro |
| <img src="menu/LEONARDO/tasca.bmp" width="24" height="24" alt="tasca.bmp"> | [`TASCA`](README_UTENTE.md#cmd-tasca) | Disegno → Forme Speciali → Tasca | Modifica Avanzata | Forma a tasca per pattern pelletteria |
| <img src="menu/LEONARDO/topopt.bmp" width="24" height="24" alt="topopt.bmp"> | [`TOPOPT`](README_UTENTE.md#cmd-topopt) | Disegno → Forme Speciali → Top Ottimizzato | Modifica Avanzata | Riempie l'ingombro di un oggetto con una griglia di fori di alleggerimento |

### (voci principali)

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/sar.bmp" width="24" height="24" alt="sar.bmp"> | [`SAR`](README_UTENTE.md#cmd-sar) | Disegno → Disegna Freccia (SAR) | Modifica Avanzata | Disegna freccia di direzione (SAR) |
| <img src="menu/LEONARDO/squadratura.bmp" width="24" height="24" alt="squadratura.bmp"> | [`CENTRO`](README_UTENTE.md#cmd-centro) | Disegno → Squadratura (Centro) | Modifica Avanzata | Squadratura: croce della bounding box di una polilinea sul layer squadratura |
| <img src="menu/LEONARDO/ARCOTANG.bmp" width="24" height="24" alt="ARCOTANG.bmp"> | [`ARCOTANG`](README_UTENTE.md#cmd-arcotang) | Disegno → Arco Tangente | Utilità Sistema Ext | Arco tangente interattivo tra due archi esistenti |

### Sviluppo Superfici

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
|  | [`UNROLLSWEEP5`](README_UTENTE.md#cmd-unrollsweep5) | Disegno → Sviluppo Superfici → Sviluppa (Unroll Sweep 5) | - | Sviluppa superficie curva in piano (unroll sweep) |
|  | [`UNROLLSWEEP5SET`](README_UTENTE.md#cmd-unrollsweep5set) | Disegno → Sviluppo Superfici → Impostazioni Unroll | - | Impostazioni per lo sviluppo superfici |

### Forme Avanzate → Quadranti

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/quadrantearchi.bmp" width="24" height="24" alt="quadrantearchi.bmp"> | [`DISEGNAQUADRANGOLO`](README_UTENTE.md#cmd-disegnaquadrangolo) | Disegno → Forme Avanzate → Quadranti → Quadrante ad Archi (DQ) | FASCIA FIANCO, Quadranti | Quadrante ad archi per borse: trapezio con raccordi e lati ad arco (DQ) |
| <img src="menu/LEONARDO/dqmodifica.bmp" width="24" height="24" alt="dqmodifica.bmp"> | [`DQMODIFICA`](README_UTENTE.md#cmd-dqmodifica) | Disegno → Forme Avanzate → Quadranti → Modifica Quadrante (DQM) | Quadranti | Riapre la finestra su un quadrante di DQ e lo aggiorna dov'è (DQM) |
| <img src="menu/LEONARDO/dql.bmp" width="24" height="24" alt="dql.bmp"> | [`DISEGNAQUADRANGOLOLUNGHEZZE`](README_UTENTE.md#cmd-disegnaquadrangololunghezze) | Disegno → Forme Avanzate → Quadranti → Quadrante a Lunghezze Fisse (DQL) | Quadranti | Come DQ, ma i lati spuntati mantengono il loro sviluppo (DQL) |
| <img src="menu/LEONARDO/dqlm.bmp" width="24" height="24" alt="dqlm.bmp"> | [`DQLMODIFICA`](README_UTENTE.md#cmd-dqlmodifica) | Disegno → Forme Avanzate → Quadranti → Modifica a Lunghezze Fisse (DQLM) | Quadranti | Modifica le figure di DQL; una figura di DQ diventa a lunghezze fisse (DQLM) |
| <img src="menu/LEONARDO/dqf.bmp" width="24" height="24" alt="dqf.bmp"> | [`DISEGNAFASCIA`](README_UTENTE.md#cmd-disegnafascia) | Disegno → Forme Avanzate → Quadranti → Fascia sul Quadrante (DQF) | Quadranti | Fascia che gira attorno ai lati scelti di un quadrante (DQF) |
| <img src="menu/LEONARDO/dqfm.bmp" width="24" height="24" alt="dqfm.bmp"> | [`DISEGNAFASCIAMISURE`](README_UTENTE.md#cmd-disegnafasciamisure) | Disegno → Forme Avanzate → Quadranti → Fascia con Misure (DQFM) | Quadranti | Fascia con le misure scritte o prese su una polilinea qualsiasi, con le forme di raccordo di DQF (DQFM) |
| <img src="menu/LEONARDO/dqp.bmp" width="24" height="24" alt="dqp.bmp"> | [`DISEGNAPENCE`](README_UTENTE.md#cmd-disegnapence) | Disegno → Forme Avanzate → Quadranti → Pence e Cannoni (DQP) | Quadranti | Pence o cannoni sul quadrante, con lo sviluppo che conserva il perimetro cucito (DQP) |
| <img src="menu/LEONARDO/dqc.bmp" width="24" height="24" alt="dqc.bmp"> | [`DISEGNACOSTRUZIONI`](README_UTENTE.md#cmd-disegnacostruzioni) | Disegno → Forme Avanzate → Quadranti → Costruzioni (DQC) | Quadranti | Costruzioni del manuale sul quadrante: tutti i pezzi da tagliare, con pieghe, tacche e nomi (DQC) |
| <img src="menu/LEONARDO/dqi.bmp" width="24" height="24" alt="dqi.bmp"> | [`IMPORTAQUADRANTE`](README_UTENTE.md#cmd-importaquadrante) | Disegno → Forme Avanzate → Quadranti → Importa Quadrante (DQI) | Quadranti | Legge polilinee chiuse qualsiasi come quadranti e disegna sopra i quadranti del plugin (DQI) |
| <img src="menu/LEONARDO/dqt.bmp" width="24" height="24" alt="dqt.bmp"> | [`TRACCIATURA`](README_UTENTE.md#cmd-tracciatura) | Disegno → Forme Avanzate → Quadranti → Tracciatura (DQT) | Quadranti | Tracciatura di lamiere e tubi applicata alle borse: raccordi fra figure, tubolare, manico a spicchi, tasca innestata (DQT) |

### Forme Avanzate

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/duerettangoli.bmp" width="24" height="24" alt="duerettangoli.bmp"> | [`DUERETTANGOLI`](README_UTENTE.md#cmd-duerettangoli) | Disegno → Forme Avanzate → Due Rettangoli | FASCIA FIANCO | Disegna due rettangoli collegati |
| <img src="menu/LEONARDO/duerettangolirac.bmp" width="24" height="24" alt="duerettangolirac.bmp"> | [`DUERETTANGOLIRAC`](README_UTENTE.md#cmd-duerettangolirac) | Disegno → Forme Avanzate → Due Rettangoli Raccordati | FASCIA FIANCO | Disegna due rettangoli collegati con raccordi |
| <img src="menu/LEONARDO/disegnafasciafianco.bmp" width="24" height="24" alt="disegnafasciafianco.bmp"> | [`DISEGNAFASCIAFIANCO`](README_UTENTE.md#cmd-disegnafasciafianco) | Disegno → Forme Avanzate → Disegna Fascia Fianco | FASCIA FIANCO | Fascia fianco dalla lunghezza dell'arco di raccordo (raccordi sul rettangolo superiore) |
| <img src="menu/LEONARDO/fasciafiancoui.bmp" width="24" height="24" alt="fasciafiancoui.bmp"> | [`FASCIAFIANCOUI`](README_UTENTE.md#cmd-fasciafiancoui) | Disegno → Forme Avanzate → Fascia Fianco UI | FASCIA FIANCO | Fascia fianco con i raccordi massimi, da una finestra |
| <img src="menu/LEONARDO/fasciafiancomax.bmp" width="24" height="24" alt="fasciafiancomax.bmp"> | [`FASCIAFIANCOMAX`](README_UTENTE.md#cmd-fasciafiancomax) | Disegno → Forme Avanzate → Fascia Fianco Max | FASCIA FIANCO | Fascia fianco con i raccordi massimi, dalla riga di comando |
| <img src="menu/LEONARDO/fasciafiancoextui.bmp" width="24" height="24" alt="fasciafiancoextui.bmp"> | [`FASCIAFIANCOEXTUI`](README_UTENTE.md#cmd-fasciafiancoextui) | Disegno → Forme Avanzate → Fascia Fianco Ext UI | FASCIA FIANCO | Fascia fianco dalla lunghezza dell'arco di raccordo, da una finestra |

### Raccordi e Smussi

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/RAGGIO_0.BMP" width="24" height="24" alt="RAGGIO_0.BMP"> | [`RACCORDA_0`](README_UTENTE.md#cmd-raccorda-0) | Disegno → Raccordi e Smussi → Raccordo Raggio Zero | Modifica Avanzata, Raccordo | Raccordo con raggio zero: unisce due linee con angolo netto |
| <img src="menu/LEONARDO/Racc.bmp" width="24" height="24" alt="Racc.bmp"> | `FILLET` | Disegno → Raccordi e Smussi → Raccordo Standard | Modifica, Raccordo | Raccordo standard con raggio corrente |
| <img src="menu/LEONARDO/Cima.bmp" width="24" height="24" alt="Cima.bmp"> | `CHAMFER` | Disegno → Raccordi e Smussi → Cima | Modifica, Raccordo | Cima/smusso tra due linee |
| <img src="menu/LEONARDO/blend.bmp" width="24" height="24" alt="blend.bmp"> | [`BLEND`](README_UTENTE.md#cmd-blend) | Disegno → Raccordi e Smussi → Blend Curve | Raccordo | Raccordo tra due curve con il raggio ricordato (0 = angolo vivo) |

### Modifica Avanzata

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/cook.bmp" width="24" height="24" alt="cook.bmp"> | [`COOKIECUTTER2`](README_UTENTE.md#cmd-cookiecutter2) | Disegno → Modifica Avanzata → Svuota Polilinea (Cookie Cutter) | Modifica Avanzata | Svuota polilinea: taglia tutto ciò che attraversa un contorno chiuso, dalla parte scelta |
| <img src="menu/LEONARDO/cook.bmp" width="24" height="24" alt="cook.bmp"> | [`COOKIECUTTER2`](README_UTENTE.md#cmd-cookiecutter2) | Disegno → Modifica Avanzata → Cookie Cutter 2 | Modifica Avanzata | Cookie Cutter 2: taglia tutto ciò che attraversa un contorno chiuso, dalla parte scelta |
| <img src="menu/LEONARDO/cc.bmp" width="24" height="24" alt="cc.bmp"> | [`CC`](README_UTENTE.md#cmd-cc) | Disegno → Modifica Avanzata → Cookie Cutter Alias (CC) | Modifica Avanzata | Alias per Cookie Cutter 2 (CC) |
| <img src="menu/LEONARDO/SPEZZA_PUNTO.bmp" width="24" height="24" alt="SPEZZA_PUNTO.bmp"> | [`SPEZZA_PUNTO`](README_UTENTE.md#cmd-spezza-punto) | Disegno → Modifica Avanzata → Spezza in Punto | Modifica Avanzata | Interrompe una linea, arco o polilinea in un punto preciso |
| <img src="menu/LEONARDO/splitcir.bmp" width="24" height="24" alt="splitcir.bmp"> | [`SPLITCIR`](README_UTENTE.md#cmd-splitcir) | Disegno → Modifica Avanzata → Spezza Cerchio | Utilità Sistema Ext | Divide un cerchio in archi uguali, partendo da un punto |
| <img src="menu/LEONARDO/TROVA_GAP.bmp" width="24" height="24" alt="TROVA_GAP.bmp"> | [`TROVA_GAP`](README_UTENTE.md#cmd-trova-gap) | Disegno → Modifica Avanzata → Trova Gap | Utilità Sistema Ext | Segna con un cerchio sul layer GAP i buchi fra estremi e gli estremi staccati |
| <img src="menu/LEONARDO/heal.bmp" width="24" height="24" alt="heal.bmp"> | [`HEAL`](README_UTENTE.md#cmd-heal) | Disegno → Modifica Avanzata → Ripara Polilinee (Heal) | Polilinea | Ripara: doppioni, vertici doppi, unione e chiusura dei buchi piccoli |
| <img src="menu/LEONARDO/contorni.bmp" width="24" height="24" alt="contorni.bmp"> | [`CONTROLLA_CONTORNI`](README_UTENTE.md#cmd-controlla-contorni) | Disegno → Modifica Avanzata → Controllo Contorni | Polilinea | Controllo dei contorni prima del taglio, con la finestra che resta aperta |
|  | [`CONFRONTA_UNIONE`](README_UTENTE.md#cmd-confronta-unione) | Disegno → Modifica Avanzata → Confronta Unione con PEDIT | - | Prova: unisce delle copie con PEDIT e con il plugin e dice se la sagoma cambia |
| <img src="menu/LEONARDO/Quic.bmp" width="24" height="24" alt="Quic.bmp"> | [`QM`](README_UTENTE.md#cmd-qm) | Disegno → Modifica Avanzata → Specchia Rapido | Modifica Avanzata | Specchiatura rapida degli oggetti selezionati |
| <img src="menu/LEONARDO/qmd.bmp" width="24" height="24" alt="qmd.bmp"> | [`QMD`](README_UTENTE.md#cmd-qmd) | Disegno → Modifica Avanzata → Specchia Rapido e Cancella | Modifica Avanzata | Specchia gli oggetti rispetto a un oggetto scelto e cancella gli originali |
| <img src="menu/LEONARDO/qmo.bmp" width="24" height="24" alt="qmo.bmp"> | [`QMO`](README_UTENTE.md#cmd-qmo) | Disegno → Modifica Avanzata → Specchia Oggetto su Se Stesso (1) | Modifica Avanzata | Specchia un oggetto rispetto al proprio lato cliccato |
| <img src="menu/LEONARDO/qmod.bmp" width="24" height="24" alt="qmod.bmp"> | [`QMOD`](README_UTENTE.md#cmd-qmod) | Disegno → Modifica Avanzata → Specchia Oggetto e Cancella | Modifica Avanzata | Specchia un oggetto rispetto al proprio lato cliccato e cancella l'originale |
|  | `AI_DRAWORDER` | Disegno → Modifica Avanzata → Porta Dietro (`_ai_draworder _Back`) | Polilinea | Porta l'oggetto selezionato dietro agli altri |
| <img src="menu/LEONARDO/perp2ent.bmp" width="24" height="24" alt="perp2ent.bmp"> | [`PERP2ENT`](README_UTENTE.md#cmd-perp2ent) | Disegno → Modifica Avanzata → Perpendicolare a Entità | Modifica Avanzata | Disegna linee perpendicolari da un punto a un'entità |
| <img src="menu/LEONARDO/JOINFUZZ.BMP" width="24" height="24" alt="JOINFUZZ.BMP"> | [`PLJOINFUZZ`](README_UTENTE.md#cmd-pljoinfuzz) | Disegno → Modifica Avanzata → Join Polilinee Fuzzy | Polilinea, Polilinea Estesa | Unisce linee e polilinee con tolleranza fuzzy |

## Menu Polilinee

### Creazione

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/PJ.bmp" width="24" height="24" alt="PJ.bmp"> | [`PJ`](README_UTENTE.md#cmd-pj) | Polilinee → Creazione → Creazione Manuale (PJ) | Polilinea | Crea polilinea manualmente unendo linee e archi (PJ) |
| <img src="menu/LEONARDO/leo-poliauto-sel.bmp" width="24" height="24" alt="leo-poliauto-sel.bmp"> | [`CATENA`](README_UTENTE.md#cmd-catena) | Polilinee → Creazione → Creazione Automatica (Catena) | Polilinea | Catena: seleziona i segmenti collegati, uno dopo l'altro (CATENA) |
| <img src="menu/LEONARDO/leo-poliauto.bmp" width="24" height="24" alt="leo-poliauto.bmp"> | [`CATENA_UNISCI`](README_UTENTE.md#cmd-catena-unisci) | Polilinee → Creazione → Catena e Unisci | Polilinea | Catena, poi unione in una polilinea e chiusura (CATENA_UNISCI) |
| <img src="menu/LEONARDO/cs.BMP" width="24" height="24" alt="cs.BMP"> | [`CS`](README_UTENTE.md#cmd-cs) | Polilinee → Creazione → Chain Selection | Modifica Avanzata | Chain Selection: selezione concatenata intelligente per endpoint |
| <img src="menu/LEONARDO/chainconfig.bmp" width="24" height="24" alt="chainconfig.bmp"> | [`CATENA_CONFIG`](README_UTENTE.md#cmd-catena-config) | Polilinee → Creazione → Catena Config | Polilinea | Impostazioni della catena (CATENA_CONFIG) |
|  | [`CATENA_STATO`](README_UTENTE.md#cmd-catena-stato) | Polilinee → Creazione → Catena Stato | - | Mostra le impostazioni della catena (CATENA_STATO) |
| <img src="menu/LEONARDO/catenapreset.bmp" width="24" height="24" alt="catenapreset.bmp"> | [`CATENA_PRESET`](README_UTENTE.md#cmd-catena-preset) | Polilinee → Creazione → Catena Preset | Polilinea | Cambio veloce del preset della catena (CATENA_PRESET) |
| <img src="menu/LEONARDO/SP2P.BMP" width="24" height="24" alt="SP2P.BMP"> | [`S2P`](README_UTENTE.md#cmd-s2p) | Polilinee → Creazione → Da Spline | Polilinea | Converte spline in polilinea con numero di segmenti definito |
| <img src="menu/LEONARDO/Spl2.bmp" width="24" height="24" alt="Spl2.bmp"> | [`EL2PL`](README_UTENTE.md#cmd-el2pl) | Polilinee → Creazione → Da Ellisse | Polilinea | Converte ellisse o arco ellittico in polilinea |
| <img src="menu/LEONARDO/PELL.bmp" width="24" height="24" alt="PELL.bmp"> | [`PELL`](README_UTENTE.md#cmd-pell) | Polilinee → Creazione → Da Ellisse (Pell) | Polilinea | Converte ellisse in polilinea con metodo speciale Pell |
| <img src="menu/LEONARDO/JOINFUZZ.BMP" width="24" height="24" alt="JOINFUZZ.BMP"> | [`PLJOINFUZZ`](README_UTENTE.md#cmd-pljoinfuzz) | Polilinee → Creazione → Join Fuzzy | Polilinea, Polilinea Estesa | Unisce linee, archi, polilinee e spline con una distanza di congiunzione |
| <img src="menu/LEONARDO/Y.bmp" width="24" height="24" alt="Y.bmp"> | [`Y`](README_UTENTE.md#cmd-y) | Polilinee → Creazione → Unione Rapida Y | Polilinea Estesa | Unione rapida Y: filtra e unisce in polilinee leggere |

### (voci principali)

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/PEDI.bmp" width="24" height="24" alt="PEDI.bmp"> | `PEDIT` | Polilinee → Modifica Polilinea | Polilinea | Editor avanzato per modificare vertici di polilinee |
| <img src="menu/LEONARDO/CHIUDI_TAGLIO.BMP" width="24" height="24" alt="CHIUDI_TAGLIO.BMP"> | [`PC`](README_UTENTE.md#cmd-pc) | Polilinee → Chiudi Polilinea | Polilinea | Chiude polilinea aperta collegando fine all'inizio |

### Direzione

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/INIZIO_DIREZIONE.bmp" width="24" height="24" alt="INIZIO_DIREZIONE.bmp"> | [`PLD`](README_UTENTE.md#cmd-pld) | Polilinee → Direzione → Imposta Direzione | Modifica Avanzata, Polilinea | Visualizza direzione polilinea con marcatore e frecce |
| <img src="menu/LEONARDO/INIZIO_DIREZIONE.bmp" width="24" height="24" alt="INIZIO_DIREZIONE.bmp"> | [`PLDREV_SHOW_DIRECTION`](README_UTENTE.md#cmd-pldrev-show-direction) | Polilinee → Direzione → Mostra Direzione | Polilinea Estesa | Mostra verso e punto di inizio della polilinea (frecce) |
| <img src="menu/LEONARDO/INVERTI_DIREZIONE.bmp" width="24" height="24" alt="INVERTI_DIREZIONE.bmp"> | [`RVRSLINE`](README_UTENTE.md#cmd-rvrsline) | Polilinee → Direzione → Inverti Direzione | Modifica Avanzata, Polilinea | Inverte la direzione di linee e polilinee |
| <img src="menu/LEONARDO/nuovoiniziop.bmp" width="24" height="24" alt="nuovoiniziop.bmp"> | [`NUOVOINIZIOP`](README_UTENTE.md#cmd-nuovoiniziop) | Polilinee → Direzione → Nuovo Inizio | Polilinea | Nuovo punto di inizio di una polilinea chiusa (anche a metà di un lato) |
| <img src="menu/LEONARDO/versouniforme.bmp" width="24" height="24" alt="versouniforme.bmp"> | [`VERSO_UNIFORME`](README_UTENTE.md#cmd-verso-uniforme) | Polilinee → Direzione → Verso Uniforme (tutti i contorni) | Polilinea | Mette tutti i contorni chiusi nello stesso verso; a richiesta l'inizio in basso a sinistra |
| <img src="menu/LEONARDO/PLDREV_SETCOLOR.bmp" width="24" height="24" alt="PLDREV_SETCOLOR.bmp"> | [`PLDREV_SETCOLOR`](README_UTENTE.md#cmd-pldrev-setcolor) | Polilinee → Direzione → Imposta Colore Frecce | Polilinea Estesa | Imposta il colore delle frecce di direzione (1-7) |
| <img src="menu/LEONARDO/PLDREV_SETPOS.bmp" width="24" height="24" alt="PLDREV_SETPOS.bmp"> | [`PLDREV_SETPOS`](README_UTENTE.md#cmd-pldrev-setpos) | Polilinee → Direzione → Imposta Posizione Frecce | Polilinea Estesa | Imposta posizione frecce direzione (Interne/Esterne) |

### Rotazioni Rapide

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/Zero.bmp" width="24" height="24" alt="Zero.bmp"> | [`ZR`](README_UTENTE.md#cmd-zr) | Polilinee → Rotazioni Rapide → Rotazione Zero | Modifica Avanzata | Azzera la rotazione di testi, blocchi e MLeader |
| <img src="menu/LEONARDO/r9.bmp" width="24" height="24" alt="r9.bmp"> | [`R9`](README_UTENTE.md#cmd-r9) | Polilinee → Rotazioni Rapide → Rotazione 90 Gradi (R9) | Modifica Avanzata | Ruota la selezione di 90 gradi in senso antiorario (come R90) |
| <img src="menu/LEONARDO/r90.bmp" width="24" height="24" alt="r90.bmp"> | [`R90`](README_UTENTE.md#cmd-r90) | Polilinee → Rotazioni Rapide → Rotazione 90 Gradi | Modifica Avanzata | Ruota la selezione di 90 gradi in senso antiorario |
| <img src="menu/LEONARDO/r90m.bmp" width="24" height="24" alt="r90m.bmp"> | [`R90M`](README_UTENTE.md#cmd-r90m) | Polilinee → Rotazioni Rapide → Rotazione -90 Gradi | Modifica Avanzata | Ruota la selezione di 90 gradi in senso orario |
| <img src="menu/LEONARDO/r180.bmp" width="24" height="24" alt="r180.bmp"> | [`R180`](README_UTENTE.md#cmd-r180) | Polilinee → Rotazioni Rapide → Rotazione 180 Gradi | Modifica Avanzata | Ruota la selezione di 180 gradi |

### Utilità Polilinee

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/CONP.bmp" width="24" height="24" alt="CONP.bmp"> | [`CONP`](README_UTENTE.md#cmd-conp) | Polilinee → Utilità Polilinee → Centro Polilinee (CONP) | Modaris | Mette un punto al centro dell'ingombro delle polilinee sul layer "0" |
| <img src="menu/LEONARDO/conp_c.bmp" width="24" height="24" alt="conp_c.bmp"> | [`CONP_C`](README_UTENTE.md#cmd-conp-c) | Polilinee → Utilità Polilinee → Cerchi in Punti (CONP_C) | Modaris | Converte cerchi su layer "0" in punti al centro |
| <img src="menu/LEONARDO/vlmoverotate.bmp" width="24" height="24" alt="vlmoverotate.bmp"> | [`VLMR`](README_UTENTE.md#cmd-vlmr) | Polilinee → Utilità Polilinee → VL Move Rotate | Polilinea | VL Move Rotate: sposta e ruota oggetti interattivamente |
| <img src="menu/LEONARDO/vlmr_tastierino.bmp" width="24" height="24" alt="vlmr_tastierino.bmp"> | [`-VLMR`](README_UTENTE.md#cmd-vlmr) | Polilinee → Utilità Polilinee → Muovi/Ruota da Tastierino (-VLMR) | Polilinea | Sposta e ruota gli oggetti con i tasti del tastierino numerico |
| <img src="menu/LEONARDO/vlwalk.bmp" width="24" height="24" alt="vlwalk.bmp"> | [`VLWALK`](README_UTENTE.md#cmd-vlwalk) | Polilinee → Utilità Polilinee → Valida Tacche Interattivo | Tacche | Valida tacche in modo interattivo lungo la polilinea |

## Menu Blocchi e Testi

### Indicazioni

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/VR.bmp" width="24" height="24" alt="VR.bmp"> | [`VR`](README_UTENTE.md#cmd-vr) | Blocchi e Testi → Indicazioni → Verticale | Diciture Standard | Inserisce blocco indicazione direzione VERTICALE materiale |
| <img src="menu/LEONARDO/OR.bmp" width="24" height="24" alt="OR.bmp"> | [`OR`](README_UTENTE.md#cmd-or) | Blocchi e Testi → Indicazioni → Orizzontale | Diciture Standard | Inserisce blocco indicazione direzione ORIZZONTALE materiale |
| <img src="menu/LEONARDO/WAR.bmp" width="24" height="24" alt="WAR.bmp"> | [`WAR`](README_UTENTE.md#cmd-war) | Blocchi e Testi → Indicazioni → Attenzione | Diciture Standard | Inserisce blocco ATTENZIONE |
| <img src="menu/LEONARDO/EQ.bmp" width="24" height="24" alt="EQ.bmp"> | [`EQ`](README_UTENTE.md#cmd-eq) | Blocchi e Testi → Indicazioni → Equalizzare | Diciture Standard | Inserisce blocco EQUALIZZARE |
| <img src="menu/LEONARDO/TABT.bmp" width="24" height="24" alt="TABT.bmp"> | [`TABT`](README_UTENTE.md#cmd-tabt) | Blocchi e Testi → Indicazioni → Tabella Testi | Diciture Standard | Inserisce blocco tabella testi |
| <img src="menu/LEONARDO/PELLE.BMP" width="24" height="24" alt="PELLE.BMP"> | [`PEL`](README_UTENTE.md#cmd-pel) | Blocchi e Testi → Indicazioni → Pelle | Dati Pezzo, Diciture Standard | Inserisce blocco indicazione materiale PELLE |
| <img src="menu/LEONARDO/FOD.BMP" width="24" height="24" alt="FOD.BMP"> | [`FOD`](README_UTENTE.md#cmd-fod) | Blocchi e Testi → Indicazioni → Fodera | Dati Pezzo, Diciture Standard | Inserisce blocco indicazione materiale FODERA |

### Fustelle

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/leo_fust_P.bmp" width="24" height="24" alt="leo_fust_P.bmp"> | [`LEO_FUST`](README_UTENTE.md#cmd-leo-fust) | Blocchi e Testi → Fustelle → Fustella P (punto) (`_LEO_FUST P`) | Fustelle | Segna il foro di una fustella a punto (P) |
| <img src="menu/LEONARDO/leo_fust_P.bmp" width="24" height="24" alt="leo_fust_P.bmp"> | [`LEO_FUST`](README_UTENTE.md#cmd-leo-fust) | Blocchi e Testi → Fustelle → Fustella 0.8 (`_LEO_FUST 0.8`) | Fustelle | Segna il foro di una fustella da 0.8 mm (simbolo e misura scritta) |
| <img src="menu/LEONARDO/leo_fust_P.bmp" width="24" height="24" alt="leo_fust_P.bmp"> | [`LEO_FUST`](README_UTENTE.md#cmd-leo-fust) | Blocchi e Testi → Fustelle → Fustella 1 (`_LEO_FUST 1`) | Fustelle | Segna il foro di una fustella da 1 mm (simbolo e misura scritta) |
| <img src="menu/LEONARDO/leo_fust_P.bmp" width="24" height="24" alt="leo_fust_P.bmp"> | [`LEO_FUST`](README_UTENTE.md#cmd-leo-fust) | Blocchi e Testi → Fustelle → Fustella 1.5 (`_LEO_FUST 1.5`) | Fustelle | Segna il foro di una fustella da 1.5 mm (simbolo e misura scritta) |
| <img src="menu/LEONARDO/leo_fust_P.bmp" width="24" height="24" alt="leo_fust_P.bmp"> | [`LEO_FUST`](README_UTENTE.md#cmd-leo-fust) | Blocchi e Testi → Fustelle → Fustella 2 (`_LEO_FUST 2`) | Fustelle | Segna il foro di una fustella da 2 mm (simbolo e misura scritta) |
| <img src="menu/LEONARDO/leo_fust_P.bmp" width="24" height="24" alt="leo_fust_P.bmp"> | [`LEO_FUST`](README_UTENTE.md#cmd-leo-fust) | Blocchi e Testi → Fustelle → Fustella 2.5 (`_LEO_FUST 2.5`) | Fustelle | Segna il foro di una fustella da 2.5 mm (simbolo e misura scritta) |
| <img src="menu/LEONARDO/leo_fust_P.bmp" width="24" height="24" alt="leo_fust_P.bmp"> | [`LEO_FUST`](README_UTENTE.md#cmd-leo-fust) | Blocchi e Testi → Fustelle → Fustella 3 (`_LEO_FUST 3`) | Fustelle | Segna il foro di una fustella da 3 mm (simbolo e misura scritta) |
| <img src="menu/LEONARDO/leo_fust_P.bmp" width="24" height="24" alt="leo_fust_P.bmp"> | [`LEO_FUST`](README_UTENTE.md#cmd-leo-fust) | Blocchi e Testi → Fustelle → Fustella 3.5 (`_LEO_FUST 3.5`) | Fustelle | Segna il foro di una fustella da 3.5 mm (simbolo e misura scritta) |
| <img src="menu/LEONARDO/leo_fust_P.bmp" width="24" height="24" alt="leo_fust_P.bmp"> | [`LEO_FUST`](README_UTENTE.md#cmd-leo-fust) | Blocchi e Testi → Fustelle → Fustella 4 (`_LEO_FUST 4`) | Fustelle | Segna il foro di una fustella da 4 mm (simbolo e misura scritta) |
| <img src="menu/LEONARDO/leo_fust_P.bmp" width="24" height="24" alt="leo_fust_P.bmp"> | [`LEO_FUST`](README_UTENTE.md#cmd-leo-fust) | Blocchi e Testi → Fustelle → Fustella 4.5 (`_LEO_FUST 4.5`) | Fustelle | Segna il foro di una fustella da 4.5 mm (simbolo e misura scritta) |
| <img src="menu/LEONARDO/leo_fust_P.bmp" width="24" height="24" alt="leo_fust_P.bmp"> | [`LEO_FUST`](README_UTENTE.md#cmd-leo-fust) | Blocchi e Testi → Fustelle → Fustella 5 (`_LEO_FUST 5`) | Fustelle | Segna il foro di una fustella da 5 mm (simbolo e misura scritta) |
| <img src="menu/LEONARDO/leo_fust_P.bmp" width="24" height="24" alt="leo_fust_P.bmp"> | [`LEO_FUST`](README_UTENTE.md#cmd-leo-fust) | Blocchi e Testi → Fustelle → Fustella 6 (`_LEO_FUST 6`) | Fustelle | Segna il foro di una fustella da 6 mm (simbolo e misura scritta) |

### Allineamento Testi

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/ATC.bmp" width="24" height="24" alt="ATC.bmp"> | [`ATC`](README_UTENTE.md#cmd-atc) | Blocchi e Testi → Allineamento Testi → Allinea a Curva | Modifica Avanzata | Allinea testo a curva con controlli dinamici |
| <img src="menu/LEONARDO/Zero.bmp" width="24" height="24" alt="Zero.bmp"> | [`ZR`](README_UTENTE.md#cmd-zr) | Blocchi e Testi → Allineamento Testi → Rotazione Zero | Modifica Avanzata | Azzera la rotazione del testo selezionato |
| <img src="menu/LEONARDO/EDT.bmp" width="24" height="24" alt="EDT.bmp"> | [`EDT`](README_UTENTE.md#cmd-edt) | Blocchi e Testi → Allineamento Testi → Ruota Testo | Utilità Sistema Ext | Ruota testo secondo angolo definito da due punti |

### Modifica Testi

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/chg.bmp" width="24" height="24" alt="chg.bmp"> | [`CHG`](README_UTENTE.md#cmd-chg) | Blocchi e Testi → Modifica Testi → Sostituisci Testo | Utilità Sistema Ext | Sostituisce stringa in selezione multipla di testi |
| <img src="menu/LEONARDO/TCASE.bmp" width="24" height="24" alt="TCASE.bmp"> | [`TCASE`](README_UTENTE.md#cmd-tcase) | Blocchi e Testi → Modifica Testi → Maiuscolo/Minuscolo | Utilità Sistema Ext | Converte maiuscolo/minuscolo del testo selezionato |
| <img src="menu/LEONARDO/cbp.bmp" width="24" height="24" alt="cbp.bmp"> | [`CBP`](README_UTENTE.md#cmd-cbp) | Blocchi e Testi → Modifica Testi → Cambia Punto Base Blocco | UTILITA SISTEMA | Cambia punto base blocco senza rilocare inserimenti |
| <img src="menu/LEONARDO/CAMBIACOL.bmp" width="24" height="24" alt="CAMBIACOL.bmp"> | [`CAMBIACOL`](README_UTENTE.md#cmd-cambiacol) | Blocchi e Testi → Modifica Testi → Cambia Colore | Layer, Utilità Sistema Ext | Cambia il colore degli oggetti: per nome o numero da 1 a 255, anche dalla macro (^C^C_CAMBIACOL Giallo) |

### Diciture Standard

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/dicitura.bmp" width="24" height="24" alt="dicitura.bmp"> | [`DICITURA`](README_UTENTE.md#cmd-dicitura) | Blocchi e Testi → Diciture Standard → Testo Personalizzato... | Diciture Standard | Inserisce un testo personalizzato ripetuto, orientato col mouse |
| <img src="menu/LEONARDO/EDG.bmp" width="24" height="24" alt="EDG.bmp"> | [`EDG`](README_UTENTE.md#cmd-edg) | Blocchi e Testi → Diciture Standard → Costola | Diciture Standard | Inserisce testo standard "COSTOLA" sul pezzo |
| <img src="menu/LEONARDO/FIL.bmp" width="24" height="24" alt="FIL.bmp"> | [`FIL`](README_UTENTE.md#cmd-fil) | Blocchi e Testi → Diciture Standard → Filo | Diciture Standard | Inserisce testo standard "FILO" sul pezzo |
| <img src="menu/LEONARDO/SCA.bmp" width="24" height="24" alt="SCA.bmp"> | [`SCA`](README_UTENTE.md#cmd-sca) | Blocchi e Testi → Diciture Standard → Scarnire | Diciture Standard | Inserisce testo standard "SCARNIRE" sul pezzo |
| <img src="menu/LEONARDO/SOT.bmp" width="24" height="24" alt="SOT.bmp"> | [`SOT`](README_UTENTE.md#cmd-sot) | Blocchi e Testi → Diciture Standard → Sottomettitura | Diciture Standard | Inserisce testo standard "SOTTOMETTITURA" sul pezzo |
| <img src="menu/LEONARDO/RIM.bmp" width="24" height="24" alt="RIM.bmp"> | [`RIM`](README_UTENTE.md#cmd-rim) | Blocchi e Testi → Diciture Standard → Rimbocco | Diciture Standard | Inserisce testo standard "RIMBOCCO" sul pezzo |
| <img src="menu/LEONARDO/TAL.bmp" width="24" height="24" alt="TAL.bmp"> | [`TAL`](README_UTENTE.md#cmd-tal) | Blocchi e Testi → Diciture Standard → Talyn | Diciture Standard | Inserisce testo standard "TALYN" sul pezzo |
| <img src="menu/LEONARDO/SAL.bmp" width="24" height="24" alt="SAL.bmp"> | [`SAL`](README_UTENTE.md#cmd-sal) | Blocchi e Testi → Diciture Standard → Salpa | Diciture Standard | Inserisce testo standard "SALPA" sul pezzo |
| <img src="menu/LEONARDO/ANT.bmp" width="24" height="24" alt="ANT.bmp"> | [`ANT`](README_UTENTE.md#cmd-ant) | Blocchi e Testi → Diciture Standard → Antistrappo | Diciture Standard | Inserisce testo standard "ANTISTRAPPO" sul pezzo |
| <img src="menu/LEONARDO/BOM.bmp" width="24" height="24" alt="BOM.bmp"> | [`BOM`](README_UTENTE.md#cmd-bom) | Blocchi e Testi → Diciture Standard → Bombatura | Diciture Standard | Inserisce testo standard "BOMBATURA" sul pezzo |
| <img src="menu/LEONARDO/RIN.bmp" width="24" height="24" alt="RIN.bmp"> | [`RIN`](README_UTENTE.md#cmd-rin) | Blocchi e Testi → Diciture Standard → Rinforzo | Diciture Standard | Inserisce testo standard "RINFORZO" sul pezzo |
| <img src="menu/LEONARDO/BOR.bmp" width="24" height="24" alt="BOR.bmp"> | [`BOR`](README_UTENTE.md#cmd-bor) | Blocchi e Testi → Diciture Standard → Bordatura | Diciture Standard | Inserisce testo standard "BORDATURA" sul pezzo |
| <img src="menu/LEONARDO/VAL.bmp" width="24" height="24" alt="VAL.bmp"> | [`VAL`](README_UTENTE.md#cmd-val) | Blocchi e Testi → Diciture Standard → Valigiaia | Diciture Standard | Inserisce testo standard "VALIGIAIA" sul pezzo |

### Cucitura

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/C5.bmp" width="24" height="24" alt="C5.bmp"> | [`C5`](README_UTENTE.md#cmd-c5) | Blocchi e Testi → Cucitura → CUC.ROV. 5MM | Diciture Standard | Inserisce testo "CUC.ROV. 5MM" |
| <img src="menu/LEONARDO/C5P.bmp" width="24" height="24" alt="C5P.bmp"> | [`C5P`](README_UTENTE.md#cmd-c5p) | Blocchi e Testi → Cucitura → CUC.ROV. 5MM CON PIPING | Diciture Standard | Inserisce testo "CUC.ROV. 5MM CON PIPING" |
| <img src="menu/LEONARDO/C7.bmp" width="24" height="24" alt="C7.bmp"> | [`C7`](README_UTENTE.md#cmd-c7) | Blocchi e Testi → Cucitura → CUC.ROV. 7MM | Diciture Standard | Inserisce testo "CUC.ROV. 7MM" |
| <img src="menu/LEONARDO/C7P.bmp" width="24" height="24" alt="C7P.bmp"> | [`C7P`](README_UTENTE.md#cmd-c7p) | Blocchi e Testi → Cucitura → CUC.ROV. 7MM CON PIPING | Diciture Standard | Inserisce testo "CUC.ROV. 7MM CON PIPING" |
| <img src="menu/LEONARDO/c5a.bmp" width="24" height="24" alt="c5a.bmp"> | [`C5A`](README_UTENTE.md#cmd-c5a) | Blocchi e Testi → Cucitura → CUC.ROV. 5MM APERTA | Diciture Standard | Inserisce testo "CUC.ROV. 5MM APERTA" |
| <img src="menu/LEONARDO/c7a.bmp" width="24" height="24" alt="c7a.bmp"> | [`C7A`](README_UTENTE.md#cmd-c7a) | Blocchi e Testi → Cucitura → CUC.ROV. 7MM APERTA | Diciture Standard | Inserisce testo "CUC.ROV. 7MM APERTA" |
| <img src="menu/LEONARDO/crov.bmp" width="24" height="24" alt="crov.bmp"> | [`CROV`](README_UTENTE.md#cmd-crov) | Blocchi e Testi → Cucitura → CUC.ROV. a Misura... | Diciture Standard | Inserisce testo "CUC.ROV. x MM" con la misura chiesta |
| <img src="menu/LEONARDO/crovp.bmp" width="24" height="24" alt="crovp.bmp"> | [`CROVP`](README_UTENTE.md#cmd-crovp) | Blocchi e Testi → Cucitura → CUC.ROV. a Misura con Piping... | Diciture Standard | Inserisce testo "CUC.ROV. x MM CON PIPING" con la misura chiesta |
| <img src="menu/LEONARDO/crova.bmp" width="24" height="24" alt="crova.bmp"> | [`CROVA`](README_UTENTE.md#cmd-crova) | Blocchi e Testi → Cucitura → CUC.ROV. a Misura Riaperta... | Diciture Standard | Inserisce testo "CUC.ROV. x MM RIAPERTA" con la misura chiesta |
| <img src="menu/LEONARDO/crovar.bmp" width="24" height="24" alt="crovar.bmp"> | [`CROVAR`](README_UTENTE.md#cmd-crovar) | Blocchi e Testi → Cucitura → CUC.ROV. a Misura Riaperta e Ribadita... | Diciture Standard | Inserisce testo "CUC.ROV. x MM RIAPERTA E RIBADITA" con la misura chiesta |
| <img src="menu/LEONARDO/cip.bmp" width="24" height="24" alt="cip.bmp"> | [`CIP`](README_UTENTE.md#cmd-cip) | Blocchi e Testi → Cucitura → CUC. in Piedi | Diciture Standard | Inserisce testo "CUC. IN PIEDI" |

### Blocchi Avanzati

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/blocco_rapido.bmp" width="24" height="24" alt="blocco_rapido.bmp"> | [`BLOCCO_RAPIDO`](README_UTENTE.md#cmd-blocco-rapido) | Blocchi e Testi → Blocchi Avanzati → Blocco Rapido | BLOCCHI AVANZATI | Crea blocco con nome casuale e lo inserisce |
| <img src="menu/LEONARDO/blocchi_in_punti.bmp" width="24" height="24" alt="blocchi_in_punti.bmp"> | [`BLOCCHI_IN_PUNTI`](README_UTENTE.md#cmd-blocchi-in-punti) | Blocchi e Testi → Blocchi Avanzati → Blocchi in Punti | BLOCCHI AVANZATI | Converte le tacche PitRTak in punti, nel punto di inserimento |
| <img src="menu/LEONARDO/inserisci_blocchi.bmp" width="24" height="24" alt="inserisci_blocchi.bmp"> | [`INSERISCI_BLOCCHI`](README_UTENTE.md#cmd-inserisci-blocchi) | Blocchi e Testi → Blocchi Avanzati → Inserisci Blocchi su Polilinea | BLOCCHI AVANZATI, Tacche | Inserisce blocchi lungo polilinea a distanza fissa |
| <img src="menu/LEONARDO/cbp.bmp" width="24" height="24" alt="cbp.bmp"> | [`CBP`](README_UTENTE.md#cmd-cbp) | Blocchi e Testi → Blocchi Avanzati → Cambia Punto Base | UTILITA SISTEMA | Cambia punto base blocco senza rilocare inserimenti |
| <img src="menu/LEONARDO/cbpr.bmp" width="24" height="24" alt="cbpr.bmp"> | [`CBPR`](README_UTENTE.md#cmd-cbpr) | Blocchi e Testi → Blocchi Avanzati → Cambia Punto Base con Riferimento | UTILITA SISTEMA | Cambia punto base blocco e riloca tutti gli inserimenti |

### (voci principali)

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/conta.bmp" width="24" height="24" alt="conta.bmp"> | [`CONTA`](README_UTENTE.md#cmd-conta) | Blocchi e Testi → Conta (Numerazione Progressiva) | Plugin | Inserisce blocchi numerati progressivamente (Conta) |

## Menu Offset

### (voci principali)

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/ofi.bmp" width="24" height="24" alt="ofi.bmp"> | [`OFI`](README_UTENTE.md#cmd-ofi) | Offset → Offset Ringrano | Offset Tratto | Offset Ringrano: originale su layer "0", offset su OUTCUT |
| <img src="menu/LEONARDO/offset_tratto.bmp" width="24" height="24" alt="offset_tratto.bmp"> | [`OFFSET_TRATTO`](README_UTENTE.md#cmd-offset-tratto) | Offset → Offset Tratto di Polilinea | Offset Tratto | Offset di un tratto di polilinea: finestra con variante, distanza, lato e anteprima |
| <img src="menu/LEONARDO/ofinc.bmp" width="24" height="24" alt="ofinc.bmp"> | [`OFINC`](README_UTENTE.md#cmd-ofinc) | Offset → Offset Incrementali (OFINC) | Offset Tratto | Offset incrementali: d, d+inc, d+2inc... misurati dall'originale |

### Offset Tratteggiato (Cucitura)

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/Of2T.BMP" width="24" height="24" alt="Of2T.BMP"> | [`OFT_2`](README_UTENTE.md#cmd-oft-2) | Offset → Offset Tratteggiato (Cucitura) → Offset 2 (scala 0.3) | Offset | Offset 2mm con linea tratteggiata tipo CUCITURA |
| <img src="menu/LEONARDO/OF3T.BMP" width="24" height="24" alt="OF3T.BMP"> | [`OFT_3`](README_UTENTE.md#cmd-oft-3) | Offset → Offset Tratteggiato (Cucitura) → Offset 3 | Offset | Offset 3mm con linea tratteggiata tipo CUCITURA |
| <img src="menu/LEONARDO/OF4T.BMP" width="24" height="24" alt="OF4T.BMP"> | [`OFT_4`](README_UTENTE.md#cmd-oft-4) | Offset → Offset Tratteggiato (Cucitura) → Offset 4 | Offset | Offset 4mm con linea tratteggiata tipo CUCITURA |
| <img src="menu/LEONARDO/OF5T.BMP" width="24" height="24" alt="OF5T.BMP"> | [`OFT_5`](README_UTENTE.md#cmd-oft-5) | Offset → Offset Tratteggiato (Cucitura) → Offset 5 | Offset | Offset 5mm con linea tratteggiata tipo CUCITURA |
| <img src="menu/LEONARDO/OF6T.BMP" width="24" height="24" alt="OF6T.BMP"> | [`OFT_6`](README_UTENTE.md#cmd-oft-6) | Offset → Offset Tratteggiato (Cucitura) → Offset 6 | Offset | Offset 6mm con linea tratteggiata tipo CUCITURA |
| <img src="menu/LEONARDO/OF8T.BMP" width="24" height="24" alt="OF8T.BMP"> | [`OFT_8`](README_UTENTE.md#cmd-oft-8) | Offset → Offset Tratteggiato (Cucitura) → Offset 8 | Offset | Offset 8mm con linea tratteggiata tipo CUCITURA |
| <img src="menu/LEONARDO/OFT10T.bmp" width="24" height="24" alt="OFT10T.bmp"> | [`OFT_10`](README_UTENTE.md#cmd-oft-10) | Offset → Offset Tratteggiato (Cucitura) → Offset 10 | Offset | Offset 10mm con linea tratteggiata tipo CUCITURA |
| <img src="menu/LEONARDO/OFt.bmp" width="24" height="24" alt="OFt.bmp"> | [`OFT`](README_UTENTE.md#cmd-oft) | Offset → Offset Tratteggiato (Cucitura) → Offset Variabile | Offset | Offset tratteggiato a distanza variabile |

### Offset Tratto Avanzato

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/offset_tratto_simple.bmp" width="24" height="24" alt="offset_tratto_simple.bmp"> | [`OFFSET_TRATTO_SIMPLE`](README_UTENTE.md#cmd-offset-tratto-simple) | Offset → Offset Tratto Avanzato → Offset Tratto Semplice | Offset Tratto | Offset tratto semplice: solo l'offset del tratto fra due punti |
| <img src="menu/LEONARDO/offset_tratto_linked.bmp" width="24" height="24" alt="offset_tratto_linked.bmp"> | [`OFFSET_TRATTO_LINKED`](README_UTENTE.md#cmd-offset-tratto-linked) | Offset → Offset Tratto Avanzato → Offset Tratto Collegato | Offset Tratto | Offset tratto collegato: offset del tratto e linee di collegamento agli estremi |
| <img src="menu/LEONARDO/offset_tratto_hatched.bmp" width="24" height="24" alt="offset_tratto_hatched.bmp"> | [`OFFSET_TRATTO_HATCHED`](README_UTENTE.md#cmd-offset-tratto-hatched) | Offset → Offset Tratto Avanzato → Offset Tratto Tratteggiato | Offset Tratto | Offset tratto tratteggiato: offset del tratto con il tipo linea CUCITURA |
| <img src="menu/LEONARDO/offset_tratto_break.bmp" width="24" height="24" alt="offset_tratto_break.bmp"> | [`OFFSET_TRATTO_BREAK`](README_UTENTE.md#cmd-offset-tratto-break) | Offset → Offset Tratto Avanzato → Offset Tratto Spezzato | Offset Tratto | Offset tratto spezzato: toglie il tratto e mette offset e collegamenti |
| <img src="menu/LEONARDO/offset_tratto_break_clean.bmp" width="24" height="24" alt="offset_tratto_break_clean.bmp"> | [`OFFSET_TRATTO_BREAK_CLEAN`](README_UTENTE.md#cmd-offset-tratto-break-clean) | Offset → Offset Tratto Avanzato → Offset Tratto Spezzato Pulito | Offset Tratto | Offset tratto spezzato pulito: toglie il tratto e mette solo l'offset |

## Menu Stampe e Nesting

### Sbozzi

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/SBOZZO.bmp" width="24" height="24" alt="SBOZZO.bmp"> | [`SBOZZO`](README_UTENTE.md#cmd-sbozzo) | Stampe e Nesting → Sbozzi → Sbozzo (geometrico o rettangolare) | Sbozzo | Sbozzo geometrico o rettangolare, spigoli vivi o arrotondati, su OUTCUT; tacche cancellate, pezzo sul layer 0 |
| <img src="menu/LEONARDO/SBOZZO_RETT.BMP" width="24" height="24" alt="SBOZZO_RETT.BMP"> | [`SBOZZO_RETT`](README_UTENTE.md#cmd-sbozzo-rett) | Stampe e Nesting → Sbozzi → Sbozzo Rettangolare | Sbozzo | Sbozzo rettangolare (ingombro allargato) e poi Nesting Avanzato |
| <img src="menu/LEONARDO/sbozzo_bound.bmp" width="24" height="24" alt="sbozzo_bound.bmp"> | [`SBOZZO_BOUND`](README_UTENTE.md#cmd-sbozzo-bound) | Stampe e Nesting → Sbozzi → Sbozzo Boundary | Sbozzo | Sbozzo boundary: disegna bounding box rettangolare |
| <img src="menu/LEONARDO/sbozzomultiplo.bmp" width="24" height="24" alt="sbozzomultiplo.bmp"> | [`COPYARRAY`](README_UTENTE.md#cmd-copyarray) | Stampe e Nesting → Sbozzi → Sbozzo Multiplo (Array) | Sbozzo | Sbozzo multiplo: array rettangolare con bbox complessivo |
| <img src="menu/LEONARDO/DIMA_ATOM.bmp" width="24" height="24" alt="DIMA_ATOM.bmp"> | [`DIMA`](README_UTENTE.md#cmd-dima) | Stampe e Nesting → Sbozzi → Dima Standard | Sbozzo | Crea dima da layer con offset automatico |
| <img src="menu/LEONARDO/dima_tacche_atom.bmp" width="24" height="24" alt="dima_tacche_atom.bmp"> | [`DIMA_TACCHE_ATOM`](README_UTENTE.md#cmd-dima-tacche-atom) | Stampe e Nesting → Sbozzi → Dima Tacche (Atom) | Sbozzo | Crea dima con tacche in modalita' atomica |
| <img src="menu/LEONARDO/cbp.bmp" width="24" height="24" alt="cbp.bmp"> | [`CBP`](README_UTENTE.md#cmd-cbp) | Stampe e Nesting → Sbozzi → Sbozzo CBP | UTILITA SISTEMA | Sbozzo con cambio punto base |
|  | [`CHECK_LINEE_INTERNE`](README_UTENTE.md#cmd-check-linee-interne) | Stampe e Nesting → Sbozzi → Verifica Contorni Doppi | - | Contorni OUTCUT/ENDCUT doppi: le copie sul layer ERR, davanti |

### Definisci Tipo Pezzo

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/ed-INFUST.bmp" width="24" height="24" alt="ed-INFUST.bmp"> | [`ED-INFUST`](README_UTENTE.md#cmd-ed-infust) | Stampe e Nesting → Definisci Tipo Pezzo → Definisci Infustitura | Dati Pezzo | Aggiunge prefisso "Infustitura" al nome del pezzo |
| <img src="menu/LEONARDO/ed-RIF.bmp" width="24" height="24" alt="ed-RIF.bmp"> | [`ED-RIF`](README_UTENTE.md#cmd-ed-rif) | Stampe e Nesting → Definisci Tipo Pezzo → Definisci Rifilo | Dati Pezzo | Aggiunge prefisso "Rifilo" al nome del pezzo |
| <img src="menu/LEONARDO/ed-SBOZ.bmp" width="24" height="24" alt="ed-SBOZ.bmp"> | [`ED-SBOZ`](README_UTENTE.md#cmd-ed-sboz) | Stampe e Nesting → Definisci Tipo Pezzo → Definisci Sbozzo (Taglio) | Dati Pezzo | Definisce lo sbozzo: scrive "Taglio" nel tipo del pezzo e davanti al nome |
| <img src="menu/LEONARDO/ed-FOD.bmp" width="24" height="24" alt="ed-FOD.bmp"> | [`ED-FOD`](README_UTENTE.md#cmd-ed-fod) | Stampe e Nesting → Definisci Tipo Pezzo → Definisci Fodera | Dati Pezzo | Aggiunge prefisso "Fodera" al nome del pezzo |

### Tavole di Stampa

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/PRESTAMPA.bmp" width="24" height="24" alt="PRESTAMPA.bmp"> | [`PRESTAMPA`](README_UTENTE.md#cmd-prestampa) | Stampe e Nesting → Tavole di Stampa → Prestampa | Tavola di Stampa | Prepara il disegno per la stampa |
| <img src="menu/LEONARDO/TAVOLA_STAMPA.bmp" width="24" height="24" alt="TAVOLA_STAMPA.bmp"> | [`TAVOLA_DI_STAMPA_ANTIBUG`](README_UTENTE.md#cmd-tavola-di-stampa-antibug) | Stampe e Nesting → Tavole di Stampa → Tavola Selezione Manuale | Tavola di Stampa | Prepara sagome + nesting per plotter (selezione manuale) |
| <img src="menu/LEONARDO/TAVOLA_STAMPA_A3.bmp" width="24" height="24" alt="TAVOLA_STAMPA_A3.bmp"> | [`TAVOLA_DI_STAMPA_A3`](README_UTENTE.md#cmd-tavola-di-stampa-a3) | Stampe e Nesting → Tavole di Stampa → Tavola Selezione A3 | Tavola di Stampa | Prepara sagome formato A3 + nesting per plotter |
| <img src="menu/LEONARDO/nesting.bmp" width="24" height="24" alt="nesting.bmp"> | [`NESTING3`](README_UTENTE.md#cmd-nesting3) | Stampe e Nesting → Tavole di Stampa → Nesting Avanzato | Tavola di Stampa | Nesting avanzato (NESTING3) |

### Nesting Base

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/allinea_blocchi.bmp" width="24" height="24" alt="allinea_blocchi.bmp"> | [`NESTINGLINEA`](README_UTENTE.md#cmd-nestinglinea) | Stampe e Nesting → Nesting Base → Nesting Linea | AAMA, Nesting Base | Nesting linea: allinea pezzi in riga orizzontale |
| <img src="menu/LEONARDO/nesting1.bmp" width="24" height="24" alt="nesting1.bmp"> | [`NESTING1`](README_UTENTE.md#cmd-nesting1) | Stampe e Nesting → Nesting Base → Nesting Singola Linea | Nesting Base | Nesting singola linea semplificato |
| <img src="menu/LEONARDO/nestingarea.bmp" width="24" height="24" alt="nestingarea.bmp"> | [`NESTINGAREA`](README_UTENTE.md#cmd-nestingarea) | Stampe e Nesting → Nesting Base → Nesting Area | Nesting Base | Definisce area temporanea per il nesting |
| <img src="menu/LEONARDO/nesting.bmp" width="24" height="24" alt="nesting.bmp"> | [`NESTING3`](README_UTENTE.md#cmd-nesting3) | Stampe e Nesting → Nesting Base → Nesting Avanzato (3) | Tavola di Stampa | Nesting avanzato variante 3 |
| <img src="menu/LEONARDO/nesting5.bmp" width="24" height="24" alt="nesting5.bmp"> | [`NESTING5`](README_UTENTE.md#cmd-nesting5) | Stampe e Nesting → Nesting Base → Nesting Multi-Riga (5) | Nesting Base | Nesting multi-riga con spacing configurabile |
| <img src="menu/LEONARDO/nesting51.bmp" width="24" height="24" alt="nesting51.bmp"> | [`NESTING51`](README_UTENTE.md#cmd-nesting51) | Stampe e Nesting → Nesting Base → Nesting Alternato (51) | Nesting Base | Nesting alternato: righe con direzione invertita |
| <img src="menu/LEONARDO/nesting52.bmp" width="24" height="24" alt="nesting52.bmp"> | [`NESTING52`](README_UTENTE.md#cmd-nesting52) | Stampe e Nesting → Nesting Base → Nesting Ordinato (52) | Nesting Base | Nesting ordinato: ordina i pezzi per dimensione prima del nesting |
|  | [`NESTING1_TAVOLA`](README_UTENTE.md#cmd-nesting1-tavola) | Stampe e Nesting → Nesting Base → Nesting Base senza spazio | - | Nesting base a scalini senza spazio, righe a serpentina, tavola rettangolare |

### Nesting Algoritmi Avanzati

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/nesting.bmp" width="24" height="24" alt="nesting.bmp"> | [`NESTING`](README_UTENTE.md#cmd-nesting) | Stampe e Nesting → Nesting Algoritmi Avanzati → Nesting Base | NESTING AVANZATO | Nesting base con gestione overflow automatico |
| <img src="menu/LEONARDO/nesting-bestfit.bmp" width="24" height="24" alt="nesting-bestfit.bmp"> | [`NESTING-BESTFIT`](README_UTENTE.md#cmd-nesting-bestfit) | Stampe e Nesting → Nesting Algoritmi Avanzati → Nesting Best Fit | NESTING AVANZATO | Nesting best fit: ottimizzazione massima dell'area |
| <img src="menu/LEONARDO/nesting-bestfit2.bmp" width="24" height="24" alt="nesting-bestfit2.bmp"> | [`NESTING-BESTFIT2`](README_UTENTE.md#cmd-nesting-bestfit2) | Stampe e Nesting → Nesting Algoritmi Avanzati → Nesting Best Fit 2 | NESTING AVANZATO | Nesting best fit versione 2 ottimizzata |
| <img src="menu/LEONARDO/nesting-trueshape3.bmp" width="24" height="24" alt="nesting-trueshape3.bmp"> | [`NESTING-TRUESHAPE3`](README_UTENTE.md#cmd-nesting-trueshape3) | Stampe e Nesting → Nesting Algoritmi Avanzati → Nesting TrueShape 3 | NESTING AVANZATO | Nesting true shape: incastro sulla forma reale dei pezzi |
| <img src="menu/LEONARDO/nesting-maxrects.bmp" width="24" height="24" alt="nesting-maxrects.bmp"> | [`NESTING-MAXRECTS`](README_UTENTE.md#cmd-nesting-maxrects) | Stampe e Nesting → Nesting Algoritmi Avanzati → Nesting MaxRects | NESTING AVANZATO | Nesting MaxRects: rettangoli liberi massimi, 4 regole x 3 ordinamenti, rotazione 90 |
| <img src="menu/LEONARDO/nesting-ottimizza.bmp" width="24" height="24" alt="nesting-ottimizza.bmp"> | [`NESTING-OTTIMIZZA`](README_UTENTE.md#cmd-nesting-ottimizza) | Stampe e Nesting → Nesting Algoritmi Avanzati → Nesting Ottimizzato (forma vera) | NESTING AVANZATO | Nesting ottimizzato sulla forma vera: elimina le sovrapposizioni per il tempo scelto |
| <img src="menu/LEONARDO/nesting_confronta.bmp" width="24" height="24" alt="nesting_confronta.bmp"> | [`NESTING_CONFRONTA`](README_UTENTE.md#cmd-nesting-confronta) | Stampe e Nesting → Nesting Algoritmi Avanzati → Nesting Confronta (tutti, sceglie il migliore) | NESTING AVANZATO | Confronta i nesting scelti (tavole, occupazione, controlli) e applica quello scelto |
| <img src="menu/LEONARDO/nesting_confronta_imp.bmp" width="24" height="24" alt="nesting_confronta_imp.bmp"> | [`NESTING_CONFRONTA_IMPOSTAZIONI`](README_UTENTE.md#cmd-nesting-confronta-impostazioni) | Stampe e Nesting → Nesting Algoritmi Avanzati → Nesting Confronta Impostazioni... | NESTING AVANZATO | Sceglie quali nesting confronta NESTING_CONFRONTA e i loro parametri |
| <img src="menu/LEONARDO/nesting-centered.bmp" width="24" height="24" alt="nesting-centered.bmp"> | [`NESTING-CENTERED`](README_UTENTE.md#cmd-nesting-centered) | Stampe e Nesting → Nesting Algoritmi Avanzati → Nesting Centrato | NESTING AVANZATO | Nesting centrato: disposizione simmetrica rispetto al centro |
| <img src="menu/LEONARDO/nesting-cluster.bmp" width="24" height="24" alt="nesting-cluster.bmp"> | [`NESTING-CLUSTER`](README_UTENTE.md#cmd-nesting-cluster) | Stampe e Nesting → Nesting Algoritmi Avanzati → Nesting Cluster | NESTING AVANZATO | Nesting cluster: raggruppa pezzi per tipo o dimensione |
| <img src="menu/LEONARDO/nesting-column.bmp" width="24" height="24" alt="nesting-column.bmp"> | [`NESTING-COLUMN`](README_UTENTE.md#cmd-nesting-column) | Stampe e Nesting → Nesting Algoritmi Avanzati → Nesting Colonna | NESTING AVANZATO | Nesting colonne: dispone i pezzi in colonne verticali |
| <img src="menu/LEONARDO/nesting-guillotine.bmp" width="24" height="24" alt="nesting-guillotine.bmp"> | [`NESTING-GUILLOTINE`](README_UTENTE.md#cmd-nesting-guillotine) | Stampe e Nesting → Nesting Algoritmi Avanzati → Nesting Ghigliottina | NESTING AVANZATO | Nesting ghigliottina: tagli ortogonali progressivi |
| <img src="menu/LEONARDO/nesting-hybrid.bmp" width="24" height="24" alt="nesting-hybrid.bmp"> | [`NESTING-HYBRID`](README_UTENTE.md#cmd-nesting-hybrid) | Stampe e Nesting → Nesting Algoritmi Avanzati → Nesting Ibrido | NESTING AVANZATO | Nesting ibrido: combina più strategie di ottimizzazione |
| <img src="menu/LEONARDO/nesting-spiral.bmp" width="24" height="24" alt="nesting-spiral.bmp"> | [`NESTING-SPIRAL`](README_UTENTE.md#cmd-nesting-spiral) | Stampe e Nesting → Nesting Algoritmi Avanzati → Nesting Spirale | NESTING AVANZATO | Nesting spirale: disposizione a spirale dal centro della tavola |
| <img src="menu/LEONARDO/nesting-tetris.bmp" width="24" height="24" alt="nesting-tetris.bmp"> | [`NESTING-TETRIS`](README_UTENTE.md#cmd-nesting-tetris) | Stampe e Nesting → Nesting Algoritmi Avanzati → Nesting Tetris | NESTING AVANZATO | Nesting tetris: incastro pezzi stile tetris |

### Fogli Plotter

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/TAVOLA_STAMPA_VUOTA.bmp" width="24" height="24" alt="TAVOLA_STAMPA_VUOTA.bmp"> | [`LEOUM`](README_UTENTE.md#cmd-leoum) | Stampe e Nesting → Fogli Plotter → Singolo Foglio (650x950) | Tavola di Stampa | Foglio plotter singolo 650x950mm |
| <img src="menu/LEONARDO/leoum2.bmp" width="24" height="24" alt="leoum2.bmp"> | [`LEOUM2`](README_UTENTE.md#cmd-leoum2) | Stampe e Nesting → Fogli Plotter → Due Fogli (1300x950) | Tavola di Stampa | Due fogli plotter 1300x950mm |
| <img src="menu/LEONARDO/leoum4.bmp" width="24" height="24" alt="leoum4.bmp"> | [`LEOUM4`](README_UTENTE.md#cmd-leoum4) | Stampe e Nesting → Fogli Plotter → Quattro Fogli (1300x1800) | Tavola di Stampa | Quattro fogli plotter 1300x1800mm |

### (voci principali)

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/Pass.bmp" width="24" height="24" alt="Pass.bmp"> | [`PASSANTE`](README_UTENTE.md#cmd-passante) | Stampe e Nesting → Passante Tracolla | Plugin | Calcola e disegna passante tracolla perfetto |

## Menu Tipolinea e Layer

### (voci principali)

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/PENNA.bmp" width="24" height="24" alt="PENNA.bmp"> | [`PENNA`](README_UTENTE.md#cmd-penna) | Tipolinea e Layer → Penna (Layer 0) | Layer | Ripristina layer "0" con colore BYLAYER (penna standard) |
| <img src="menu/LEONARDO/ENDCUT.bmp" width="24" height="24" alt="ENDCUT.bmp"> | [`ENDCUT`](README_UTENTE.md#cmd-endcut) | Tipolinea e Layer → Rifilo (ENDCUT) | Layer | Sposta oggetto sul layer ENDCUT (rifilo, Ciano) |
| <img src="menu/LEONARDO/OUTCUT.bmp" width="24" height="24" alt="OUTCUT.bmp"> | [`OUTCUT`](README_UTENTE.md#cmd-outcut) | Tipolinea e Layer → Taglio (OUTCUT) | Layer | Sposta oggetto sul layer OUTCUT (taglio esterno, Rosso) |
| <img src="menu/LEONARDO/INTCUT.bmp" width="24" height="24" alt="INTCUT.bmp"> | [`INTCUT`](README_UTENTE.md#cmd-intcut) | Tipolinea e Layer → Taglio Interno (INTCUT) | Layer | Sposta oggetto sul layer INTCUT (taglio interno, Blu) |

### Colori Rapidi

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/giallo.bmp" width="24" height="24" alt="giallo.bmp"> | [`GGG`](README_UTENTE.md#cmd-ggg) | Tipolinea e Layer → Colori Rapidi → Giallo (2) | Layer | Imposta colore Giallo (ACI 2) per gli oggetti selezionati |
| <img src="menu/LEONARDO/verde.bmp" width="24" height="24" alt="verde.bmp"> | [`VVV`](README_UTENTE.md#cmd-vvv) | Tipolinea e Layer → Colori Rapidi → Verde (3) | Layer | Imposta colore Verde (ACI 3) per gli oggetti selezionati |
| <img src="menu/LEONARDO/arancio.bmp" width="24" height="24" alt="arancio.bmp"> | [`AAA`](README_UTENTE.md#cmd-aaa) | Tipolinea e Layer → Colori Rapidi → Arancione (30) | Layer | Imposta colore Arancione (ACI 30) per gli oggetti selezionati |
| <img src="menu/LEONARDO/fuxia.bmp" width="24" height="24" alt="fuxia.bmp"> | [`FFF`](README_UTENTE.md#cmd-fff) | Tipolinea e Layer → Colori Rapidi → Magenta (6) | Layer | Imposta colore Magenta (ACI 6) per gli oggetti selezionati |
| <img src="menu/LEONARDO/bianco.bmp" width="24" height="24" alt="bianco.bmp"> | [`BBB`](README_UTENTE.md#cmd-bbb) | Tipolinea e Layer → Colori Rapidi → Bianco (254) | Layer | Imposta colore Bianco (ACI 254) per gli oggetti selezionati |

### (voci principali)

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/cucitura.bmp" width="24" height="24" alt="cucitura.bmp"> | [`CUCITURA`](README_UTENTE.md#cmd-cucitura) | Tipolinea e Layer → Nuova Cucitura | Layer | Imposta tipo linea CUCITURA (tratteggiato, scala 0.3) |
| <img src="menu/LEONARDO/Continua.bmp" width="24" height="24" alt="Continua.bmp"> | [`CONTINUA`](README_UTENTE.md#cmd-continua) | Tipolinea e Layer → Linea Continua | Layer | Ripristina tipo linea continua (BYLAYER) |

## Menu Tacche

### (voci principali)

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/TakP.bmp" width="24" height="24" alt="TakP.bmp"> | [`INSERISCI_TACCA`](README_UTENTE.md#cmd-inserisci-tacca) | Tacche → Inserisci Tacca | Tacche | Inserisce blocco tacca con orientamento automatico sulla polilinea |
| <img src="menu/LEONARDO/TACCA_dapoli.BMP" width="24" height="24" alt="TACCA_dapoli.BMP"> | [`TACCA_DAPOLI`](README_UTENTE.md#cmd-tacca-dapoli) | Tacche → Tacca da Polilinea | Tacche | Copia distanza tra due punti della polilinea e inserisce tacca |
| <img src="menu/LEONARDO/TACCA_DISTANZA.BMP" width="24" height="24" alt="TACCA_DISTANZA.BMP"> | [`TACCA_DA_MISURA`](README_UTENTE.md#cmd-tacca-da-misura) | Tacche → Tacca da Misura | Tacche | Inserisce tacca a distanza numerica specifica |
| <img src="menu/LEONARDO/tacca.bmp" width="24" height="24" alt="tacca.bmp"> | [`TACCA`](README_UTENTE.md#cmd-tacca) | Tacche → Menu Tacche (TACCA) | Tacche | Menu principale tacche con selezione modalita' |

### Modifica Tacche

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/COPIA_TACCHE.BMP" width="24" height="24" alt="COPIA_TACCHE.BMP"> | [`COPIA_TACCHE`](README_UTENTE.md#cmd-copia-tacche) | Tacche → Modifica Tacche → Copia Tacche | Tacche | Copia tacche da un pezzo (fianco) a un altro (quadrante/fascia) |
| <img src="menu/LEONARDO/RIBALTA.BMP" width="24" height="24" alt="RIBALTA.BMP"> | [`RIBALTA_TACCHE`](README_UTENTE.md#cmd-ribalta-tacche) | Tacche → Modifica Tacche → Ribalta Tacche | Tacche | Ruota le tacche di 180 gradi (cambia verso) |
| <img src="menu/LEONARDO/riposiziona.BMP" width="24" height="24" alt="riposiziona.BMP"> | [`RIPOSIZIONA_TACCHE`](README_UTENTE.md#cmd-riposiziona-tacche) | Tacche → Modifica Tacche → Riposiziona Tacche | Tacche | Riposiziona tacche da polilinea netta a sbozzo |
| <img src="menu/LEONARDO/SOS_TACCHE.bmp" width="24" height="24" alt="SOS_TACCHE.bmp"> | [`SOSTITUISCI_TACCHE`](README_UTENTE.md#cmd-sostituisci-tacche) | Tacche → Modifica Tacche → Sostituisci Tacche | Tacche | Sostituisce tacche esistenti |
| <img src="menu/LEONARDO/METTI_V.bmp" width="24" height="24" alt="METTI_V.bmp"> | [`METTI_V`](README_UTENTE.md#cmd-metti-v) | Tacche → Modifica Tacche → Metti V | Tacche | Inserisce rientranza V sulla polilinea (Metti V) |
| <img src="menu/LEONARDO/METTI_V_AUTO.bmp" width="24" height="24" alt="METTI_V_AUTO.bmp"> | [`METTI_V_AUTO`](README_UTENTE.md#cmd-metti-v-auto) | Tacche → Modifica Tacche → Metti V Automatico | Tacche | Trova tacche vicine e le sostituisce automaticamente con V |

### Conversione Tacche

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/tacche_in_tagliate.bmp" width="24" height="24" alt="tacche_in_tagliate.bmp"> | [`TACCHE_IN_TAGLIATE`](README_UTENTE.md#cmd-tacche-in-tagliate) | Tacche → Conversione Tacche → Tacche in Tagliate | Conversione Tacche | Converte blocchi "tacca" in "tacca_t" (tacche tagliate) |
| <img src="menu/LEONARDO/tagliate_in_tacche.bmp" width="24" height="24" alt="tagliate_in_tacche.bmp"> | [`TAGLIATE_IN_TACCHE`](README_UTENTE.md#cmd-tagliate-in-tacche) | Tacche → Conversione Tacche → Tagliate in Tacche | Conversione Tacche | Converte blocchi "tacca_t" in "tacca" (tacche standard) |
| <img src="menu/LEONARDO/tacche_in_punti.bmp" width="24" height="24" alt="tacche_in_punti.bmp"> | [`TACCHE_IN_PUNTI`](README_UTENTE.md#cmd-tacche-in-punti) | Tacche → Conversione Tacche → Tacche in Punti | Conversione Tacche | Converte blocchi tacca in punti POINT |
| <img src="menu/LEONARDO/punti_in_tacche.bmp" width="24" height="24" alt="punti_in_tacche.bmp"> | [`PUNTI_IN_TACCHE`](README_UTENTE.md#cmd-punti-in-tacche) | Tacche → Conversione Tacche → Punti in Tacche | Conversione Tacche | Converte punti POINT in blocchi tacca |
| <img src="menu/LEONARDO/mozart_in_tacche.bmp" width="24" height="24" alt="mozart_in_tacche.bmp"> | [`MOZART_IN_TACCHE`](README_UTENTE.md#cmd-mozart-in-tacche) | Tacche → Conversione Tacche → Mozart in Tacche | Conversione Tacche | Converte blocchi Mozart "PitTacCT" in tacche standard |
| <img src="menu/LEONARDO/tacche_in_mozart.bmp" width="24" height="24" alt="tacche_in_mozart.bmp"> | [`TACCHE_IN_MOZART`](README_UTENTE.md#cmd-tacche-in-mozart) | Tacche → Conversione Tacche → Tacche in Mozart | Conversione Tacche | Converte tacche standard in blocchi Mozart "PitTacCT" |

### (voci principali)

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/vlwalk.bmp" width="24" height="24" alt="vlwalk.bmp"> | [`VLWALK`](README_UTENTE.md#cmd-vlwalk) | Tacche → Valida Tacche Interattivo | Tacche | Valida tacche in modo interattivo lungo la polilinea |

## Menu Materiali e Articoli

### Gestione Materiali

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/MATERIALE.BMP" width="24" height="24" alt="MATERIALE.BMP"> | [`MAT`](README_UTENTE.md#cmd-mat) | Materiali e Articoli → Gestione Materiali → Inserisci Materiale | Dati Pezzo | Inserisce materiale del pezzo (4 schede: Pelle/Infust/Tela/Fodera) |
| <img src="menu/LEONARDO/ed_materiale.bmp" width="24" height="24" alt="ed_materiale.bmp"> | [`ED-MAT`](README_UTENTE.md#cmd-ed-mat) | Materiali e Articoli → Gestione Materiali → Modifica Materiale | Dati Pezzo | Modifica il materiale del pezzo tramite dialog |
| <img src="menu/LEONARDO/ed_numero_materiale.bmp" width="24" height="24" alt="ed_numero_materiale.bmp"> | [`ED-MATERIALE`](README_UTENTE.md#cmd-ed-materiale) | Materiali e Articoli → Gestione Materiali → Modifica Quantità/Tipologia | Dati Pezzo | Modifica rapidamente quantità e tipologia del materiale |
| <img src="menu/LEONARDO/sostmat.bmp" width="24" height="24" alt="sostmat.bmp"> | [`SOSTMAT`](README_UTENTE.md#cmd-sostmat) | Materiali e Articoli → Gestione Materiali → Sostituisci Materiale (batch) | Gestione Materiali DB | Sostituisce materiale in batch mantenendo quantità e tipologia |
| <img src="menu/LEONARDO/mat1.bmp" width="24" height="24" alt="mat1.bmp"> | [`MAT1`](README_UTENTE.md#cmd-mat1) | Materiali e Articoli → Gestione Materiali → Visualizza per Materiale | Gestione Materiali DB | Visualizza e zooma i pezzi filtrati per materiale |
| <img src="menu/LEONARDO/seleziona-permat.bmp" width="24" height="24" alt="seleziona-permat.bmp"> | [`SELEZIONA-PERMAT`](README_UTENTE.md#cmd-seleziona-permat) | Materiali e Articoli → Gestione Materiali → Seleziona per Materiale | Gestione Materiali DB | Seleziona sagome per materiale specifico |
| <img src="menu/LEONARDO/mappamat.bmp" width="24" height="24" alt="mappamat.bmp"> | [`MAPPAMAT`](README_UTENTE.md#cmd-mappamat) | Materiali e Articoli → Gestione Materiali → Mappa dei Materiali | Gestione Materiali DB | Colora i pezzi per materiale, con legenda (i colori spariscono chiudendo la legenda) |
| <img src="menu/LEONARDO/mappacat.bmp" width="24" height="24" alt="mappacat.bmp"> | [`MAPPACAT`](README_UTENTE.md#cmd-mappacat) | Materiali e Articoli → Gestione Materiali → Mappa delle Categorie | Gestione Materiali DB | Colora i pezzi per categoria: Infustiture, Pelle, Tele, Fodere |
| <img src="menu/LEONARDO/controlla.bmp" width="24" height="24" alt="controlla.bmp"> | [`CONTROLLA`](README_UTENTE.md#cmd-controlla) | Materiali e Articoli → Gestione Materiali → Controllo dei Pezzi | Gestione Materiali DB | Trova i pezzi senza materiale o nome e i blocchi fuori dai pezzi, prima del taglio |
| <img src="menu/LEONARDO/gestmat.bmp" width="24" height="24" alt="gestmat.bmp"> | [`GESTMAT`](README_UTENTE.md#cmd-gestmat) | Materiali e Articoli → Gestione Materiali → Database Materiali | Gestione Materiali DB | Dialog gestione e modifica liste materiali |
| <img src="menu/LEONARDO/gnames.bmp" width="24" height="24" alt="gnames.bmp"> | [`GNAMES`](README_UTENTE.md#cmd-gnames) | Materiali e Articoli → Gestione Materiali → Database Nomi | Gestione Materiali DB | Dialog gestione liste nomi pezzo (Nome1/2/3.txt) |

### Gestione Articoli

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/NUM_ART.bmp" width="24" height="24" alt="NUM_ART.bmp"> | [`NUM`](README_UTENTE.md#cmd-num) | Materiali e Articoli → Gestione Articoli → Inserisci Numero Articolo | Dati Pezzo | Inserisce numero articolo nel disegno |
|  | [`ED-NUMART`](README_UTENTE.md#cmd-ed-numart) | Materiali e Articoli → Gestione Articoli → Modifica Numero Articolo | - | Modifica un numero articolo esistente |
| <img src="menu/LEONARDO/NOME_PEZZO.BMP" width="24" height="24" alt="NOME_PEZZO.BMP"> | [`NOM`](README_UTENTE.md#cmd-nom) | Materiali e Articoli → Gestione Articoli → Inserisci Nome Pezzo | Dati Pezzo | Inserisce il nome del pezzo tramite dialog a 3 liste |
| <img src="menu/LEONARDO/ed_nome_pezzo.bmp" width="24" height="24" alt="ed_nome_pezzo.bmp"> | [`ED-NOM`](README_UTENTE.md#cmd-ed-nom) | Materiali e Articoli → Gestione Articoli → Modifica Nome Pezzo | Dati Pezzo | Modifica il nome del pezzo tramite dialog |

### Accessori e Lavorazioni

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/accessorio_ins.bmp" width="24" height="24" alt="accessorio_ins.bmp"> | [`ACC`](README_UTENTE.md#cmd-acc) | Materiali e Articoli → Accessori e Lavorazioni → Inserisci Accessorio | Lavorazioni e Accessori | Inserisce accessori metallici multipli (max 16) con quantità |
| <img src="menu/LEONARDO/accessorio_edit.bmp" width="24" height="24" alt="accessorio_edit.bmp"> | [`ED-ACC`](README_UTENTE.md#cmd-ed-acc) | Materiali e Articoli → Accessori e Lavorazioni → Modifica Accessorio | Lavorazioni e Accessori | Modifica, aggiunge, rimuove o riordina accessori |
| <img src="menu/LEONARDO/accessorio_db.bmp" width="24" height="24" alt="accessorio_db.bmp"> | [`ED-DB-ACC`](README_UTENTE.md#cmd-ed-db-acc) | Materiali e Articoli → Accessori e Lavorazioni → Database Accessori | Lavorazioni e Accessori | Edita il database accessori (accessori.txt) |
| <img src="menu/LEONARDO/accessorio_data.bmp" width="24" height="24" alt="accessorio_data.bmp"> | [`CREA-DATACC`](README_UTENTE.md#cmd-crea-datacc) | Materiali e Articoli → Accessori e Lavorazioni → Crea Blocco Dati Accessori | Lavorazioni e Accessori | Crea blocco DATACC con 32 attributi per accessori |
| <img src="menu/LEONARDO/lavorazione_ins.bmp" width="24" height="24" alt="lavorazione_ins.bmp"> | [`LAV`](README_UTENTE.md#cmd-lav) | Materiali e Articoli → Accessori e Lavorazioni → Inserisci Lavorazione | Lavorazioni e Accessori | Inserisce lavorazioni multiple (max 16) con ripetizioni |
| <img src="menu/LEONARDO/lavorazione_edit.bmp" width="24" height="24" alt="lavorazione_edit.bmp"> | [`ED-LAV`](README_UTENTE.md#cmd-ed-lav) | Materiali e Articoli → Accessori e Lavorazioni → Modifica Lavorazione | Lavorazioni e Accessori | Modifica, aggiunge, rimuove o riordina lavorazioni |
| <img src="menu/LEONARDO/lavorazione_db.bmp" width="24" height="24" alt="lavorazione_db.bmp"> | [`ED-DB-LAV`](README_UTENTE.md#cmd-ed-db-lav) | Materiali e Articoli → Accessori e Lavorazioni → Database Lavorazioni | Lavorazioni e Accessori | Edita il database lavorazioni (lavorazioni.txt) |
| <img src="menu/LEONARDO/lavorazione_data.bmp" width="24" height="24" alt="lavorazione_data.bmp"> | [`CREA-DATLAV`](README_UTENTE.md#cmd-crea-datlav) | Materiali e Articoli → Accessori e Lavorazioni → Crea Blocco Dati Lavorazioni | Lavorazioni e Accessori | Crea blocco DATLAV con 32 attributi per lavorazioni |

### (voci principali)

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/SPESSORE.BMP" width="24" height="24" alt="SPESSORE.BMP"> | [`SPESSORE`](README_UTENTE.md#cmd-spessore) | Materiali e Articoli → Gestione Spessore | Dati Pezzo | Scrive lo spessore finito del pezzo (SF.) nei punti indicati |

## Menu AAMA e Export

### AAMA Standard

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/AAMA.BMP" width="24" height="24" alt="AAMA.BMP"> | [`AAMA`](README_UTENTE.md#cmd-aama) | AAMA e Export → AAMA Standard → AAMA Standard | AAMA | Processa sagome AAMA standard per macchine da taglio |
|  | [`AAMA-SILENT`](README_UTENTE.md#cmd-aama-silent) | AAMA e Export → AAMA Standard → AAMA Silent (batch) | - | Elaborazione AAMA in modalita' silenziosa per batch |
|  | [`AAMA_SPACING`](README_UTENTE.md#cmd-aama-spacing) | AAMA e Export → AAMA Standard → AAMA Spaziatura | - | Apre le impostazioni AAMA sulla scheda Posizionamento (spazi fra i blocchi) |
| <img src="menu/LEONARDO/aama_estrai.bmp" width="24" height="24" alt="aama_estrai.bmp"> | [`AAMA_ESTRAI`](README_UTENTE.md#cmd-aama-estrai) | AAMA e Export → AAMA Standard → AAMA Estrai | AAMA | Crea il DXF dai blocchi AAMA a video (layer 1) |
| <img src="menu/LEONARDO/aama_sel.bmp" width="24" height="24" alt="aama_sel.bmp"> | [`AAMA-SEL`](README_UTENTE.md#cmd-aama-sel) | AAMA e Export → AAMA Standard → AAMA Selezione (clic nei pezzi) | AAMA | AAMA sui pezzi scelti con un clic dentro o con una finestra |
| <img src="menu/LEONARDO/aama_mat.bmp" width="24" height="24" alt="aama_mat.bmp"> | [`AAMA-MAT`](README_UTENTE.md#cmd-aama-mat) | AAMA e Export → AAMA Standard → AAMA per Materiale | AAMA | AAMA per materiale: un DXF per ogni materiale scelto o i blocchi a video |
|  | [`AAMA-DXF`](README_UTENTE.md#cmd-aama-dxf) | AAMA e Export → AAMA Standard → AAMA DXF dai blocchi | - | Crea il DXF dai blocchi AAMA a video (come AAMA Estrai) |
| <img src="menu/LEONARDO/aama_batch.bmp" width="24" height="24" alt="aama_batch.bmp"> | [`AAMA-BATCH`](README_UTENTE.md#cmd-aama-batch) | AAMA e Export → AAMA Standard → AAMA su Cartella | AAMA | AAMA su tutti i DWG di una cartella, senza aprirli |
|  | [`AAMA_RUN_FILE`](README_UTENTE.md#cmd-aama-run-file) | AAMA e Export → AAMA Standard → AAMA su File | - | AAMA su un DWG scelto, senza aprirlo |
|  | [`AAMA_TEST`](README_UTENTE.md#cmd-aama-test) | AAMA e Export → AAMA Standard → AAMA Test | - | Test elaborazione AAMA |
|  | [`AAMA_DEBUG`](README_UTENTE.md#cmd-aama-debug) | AAMA e Export → AAMA Standard → AAMA Debug | - | Debug elaborazione AAMA |
|  | [`AAMA_ERRORS`](README_UTENTE.md#cmd-aama-errors) | AAMA e Export → AAMA Standard → AAMA Errori | - | Mostra errori elaborazione AAMA |
|  | [`AAMA_CLEAR_ERRORS`](README_UTENTE.md#cmd-aama-clear-errors) | AAMA e Export → AAMA Standard → AAMA Cancella Errori | - | Cancella gli errori AAMA segnalati |
| <img src="menu/LEONARDO/aama_cfg.bmp" width="24" height="24" alt="aama_cfg.bmp"> | [`AAMA-CFG`](README_UTENTE.md#cmd-aama-cfg) | AAMA e Export → AAMA Standard → Impostazioni AAMA... | AAMA | Impostazioni AAMA: DXF, posizionamento, rifilo, tacche, layer e colori, Modaris |

### AAMA Rifilo

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/aamar_init.BMP" width="24" height="24" alt="aamar_init.BMP"> | [`AAMAR_INIT`](README_UTENTE.md#cmd-aamar-init) | AAMA e Export → AAMA Rifilo → AAMA-R Inizializza | AAMA Rifilo | Rimette i valori RIFILO di partenza e apre la scheda Rifilo delle impostazioni |
| <img src="menu/LEONARDO/aamar_run.bmp" width="24" height="24" alt="aamar_run.bmp"> | [`AAMAR`](README_UTENTE.md#cmd-aamar) | AAMA e Export → AAMA Rifilo → AAMA-R Principale | AAMA, AAMA Rifilo | Esegue elaborazione AAMA Rifilo (aamar principale) |
| <img src="menu/LEONARDO/aamar_material.bmp" width="24" height="24" alt="aamar_material.bmp"> | [`AAMAR_MATERIAL`](README_UTENTE.md#cmd-aamar-material) | AAMA e Export → AAMA Rifilo → AAMA-R Materiale | AAMA Rifilo | Materiale RIFILO: apre la scheda Rifilo delle impostazioni AAMA |
| <img src="menu/LEONARDO/aamar_tipologia.bmp" width="24" height="24" alt="aamar_tipologia.bmp"> | [`AAMAR_TIPOLOGIA`](README_UTENTE.md#cmd-aamar-tipologia) | AAMA e Export → AAMA Rifilo → AAMA-R Tipologia | AAMA Rifilo | Tipologia RIFILO: apre la scheda Rifilo delle impostazioni AAMA |
| <img src="menu/LEONARDO/aamar_quantita.bmp" width="24" height="24" alt="aamar_quantita.bmp"> | [`AAMAR_QUANTITA`](README_UTENTE.md#cmd-aamar-quantita) | AAMA e Export → AAMA Rifilo → AAMA-R Quantità | AAMA Rifilo | Quantità RIFILO: apre la scheda Rifilo delle impostazioni AAMA |
| <img src="menu/LEONARDO/aamar_spacing.bmp" width="24" height="24" alt="aamar_spacing.bmp"> | [`AAMAR_SPACING`](README_UTENTE.md#cmd-aamar-spacing) | AAMA e Export → AAMA Rifilo → AAMA-R Spaziatura | AAMA Rifilo | Spazio fra i blocchi RIFILO: apre la scheda Rifilo delle impostazioni AAMA |
| <img src="menu/LEONARDO/aamar_settings.bmp" width="24" height="24" alt="aamar_settings.bmp"> | [`AAMAR_SETTINGS`](README_UTENTE.md#cmd-aamar-settings) | AAMA e Export → AAMA Rifilo → AAMA-R Impostazioni | AAMA Rifilo | Impostazioni RIFILO: apre la scheda Rifilo delle impostazioni AAMA |
|  | [`AAMAR_TEST`](README_UTENTE.md#cmd-aamar-test) | AAMA e Export → AAMA Rifilo → AAMA-R Test | - | Test elaborazione AAMA Rifilo |
|  | [`AAMAR_DEBUG`](README_UTENTE.md#cmd-aamar-debug) | AAMA e Export → AAMA Rifilo → AAMA-R Debug | - | Debug elaborazione AAMA Rifilo |
|  | [`AAMAR_ERRORS`](README_UTENTE.md#cmd-aamar-errors) | AAMA e Export → AAMA Rifilo → AAMA-R Errori | - | Mostra errori elaborazione AAMA Rifilo |
|  | [`AAMAR_CLEAR_ERRORS`](README_UTENTE.md#cmd-aamar-clear-errors) | AAMA e Export → AAMA Rifilo → AAMA-R Cancella Errori | - | Cancella gli errori AAMA Rifilo segnalati |

### Geber

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/geber.bmp" width="24" height="24" alt="geber.bmp"> | [`GEBER`](README_UTENTE.md#cmd-geber) | AAMA e Export → Geber → Geber Converti | AAMA | Converti batch blocchi tacca in punti (formato Geber) |
| <img src="menu/LEONARDO/set_geber_tolerance.bmp" width="24" height="24" alt="set_geber_tolerance.bmp"> | [`SET_GEBER_TOLERANCE`](README_UTENTE.md#cmd-set-geber-tolerance) | AAMA e Export → Geber → Geber Tolleranza | AAMA | Imposta tolleranze per la conversione tacche Geber |

### Foratura e Marcatura

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/drill1.bmp" width="24" height="24" alt="drill1.bmp"> | [`DRILL1`](README_UTENTE.md#cmd-drill1) | AAMA e Export → Foratura e Marcatura → Drill 1 | AAMA | Drill 1 (layer 201): punti scelti o cliccati; sui cerchi il punto al centro |
| <img src="menu/LEONARDO/drill2.bmp" width="24" height="24" alt="drill2.bmp"> | [`DRILL2`](README_UTENTE.md#cmd-drill2) | AAMA e Export → Foratura e Marcatura → Drill 2 | AAMA | Drill 2 (layer 202): punti scelti o cliccati; sui cerchi il punto al centro |
| <img src="menu/LEONARDO/drillp.bmp" width="24" height="24" alt="drillp.bmp"> | [`DRILLP`](README_UTENTE.md#cmd-drillp) | AAMA e Export → Foratura e Marcatura → Drill P | AAMA | Pricker (layer 100): punti scelti o cliccati; sui cerchi il punto al centro |
| <img src="menu/LEONARDO/MARCATURA.bmp" width="24" height="24" alt="MARCATURA.bmp"> | [`MARCATURA`](README_UTENTE.md#cmd-marcatura) | AAMA e Export → Foratura e Marcatura → Marcatura | AAMA | Sposta oggetto su layer 91 MARCATURA (Ciano) |
| <img src="menu/LEONARDO/PROIEZIONE.bmp" width="24" height="24" alt="PROIEZIONE.bmp"> | [`PROIEZIONE`](README_UTENTE.md#cmd-proiezione) | AAMA e Export → Foratura e Marcatura → Proiezione | AAMA | Sposta oggetto su layer 90 PROIEZIONE (Fucsia) |
| <img src="menu/LEONARDO/aama_oggetti.bmp" width="24" height="24" alt="aama_oggetti.bmp"> | [`AAMA-OGGETTI`](README_UTENTE.md#cmd-aama-oggetti) | AAMA e Export → Foratura e Marcatura → Definisci Oggetti AAMA... | AAMA | Definisce gli oggetti AAMA: drill, pricker, tacche, marcature, proiezioni |
|  | [`AAMA-VIS`](README_UTENTE.md#cmd-aama-vis) | AAMA e Export → Foratura e Marcatura → Visualizza Oggetti AAMA | - | Visualizza gli oggetti AAMA |
|  | [`AAMA-NAS`](README_UTENTE.md#cmd-aama-nas) | AAMA e Export → Foratura e Marcatura → Nascondi Oggetti AAMA | - | Nasconde gli oggetti AAMA |
| <img src="menu/LEONARDO/aama_solo.bmp" width="24" height="24" alt="aama_solo.bmp"> | [`AAMA-SOLO`](README_UTENTE.md#cmd-aama-solo) | AAMA e Export → Foratura e Marcatura → Visualizza Solo Oggetti AAMA | AAMA | Visualizza soltanto gli oggetti AAMA e le sagome |
| <img src="menu/LEONARDO/aama_mod.bmp" width="24" height="24" alt="aama_mod.bmp"> | [`AAMA-MOD`](README_UTENTE.md#cmd-aama-mod) | AAMA e Export → Foratura e Marcatura → Visualizza Modello | AAMA | Visualizza tutto il modello |
|  | [`AAMA-DAV`](README_UTENTE.md#cmd-aama-dav) | AAMA e Export → Foratura e Marcatura → Porta Davanti Oggetti AAMA | - | Porta in primo piano gli oggetti AAMA |
|  | [`AAMA-TOGLI`](README_UTENTE.md#cmd-aama-togli) | AAMA e Export → Foratura e Marcatura → Togli Evidenziazione | - | Toglie l'evidenziazione dei pezzi estratti |

### Modaris

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/Modaris-AAMA.bmp" width="24" height="24" alt="Modaris-AAMA.bmp"> | [`MODARIS-AAMA`](README_UTENTE.md#cmd-modaris-aama) | AAMA e Export → Modaris → Modaris AAMA | Modaris | Converte blocchi Modaris v3.0 per elaborazione AAMA |
| <img src="menu/LEONARDO/MA-config.bmp" width="24" height="24" alt="MA-config.bmp"> | [`MA-CONFIG`](README_UTENTE.md#cmd-ma-config) | AAMA e Export → Modaris → Modaris Config | Modaris | Configurazione parametri conversione Modaris-AAMA |
|  | [`MA-TEST`](README_UTENTE.md#cmd-ma-test) | AAMA e Export → Modaris → Modaris Test | - | Test conversione Modaris |
|  | [`MA-DEBUG`](README_UTENTE.md#cmd-ma-debug) | AAMA e Export → Modaris → Modaris Debug | - | Debug conversione Modaris |
| <img src="menu/LEONARDO/modaris_batch.bmp" width="24" height="24" alt="modaris_batch.bmp"> | [`MODARIS-AAMA-BATCH`](README_UTENTE.md#cmd-modaris-aama-batch) | AAMA e Export → Modaris → Modaris su Cartella | Modaris | Modaris-AAMA su tutti i DWG di una cartella (file nome_AAMA.dwg) |

### ATOM Layout

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/atom_layout.bmp" width="24" height="24" alt="atom_layout.bmp"> | [`ATOM-LAYOUT`](README_UTENTE.md#cmd-atom-layout) | AAMA e Export → ATOM Layout → Nuovo Layout... | ATOM | Nuovo layout ATOM: foglio o rotolo con i pezzi AAMA disposti in automatico |
| <img src="menu/LEONARDO/atom_pezzi.bmp" width="24" height="24" alt="atom_pezzi.bmp"> | [`ATOM-PEZZI`](README_UTENTE.md#cmd-atom-pezzi) | AAMA e Export → ATOM Layout → Aggiungi Pezzi | ATOM | Aggiunge pezzi AAMA a un layout ATOM |
| <img src="menu/LEONARDO/atom_disponi.bmp" width="24" height="24" alt="atom_disponi.bmp"> | [`ATOM-DISPONI`](README_UTENTE.md#cmd-atom-disponi) | AAMA e Export → ATOM Layout → Disponi Pezzi | ATOM | Ridispone tutti i pezzi del layout ATOM |
| <img src="menu/LEONARDO/atom_controlla.bmp" width="24" height="24" alt="atom_controlla.bmp"> | [`ATOM-CONTROLLA`](README_UTENTE.md#cmd-atom-controlla) | AAMA e Export → ATOM Layout → Controlla Layout | ATOM | Elenca pezzi fuori foglio, sovrapposti o più vicini del gap |
| <img src="menu/LEONARDO/atom_dati.bmp" width="24" height="24" alt="atom_dati.bmp"> | [`ATOM-DATI`](README_UTENTE.md#cmd-atom-dati) | AAMA e Export → ATOM Layout → Dati del Layout... | ATOM | Cambia i dati del layout ATOM (codice, materiale, misure, gap, cartella) |
| <img src="menu/LEONARDO/atom_salva.bmp" width="24" height="24" alt="atom_salva.bmp"> | [`ATOM-SALVA`](README_UTENTE.md#cmd-atom-salva) | AAMA e Export → ATOM Layout → Salva per ATOM (.lay .die .shc) | ATOM | Scrive il layout per la ATOM: .lay, .shc e un .die per sagoma |
| <img src="menu/LEONARDO/atom_apri.bmp" width="24" height="24" alt="atom_apri.bmp"> | [`ATOM-APRI`](README_UTENTE.md#cmd-atom-apri) | AAMA e Export → ATOM Layout → Apri File ATOM... | ATOM | Apre un file ATOM (.lay, .shc o .die) nel disegno |
| <img src="menu/LEONARDO/atom_die.bmp" width="24" height="24" alt="atom_die.bmp"> | [`ATOM-DIE`](README_UTENTE.md#cmd-atom-die) | AAMA e Export → ATOM Layout → Solo Sagome .die e .shc | ATOM | Scrive solo le sagome .die e lo .shc dai blocchi AAMA, senza layout |
| <img src="menu/LEONARDO/atom_cfg.bmp" width="24" height="24" alt="atom_cfg.bmp"> | [`ATOM-CFG`](README_UTENTE.md#cmd-atom-cfg) | AAMA e Export → ATOM Layout → Impostazioni ATOM... | ATOM | Impostazioni ATOM: layer, utensili, tacche, tolleranza, rotazioni |

## Menu Consumi e Report

### Calcolo Consumi

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/consumi_metro.bmp" width="24" height="24" alt="consumi_metro.bmp"> | [`CONSUMI_METRO`](README_UTENTE.md#cmd-consumi-metro) | Consumi e Report → Calcolo Consumi → Consumi Metro | CONSUMI NOG | Quanti pezzi stanno in un foglio (anche scegliendo il pezzo nel disegno) |
| <img src="menu/LEONARDO/consumi_rotolo.bmp" width="24" height="24" alt="consumi_rotolo.bmp"> | [`CONSUMI_ROTOLO`](README_UTENTE.md#cmd-consumi-rotolo) | Consumi e Report → Calcolo Consumi → Consumi Rotolo | CONSUMI NOG | Metri di rotolo per un numero di pezzi (anche scegliendo il pezzo nel disegno) |

### Computo Materiali

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/NOG.bmp" width="24" height="24" alt="NOG.bmp"> | [`NOG`](README_UTENTE.md#cmd-nog) | Consumi e Report → Computo Materiali → Computo NOG... | CONSUMI NOG | Calcolo consumi: finestra con approssimazione, sfrido, unita' e formato, poi il documento riepilogativo |
| <img src="menu/LEONARDO/computo_file.bmp" width="24" height="24" alt="computo_file.bmp"> | [`COMPUTO_FILE`](README_UTENTE.md#cmd-computo-file) | Consumi e Report → Computo Materiali → Computo su File (senza finestra) | CONSUMI NOG | Consumi senza finestra con le scelte dell'ultimo NOG: CSV e documento accanto al disegno |
|  | [`NOG-TOGLI`](README_UTENTE.md#cmd-nog-togli) | Consumi e Report → Computo Materiali → Togli Evidenziazione Consumi | - | Toglie l'evidenziazione dei pezzi (verdi calcolati, rossi scartati) |
| <img src="menu/LEONARDO/nog_addmat.bmp" width="24" height="24" alt="nog_addmat.bmp"> | [`NOG-ADDMAT`](README_UTENTE.md#cmd-nog-addmat) | Consumi e Report → Computo Materiali → NOG Aggiungi Materiale | NOG Configurazione | Materiali specifici: aggiunge, aggiorna o toglie i parametri di un materiale |
| <img src="menu/LEONARDO/nog_config.bmp" width="24" height="24" alt="nog_config.bmp"> | [`NOG-CONFIG`](README_UTENTE.md#cmd-nog-config) | Consumi e Report → Computo Materiali → NOG Configurazione | NOG Configurazione | Configurazione dei consumi: categorie, misura, materiali specifici, pelle campione |

### Schede e Report

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/scheda.bmp" width="24" height="24" alt="scheda.bmp"> | [`SCHEDA`](README_UTENTE.md#cmd-scheda) | Consumi e Report → Schede e Report → Menu Schede e Computi... | Schede e Report | Menu di schede, consumi e computi: sceglie e lancia il comando |
| <img src="menu/LEONARDO/riepilogo_materiali.bmp" width="24" height="24" alt="riepilogo_materiali.bmp"> | [`RIEPILOGO_MATERIALI`](README_UTENTE.md#cmd-riepilogo-materiali) | Consumi e Report → Schede e Report → Riepilogo Materiali | Schede e Report | Riepilogo materiali: quantità per materiale e spessore, CSV e HTML |
| <img src="menu/LEONARDO/scheda_img.bmp" width="24" height="24" alt="scheda_img.bmp"> | [`SCHEDAPRO`](README_UTENTE.md#cmd-schedapro) | Consumi e Report → Schede e Report → Scheda Pezzi PRO (immagini, HTML) | Schede e Report | Scheda materiali dei pezzi con immagini: HTML interattivo e CSV |
| <img src="menu/LEONARDO/scheda_acc.bmp" width="24" height="24" alt="scheda_acc.bmp"> | [`SCHEDA-ACC`](README_UTENTE.md#cmd-scheda-acc) | Consumi e Report → Schede e Report → Scheda Accessori | Schede e Report | Genera scheda accessori metallici per articolo |
| <img src="menu/LEONARDO/scheda_lav.bmp" width="24" height="24" alt="scheda_lav.bmp"> | [`SCHEDA-LAV`](README_UTENTE.md#cmd-scheda-lav) | Consumi e Report → Schede e Report → Scheda Lavorazioni | Schede e Report | Genera la scheda delle lavorazioni con i costi |
| <img src="menu/LEONARDO/scheda_pz_acc.bmp" width="24" height="24" alt="scheda_pz_acc.bmp"> | [`SCHEDA-PEZZI-ACC`](README_UTENTE.md#cmd-scheda-pezzi-acc) | Consumi e Report → Schede e Report → Scheda Pezzi Accessori | Schede e Report | Genera scheda pezzi con dettaglio accessori |
| <img src="menu/LEONARDO/scheda_pz_lav.bmp" width="24" height="24" alt="scheda_pz_lav.bmp"> | [`SCHEDA-PEZZI-LAV`](README_UTENTE.md#cmd-scheda-pezzi-lav) | Consumi e Report → Schede e Report → Scheda Pezzi Lavorazioni | Schede e Report | Genera scheda pezzi con dettaglio lavorazioni |
| <img src="menu/LEONARDO/scheda_html.bmp" width="24" height="24" alt="scheda_html.bmp"> | [`SCHEDAPRO_HTML`](README_UTENTE.md#cmd-schedapro-html) | Consumi e Report → Schede e Report → Rigenera HTML | Schede e Report | Rigenera la scheda HTML da un'estrazione precedente (.dat) |
| <img src="menu/LEONARDO/scheda_html_int.bmp" width="24" height="24" alt="scheda_html_int.bmp"> | [`SCHEDAPRO_CFG`](README_UTENTE.md#cmd-schedapro-cfg) | Consumi e Report → Schede e Report → Configura Scheda | Schede e Report | Configurazione della scheda pezzi PRO |

### Computi

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/computo_costi.bmp" width="24" height="24" alt="computo_costi.bmp"> | [`COMPUTO_COSTI`](README_UTENTE.md#cmd-computo-costi) | Consumi e Report → Computi → Computo Costi del modello | Schede e Report | Costo del modello: consumi x prezzi, accessori, lavorazioni, cuciture, ricarico |
| <img src="menu/LEONARDO/computo_pezzi.bmp" width="24" height="24" alt="computo_pezzi.bmp"> | [`COMPUTO_PEZZI`](README_UTENTE.md#cmd-computo-pezzi) | Consumi e Report → Computi → Computo Pezzi | Schede e Report | Pezzi, materiali, quantità, aree e perimetri |
| <img src="menu/LEONARDO/computo_taglio.bmp" width="24" height="24" alt="computo_taglio.bmp"> | [`COMPUTO_TAGLIO`](README_UTENTE.md#cmd-computo-taglio) | Consumi e Report → Computi → Computo Taglio | Schede e Report | Metri e tempo di taglio per materiale |

### (voci principali)

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/MISURA_CUCITURA.bmp" width="24" height="24" alt="MISURA_CUCITURA.bmp"> | [`MISURA-CUCITURA`](README_UTENTE.md#cmd-misura-cucitura) | Consumi e Report → Misura Cucitura | Utilità Sistema Ext | Misura cucitura: lunghezza delle cuciture dentro ogni pezzo |

## Menu Utilità

### Sistema

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/inizializza.bmp" width="24" height="24" alt="inizializza.bmp"> | [`INIZIALIZZA2`](README_UTENTE.md#cmd-inizializza2) | Utilità → Sistema → Inizializza Librerie | UTILITA SISTEMA | Carica librerie .dll esterne (prerequisito avvio) |
| <img src="menu/LEONARDO/font_test.bmp" width="24" height="24" alt="font_test.bmp"> | [`FONT_TEST`](README_UTENTE.md#cmd-font-test) | Utilità → Sistema → Test Font SHX | Utilità Sistema Ext | Crea righe di test per font .shx da directory |
| <img src="menu/LEONARDO/HexDecConverter.bmp" width="24" height="24" alt="HexDecConverter.bmp"> | [`HEXDECCONVERTER`](README_UTENTE.md#cmd-hexdecconverter) | Utilità → Sistema → HexDec Converter | Utilità Sistema Ext | Converte testo tra esadecimale e decimale |

### Utilità Blocchi

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/blocco_rapido.bmp" width="24" height="24" alt="blocco_rapido.bmp"> | [`BLOCCO_RAPIDO`](README_UTENTE.md#cmd-blocco-rapido) | Utilità → Utilità Blocchi → Blocco Rapido | BLOCCHI AVANZATI | Crea blocco con nome casuale e lo inserisce |
| <img src="menu/LEONARDO/blocchi_in_punti.bmp" width="24" height="24" alt="blocchi_in_punti.bmp"> | [`BLOCCHI_IN_PUNTI`](README_UTENTE.md#cmd-blocchi-in-punti) | Utilità → Utilità Blocchi → Blocchi in Punti | BLOCCHI AVANZATI | Converte le tacche PitRTak in punti, nel punto di inserimento |
| <img src="menu/LEONARDO/inserisci_blocchi.bmp" width="24" height="24" alt="inserisci_blocchi.bmp"> | [`INSERISCI_BLOCCHI`](README_UTENTE.md#cmd-inserisci-blocchi) | Utilità → Utilità Blocchi → Inserisci Blocchi su Polilinea | BLOCCHI AVANZATI, Tacche | Inserisce blocchi lungo polilinea a distanza fissa |
| <img src="menu/LEONARDO/cbp.bmp" width="24" height="24" alt="cbp.bmp"> | [`CBP`](README_UTENTE.md#cmd-cbp) | Utilità → Utilità Blocchi → Cambia Punto Base | UTILITA SISTEMA | Cambia punto base blocco senza rilocare inserimenti |
| <img src="menu/LEONARDO/cbpr.bmp" width="24" height="24" alt="cbpr.bmp"> | [`CBPR`](README_UTENTE.md#cmd-cbpr) | Utilità → Utilità Blocchi → Cambia Punto Base con Riferimento | UTILITA SISTEMA | Cambia punto base blocco e riloca tutti gli inserimenti |

### Utilità Geometria

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
| <img src="menu/LEONARDO/splitcir.bmp" width="24" height="24" alt="splitcir.bmp"> | [`SPLITCIR`](README_UTENTE.md#cmd-splitcir) | Utilità → Utilità Geometria → Spezza Cerchio | Utilità Sistema Ext | Divide un cerchio in archi uguali, partendo da un punto |
| <img src="menu/LEONARDO/TROVA_GAP.bmp" width="24" height="24" alt="TROVA_GAP.bmp"> | [`TROVA_GAP`](README_UTENTE.md#cmd-trova-gap) | Utilità → Utilità Geometria → Trova Gap | Utilità Sistema Ext | Cerca gap tra entità e li segnala |
| <img src="menu/LEONARDO/MISURA_CUCITURA.bmp" width="24" height="24" alt="MISURA_CUCITURA.bmp"> | [`MISURA-CUCITURA`](README_UTENTE.md#cmd-misura-cucitura) | Utilità → Utilità Geometria → Misura Cucitura | Utilità Sistema Ext | Misura cucitura: calcola lunghezze per modello |

## Menu LEONARDO

### (voci principali)

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
|  | `BROWSER` | LEONARDO → Visita Sito Web (`_Browser http://www.guasqui.it`) | - | Apre il sito web www.guasqui.it |
|  | `BROWSER` | LEONARDO → Guida in Linea (`_Browser https://github.com/leongua/leonardo`) | - | Apre la guida in linea su GitHub |
| <img src="menu/LEONARDO/inizializza.bmp" width="24" height="24" alt="inizializza.bmp"> | [`INIZIALIZZA2`](README_UTENTE.md#cmd-inizializza2) | LEONARDO → Inizializza App Sistema | UTILITA SISTEMA | Inizializza le librerie di sistema |

### Gestione Licenza

| | Comando | Voce di menu | Barra | Cosa fa |
|:-:|---|---|---|---|
|  | [`ACTIVATE-LICENSE`](README_UTENTE.md#cmd-activate-license) | LEONARDO → Gestione Licenza → Attiva Licenza | - | Attiva la licenza del software |
|  | [`SHOW-SYSTEM-ID`](README_UTENTE.md#cmd-show-system-id) | LEONARDO → Gestione Licenza → Mostra System ID | - | Mostra il System ID per la registrazione |

## Barre degli strumenti

Ogni pulsante ha due icone: la piccola (16×16, `nome_16.bmp`) e la grande. ZWCAD usa l'una o l'altra secondo l'impostazione "pulsanti grandi"; le icone `ZWRC_...` sono quelle interne di ZWCAD.

### Principale

| Piccola | Grande | Pulsante | Comando |
|:-:|:-:|---|---|
| `ZWRC_NEW` | `ZWRC_NEW` | Nuovo | `NEW` |
| `ZWRC_OPEN` | `ZWRC_OPEN` | Apri | `OPEN` |
| `ZWRC_SAVE` | `ZWRC_SAVE` | Salva | `QSAVE` |
| `ZWRC_PLOT` | `ZWRC_PLOT` | Stampa | `PLOT` |
| `ZWRC_UNDO` | `ZWRC_UNDO` | Annulla | `UNDO` |
| `ZWRC_REDO` | `ZWRC_REDO` | Ripristina | `REDO` |

### Disegno

| Piccola | Grande | Pulsante | Comando |
|:-:|:-:|---|---|
| `ZWRC_LINE` | `ZWRC_LINE` | Linea | `LINE` |
| `ZWRC_PLINE` | `ZWRC_PLINE` | Polilinea | `PLINE` |
| `ZWRC_CIRCLE` | `ZWRC_CIRCLE` | Cerchio | `CIRCLE` |
| `ZWRC_ARC` | `ZWRC_ARC` | Arco | `ARC` |
| `ZWRC_RECTAN` | `ZWRC_RECTAN` | Rettangolo | `RECTANG` |
| `ZWRC_POLYGO` | `ZWRC_POLYGO` | Poligono | `POLYGON` |
| `ZWRC_ELLIPS` | `ZWRC_ELLIPS` | Ellisse | `ELLIPSE` |
| `ZWRC_SPLINE` | `ZWRC_SPLINE` | Spline | `SPLINE` |
| `ZWRC_BHATCH` | `ZWRC_BHATCH` | Tratteggio | `BHATCH` |
| `ZWRC_TEXT` | `ZWRC_TEXT` | Testo Riga | `TEXT` |
| `ZWRC_MTEXT` | `ZWRC_MTEXT` | Testo Multilinea | `MTEXT` |

### Modifica

| Piccola | Grande | Pulsante | Comando |
|:-:|:-:|---|---|
| `ZWRC_ERASE` | `ZWRC_ERASE` | Cancella | `ERASE` |
| `ZWRC_COPY` | `ZWRC_COPY` | Copia | `COPY` |
| `ZWRC_MIRROR` | `ZWRC_MIRROR` | Specchio | `MIRROR` |
| `ZWRC_OFFSET` | `ZWRC_OFFSET` | Offset | `OFFSET` |
| `ZWRC_MOVE` | `ZWRC_MOVE` | Sposta | `MOVE` |
| `ZWRC_ROTATE` | `ZWRC_ROTATE` | Ruota | `ROTATE` |
| `ZWRC_SCALE` | `ZWRC_SCALE` | Scala | `SCALE` |
| `ZWRC_STRETC` | `ZWRC_STRETC` | Stira | `STRETCH` |
| `ZWRC_TRIM` | `ZWRC_TRIM` | Taglia | `TRIM` |
| `ZWRC_EXTEND` | `ZWRC_EXTEND` | Estendi | `EXTEND` |
| `ZWRC_BREAK` | `ZWRC_BREAK` | Spezza | `BREAK` |
| `ZWRC_FILLET` | `ZWRC_FILLET` | Raccorda | `FILLET` |
| `ZWRC_CHAMFER` | `ZWRC_CHAMFER` | Smusso | `CHAMFER` |
| `ZWRC_EXPLOD` | `ZWRC_EXPLOD` | Esplodi | `EXPLODE` |
| `ZWRC_ALIGN` | `ZWRC_ALIGN` | Allinea | `ALIGN` |

### Layer

| Piccola | Grande | Pulsante | Comando |
|:-:|:-:|---|---|
| <img src="menu/LEONARDO/giallo_16.bmp" width="16" height="16" alt="giallo_16.bmp"> | <img src="menu/LEONARDO/giallo.bmp" width="32" height="32" alt="giallo.bmp"> | Giallo (2) | [`GGG`](README_UTENTE.md#cmd-ggg) |
| <img src="menu/LEONARDO/verde_16.bmp" width="16" height="16" alt="verde_16.bmp"> | <img src="menu/LEONARDO/verde.bmp" width="32" height="32" alt="verde.bmp"> | Verde (3) | [`VVV`](README_UTENTE.md#cmd-vvv) |
| <img src="menu/LEONARDO/arancio_16.bmp" width="16" height="16" alt="arancio_16.bmp"> | <img src="menu/LEONARDO/arancio.bmp" width="32" height="32" alt="arancio.bmp"> | Arancione (30) | [`AAA`](README_UTENTE.md#cmd-aaa) |
| <img src="menu/LEONARDO/fuxia_16.bmp" width="16" height="16" alt="fuxia_16.bmp"> | <img src="menu/LEONARDO/fuxia.bmp" width="32" height="32" alt="fuxia.bmp"> | Magenta (6) | [`FFF`](README_UTENTE.md#cmd-fff) |
| <img src="menu/LEONARDO/bianco_16.bmp" width="16" height="16" alt="bianco_16.bmp"> | <img src="menu/LEONARDO/bianco.bmp" width="32" height="32" alt="bianco.bmp"> | Bianco (254) | [`BBB`](README_UTENTE.md#cmd-bbb) |
| <img src="menu/LEONARDO/CAMBIACOL_16.bmp" width="16" height="16" alt="CAMBIACOL_16.bmp"> | <img src="menu/LEONARDO/CAMBIACOL.bmp" width="32" height="32" alt="CAMBIACOL.bmp"> | Cambia Colore (tutti i colori) | [`CAMBIACOL`](README_UTENTE.md#cmd-cambiacol) |
| <img src="menu/LEONARDO/PENNA_16.bmp" width="16" height="16" alt="PENNA_16.bmp"> | <img src="menu/LEONARDO/PENNA.bmp" width="32" height="32" alt="PENNA.bmp"> | Penna | [`PENNA`](README_UTENTE.md#cmd-penna) |
| <img src="menu/LEONARDO/ENDCUT_16.bmp" width="16" height="16" alt="ENDCUT_16.bmp"> | <img src="menu/LEONARDO/ENDCUT.bmp" width="32" height="32" alt="ENDCUT.bmp"> | Rifilo (ENDCUT) | [`ENDCUT`](README_UTENTE.md#cmd-endcut) |
| <img src="menu/LEONARDO/OUTCUT_16.bmp" width="16" height="16" alt="OUTCUT_16.bmp"> | <img src="menu/LEONARDO/OUTCUT.bmp" width="32" height="32" alt="OUTCUT.bmp"> | Taglio (OUTCUT) | [`OUTCUT`](README_UTENTE.md#cmd-outcut) |
| <img src="menu/LEONARDO/INTCUT_16.bmp" width="16" height="16" alt="INTCUT_16.bmp"> | <img src="menu/LEONARDO/INTCUT.bmp" width="32" height="32" alt="INTCUT.bmp"> | Taglio Interno (INTCUT) | [`INTCUT`](README_UTENTE.md#cmd-intcut) |
| <img src="menu/LEONARDO/cucitura_16.bmp" width="16" height="16" alt="cucitura_16.bmp"> | <img src="menu/LEONARDO/cucitura.bmp" width="32" height="32" alt="cucitura.bmp"> | Cucitura | [`CUCITURA`](README_UTENTE.md#cmd-cucitura) |
| <img src="menu/LEONARDO/Continua_16.bmp" width="16" height="16" alt="Continua_16.bmp"> | <img src="menu/LEONARDO/Continua.bmp" width="32" height="32" alt="Continua.bmp"> | Continua | [`CONTINUA`](README_UTENTE.md#cmd-continua) |

### Raccordo

| Piccola | Grande | Pulsante | Comando |
|:-:|:-:|---|---|
| <img src="menu/LEONARDO/RAGGIO_0_16.BMP" width="16" height="16" alt="RAGGIO_0_16.BMP"> | <img src="menu/LEONARDO/RAGGIO_0.BMP" width="32" height="32" alt="RAGGIO_0.BMP"> | Raccordo Raggio Zero | [`RACCORDA_0`](README_UTENTE.md#cmd-raccorda-0) |
| <img src="menu/LEONARDO/Cima_16.bmp" width="16" height="16" alt="Cima_16.bmp"> | <img src="menu/LEONARDO/Cima.bmp" width="32" height="32" alt="Cima.bmp"> | Cima | `CHAMFER` |
| <img src="menu/LEONARDO/Racc.bmp" width="16" height="16" alt="Racc.bmp"> | <img src="menu/LEONARDO/Racc.bmp" width="32" height="32" alt="Racc.bmp"> | Raccordo | `FILLET` |
| <img src="menu/LEONARDO/blend_16.bmp" width="16" height="16" alt="blend_16.bmp"> | <img src="menu/LEONARDO/blend.bmp" width="32" height="32" alt="blend.bmp"> | Blend Curve | [`BLEND`](README_UTENTE.md#cmd-blend) |

### Arco

| Piccola | Grande | Pulsante | Comando |
|:-:|:-:|---|---|
| `ZWRC_ARCSER` | `ZWRC_ARCSER` | Inizio, Fine, Raggio | `ARC` |
| `ZWRC_ARCCON` | `ZWRC_ARCCON` | Continua | `ARC` |

### Polilinea

| Piccola | Grande | Pulsante | Comando |
|:-:|:-:|---|---|
| <img src="menu/LEONARDO/PEDI_16.bmp" width="16" height="16" alt="PEDI_16.bmp"> | <img src="menu/LEONARDO/PEDI.bmp" width="32" height="32" alt="PEDI.bmp"> | Edita Polilinea | `PEDIT` |
| <img src="menu/LEONARDO/PJ_16.bmp" width="16" height="16" alt="PJ_16.bmp"> | <img src="menu/LEONARDO/PJ.bmp" width="32" height="32" alt="PJ.bmp"> | Creazione Manuale (PJ) | [`PJ`](README_UTENTE.md#cmd-pj) |
| <img src="menu/LEONARDO/leo-poliauto_16.bmp" width="16" height="16" alt="leo-poliauto_16.bmp"> | <img src="menu/LEONARDO/leo-poliauto.bmp" width="32" height="32" alt="leo-poliauto.bmp"> | Catena e Unisci | [`CATENA_UNISCI`](README_UTENTE.md#cmd-catena-unisci) |
| <img src="menu/LEONARDO/leo-poliauto-sel_16.bmp" width="16" height="16" alt="leo-poliauto-sel_16.bmp"> | <img src="menu/LEONARDO/leo-poliauto-sel.bmp" width="32" height="32" alt="leo-poliauto-sel.bmp"> | Catena (selezione) | [`CATENA`](README_UTENTE.md#cmd-catena) |
| <img src="menu/LEONARDO/chainconfig_16.bmp" width="16" height="16" alt="chainconfig_16.bmp"> | <img src="menu/LEONARDO/chainconfig.bmp" width="32" height="32" alt="chainconfig.bmp"> | Catena Config | [`CATENA_CONFIG`](README_UTENTE.md#cmd-catena-config) |
| <img src="menu/LEONARDO/catenapreset_16.bmp" width="16" height="16" alt="catenapreset_16.bmp"> | <img src="menu/LEONARDO/catenapreset.bmp" width="32" height="32" alt="catenapreset.bmp"> | Catena Preset | [`CATENA_PRESET`](README_UTENTE.md#cmd-catena-preset) |
| <img src="menu/LEONARDO/SP2P.BMP" width="16" height="16" alt="SP2P.BMP"> | <img src="menu/LEONARDO/SP2P.BMP" width="32" height="32" alt="SP2P.BMP"> | Da Spline | [`S2P`](README_UTENTE.md#cmd-s2p) |
| <img src="menu/LEONARDO/Spl2_16.bmp" width="16" height="16" alt="Spl2_16.bmp"> | <img src="menu/LEONARDO/Spl2.bmp" width="32" height="32" alt="Spl2.bmp"> | Da Ellisse | [`EL2PL`](README_UTENTE.md#cmd-el2pl) |
| <img src="menu/LEONARDO/PELL_16.bmp" width="16" height="16" alt="PELL_16.bmp"> | <img src="menu/LEONARDO/PELL.bmp" width="32" height="32" alt="PELL.bmp"> | Da Ellisse (Pell) | [`PELL`](README_UTENTE.md#cmd-pell) |
| <img src="menu/LEONARDO/CHIUDI_TAGLIO_16.BMP" width="16" height="16" alt="CHIUDI_TAGLIO_16.BMP"> | <img src="menu/LEONARDO/CHIUDI_TAGLIO.BMP" width="32" height="32" alt="CHIUDI_TAGLIO.BMP"> | Chiudi | [`PC`](README_UTENTE.md#cmd-pc) |
| <img src="menu/LEONARDO/JOINFUZZ_16.BMP" width="16" height="16" alt="JOINFUZZ_16.BMP"> | <img src="menu/LEONARDO/JOINFUZZ.BMP" width="32" height="32" alt="JOINFUZZ.BMP"> | Join Fuzz | [`PLJOINFUZZ`](README_UTENTE.md#cmd-pljoinfuzz) |
| <img src="menu/LEONARDO/heal_16.bmp" width="16" height="16" alt="heal_16.bmp"> | <img src="menu/LEONARDO/heal.bmp" width="32" height="32" alt="heal.bmp"> | Heal (Ripara) | [`HEAL`](README_UTENTE.md#cmd-heal) |
| <img src="menu/LEONARDO/contorni_16.bmp" width="16" height="16" alt="contorni_16.bmp"> | <img src="menu/LEONARDO/contorni.bmp" width="32" height="32" alt="contorni.bmp"> | Controllo Contorni | [`CONTROLLA_CONTORNI`](README_UTENTE.md#cmd-controlla-contorni) |
| <img src="menu/LEONARDO/INIZIO_DIREZIONE_16.bmp" width="16" height="16" alt="INIZIO_DIREZIONE_16.bmp"> | <img src="menu/LEONARDO/INIZIO_DIREZIONE.bmp" width="32" height="32" alt="INIZIO_DIREZIONE.bmp"> | Visualizza e Imposta Direzione | [`PLD`](README_UTENTE.md#cmd-pld) |
| <img src="menu/LEONARDO/INVERTI_DIREZIONE_16.bmp" width="16" height="16" alt="INVERTI_DIREZIONE_16.bmp"> | <img src="menu/LEONARDO/INVERTI_DIREZIONE.bmp" width="32" height="32" alt="INVERTI_DIREZIONE.bmp"> | Inverti Direzione | [`RVRSLINE`](README_UTENTE.md#cmd-rvrsline) |
| <img src="menu/LEONARDO/nuovoiniziop_16.bmp" width="16" height="16" alt="nuovoiniziop_16.bmp"> | <img src="menu/LEONARDO/nuovoiniziop.bmp" width="32" height="32" alt="nuovoiniziop.bmp"> | Nuovo Inizio | [`NUOVOINIZIOP`](README_UTENTE.md#cmd-nuovoiniziop) |
| <img src="menu/LEONARDO/versouniforme_16.bmp" width="16" height="16" alt="versouniforme_16.bmp"> | <img src="menu/LEONARDO/versouniforme.bmp" width="32" height="32" alt="versouniforme.bmp"> | Verso Uniforme | [`VERSO_UNIFORME`](README_UTENTE.md#cmd-verso-uniforme) |
| `ZWRC_SN2BCK` | `ZWRC_SN2BCK` | Porta Dietro | `AI_DRAWORDER` |
| <img src="menu/LEONARDO/vlmoverotate_16.bmp" width="16" height="16" alt="vlmoverotate_16.bmp"> | <img src="menu/LEONARDO/vlmoverotate.bmp" width="32" height="32" alt="vlmoverotate.bmp"> | VL Move Rotate | [`VLMR`](README_UTENTE.md#cmd-vlmr) |
| <img src="menu/LEONARDO/vlmr_tastierino_16.bmp" width="16" height="16" alt="vlmr_tastierino_16.bmp"> | <img src="menu/LEONARDO/vlmr_tastierino.bmp" width="32" height="32" alt="vlmr_tastierino.bmp"> | Muovi/Ruota da Tastierino | [`-VLMR`](README_UTENTE.md#cmd-vlmr) |

### Polilinea Estesa

| Piccola | Grande | Pulsante | Comando |
|:-:|:-:|---|---|
| <img src="menu/LEONARDO/Y_16.bmp" width="16" height="16" alt="Y_16.bmp"> | <img src="menu/LEONARDO/Y.bmp" width="32" height="32" alt="Y.bmp"> | Unione Rapida Y | [`Y`](README_UTENTE.md#cmd-y) |
| <img src="menu/LEONARDO/JOINFUZZ_16.BMP" width="16" height="16" alt="JOINFUZZ_16.BMP"> | <img src="menu/LEONARDO/JOINFUZZ.BMP" width="32" height="32" alt="JOINFUZZ.BMP"> | Join Fuzz | [`PLJOINFUZZ`](README_UTENTE.md#cmd-pljoinfuzz) |
| <img src="menu/LEONARDO/INIZIO_DIREZIONE_16.bmp" width="16" height="16" alt="INIZIO_DIREZIONE_16.bmp"> | <img src="menu/LEONARDO/INIZIO_DIREZIONE.bmp" width="32" height="32" alt="INIZIO_DIREZIONE.bmp"> | Mostra Direzione | [`PLDREV_SHOW_DIRECTION`](README_UTENTE.md#cmd-pldrev-show-direction) |
| <img src="menu/LEONARDO/PLDREV_SETCOLOR_16.bmp" width="16" height="16" alt="PLDREV_SETCOLOR_16.bmp"> | <img src="menu/LEONARDO/PLDREV_SETCOLOR.bmp" width="32" height="32" alt="PLDREV_SETCOLOR.bmp"> | Imposta Colore Frecce | [`PLDREV_SETCOLOR`](README_UTENTE.md#cmd-pldrev-setcolor) |
| <img src="menu/LEONARDO/PLDREV_SETPOS_16.bmp" width="16" height="16" alt="PLDREV_SETPOS_16.bmp"> | <img src="menu/LEONARDO/PLDREV_SETPOS.bmp" width="32" height="32" alt="PLDREV_SETPOS.bmp"> | Imposta Posizione Frecce | [`PLDREV_SETPOS`](README_UTENTE.md#cmd-pldrev-setpos) |

### Tacche

| Piccola | Grande | Pulsante | Comando |
|:-:|:-:|---|---|
| <img src="menu/LEONARDO/TakP_16.bmp" width="16" height="16" alt="TakP_16.bmp"> | <img src="menu/LEONARDO/TakP.bmp" width="32" height="32" alt="TakP.bmp"> | Inserisci Tacca | [`INSERISCI_TACCA`](README_UTENTE.md#cmd-inserisci-tacca) |
| <img src="menu/LEONARDO/tacca_16.bmp" width="16" height="16" alt="tacca_16.bmp"> | <img src="menu/LEONARDO/tacca.bmp" width="32" height="32" alt="tacca.bmp"> | Menu Tacche | [`TACCA`](README_UTENTE.md#cmd-tacca) |
| <img src="menu/LEONARDO/TACCA_dapoli_16.BMP" width="16" height="16" alt="TACCA_dapoli_16.BMP"> | <img src="menu/LEONARDO/TACCA_dapoli.BMP" width="32" height="32" alt="TACCA_dapoli.BMP"> | Tacca da Polilinea | [`TACCA_DAPOLI`](README_UTENTE.md#cmd-tacca-dapoli) |
| <img src="menu/LEONARDO/TACCA_DISTANZA_16.BMP" width="16" height="16" alt="TACCA_DISTANZA_16.BMP"> | <img src="menu/LEONARDO/TACCA_DISTANZA.BMP" width="32" height="32" alt="TACCA_DISTANZA.BMP"> | Tacca da Misura | [`TACCA_DA_MISURA`](README_UTENTE.md#cmd-tacca-da-misura) |
| <img src="menu/LEONARDO/COPIA_TACCHE_16.BMP" width="16" height="16" alt="COPIA_TACCHE_16.BMP"> | <img src="menu/LEONARDO/COPIA_TACCHE.BMP" width="32" height="32" alt="COPIA_TACCHE.BMP"> | Copia Tacche | [`COPIA_TACCHE`](README_UTENTE.md#cmd-copia-tacche) |
| <img src="menu/LEONARDO/RIBALTA_16.BMP" width="16" height="16" alt="RIBALTA_16.BMP"> | <img src="menu/LEONARDO/RIBALTA.BMP" width="32" height="32" alt="RIBALTA.BMP"> | Ribalta Tacche | [`RIBALTA_TACCHE`](README_UTENTE.md#cmd-ribalta-tacche) |
| <img src="menu/LEONARDO/riposiziona_16.BMP" width="16" height="16" alt="riposiziona_16.BMP"> | <img src="menu/LEONARDO/riposiziona.BMP" width="32" height="32" alt="riposiziona.BMP"> | Riposiziona Tacche | [`RIPOSIZIONA_TACCHE`](README_UTENTE.md#cmd-riposiziona-tacche) |
| <img src="menu/LEONARDO/SOS_TACCHE_16.bmp" width="16" height="16" alt="SOS_TACCHE_16.bmp"> | <img src="menu/LEONARDO/SOS_TACCHE.bmp" width="32" height="32" alt="SOS_TACCHE.bmp"> | Sostituisci Tacche | [`SOSTITUISCI_TACCHE`](README_UTENTE.md#cmd-sostituisci-tacche) |
| <img src="menu/LEONARDO/METTI_V_16.bmp" width="16" height="16" alt="METTI_V_16.bmp"> | <img src="menu/LEONARDO/METTI_V.bmp" width="32" height="32" alt="METTI_V.bmp"> | Metti V | [`METTI_V`](README_UTENTE.md#cmd-metti-v) |
| <img src="menu/LEONARDO/METTI_V_AUTO_16.bmp" width="16" height="16" alt="METTI_V_AUTO_16.bmp"> | <img src="menu/LEONARDO/METTI_V_AUTO.bmp" width="32" height="32" alt="METTI_V_AUTO.bmp"> | Sostituisci tacche con rientri a V | [`METTI_V_AUTO`](README_UTENTE.md#cmd-metti-v-auto) |
| <img src="menu/LEONARDO/inserisci_blocchi_16.bmp" width="16" height="16" alt="inserisci_blocchi_16.bmp"> | <img src="menu/LEONARDO/inserisci_blocchi.bmp" width="32" height="32" alt="inserisci_blocchi.bmp"> | Inserisci Blocchi a distanza | [`INSERISCI_BLOCCHI`](README_UTENTE.md#cmd-inserisci-blocchi) |
| <img src="menu/LEONARDO/vlwalk_16.bmp" width="16" height="16" alt="vlwalk_16.bmp"> | <img src="menu/LEONARDO/vlwalk.bmp" width="32" height="32" alt="vlwalk.bmp"> | Valida tacche interattivo | [`VLWALK`](README_UTENTE.md#cmd-vlwalk) |

### Conversione Tacche

| Piccola | Grande | Pulsante | Comando |
|:-:|:-:|---|---|
| <img src="menu/LEONARDO/tacche_in_tagliate_16.bmp" width="16" height="16" alt="tacche_in_tagliate_16.bmp"> | <img src="menu/LEONARDO/tacche_in_tagliate.bmp" width="32" height="32" alt="tacche_in_tagliate.bmp"> | Tacche in Tagliate | [`TACCHE_IN_TAGLIATE`](README_UTENTE.md#cmd-tacche-in-tagliate) |
| <img src="menu/LEONARDO/tagliate_in_tacche_16.bmp" width="16" height="16" alt="tagliate_in_tacche_16.bmp"> | <img src="menu/LEONARDO/tagliate_in_tacche.bmp" width="32" height="32" alt="tagliate_in_tacche.bmp"> | Tagliate in Tacche | [`TAGLIATE_IN_TACCHE`](README_UTENTE.md#cmd-tagliate-in-tacche) |
| <img src="menu/LEONARDO/tacche_in_punti_16.bmp" width="16" height="16" alt="tacche_in_punti_16.bmp"> | <img src="menu/LEONARDO/tacche_in_punti.bmp" width="32" height="32" alt="tacche_in_punti.bmp"> | Tacche in Punti | [`TACCHE_IN_PUNTI`](README_UTENTE.md#cmd-tacche-in-punti) |
| <img src="menu/LEONARDO/punti_in_tacche_16.bmp" width="16" height="16" alt="punti_in_tacche_16.bmp"> | <img src="menu/LEONARDO/punti_in_tacche.bmp" width="32" height="32" alt="punti_in_tacche.bmp"> | Punti in Tacche | [`PUNTI_IN_TACCHE`](README_UTENTE.md#cmd-punti-in-tacche) |
| <img src="menu/LEONARDO/mozart_in_tacche_16.bmp" width="16" height="16" alt="mozart_in_tacche_16.bmp"> | <img src="menu/LEONARDO/mozart_in_tacche.bmp" width="32" height="32" alt="mozart_in_tacche.bmp"> | Mozart in Tacche | [`MOZART_IN_TACCHE`](README_UTENTE.md#cmd-mozart-in-tacche) |
| <img src="menu/LEONARDO/tacche_in_mozart_16.bmp" width="16" height="16" alt="tacche_in_mozart_16.bmp"> | <img src="menu/LEONARDO/tacche_in_mozart.bmp" width="32" height="32" alt="tacche_in_mozart.bmp"> | Tacche in Mozart | [`TACCHE_IN_MOZART`](README_UTENTE.md#cmd-tacche-in-mozart) |

### AAMA

| Piccola | Grande | Pulsante | Comando |
|:-:|:-:|---|---|
| <img src="menu/LEONARDO/AAMA_16.BMP" width="16" height="16" alt="AAMA_16.BMP"> | <img src="menu/LEONARDO/AAMA.BMP" width="32" height="32" alt="AAMA.BMP"> | AAMA Standard | [`AAMA`](README_UTENTE.md#cmd-aama) |
| <img src="menu/LEONARDO/aamar_run_16.bmp" width="16" height="16" alt="aamar_run_16.bmp"> | <img src="menu/LEONARDO/aamar_run.bmp" width="32" height="32" alt="aamar_run.bmp"> | AAMA Standard Rifilo | [`AAMAR`](README_UTENTE.md#cmd-aamar) |
| <img src="menu/LEONARDO/aama_estrai_16.bmp" width="16" height="16" alt="aama_estrai_16.bmp"> | <img src="menu/LEONARDO/aama_estrai.bmp" width="32" height="32" alt="aama_estrai.bmp"> | AAMA Estrai | [`AAMA_ESTRAI`](README_UTENTE.md#cmd-aama-estrai) |
| <img src="menu/LEONARDO/aama_sel_16.bmp" width="16" height="16" alt="aama_sel_16.bmp"> | <img src="menu/LEONARDO/aama_sel.bmp" width="32" height="32" alt="aama_sel.bmp"> | AAMA Selezione | [`AAMA-SEL`](README_UTENTE.md#cmd-aama-sel) |
| <img src="menu/LEONARDO/aama_mat_16.bmp" width="16" height="16" alt="aama_mat_16.bmp"> | <img src="menu/LEONARDO/aama_mat.bmp" width="32" height="32" alt="aama_mat.bmp"> | AAMA per Materiale | [`AAMA-MAT`](README_UTENTE.md#cmd-aama-mat) |
| <img src="menu/LEONARDO/aama_batch_16.bmp" width="16" height="16" alt="aama_batch_16.bmp"> | <img src="menu/LEONARDO/aama_batch.bmp" width="32" height="32" alt="aama_batch.bmp"> | AAMA su Cartella | [`AAMA-BATCH`](README_UTENTE.md#cmd-aama-batch) |
| <img src="menu/LEONARDO/drill1_16.bmp" width="16" height="16" alt="drill1_16.bmp"> | <img src="menu/LEONARDO/drill1.bmp" width="32" height="32" alt="drill1.bmp"> | Drill 1 | [`DRILL1`](README_UTENTE.md#cmd-drill1) |
| <img src="menu/LEONARDO/drill2_16.bmp" width="16" height="16" alt="drill2_16.bmp"> | <img src="menu/LEONARDO/drill2.bmp" width="32" height="32" alt="drill2.bmp"> | Drill 2 | [`DRILL2`](README_UTENTE.md#cmd-drill2) |
| <img src="menu/LEONARDO/drillp_16.bmp" width="16" height="16" alt="drillp_16.bmp"> | <img src="menu/LEONARDO/drillp.bmp" width="32" height="32" alt="drillp.bmp"> | Drill P | [`DRILLP`](README_UTENTE.md#cmd-drillp) |
| <img src="menu/LEONARDO/PROIEZIONE_16.bmp" width="16" height="16" alt="PROIEZIONE_16.bmp"> | <img src="menu/LEONARDO/PROIEZIONE.bmp" width="32" height="32" alt="PROIEZIONE.bmp"> | Proiezione | [`PROIEZIONE`](README_UTENTE.md#cmd-proiezione) |
| <img src="menu/LEONARDO/MARCATURA_16.bmp" width="16" height="16" alt="MARCATURA_16.bmp"> | <img src="menu/LEONARDO/MARCATURA.bmp" width="32" height="32" alt="MARCATURA.bmp"> | Marcatura | [`MARCATURA`](README_UTENTE.md#cmd-marcatura) |
| <img src="menu/LEONARDO/aama_oggetti_16.bmp" width="16" height="16" alt="aama_oggetti_16.bmp"> | <img src="menu/LEONARDO/aama_oggetti.bmp" width="32" height="32" alt="aama_oggetti.bmp"> | Definisci Oggetti AAMA | [`AAMA-OGGETTI`](README_UTENTE.md#cmd-aama-oggetti) |
| <img src="menu/LEONARDO/aama_solo_16.bmp" width="16" height="16" alt="aama_solo_16.bmp"> | <img src="menu/LEONARDO/aama_solo.bmp" width="32" height="32" alt="aama_solo.bmp"> | Visualizza Solo Oggetti AAMA | [`AAMA-SOLO`](README_UTENTE.md#cmd-aama-solo) |
| <img src="menu/LEONARDO/aama_mod_16.bmp" width="16" height="16" alt="aama_mod_16.bmp"> | <img src="menu/LEONARDO/aama_mod.bmp" width="32" height="32" alt="aama_mod.bmp"> | Visualizza Modello | [`AAMA-MOD`](README_UTENTE.md#cmd-aama-mod) |
| <img src="menu/LEONARDO/allinea_blocchi_16.bmp" width="16" height="16" alt="allinea_blocchi_16.bmp"> | <img src="menu/LEONARDO/allinea_blocchi.bmp" width="32" height="32" alt="allinea_blocchi.bmp"> | Allinea Blocchi | [`NESTINGLINEA`](README_UTENTE.md#cmd-nestinglinea) |
| <img src="menu/LEONARDO/geber_16.bmp" width="16" height="16" alt="geber_16.bmp"> | <img src="menu/LEONARDO/geber.bmp" width="32" height="32" alt="geber.bmp"> | Trasforma le tacche in punti geber | [`GEBER`](README_UTENTE.md#cmd-geber) |
| <img src="menu/LEONARDO/set_geber_tolerance_16.bmp" width="16" height="16" alt="set_geber_tolerance_16.bmp"> | <img src="menu/LEONARDO/set_geber_tolerance.bmp" width="32" height="32" alt="set_geber_tolerance.bmp"> | Tolleranza Geber | [`SET_GEBER_TOLERANCE`](README_UTENTE.md#cmd-set-geber-tolerance) |
| <img src="menu/LEONARDO/aama_cfg_16.bmp" width="16" height="16" alt="aama_cfg_16.bmp"> | <img src="menu/LEONARDO/aama_cfg.bmp" width="32" height="32" alt="aama_cfg.bmp"> | Impostazioni AAMA | [`AAMA-CFG`](README_UTENTE.md#cmd-aama-cfg) |

### AAMA Rifilo

| Piccola | Grande | Pulsante | Comando |
|:-:|:-:|---|---|
| <img src="menu/LEONARDO/aamar_init_16.BMP" width="16" height="16" alt="aamar_init_16.BMP"> | <img src="menu/LEONARDO/aamar_init.BMP" width="32" height="32" alt="aamar_init.BMP"> | Inizializza RIFILO | [`AAMAR_INIT`](README_UTENTE.md#cmd-aamar-init) |
| <img src="menu/LEONARDO/aamar_run_16.bmp" width="16" height="16" alt="aamar_run_16.bmp"> | <img src="menu/LEONARDO/aamar_run.bmp" width="32" height="32" alt="aamar_run.bmp"> | AAMA Rifilo | [`AAMAR`](README_UTENTE.md#cmd-aamar) |
| <img src="menu/LEONARDO/aamar_material_16.bmp" width="16" height="16" alt="aamar_material_16.bmp"> | <img src="menu/LEONARDO/aamar_material.bmp" width="32" height="32" alt="aamar_material.bmp"> | RIFILO - Materiale | [`AAMAR_MATERIAL`](README_UTENTE.md#cmd-aamar-material) |
| <img src="menu/LEONARDO/aamar_tipologia_16.bmp" width="16" height="16" alt="aamar_tipologia_16.bmp"> | <img src="menu/LEONARDO/aamar_tipologia.bmp" width="32" height="32" alt="aamar_tipologia.bmp"> | RIFILO - Tipologia | [`AAMAR_TIPOLOGIA`](README_UTENTE.md#cmd-aamar-tipologia) |
| <img src="menu/LEONARDO/aamar_quantita_16.bmp" width="16" height="16" alt="aamar_quantita_16.bmp"> | <img src="menu/LEONARDO/aamar_quantita.bmp" width="32" height="32" alt="aamar_quantita.bmp"> | RIFILO - Quantità | [`AAMAR_QUANTITA`](README_UTENTE.md#cmd-aamar-quantita) |
| <img src="menu/LEONARDO/aamar_spacing_16.bmp" width="16" height="16" alt="aamar_spacing_16.bmp"> | <img src="menu/LEONARDO/aamar_spacing.bmp" width="32" height="32" alt="aamar_spacing.bmp"> | RIFILO - Spaziatura | [`AAMAR_SPACING`](README_UTENTE.md#cmd-aamar-spacing) |
| <img src="menu/LEONARDO/aamar_settings_16.bmp" width="16" height="16" alt="aamar_settings_16.bmp"> | <img src="menu/LEONARDO/aamar_settings.bmp" width="32" height="32" alt="aamar_settings.bmp"> | RIFILO - Impostazioni | [`AAMAR_SETTINGS`](README_UTENTE.md#cmd-aamar-settings) |

### ATOM

| Piccola | Grande | Pulsante | Comando |
|:-:|:-:|---|---|
| <img src="menu/LEONARDO/atom_layout_16.bmp" width="16" height="16" alt="atom_layout_16.bmp"> | <img src="menu/LEONARDO/atom_layout.bmp" width="32" height="32" alt="atom_layout.bmp"> | ATOM Nuovo Layout | [`ATOM-LAYOUT`](README_UTENTE.md#cmd-atom-layout) |
| <img src="menu/LEONARDO/atom_pezzi_16.bmp" width="16" height="16" alt="atom_pezzi_16.bmp"> | <img src="menu/LEONARDO/atom_pezzi.bmp" width="32" height="32" alt="atom_pezzi.bmp"> | ATOM Aggiungi Pezzi | [`ATOM-PEZZI`](README_UTENTE.md#cmd-atom-pezzi) |
| <img src="menu/LEONARDO/atom_disponi_16.bmp" width="16" height="16" alt="atom_disponi_16.bmp"> | <img src="menu/LEONARDO/atom_disponi.bmp" width="32" height="32" alt="atom_disponi.bmp"> | ATOM Disponi Pezzi | [`ATOM-DISPONI`](README_UTENTE.md#cmd-atom-disponi) |
| <img src="menu/LEONARDO/atom_controlla_16.bmp" width="16" height="16" alt="atom_controlla_16.bmp"> | <img src="menu/LEONARDO/atom_controlla.bmp" width="32" height="32" alt="atom_controlla.bmp"> | ATOM Controlla Layout | [`ATOM-CONTROLLA`](README_UTENTE.md#cmd-atom-controlla) |
| <img src="menu/LEONARDO/atom_dati_16.bmp" width="16" height="16" alt="atom_dati_16.bmp"> | <img src="menu/LEONARDO/atom_dati.bmp" width="32" height="32" alt="atom_dati.bmp"> | ATOM Dati del Layout | [`ATOM-DATI`](README_UTENTE.md#cmd-atom-dati) |
| <img src="menu/LEONARDO/atom_salva_16.bmp" width="16" height="16" alt="atom_salva_16.bmp"> | <img src="menu/LEONARDO/atom_salva.bmp" width="32" height="32" alt="atom_salva.bmp"> | ATOM Salva | [`ATOM-SALVA`](README_UTENTE.md#cmd-atom-salva) |
| <img src="menu/LEONARDO/atom_apri_16.bmp" width="16" height="16" alt="atom_apri_16.bmp"> | <img src="menu/LEONARDO/atom_apri.bmp" width="32" height="32" alt="atom_apri.bmp"> | ATOM Apri | [`ATOM-APRI`](README_UTENTE.md#cmd-atom-apri) |
| <img src="menu/LEONARDO/atom_die_16.bmp" width="16" height="16" alt="atom_die_16.bmp"> | <img src="menu/LEONARDO/atom_die.bmp" width="32" height="32" alt="atom_die.bmp"> | ATOM Solo Sagome | [`ATOM-DIE`](README_UTENTE.md#cmd-atom-die) |
| <img src="menu/LEONARDO/atom_cfg_16.bmp" width="16" height="16" alt="atom_cfg_16.bmp"> | <img src="menu/LEONARDO/atom_cfg.bmp" width="32" height="32" alt="atom_cfg.bmp"> | Impostazioni ATOM | [`ATOM-CFG`](README_UTENTE.md#cmd-atom-cfg) |

### Modifica Avanzata

| Piccola | Grande | Pulsante | Comando |
|:-:|:-:|---|---|
| <img src="menu/LEONARDO/cook_16.bmp" width="16" height="16" alt="cook_16.bmp"> | <img src="menu/LEONARDO/cook.bmp" width="32" height="32" alt="cook.bmp"> | Svuota Polilinea | [`COOKIECUTTER2`](README_UTENTE.md#cmd-cookiecutter2) |
| <img src="menu/LEONARDO/cc_16.bmp" width="16" height="16" alt="cc_16.bmp"> | <img src="menu/LEONARDO/cc.bmp" width="32" height="32" alt="cc.bmp"> | Cookie Cutter (CC) | [`CC`](README_UTENTE.md#cmd-cc) |
| <img src="menu/LEONARDO/perp2ent_16.bmp" width="16" height="16" alt="perp2ent_16.bmp"> | <img src="menu/LEONARDO/perp2ent.bmp" width="32" height="32" alt="perp2ent.bmp"> | Perp a Ent | [`PERP2ENT`](README_UTENTE.md#cmd-perp2ent) |
| <img src="menu/LEONARDO/SPEZZA_PUNTO_16.bmp" width="16" height="16" alt="SPEZZA_PUNTO_16.bmp"> | <img src="menu/LEONARDO/SPEZZA_PUNTO.bmp" width="32" height="32" alt="SPEZZA_PUNTO.bmp"> | Spezza in Punto | [`SPEZZA_PUNTO`](README_UTENTE.md#cmd-spezza-punto) |
| <img src="menu/LEONARDO/RAGGIO_0_16.BMP" width="16" height="16" alt="RAGGIO_0_16.BMP"> | <img src="menu/LEONARDO/RAGGIO_0.BMP" width="32" height="32" alt="RAGGIO_0.BMP"> | Raccordo Raggio Zero | [`RACCORDA_0`](README_UTENTE.md#cmd-raccorda-0) |
| <img src="menu/LEONARDO/Zero_16.bmp" width="16" height="16" alt="Zero_16.bmp"> | <img src="menu/LEONARDO/Zero.bmp" width="32" height="32" alt="Zero.bmp"> | Rotazione Zero | [`ZR`](README_UTENTE.md#cmd-zr) |
| <img src="menu/LEONARDO/r9_16.bmp" width="16" height="16" alt="r9_16.bmp"> | <img src="menu/LEONARDO/r9.bmp" width="32" height="32" alt="r9.bmp"> | Rotazione 90 (R9) | [`R9`](README_UTENTE.md#cmd-r9) |
| <img src="menu/LEONARDO/r90_16.bmp" width="16" height="16" alt="r90_16.bmp"> | <img src="menu/LEONARDO/r90.bmp" width="32" height="32" alt="r90.bmp"> | Rotazione 90 | [`R90`](README_UTENTE.md#cmd-r90) |
| <img src="menu/LEONARDO/r90m_16.bmp" width="16" height="16" alt="r90m_16.bmp"> | <img src="menu/LEONARDO/r90m.bmp" width="32" height="32" alt="r90m.bmp"> | Rotazione -90 | [`R90M`](README_UTENTE.md#cmd-r90m) |
| <img src="menu/LEONARDO/r180_16.bmp" width="16" height="16" alt="r180_16.bmp"> | <img src="menu/LEONARDO/r180.bmp" width="32" height="32" alt="r180.bmp"> | Rotazione 180 | [`R180`](README_UTENTE.md#cmd-r180) |
| <img src="menu/LEONARDO/squadratura_16.bmp" width="16" height="16" alt="squadratura_16.bmp"> | <img src="menu/LEONARDO/squadratura.bmp" width="32" height="32" alt="squadratura.bmp"> | Squadratura (Centro) | [`CENTRO`](README_UTENTE.md#cmd-centro) |
| <img src="menu/LEONARDO/sar_16.bmp" width="16" height="16" alt="sar_16.bmp"> | <img src="menu/LEONARDO/sar.bmp" width="32" height="32" alt="sar.bmp"> | Disegna Freccia (SAR) | [`SAR`](README_UTENTE.md#cmd-sar) |
| <img src="menu/LEONARDO/Quic_16.bmp" width="16" height="16" alt="Quic_16.bmp"> | <img src="menu/LEONARDO/Quic.bmp" width="32" height="32" alt="Quic.bmp"> | Specchia Rapido | [`QM`](README_UTENTE.md#cmd-qm) |
| <img src="menu/LEONARDO/qmd_16.bmp" width="16" height="16" alt="qmd_16.bmp"> | <img src="menu/LEONARDO/qmd.bmp" width="32" height="32" alt="qmd.bmp"> | Specchia Rapido e Cancella | [`QMD`](README_UTENTE.md#cmd-qmd) |
| <img src="menu/LEONARDO/qmo_16.bmp" width="16" height="16" alt="qmo_16.bmp"> | <img src="menu/LEONARDO/qmo.bmp" width="32" height="32" alt="qmo.bmp"> | Specchia Oggetto | [`QMO`](README_UTENTE.md#cmd-qmo) |
| <img src="menu/LEONARDO/qmod_16.bmp" width="16" height="16" alt="qmod_16.bmp"> | <img src="menu/LEONARDO/qmod.bmp" width="32" height="32" alt="qmod.bmp"> | Specchia Oggetto e Cancella | [`QMOD`](README_UTENTE.md#cmd-qmod) |
| <img src="menu/LEONARDO/ATC_16.bmp" width="16" height="16" alt="ATC_16.bmp"> | <img src="menu/LEONARDO/ATC.bmp" width="32" height="32" alt="ATC.bmp"> | Allinea Testo a Curva | [`ATC`](README_UTENTE.md#cmd-atc) |
| `ZWRC_POLYGO` | `ZWRC_POLYGO` | Poligono | `POLYGON` |
| `ZWRC_RECTAN` | `ZWRC_RECTAN` | Rettangolo | `RECTANG` |
| <img src="menu/LEONARDO/RECT_16.bmp" width="16" height="16" alt="RECT_16.bmp"> | <img src="menu/LEONARDO/RECT.bmp" width="32" height="32" alt="RECT.bmp"> | Rettangolo dal Centro | [`LEORETTANGOLO`](README_UTENTE.md#cmd-leorettangolo) |
| <img src="menu/LEONARDO/rettangoloraccordato_16.bmp" width="16" height="16" alt="rettangoloraccordato_16.bmp"> | <img src="menu/LEONARDO/rettangoloraccordato.bmp" width="32" height="32" alt="rettangoloraccordato.bmp"> | Rettangolo Raccordato | [`LEORACRETT`](README_UTENTE.md#cmd-leoracrett) |
| <img src="menu/LEONARDO/tavola-vuota_16.BMP" width="16" height="16" alt="tavola-vuota_16.BMP"> | <img src="menu/LEONARDO/tavola-vuota.BMP" width="32" height="32" alt="tavola-vuota.BMP"> | Rettangolo A3 | [`LEOA3`](README_UTENTE.md#cmd-leoa3) |
| <img src="menu/LEONARDO/TAVOLA_STAMPA_A4_16.bmp" width="16" height="16" alt="TAVOLA_STAMPA_A4_16.bmp"> | <img src="menu/LEONARDO/TAVOLA_STAMPA_A4.bmp" width="32" height="32" alt="TAVOLA_STAMPA_A4.bmp"> | Rettangolo A4 | [`LEOA4`](README_UTENTE.md#cmd-leoa4) |
| <img src="menu/LEONARDO/TRAPI_16.bmp" width="16" height="16" alt="TRAPI_16.bmp"> | <img src="menu/LEONARDO/TRAPI.bmp" width="32" height="32" alt="TRAPI.bmp"> | Trapezio per Altezza | [`TRAPI`](README_UTENTE.md#cmd-trapi) |
| <img src="menu/LEONARDO/TRAPL_16.bmp" width="16" height="16" alt="TRAPL_16.bmp"> | <img src="menu/LEONARDO/TRAPL.bmp" width="32" height="32" alt="TRAPL.bmp"> | Trapezio per Lato | [`TRAPL`](README_UTENTE.md#cmd-trapl) |
| <img src="menu/LEONARDO/goldrect_16.bmp" width="16" height="16" alt="goldrect_16.bmp"> | <img src="menu/LEONARDO/goldrect.bmp" width="32" height="32" alt="goldrect.bmp"> | Rettangolo Aureo | [`GOLDRECT`](README_UTENTE.md#cmd-goldrect) |
| <img src="menu/LEONARDO/goldspiral_16.bmp" width="16" height="16" alt="goldspiral_16.bmp"> | <img src="menu/LEONARDO/goldspiral.bmp" width="32" height="32" alt="goldspiral.bmp"> | Spirale Aurea | [`GOLDSPIRAL`](README_UTENTE.md#cmd-goldspiral) |
| <img src="menu/LEONARDO/spirale_16.bmp" width="16" height="16" alt="spirale_16.bmp"> | <img src="menu/LEONARDO/spirale.bmp" width="32" height="32" alt="spirale.bmp"> | Spirale | [`SPIRALE`](README_UTENTE.md#cmd-spirale) |
| <img src="menu/LEONARDO/ovale_16.bmp" width="16" height="16" alt="ovale_16.bmp"> | <img src="menu/LEONARDO/ovale.bmp" width="32" height="32" alt="ovale.bmp"> | Ovale | [`OVALE`](README_UTENTE.md#cmd-ovale) |
| <img src="menu/LEONARDO/ovolo_16.bmp" width="16" height="16" alt="ovolo_16.bmp"> | <img src="menu/LEONARDO/ovolo.bmp" width="32" height="32" alt="ovolo.bmp"> | Ovolo | [`OVOLO`](README_UTENTE.md#cmd-ovolo) |
| <img src="menu/LEONARDO/ellisse_16.bmp" width="16" height="16" alt="ellisse_16.bmp"> | <img src="menu/LEONARDO/ellisse.bmp" width="32" height="32" alt="ellisse.bmp"> | Ellisse a Polilinea | [`ELLISSE`](README_UTENTE.md#cmd-ellisse) |
| <img src="menu/LEONARDO/cicloide_16.bmp" width="16" height="16" alt="cicloide_16.bmp"> | <img src="menu/LEONARDO/cicloide.bmp" width="32" height="32" alt="cicloide.bmp"> | Cicloide | [`CICLOIDE`](README_UTENTE.md#cmd-cicloide) |
| <img src="menu/LEONARDO/triangolo_16.bmp" width="16" height="16" alt="triangolo_16.bmp"> | <img src="menu/LEONARDO/triangolo.bmp" width="32" height="32" alt="triangolo.bmp"> | Triangolo Isoscele | [`TRIANGOLO`](README_UTENTE.md#cmd-triangolo) |
| <img src="menu/LEONARDO/rombo_16.bmp" width="16" height="16" alt="rombo_16.bmp"> | <img src="menu/LEONARDO/rombo.bmp" width="32" height="32" alt="rombo.bmp"> | Rombo | [`ROMBO`](README_UTENTE.md#cmd-rombo) |
| <img src="menu/LEONARDO/circonf_16.bmp" width="16" height="16" alt="circonf_16.bmp"> | <img src="menu/LEONARDO/circonf.bmp" width="32" height="32" alt="circonf.bmp"> | Cerchio da Perimetro | [`CIRCONF`](README_UTENTE.md#cmd-circonf) |
| <img src="menu/LEONARDO/tasca_16.bmp" width="16" height="16" alt="tasca_16.bmp"> | <img src="menu/LEONARDO/tasca.bmp" width="32" height="32" alt="tasca.bmp"> | Tasca | [`TASCA`](README_UTENTE.md#cmd-tasca) |
| <img src="menu/LEONARDO/topopt_16.bmp" width="16" height="16" alt="topopt_16.bmp"> | <img src="menu/LEONARDO/topopt.bmp" width="32" height="32" alt="topopt.bmp"> | Top Ottimizzato | [`TOPOPT`](README_UTENTE.md#cmd-topopt) |
| <img src="menu/LEONARDO/INIZIO_DIREZIONE_16.bmp" width="16" height="16" alt="INIZIO_DIREZIONE_16.bmp"> | <img src="menu/LEONARDO/INIZIO_DIREZIONE.bmp" width="32" height="32" alt="INIZIO_DIREZIONE.bmp"> | Direzione Polilinea | [`PLD`](README_UTENTE.md#cmd-pld) |
| <img src="menu/LEONARDO/INVERTI_DIREZIONE_16.bmp" width="16" height="16" alt="INVERTI_DIREZIONE_16.bmp"> | <img src="menu/LEONARDO/INVERTI_DIREZIONE.bmp" width="32" height="32" alt="INVERTI_DIREZIONE.bmp"> | Inverti Direzione | [`RVRSLINE`](README_UTENTE.md#cmd-rvrsline) |
| <img src="menu/LEONARDO/cs_16.BMP" width="16" height="16" alt="cs_16.BMP"> | <img src="menu/LEONARDO/cs.BMP" width="32" height="32" alt="cs.BMP"> | Chain Selection | [`CS`](README_UTENTE.md#cmd-cs) |

### Tavola di Stampa

| Piccola | Grande | Pulsante | Comando |
|:-:|:-:|---|---|
| <img src="menu/LEONARDO/PRESTAMPA_16.bmp" width="16" height="16" alt="PRESTAMPA_16.bmp"> | <img src="menu/LEONARDO/PRESTAMPA.bmp" width="32" height="32" alt="PRESTAMPA.bmp"> | Prestampa | [`PRESTAMPA`](README_UTENTE.md#cmd-prestampa) |
| <img src="menu/LEONARDO/TAVOLA_STAMPA_16.bmp" width="16" height="16" alt="TAVOLA_STAMPA_16.bmp"> | <img src="menu/LEONARDO/TAVOLA_STAMPA.bmp" width="32" height="32" alt="TAVOLA_STAMPA.bmp"> | Tavola Selezione Manuale | [`TAVOLA_DI_STAMPA_ANTIBUG`](README_UTENTE.md#cmd-tavola-di-stampa-antibug) |
| <img src="menu/LEONARDO/TAVOLA_STAMPA_A3_16.bmp" width="16" height="16" alt="TAVOLA_STAMPA_A3_16.bmp"> | <img src="menu/LEONARDO/TAVOLA_STAMPA_A3.bmp" width="32" height="32" alt="TAVOLA_STAMPA_A3.bmp"> | Tavola A3 | [`TAVOLA_DI_STAMPA_A3`](README_UTENTE.md#cmd-tavola-di-stampa-a3) |
| <img src="menu/LEONARDO/nesting_16.bmp" width="16" height="16" alt="nesting_16.bmp"> | <img src="menu/LEONARDO/nesting.bmp" width="32" height="32" alt="nesting.bmp"> | Nesting Avanzato | [`NESTING3`](README_UTENTE.md#cmd-nesting3) |
| <img src="menu/LEONARDO/TAVOLA_STAMPA_VUOTA_16.bmp" width="16" height="16" alt="TAVOLA_STAMPA_VUOTA_16.bmp"> | <img src="menu/LEONARDO/TAVOLA_STAMPA_VUOTA.bmp" width="32" height="32" alt="TAVOLA_STAMPA_VUOTA.bmp"> | Foglio Plotter Singolo | [`LEOUM`](README_UTENTE.md#cmd-leoum) |
| <img src="menu/LEONARDO/leoum2_16.bmp" width="16" height="16" alt="leoum2_16.bmp"> | <img src="menu/LEONARDO/leoum2.bmp" width="32" height="32" alt="leoum2.bmp"> | 2 Fogli Plotter | [`LEOUM2`](README_UTENTE.md#cmd-leoum2) |
| <img src="menu/LEONARDO/leoum4_16.bmp" width="16" height="16" alt="leoum4_16.bmp"> | <img src="menu/LEONARDO/leoum4.bmp" width="32" height="32" alt="leoum4.bmp"> | 4 Fogli Plotter | [`LEOUM4`](README_UTENTE.md#cmd-leoum4) |

### Sbozzo

| Piccola | Grande | Pulsante | Comando |
|:-:|:-:|---|---|
| <img src="menu/LEONARDO/SBOZZO_16.bmp" width="16" height="16" alt="SBOZZO_16.bmp"> | <img src="menu/LEONARDO/SBOZZO.bmp" width="32" height="32" alt="SBOZZO.bmp"> | Sbozzo Singolo | [`SBOZZO`](README_UTENTE.md#cmd-sbozzo) |
| <img src="menu/LEONARDO/SBOZZO_RETT_16.BMP" width="16" height="16" alt="SBOZZO_RETT_16.BMP"> | <img src="menu/LEONARDO/SBOZZO_RETT.BMP" width="32" height="32" alt="SBOZZO_RETT.BMP"> | Sbozzo Rettangolare | [`SBOZZO_RETT`](README_UTENTE.md#cmd-sbozzo-rett) |
| <img src="menu/LEONARDO/sbozzo_bound_16.bmp" width="16" height="16" alt="sbozzo_bound_16.bmp"> | <img src="menu/LEONARDO/sbozzo_bound.bmp" width="32" height="32" alt="sbozzo_bound.bmp"> | Sbozzo Boundary | [`SBOZZO_BOUND`](README_UTENTE.md#cmd-sbozzo-bound) |
| <img src="menu/LEONARDO/sbozzomultiplo_16.bmp" width="16" height="16" alt="sbozzomultiplo_16.bmp"> | <img src="menu/LEONARDO/sbozzomultiplo.bmp" width="32" height="32" alt="sbozzomultiplo.bmp"> | Sbozzo Multiplo | [`COPYARRAY`](README_UTENTE.md#cmd-copyarray) |
| <img src="menu/LEONARDO/DIMA_ATOM_16.bmp" width="16" height="16" alt="DIMA_ATOM_16.bmp"> | <img src="menu/LEONARDO/DIMA_ATOM.bmp" width="32" height="32" alt="DIMA_ATOM.bmp"> | Dima | [`DIMA`](README_UTENTE.md#cmd-dima) |
| <img src="menu/LEONARDO/dima_tacche_atom_16.bmp" width="16" height="16" alt="dima_tacche_atom_16.bmp"> | <img src="menu/LEONARDO/dima_tacche_atom.bmp" width="32" height="32" alt="dima_tacche_atom.bmp"> | Dima Tacche (Atom) | [`DIMA_TACCHE_ATOM`](README_UTENTE.md#cmd-dima-tacche-atom) |

### Plugin

| Piccola | Grande | Pulsante | Comando |
|:-:|:-:|---|---|
| <img src="menu/LEONARDO/conta_16.bmp" width="16" height="16" alt="conta_16.bmp"> | <img src="menu/LEONARDO/conta.bmp" width="32" height="32" alt="conta.bmp"> | Conta | [`CONTA`](README_UTENTE.md#cmd-conta) |
| <img src="menu/LEONARDO/Pass_16.bmp" width="16" height="16" alt="Pass_16.bmp"> | <img src="menu/LEONARDO/Pass.bmp" width="32" height="32" alt="Pass.bmp"> | Passante | [`PASSANTE`](README_UTENTE.md#cmd-passante) |

### Offset

| Piccola | Grande | Pulsante | Comando |
|:-:|:-:|---|---|
| <img src="menu/LEONARDO/OF2_16.BMP" width="16" height="16" alt="OF2_16.BMP"> | <img src="menu/LEONARDO/OF2.BMP" width="32" height="32" alt="OF2.BMP"> | Offset 2 |  |
| <img src="menu/LEONARDO/OF3_16.BMP" width="16" height="16" alt="OF3_16.BMP"> | <img src="menu/LEONARDO/OF3.BMP" width="32" height="32" alt="OF3.BMP"> | Offset 3 |  |
| <img src="menu/LEONARDO/OF4_16.BMP" width="16" height="16" alt="OF4_16.BMP"> | <img src="menu/LEONARDO/OF4.BMP" width="32" height="32" alt="OF4.BMP"> | Offset 4 |  |
| <img src="menu/LEONARDO/OF5_16.BMP" width="16" height="16" alt="OF5_16.BMP"> | <img src="menu/LEONARDO/OF5.BMP" width="32" height="32" alt="OF5.BMP"> | Offset 5 |  |
| <img src="menu/LEONARDO/OF6_16.BMP" width="16" height="16" alt="OF6_16.BMP"> | <img src="menu/LEONARDO/OF6.BMP" width="32" height="32" alt="OF6.BMP"> | Offset 6 |  |
| <img src="menu/LEONARDO/OF8_16.BMP" width="16" height="16" alt="OF8_16.BMP"> | <img src="menu/LEONARDO/OF8.BMP" width="32" height="32" alt="OF8.BMP"> | Offset 8 |  |
| <img src="menu/LEONARDO/OF10_16.BMP" width="16" height="16" alt="OF10_16.BMP"> | <img src="menu/LEONARDO/OF10.BMP" width="32" height="32" alt="OF10.BMP"> | Offset 10 |  |
| <img src="menu/LEONARDO/OF_16.bmp" width="16" height="16" alt="OF_16.bmp"> | <img src="menu/LEONARDO/OF.bmp" width="32" height="32" alt="OF.bmp"> | Offset Variabile | `OFFSET` |
| <img src="menu/LEONARDO/Of2T_16.BMP" width="16" height="16" alt="Of2T_16.BMP"> | <img src="menu/LEONARDO/Of2T.BMP" width="32" height="32" alt="Of2T.BMP"> | Offset 2 Tratteggiato | [`OFT_2`](README_UTENTE.md#cmd-oft-2) |
| <img src="menu/LEONARDO/OF3T_16.BMP" width="16" height="16" alt="OF3T_16.BMP"> | <img src="menu/LEONARDO/OF3T.BMP" width="32" height="32" alt="OF3T.BMP"> | Offset 3 Tratteggiato | [`OFT_3`](README_UTENTE.md#cmd-oft-3) |
| <img src="menu/LEONARDO/OF4T_16.BMP" width="16" height="16" alt="OF4T_16.BMP"> | <img src="menu/LEONARDO/OF4T.BMP" width="32" height="32" alt="OF4T.BMP"> | Offset 4 Tratteggiato | [`OFT_4`](README_UTENTE.md#cmd-oft-4) |
| <img src="menu/LEONARDO/OF5T_16.BMP" width="16" height="16" alt="OF5T_16.BMP"> | <img src="menu/LEONARDO/OF5T.BMP" width="32" height="32" alt="OF5T.BMP"> | Offset 5 Tratteggiato | [`OFT_5`](README_UTENTE.md#cmd-oft-5) |
| <img src="menu/LEONARDO/OF6T_16.BMP" width="16" height="16" alt="OF6T_16.BMP"> | <img src="menu/LEONARDO/OF6T.BMP" width="32" height="32" alt="OF6T.BMP"> | Offset 6 Tratteggiato | [`OFT_6`](README_UTENTE.md#cmd-oft-6) |
| <img src="menu/LEONARDO/OF8T_16.BMP" width="16" height="16" alt="OF8T_16.BMP"> | <img src="menu/LEONARDO/OF8T.BMP" width="32" height="32" alt="OF8T.BMP"> | Offset 8 Tratteggiato | [`OFT_8`](README_UTENTE.md#cmd-oft-8) |
| <img src="menu/LEONARDO/OFT10T_16.bmp" width="16" height="16" alt="OFT10T_16.bmp"> | <img src="menu/LEONARDO/OFT10T.bmp" width="32" height="32" alt="OFT10T.bmp"> | Offset 10 Tratteggiato | [`OFT_10`](README_UTENTE.md#cmd-oft-10) |
| <img src="menu/LEONARDO/OFt_16.bmp" width="16" height="16" alt="OFt_16.bmp"> | <img src="menu/LEONARDO/OFt.bmp" width="32" height="32" alt="OFt.bmp"> | Offset Tratteggiato | [`OFT`](README_UTENTE.md#cmd-oft) |

### Offset Tratto

| Piccola | Grande | Pulsante | Comando |
|:-:|:-:|---|---|
| <img src="menu/LEONARDO/ofi_16.bmp" width="16" height="16" alt="ofi_16.bmp"> | <img src="menu/LEONARDO/ofi.bmp" width="32" height="32" alt="ofi.bmp"> | OFI | [`OFI`](README_UTENTE.md#cmd-ofi) |
| <img src="menu/LEONARDO/ofinc_16.bmp" width="16" height="16" alt="ofinc_16.bmp"> | <img src="menu/LEONARDO/ofinc.bmp" width="32" height="32" alt="ofinc.bmp"> | Offset Incrementali | [`OFINC`](README_UTENTE.md#cmd-ofinc) |
| <img src="menu/LEONARDO/offset_tratto_16.bmp" width="16" height="16" alt="offset_tratto_16.bmp"> | <img src="menu/LEONARDO/offset_tratto.bmp" width="32" height="32" alt="offset_tratto.bmp"> | Offset Tratto (finestra) | [`OFFSET_TRATTO`](README_UTENTE.md#cmd-offset-tratto) |
| <img src="menu/LEONARDO/offset_tratto_simple_16.bmp" width="16" height="16" alt="offset_tratto_simple_16.bmp"> | <img src="menu/LEONARDO/offset_tratto_simple.bmp" width="32" height="32" alt="offset_tratto_simple.bmp"> | Offset Tratto Semplice | [`OFFSET_TRATTO_SIMPLE`](README_UTENTE.md#cmd-offset-tratto-simple) |
| <img src="menu/LEONARDO/offset_tratto_linked_16.bmp" width="16" height="16" alt="offset_tratto_linked_16.bmp"> | <img src="menu/LEONARDO/offset_tratto_linked.bmp" width="32" height="32" alt="offset_tratto_linked.bmp"> | Offset Tratto Collegato | [`OFFSET_TRATTO_LINKED`](README_UTENTE.md#cmd-offset-tratto-linked) |
| <img src="menu/LEONARDO/offset_tratto_hatched_16.bmp" width="16" height="16" alt="offset_tratto_hatched_16.bmp"> | <img src="menu/LEONARDO/offset_tratto_hatched.bmp" width="32" height="32" alt="offset_tratto_hatched.bmp"> | Offset Tratto Tratteggiato | [`OFFSET_TRATTO_HATCHED`](README_UTENTE.md#cmd-offset-tratto-hatched) |
| <img src="menu/LEONARDO/offset_tratto_break_16.bmp" width="16" height="16" alt="offset_tratto_break_16.bmp"> | <img src="menu/LEONARDO/offset_tratto_break.bmp" width="32" height="32" alt="offset_tratto_break.bmp"> | Offset Tratto Spezzato | [`OFFSET_TRATTO_BREAK`](README_UTENTE.md#cmd-offset-tratto-break) |
| <img src="menu/LEONARDO/offset_tratto_break_clean_16.bmp" width="16" height="16" alt="offset_tratto_break_clean_16.bmp"> | <img src="menu/LEONARDO/offset_tratto_break_clean.bmp" width="32" height="32" alt="offset_tratto_break_clean.bmp"> | Offset Tratto Pulito | [`OFFSET_TRATTO_BREAK_CLEAN`](README_UTENTE.md#cmd-offset-tratto-break-clean) |

### Interroga

| Piccola | Grande | Pulsante | Comando |
|:-:|:-:|---|---|
| `ZWRC_DIMALI` | `ZWRC_DIMALI` | Quota Allineata | `DIMALIGNED` |
| `ZWRC_DIMRAD` | `ZWRC_DIMRAD` | Quota Raggio | `DIMRADIUS` |
| `ZWRC_DIMDIA` | `ZWRC_DIMDIA` | Quota Diametro | `DIMDIAMETER` |
| `ZWRC_LIST` | `ZWRC_LIST` | Elenca | `LIST` |
| `ZWRC_DIST` | `ZWRC_DIST` | Distanza |  |
| `ZWRC_AREA` | `ZWRC_AREA` | Area | `AREA` |
| `ZWRC_IMGATT` | `ZWRC_IMGATT` | Attacca Immagine | `IMAGEATTACH` |

### CONSUMI NOG

| Piccola | Grande | Pulsante | Comando |
|:-:|:-:|---|---|
| <img src="menu/LEONARDO/consumi_metro_16.bmp" width="16" height="16" alt="consumi_metro_16.bmp"> | <img src="menu/LEONARDO/consumi_metro.bmp" width="32" height="32" alt="consumi_metro.bmp"> | Consumi Metro | [`CONSUMI_METRO`](README_UTENTE.md#cmd-consumi-metro) |
| <img src="menu/LEONARDO/consumi_rotolo_16.bmp" width="16" height="16" alt="consumi_rotolo_16.bmp"> | <img src="menu/LEONARDO/consumi_rotolo.bmp" width="32" height="32" alt="consumi_rotolo.bmp"> | Consumi Rotolo | [`CONSUMI_ROTOLO`](README_UTENTE.md#cmd-consumi-rotolo) |
| <img src="menu/LEONARDO/NOG_16.bmp" width="16" height="16" alt="NOG_16.bmp"> | <img src="menu/LEONARDO/NOG.bmp" width="32" height="32" alt="NOG.bmp"> | Computo Materiali | [`NOG`](README_UTENTE.md#cmd-nog) |
| <img src="menu/LEONARDO/computo_file_16.bmp" width="16" height="16" alt="computo_file_16.bmp"> | <img src="menu/LEONARDO/computo_file.bmp" width="32" height="32" alt="computo_file.bmp"> | Computo su File | [`COMPUTO_FILE`](README_UTENTE.md#cmd-computo-file) |

### NOG Configurazione

| Piccola | Grande | Pulsante | Comando |
|:-:|:-:|---|---|
| <img src="menu/LEONARDO/nog_config_16.bmp" width="16" height="16" alt="nog_config_16.bmp"> | <img src="menu/LEONARDO/nog_config.bmp" width="32" height="32" alt="nog_config.bmp"> | Configurazione NOG | [`NOG-CONFIG`](README_UTENTE.md#cmd-nog-config) |
| <img src="menu/LEONARDO/nog_addmat_16.bmp" width="16" height="16" alt="nog_addmat_16.bmp"> | <img src="menu/LEONARDO/nog_addmat.bmp" width="32" height="32" alt="nog_addmat.bmp"> | NOG Aggiungi Materiale | [`NOG-ADDMAT`](README_UTENTE.md#cmd-nog-addmat) |

### Schede e Report

| Piccola | Grande | Pulsante | Comando |
|:-:|:-:|---|---|
| <img src="menu/LEONARDO/scheda_16.bmp" width="16" height="16" alt="scheda_16.bmp"> | <img src="menu/LEONARDO/scheda.bmp" width="32" height="32" alt="scheda.bmp"> | Menu Schede e Computi | [`SCHEDA`](README_UTENTE.md#cmd-scheda) |
| <img src="menu/LEONARDO/riepilogo_materiali_16.bmp" width="16" height="16" alt="riepilogo_materiali_16.bmp"> | <img src="menu/LEONARDO/riepilogo_materiali.bmp" width="32" height="32" alt="riepilogo_materiali.bmp"> | Riepilogo Materiali | [`RIEPILOGO_MATERIALI`](README_UTENTE.md#cmd-riepilogo-materiali) |
| <img src="menu/LEONARDO/scheda_img_16.bmp" width="16" height="16" alt="scheda_img_16.bmp"> | <img src="menu/LEONARDO/scheda_img.bmp" width="32" height="32" alt="scheda_img.bmp"> | Scheda Pezzi PRO | [`SCHEDAPRO`](README_UTENTE.md#cmd-schedapro) |
| <img src="menu/LEONARDO/scheda_acc_16.bmp" width="16" height="16" alt="scheda_acc_16.bmp"> | <img src="menu/LEONARDO/scheda_acc.bmp" width="32" height="32" alt="scheda_acc.bmp"> | Scheda Accessori | [`SCHEDA-ACC`](README_UTENTE.md#cmd-scheda-acc) |
| <img src="menu/LEONARDO/scheda_lav_16.bmp" width="16" height="16" alt="scheda_lav_16.bmp"> | <img src="menu/LEONARDO/scheda_lav.bmp" width="32" height="32" alt="scheda_lav.bmp"> | Scheda Lavorazioni | [`SCHEDA-LAV`](README_UTENTE.md#cmd-scheda-lav) |
| <img src="menu/LEONARDO/scheda_pz_acc_16.bmp" width="16" height="16" alt="scheda_pz_acc_16.bmp"> | <img src="menu/LEONARDO/scheda_pz_acc.bmp" width="32" height="32" alt="scheda_pz_acc.bmp"> | Scheda Pezzi+Accessori | [`SCHEDA-PEZZI-ACC`](README_UTENTE.md#cmd-scheda-pezzi-acc) |
| <img src="menu/LEONARDO/scheda_pz_lav_16.bmp" width="16" height="16" alt="scheda_pz_lav_16.bmp"> | <img src="menu/LEONARDO/scheda_pz_lav.bmp" width="32" height="32" alt="scheda_pz_lav.bmp"> | Scheda Pezzi+Lavorazioni | [`SCHEDA-PEZZI-LAV`](README_UTENTE.md#cmd-scheda-pezzi-lav) |
| <img src="menu/LEONARDO/scheda_html_16.bmp" width="16" height="16" alt="scheda_html_16.bmp"> | <img src="menu/LEONARDO/scheda_html.bmp" width="32" height="32" alt="scheda_html.bmp"> | Rigenera HTML | [`SCHEDAPRO_HTML`](README_UTENTE.md#cmd-schedapro-html) |
| <img src="menu/LEONARDO/scheda_html_int_16.bmp" width="16" height="16" alt="scheda_html_int_16.bmp"> | <img src="menu/LEONARDO/scheda_html_int.bmp" width="32" height="32" alt="scheda_html_int.bmp"> | Configura Scheda | [`SCHEDAPRO_CFG`](README_UTENTE.md#cmd-schedapro-cfg) |
| <img src="menu/LEONARDO/computo_costi_16.bmp" width="16" height="16" alt="computo_costi_16.bmp"> | <img src="menu/LEONARDO/computo_costi.bmp" width="32" height="32" alt="computo_costi.bmp"> | Computo Costi | [`COMPUTO_COSTI`](README_UTENTE.md#cmd-computo-costi) |
| <img src="menu/LEONARDO/computo_pezzi_16.bmp" width="16" height="16" alt="computo_pezzi_16.bmp"> | <img src="menu/LEONARDO/computo_pezzi.bmp" width="32" height="32" alt="computo_pezzi.bmp"> | Computo Pezzi | [`COMPUTO_PEZZI`](README_UTENTE.md#cmd-computo-pezzi) |
| <img src="menu/LEONARDO/computo_taglio_16.bmp" width="16" height="16" alt="computo_taglio_16.bmp"> | <img src="menu/LEONARDO/computo_taglio.bmp" width="32" height="32" alt="computo_taglio.bmp"> | Computo Taglio | [`COMPUTO_TAGLIO`](README_UTENTE.md#cmd-computo-taglio) |

### FASCIA FIANCO

| Piccola | Grande | Pulsante | Comando |
|:-:|:-:|---|---|
| <img src="menu/LEONARDO/disegnafasciafianco_16.bmp" width="16" height="16" alt="disegnafasciafianco_16.bmp"> | <img src="menu/LEONARDO/disegnafasciafianco.bmp" width="32" height="32" alt="disegnafasciafianco.bmp"> | Disegna Fascia | [`DISEGNAFASCIAFIANCO`](README_UTENTE.md#cmd-disegnafasciafianco) |
| <img src="menu/LEONARDO/fasciafiancoui_16.bmp" width="16" height="16" alt="fasciafiancoui_16.bmp"> | <img src="menu/LEONARDO/fasciafiancoui.bmp" width="32" height="32" alt="fasciafiancoui.bmp"> | Fascia UI | [`FASCIAFIANCOUI`](README_UTENTE.md#cmd-fasciafiancoui) |
| <img src="menu/LEONARDO/fasciafiancoextui_16.bmp" width="16" height="16" alt="fasciafiancoextui_16.bmp"> | <img src="menu/LEONARDO/fasciafiancoextui.bmp" width="32" height="32" alt="fasciafiancoextui.bmp"> | Fascia Ext | [`FASCIAFIANCOEXTUI`](README_UTENTE.md#cmd-fasciafiancoextui) |
| <img src="menu/LEONARDO/fasciafiancomax_16.bmp" width="16" height="16" alt="fasciafiancomax_16.bmp"> | <img src="menu/LEONARDO/fasciafiancomax.bmp" width="32" height="32" alt="fasciafiancomax.bmp"> | Fascia Fianco Max | [`FASCIAFIANCOMAX`](README_UTENTE.md#cmd-fasciafiancomax) |
| <img src="menu/LEONARDO/quadrantearchi_16.bmp" width="16" height="16" alt="quadrantearchi_16.bmp"> | <img src="menu/LEONARDO/quadrantearchi.bmp" width="32" height="32" alt="quadrantearchi.bmp"> | Quadrante ad Archi | [`DISEGNAQUADRANGOLO`](README_UTENTE.md#cmd-disegnaquadrangolo) |
| <img src="menu/LEONARDO/duerettangoli_16.bmp" width="16" height="16" alt="duerettangoli_16.bmp"> | <img src="menu/LEONARDO/duerettangoli.bmp" width="32" height="32" alt="duerettangoli.bmp"> | Due Rettangoli | [`DUERETTANGOLI`](README_UTENTE.md#cmd-duerettangoli) |
| <img src="menu/LEONARDO/duerettangolirac_16.bmp" width="16" height="16" alt="duerettangolirac_16.bmp"> | <img src="menu/LEONARDO/duerettangolirac.bmp" width="32" height="32" alt="duerettangolirac.bmp"> | Due Rettangoli Raccordati | [`DUERETTANGOLIRAC`](README_UTENTE.md#cmd-duerettangolirac) |

### Quadranti

| Piccola | Grande | Pulsante | Comando |
|:-:|:-:|---|---|
| <img src="menu/LEONARDO/quadrantearchi_16.bmp" width="16" height="16" alt="quadrantearchi_16.bmp"> | <img src="menu/LEONARDO/quadrantearchi.bmp" width="32" height="32" alt="quadrantearchi.bmp"> | Quadrante ad Archi (DQ) | [`DISEGNAQUADRANGOLO`](README_UTENTE.md#cmd-disegnaquadrangolo) |
| <img src="menu/LEONARDO/dqmodifica_16.bmp" width="16" height="16" alt="dqmodifica_16.bmp"> | <img src="menu/LEONARDO/dqmodifica.bmp" width="32" height="32" alt="dqmodifica.bmp"> | Modifica Quadrante (DQM) | [`DQMODIFICA`](README_UTENTE.md#cmd-dqmodifica) |
| <img src="menu/LEONARDO/dql_16.bmp" width="16" height="16" alt="dql_16.bmp"> | <img src="menu/LEONARDO/dql.bmp" width="32" height="32" alt="dql.bmp"> | Quadrante a Lunghezze Fisse (DQL) | [`DISEGNAQUADRANGOLOLUNGHEZZE`](README_UTENTE.md#cmd-disegnaquadrangololunghezze) |
| <img src="menu/LEONARDO/dqlm_16.bmp" width="16" height="16" alt="dqlm_16.bmp"> | <img src="menu/LEONARDO/dqlm.bmp" width="32" height="32" alt="dqlm.bmp"> | Modifica a Lunghezze Fisse (DQLM) | [`DQLMODIFICA`](README_UTENTE.md#cmd-dqlmodifica) |
| <img src="menu/LEONARDO/dqf_16.bmp" width="16" height="16" alt="dqf_16.bmp"> | <img src="menu/LEONARDO/dqf.bmp" width="32" height="32" alt="dqf.bmp"> | Fascia sul Quadrante (DQF) | [`DISEGNAFASCIA`](README_UTENTE.md#cmd-disegnafascia) |
| <img src="menu/LEONARDO/dqfm_16.bmp" width="16" height="16" alt="dqfm_16.bmp"> | <img src="menu/LEONARDO/dqfm.bmp" width="32" height="32" alt="dqfm.bmp"> | Fascia con Misure (DQFM) | [`DISEGNAFASCIAMISURE`](README_UTENTE.md#cmd-disegnafasciamisure) |
| <img src="menu/LEONARDO/dqp_16.bmp" width="16" height="16" alt="dqp_16.bmp"> | <img src="menu/LEONARDO/dqp.bmp" width="32" height="32" alt="dqp.bmp"> | Pence e Cannoni (DQP) | [`DISEGNAPENCE`](README_UTENTE.md#cmd-disegnapence) |
| <img src="menu/LEONARDO/dqc_16.bmp" width="16" height="16" alt="dqc_16.bmp"> | <img src="menu/LEONARDO/dqc.bmp" width="32" height="32" alt="dqc.bmp"> | Costruzioni (DQC) | [`DISEGNACOSTRUZIONI`](README_UTENTE.md#cmd-disegnacostruzioni) |
| <img src="menu/LEONARDO/dqi_16.bmp" width="16" height="16" alt="dqi_16.bmp"> | <img src="menu/LEONARDO/dqi.bmp" width="32" height="32" alt="dqi.bmp"> | Importa Quadrante (DQI) | [`IMPORTAQUADRANTE`](README_UTENTE.md#cmd-importaquadrante) |
| <img src="menu/LEONARDO/dqt_16.bmp" width="16" height="16" alt="dqt_16.bmp"> | <img src="menu/LEONARDO/dqt.bmp" width="32" height="32" alt="dqt.bmp"> | Tracciatura (DQT) | [`TRACCIATURA`](README_UTENTE.md#cmd-tracciatura) |

### BLOCCHI AVANZATI

| Piccola | Grande | Pulsante | Comando |
|:-:|:-:|---|---|
| <img src="menu/LEONARDO/blocchi_in_punti_16.bmp" width="16" height="16" alt="blocchi_in_punti_16.bmp"> | <img src="menu/LEONARDO/blocchi_in_punti.bmp" width="32" height="32" alt="blocchi_in_punti.bmp"> | Blocchi in Punti | [`BLOCCHI_IN_PUNTI`](README_UTENTE.md#cmd-blocchi-in-punti) |
| <img src="menu/LEONARDO/blocco_rapido_16.bmp" width="16" height="16" alt="blocco_rapido_16.bmp"> | <img src="menu/LEONARDO/blocco_rapido.bmp" width="32" height="32" alt="blocco_rapido.bmp"> | Blocco Rapido | [`BLOCCO_RAPIDO`](README_UTENTE.md#cmd-blocco-rapido) |
| <img src="menu/LEONARDO/inserisci_blocchi_16.bmp" width="16" height="16" alt="inserisci_blocchi_16.bmp"> | <img src="menu/LEONARDO/inserisci_blocchi.bmp" width="32" height="32" alt="inserisci_blocchi.bmp"> | Inserisci Blocchi su polilinea | [`INSERISCI_BLOCCHI`](README_UTENTE.md#cmd-inserisci-blocchi) |

### UTILITA SISTEMA

| Piccola | Grande | Pulsante | Comando |
|:-:|:-:|---|---|
| <img src="menu/LEONARDO/inizializza_16.bmp" width="16" height="16" alt="inizializza_16.bmp"> | <img src="menu/LEONARDO/inizializza.bmp" width="32" height="32" alt="inizializza.bmp"> | Inizializza | [`INIZIALIZZA2`](README_UTENTE.md#cmd-inizializza2) |
| <img src="menu/LEONARDO/cbp_16.bmp" width="16" height="16" alt="cbp_16.bmp"> | <img src="menu/LEONARDO/cbp.bmp" width="32" height="32" alt="cbp.bmp"> | cambia punto base blocco | [`CBP`](README_UTENTE.md#cmd-cbp) |
| <img src="menu/LEONARDO/cbpr_16.bmp" width="16" height="16" alt="cbpr_16.bmp"> | <img src="menu/LEONARDO/cbpr.bmp" width="32" height="32" alt="cbpr.bmp"> | cambia punto base blocco con riferimento | [`CBPR`](README_UTENTE.md#cmd-cbpr) |

### Utilità Sistema Ext

| Piccola | Grande | Pulsante | Comando |
|:-:|:-:|---|---|
| <img src="menu/LEONARDO/HexDecConverter_16.bmp" width="16" height="16" alt="HexDecConverter_16.bmp"> | <img src="menu/LEONARDO/HexDecConverter.bmp" width="32" height="32" alt="HexDecConverter.bmp"> | Hex/Dec Converter | [`HEXDECCONVERTER`](README_UTENTE.md#cmd-hexdecconverter) |
| <img src="menu/LEONARDO/font_test_16.bmp" width="16" height="16" alt="font_test_16.bmp"> | <img src="menu/LEONARDO/font_test.bmp" width="32" height="32" alt="font_test.bmp"> | Test Font SHX | [`FONT_TEST`](README_UTENTE.md#cmd-font-test) |
| <img src="menu/LEONARDO/CAMBIACOL_16.bmp" width="16" height="16" alt="CAMBIACOL_16.bmp"> | <img src="menu/LEONARDO/CAMBIACOL.bmp" width="32" height="32" alt="CAMBIACOL.bmp"> | Cambia Colore | [`CAMBIACOL`](README_UTENTE.md#cmd-cambiacol) |
| <img src="menu/LEONARDO/TCASE_16.bmp" width="16" height="16" alt="TCASE_16.bmp"> | <img src="menu/LEONARDO/TCASE.bmp" width="32" height="32" alt="TCASE.bmp"> | Maiuscolo/Minuscolo | [`TCASE`](README_UTENTE.md#cmd-tcase) |
| <img src="menu/LEONARDO/chg_16.bmp" width="16" height="16" alt="chg_16.bmp"> | <img src="menu/LEONARDO/chg.bmp" width="32" height="32" alt="chg.bmp"> | Sostituisci Stringa | [`CHG`](README_UTENTE.md#cmd-chg) |
| <img src="menu/LEONARDO/EDT_16.bmp" width="16" height="16" alt="EDT_16.bmp"> | <img src="menu/LEONARDO/EDT.bmp" width="32" height="32" alt="EDT.bmp"> | Ruota Testo | [`EDT`](README_UTENTE.md#cmd-edt) |
| <img src="menu/LEONARDO/ARCOTANG_16.bmp" width="16" height="16" alt="ARCOTANG_16.bmp"> | <img src="menu/LEONARDO/ARCOTANG.bmp" width="32" height="32" alt="ARCOTANG.bmp"> | Arco Tangente | [`ARCOTANG`](README_UTENTE.md#cmd-arcotang) |
| <img src="menu/LEONARDO/splitcir_16.bmp" width="16" height="16" alt="splitcir_16.bmp"> | <img src="menu/LEONARDO/splitcir.bmp" width="32" height="32" alt="splitcir.bmp"> | Spezza Cerchio | [`SPLITCIR`](README_UTENTE.md#cmd-splitcir) |
| <img src="menu/LEONARDO/TROVA_GAP_16.bmp" width="16" height="16" alt="TROVA_GAP_16.bmp"> | <img src="menu/LEONARDO/TROVA_GAP.bmp" width="32" height="32" alt="TROVA_GAP.bmp"> | Trova Gap | [`TROVA_GAP`](README_UTENTE.md#cmd-trova-gap) |
| <img src="menu/LEONARDO/MISURA_CUCITURA_16.bmp" width="16" height="16" alt="MISURA_CUCITURA_16.bmp"> | <img src="menu/LEONARDO/MISURA_CUCITURA.bmp" width="32" height="32" alt="MISURA_CUCITURA.bmp"> | Misura Cucitura | [`MISURA-CUCITURA`](README_UTENTE.md#cmd-misura-cucitura) |

### NESTING AVANZATO

| Piccola | Grande | Pulsante | Comando |
|:-:|:-:|---|---|
| <img src="menu/LEONARDO/nesting_16.bmp" width="16" height="16" alt="nesting_16.bmp"> | <img src="menu/LEONARDO/nesting.bmp" width="32" height="32" alt="nesting.bmp"> | Nesting Base | [`NESTING`](README_UTENTE.md#cmd-nesting) |
| <img src="menu/LEONARDO/nesting-bestfit_16.bmp" width="16" height="16" alt="nesting-bestfit_16.bmp"> | <img src="menu/LEONARDO/nesting-bestfit.bmp" width="32" height="32" alt="nesting-bestfit.bmp"> | Nesting Best Fit | [`NESTING-BESTFIT`](README_UTENTE.md#cmd-nesting-bestfit) |
| <img src="menu/LEONARDO/nesting-bestfit2_16.bmp" width="16" height="16" alt="nesting-bestfit2_16.bmp"> | <img src="menu/LEONARDO/nesting-bestfit2.bmp" width="32" height="32" alt="nesting-bestfit2.bmp"> | Nesting Best Fit 2 | [`NESTING-BESTFIT2`](README_UTENTE.md#cmd-nesting-bestfit2) |
| <img src="menu/LEONARDO/nesting-trueshape3_16.bmp" width="16" height="16" alt="nesting-trueshape3_16.bmp"> | <img src="menu/LEONARDO/nesting-trueshape3.bmp" width="32" height="32" alt="nesting-trueshape3.bmp"> | Nesting True-Shape 3 | [`NESTING-TRUESHAPE3`](README_UTENTE.md#cmd-nesting-trueshape3) |
| <img src="menu/LEONARDO/nesting-ottimizza_16.bmp" width="16" height="16" alt="nesting-ottimizza_16.bmp"> | <img src="menu/LEONARDO/nesting-ottimizza.bmp" width="32" height="32" alt="nesting-ottimizza.bmp"> | Nesting Ottimizzato | [`NESTING-OTTIMIZZA`](README_UTENTE.md#cmd-nesting-ottimizza) |
| <img src="menu/LEONARDO/nesting-centered_16.bmp" width="16" height="16" alt="nesting-centered_16.bmp"> | <img src="menu/LEONARDO/nesting-centered.bmp" width="32" height="32" alt="nesting-centered.bmp"> | Nesting Centrato | [`NESTING-CENTERED`](README_UTENTE.md#cmd-nesting-centered) |
| <img src="menu/LEONARDO/nesting-cluster_16.bmp" width="16" height="16" alt="nesting-cluster_16.bmp"> | <img src="menu/LEONARDO/nesting-cluster.bmp" width="32" height="32" alt="nesting-cluster.bmp"> | Nesting Cluster | [`NESTING-CLUSTER`](README_UTENTE.md#cmd-nesting-cluster) |
| <img src="menu/LEONARDO/nesting-column_16.bmp" width="16" height="16" alt="nesting-column_16.bmp"> | <img src="menu/LEONARDO/nesting-column.bmp" width="32" height="32" alt="nesting-column.bmp"> | Nesting Colonna | [`NESTING-COLUMN`](README_UTENTE.md#cmd-nesting-column) |
| <img src="menu/LEONARDO/nesting-guillotine_16.bmp" width="16" height="16" alt="nesting-guillotine_16.bmp"> | <img src="menu/LEONARDO/nesting-guillotine.bmp" width="32" height="32" alt="nesting-guillotine.bmp"> | Nesting Ghigliottina | [`NESTING-GUILLOTINE`](README_UTENTE.md#cmd-nesting-guillotine) |
| <img src="menu/LEONARDO/nesting-maxrects_16.bmp" width="16" height="16" alt="nesting-maxrects_16.bmp"> | <img src="menu/LEONARDO/nesting-maxrects.bmp" width="32" height="32" alt="nesting-maxrects.bmp"> | Nesting MaxRects | [`NESTING-MAXRECTS`](README_UTENTE.md#cmd-nesting-maxrects) |
| <img src="menu/LEONARDO/nesting-hybrid_16.bmp" width="16" height="16" alt="nesting-hybrid_16.bmp"> | <img src="menu/LEONARDO/nesting-hybrid.bmp" width="32" height="32" alt="nesting-hybrid.bmp"> | Nesting Ibrido | [`NESTING-HYBRID`](README_UTENTE.md#cmd-nesting-hybrid) |
| <img src="menu/LEONARDO/nesting-spiral_16.bmp" width="16" height="16" alt="nesting-spiral_16.bmp"> | <img src="menu/LEONARDO/nesting-spiral.bmp" width="32" height="32" alt="nesting-spiral.bmp"> | Nesting Spirale | [`NESTING-SPIRAL`](README_UTENTE.md#cmd-nesting-spiral) |
| <img src="menu/LEONARDO/nesting-tetris_16.bmp" width="16" height="16" alt="nesting-tetris_16.bmp"> | <img src="menu/LEONARDO/nesting-tetris.bmp" width="32" height="32" alt="nesting-tetris.bmp"> | Nesting Tetris | [`NESTING-TETRIS`](README_UTENTE.md#cmd-nesting-tetris) |
| <img src="menu/LEONARDO/nesting_confronta_16.bmp" width="16" height="16" alt="nesting_confronta_16.bmp"> | <img src="menu/LEONARDO/nesting_confronta.bmp" width="32" height="32" alt="nesting_confronta.bmp"> | Nesting Confronta | [`NESTING_CONFRONTA`](README_UTENTE.md#cmd-nesting-confronta) |
| <img src="menu/LEONARDO/nesting_confronta_imp_16.bmp" width="16" height="16" alt="nesting_confronta_imp_16.bmp"> | <img src="menu/LEONARDO/nesting_confronta_imp.bmp" width="32" height="32" alt="nesting_confronta_imp.bmp"> | Impostazioni Confronto | [`NESTING_CONFRONTA_IMPOSTAZIONI`](README_UTENTE.md#cmd-nesting-confronta-impostazioni) |

### Nesting Base

| Piccola | Grande | Pulsante | Comando |
|:-:|:-:|---|---|
| <img src="menu/LEONARDO/nesting_linea_16.bmp" width="16" height="16" alt="nesting_linea_16.bmp"> | <img src="menu/LEONARDO/nesting_linea.bmp" width="32" height="32" alt="nesting_linea.bmp"> | Nesting Linea | [`NESTINGLINEA`](README_UTENTE.md#cmd-nestinglinea) |
| <img src="menu/LEONARDO/nesting1_16.bmp" width="16" height="16" alt="nesting1_16.bmp"> | <img src="menu/LEONARDO/nesting1.bmp" width="32" height="32" alt="nesting1.bmp"> | Nesting Singola Linea | [`NESTING1`](README_UTENTE.md#cmd-nesting1) |
| <img src="menu/LEONARDO/nestingarea_16.bmp" width="16" height="16" alt="nestingarea_16.bmp"> | <img src="menu/LEONARDO/nestingarea.bmp" width="32" height="32" alt="nestingarea.bmp"> | Nesting Area | [`NESTINGAREA`](README_UTENTE.md#cmd-nestingarea) |
| <img src="menu/LEONARDO/nesting5_16.bmp" width="16" height="16" alt="nesting5_16.bmp"> | <img src="menu/LEONARDO/nesting5.bmp" width="32" height="32" alt="nesting5.bmp"> | Nesting Multi-Riga | [`NESTING5`](README_UTENTE.md#cmd-nesting5) |
| <img src="menu/LEONARDO/nesting51_16.bmp" width="16" height="16" alt="nesting51_16.bmp"> | <img src="menu/LEONARDO/nesting51.bmp" width="32" height="32" alt="nesting51.bmp"> | Nesting Alternato | [`NESTING51`](README_UTENTE.md#cmd-nesting51) |
| <img src="menu/LEONARDO/nesting52_16.bmp" width="16" height="16" alt="nesting52_16.bmp"> | <img src="menu/LEONARDO/nesting52.bmp" width="32" height="32" alt="nesting52.bmp"> | Nesting Ordinato | [`NESTING52`](README_UTENTE.md#cmd-nesting52) |

### Dati Pezzo

| Piccola | Grande | Pulsante | Comando |
|:-:|:-:|---|---|
| <img src="menu/LEONARDO/NOME_PEZZO_16.BMP" width="16" height="16" alt="NOME_PEZZO_16.BMP"> | <img src="menu/LEONARDO/NOME_PEZZO.BMP" width="32" height="32" alt="NOME_PEZZO.BMP"> | Nome Pezzo | [`NOM`](README_UTENTE.md#cmd-nom) |
| <img src="menu/LEONARDO/ed_nome_pezzo_16.bmp" width="16" height="16" alt="ed_nome_pezzo_16.bmp"> | <img src="menu/LEONARDO/ed_nome_pezzo.bmp" width="32" height="32" alt="ed_nome_pezzo.bmp"> | Modifica Nome Pezzo | [`ED-NOM`](README_UTENTE.md#cmd-ed-nom) |
| <img src="menu/LEONARDO/MATERIALE_16.BMP" width="16" height="16" alt="MATERIALE_16.BMP"> | <img src="menu/LEONARDO/MATERIALE.BMP" width="32" height="32" alt="MATERIALE.BMP"> | Materiale | [`MAT`](README_UTENTE.md#cmd-mat) |
| <img src="menu/LEONARDO/ed_materiale_16.bmp" width="16" height="16" alt="ed_materiale_16.bmp"> | <img src="menu/LEONARDO/ed_materiale.bmp" width="32" height="32" alt="ed_materiale.bmp"> | Modifica Materiale | [`ED-MAT`](README_UTENTE.md#cmd-ed-mat) |
| <img src="menu/LEONARDO/ed_numero_materiale_16.bmp" width="16" height="16" alt="ed_numero_materiale_16.bmp"> | <img src="menu/LEONARDO/ed_numero_materiale.bmp" width="32" height="32" alt="ed_numero_materiale.bmp"> | Modifica Quantità/Tipologia | [`ED-MATERIALE`](README_UTENTE.md#cmd-ed-materiale) |
| <img src="menu/LEONARDO/NUM_ART_16.bmp" width="16" height="16" alt="NUM_ART_16.bmp"> | <img src="menu/LEONARDO/NUM_ART.bmp" width="32" height="32" alt="NUM_ART.bmp"> | Numero Articolo | [`NUM`](README_UTENTE.md#cmd-num) |
| <img src="menu/LEONARDO/SPESSORE_16.BMP" width="16" height="16" alt="SPESSORE_16.BMP"> | <img src="menu/LEONARDO/SPESSORE.BMP" width="32" height="32" alt="SPESSORE.BMP"> | Spessore | [`SPESSORE`](README_UTENTE.md#cmd-spessore) |
| <img src="menu/LEONARDO/PELLE_16.BMP" width="16" height="16" alt="PELLE_16.BMP"> | <img src="menu/LEONARDO/PELLE.BMP" width="32" height="32" alt="PELLE.BMP"> | Pelle | [`PEL`](README_UTENTE.md#cmd-pel) |
| <img src="menu/LEONARDO/FOD.BMP" width="16" height="16" alt="FOD.BMP"> | <img src="menu/LEONARDO/FOD.BMP" width="32" height="32" alt="FOD.BMP"> | Fodera | [`FOD`](README_UTENTE.md#cmd-fod) |
| <img src="menu/LEONARDO/ed-INFUST_16.bmp" width="16" height="16" alt="ed-INFUST_16.bmp"> | <img src="menu/LEONARDO/ed-INFUST.bmp" width="32" height="32" alt="ed-INFUST.bmp"> | Definisci Infustitura | [`ED-INFUST`](README_UTENTE.md#cmd-ed-infust) |
| <img src="menu/LEONARDO/ed-FOD_16.bmp" width="16" height="16" alt="ed-FOD_16.bmp"> | <img src="menu/LEONARDO/ed-FOD.bmp" width="32" height="32" alt="ed-FOD.bmp"> | Definisci Fodera | [`ED-FOD`](README_UTENTE.md#cmd-ed-fod) |
| <img src="menu/LEONARDO/ed-RIF_16.bmp" width="16" height="16" alt="ed-RIF_16.bmp"> | <img src="menu/LEONARDO/ed-RIF.bmp" width="32" height="32" alt="ed-RIF.bmp"> | Definisci Rifilo | [`ED-RIF`](README_UTENTE.md#cmd-ed-rif) |
| <img src="menu/LEONARDO/ed-SBOZ_16.bmp" width="16" height="16" alt="ed-SBOZ_16.bmp"> | <img src="menu/LEONARDO/ed-SBOZ.bmp" width="32" height="32" alt="ed-SBOZ.bmp"> | Definisci Sbozzo/Taglio | [`ED-SBOZ`](README_UTENTE.md#cmd-ed-sboz) |

### Lavorazioni e Accessori

| Piccola | Grande | Pulsante | Comando |
|:-:|:-:|---|---|
| <img src="menu/LEONARDO/lavorazione_ins_16.bmp" width="16" height="16" alt="lavorazione_ins_16.bmp"> | <img src="menu/LEONARDO/lavorazione_ins.bmp" width="32" height="32" alt="lavorazione_ins.bmp"> | Inserisci Lavorazione | [`LAV`](README_UTENTE.md#cmd-lav) |
| <img src="menu/LEONARDO/lavorazione_edit_16.bmp" width="16" height="16" alt="lavorazione_edit_16.bmp"> | <img src="menu/LEONARDO/lavorazione_edit.bmp" width="32" height="32" alt="lavorazione_edit.bmp"> | Modifica Lavorazione | [`ED-LAV`](README_UTENTE.md#cmd-ed-lav) |
| <img src="menu/LEONARDO/lavorazione_db_16.bmp" width="16" height="16" alt="lavorazione_db_16.bmp"> | <img src="menu/LEONARDO/lavorazione_db.bmp" width="32" height="32" alt="lavorazione_db.bmp"> | Database Lavorazioni | [`ED-DB-LAV`](README_UTENTE.md#cmd-ed-db-lav) |
| <img src="menu/LEONARDO/lavorazione_data_16.bmp" width="16" height="16" alt="lavorazione_data_16.bmp"> | <img src="menu/LEONARDO/lavorazione_data.bmp" width="32" height="32" alt="lavorazione_data.bmp"> | Crea Blocco Dati Lavorazioni | [`CREA-DATLAV`](README_UTENTE.md#cmd-crea-datlav) |
| <img src="menu/LEONARDO/accessorio_ins_16.bmp" width="16" height="16" alt="accessorio_ins_16.bmp"> | <img src="menu/LEONARDO/accessorio_ins.bmp" width="32" height="32" alt="accessorio_ins.bmp"> | Inserisci Accessorio | [`ACC`](README_UTENTE.md#cmd-acc) |
| <img src="menu/LEONARDO/accessorio_edit_16.bmp" width="16" height="16" alt="accessorio_edit_16.bmp"> | <img src="menu/LEONARDO/accessorio_edit.bmp" width="32" height="32" alt="accessorio_edit.bmp"> | Modifica Accessorio | [`ED-ACC`](README_UTENTE.md#cmd-ed-acc) |
| <img src="menu/LEONARDO/accessorio_db_16.bmp" width="16" height="16" alt="accessorio_db_16.bmp"> | <img src="menu/LEONARDO/accessorio_db.bmp" width="32" height="32" alt="accessorio_db.bmp"> | Database Accessori | [`ED-DB-ACC`](README_UTENTE.md#cmd-ed-db-acc) |
| <img src="menu/LEONARDO/accessorio_data_16.bmp" width="16" height="16" alt="accessorio_data_16.bmp"> | <img src="menu/LEONARDO/accessorio_data.bmp" width="32" height="32" alt="accessorio_data.bmp"> | Crea Blocco Dati Accessori | [`CREA-DATACC`](README_UTENTE.md#cmd-crea-datacc) |

### Gestione Materiali DB

| Piccola | Grande | Pulsante | Comando |
|:-:|:-:|---|---|
| <img src="menu/LEONARDO/gestmat_16.bmp" width="16" height="16" alt="gestmat_16.bmp"> | <img src="menu/LEONARDO/gestmat.bmp" width="32" height="32" alt="gestmat.bmp"> | Database Materiali | [`GESTMAT`](README_UTENTE.md#cmd-gestmat) |
| <img src="menu/LEONARDO/gnames_16.bmp" width="16" height="16" alt="gnames_16.bmp"> | <img src="menu/LEONARDO/gnames.bmp" width="32" height="32" alt="gnames.bmp"> | Database Nomi | [`GNAMES`](README_UTENTE.md#cmd-gnames) |
| <img src="menu/LEONARDO/sostmat_16.bmp" width="16" height="16" alt="sostmat_16.bmp"> | <img src="menu/LEONARDO/sostmat.bmp" width="32" height="32" alt="sostmat.bmp"> | Sostituisci Materiale (batch) | [`SOSTMAT`](README_UTENTE.md#cmd-sostmat) |
| <img src="menu/LEONARDO/mat1_16.bmp" width="16" height="16" alt="mat1_16.bmp"> | <img src="menu/LEONARDO/mat1.bmp" width="32" height="32" alt="mat1.bmp"> | Visualizza per Materiale | [`MAT1`](README_UTENTE.md#cmd-mat1) |
| <img src="menu/LEONARDO/seleziona-permat_16.bmp" width="16" height="16" alt="seleziona-permat_16.bmp"> | <img src="menu/LEONARDO/seleziona-permat.bmp" width="32" height="32" alt="seleziona-permat.bmp"> | Seleziona per Materiale | [`SELEZIONA-PERMAT`](README_UTENTE.md#cmd-seleziona-permat) |
| <img src="menu/LEONARDO/mappamat_16.bmp" width="16" height="16" alt="mappamat_16.bmp"> | <img src="menu/LEONARDO/mappamat.bmp" width="32" height="32" alt="mappamat.bmp"> | Mappa dei Materiali | [`MAPPAMAT`](README_UTENTE.md#cmd-mappamat) |
| <img src="menu/LEONARDO/mappacat_16.bmp" width="16" height="16" alt="mappacat_16.bmp"> | <img src="menu/LEONARDO/mappacat.bmp" width="32" height="32" alt="mappacat.bmp"> | Mappa delle Categorie | [`MAPPACAT`](README_UTENTE.md#cmd-mappacat) |
| <img src="menu/LEONARDO/controlla_16.bmp" width="16" height="16" alt="controlla_16.bmp"> | <img src="menu/LEONARDO/controlla.bmp" width="32" height="32" alt="controlla.bmp"> | Controllo dei Pezzi | [`CONTROLLA`](README_UTENTE.md#cmd-controlla) |

### Fustelle

| Piccola | Grande | Pulsante | Comando |
|:-:|:-:|---|---|
| <img src="menu/LEONARDO/leo_fust_P_16.bmp" width="16" height="16" alt="leo_fust_P_16.bmp"> | <img src="menu/LEONARDO/leo_fust_P.bmp" width="32" height="32" alt="leo_fust_P.bmp"> | Fustella P | [`LEO_FUST`](README_UTENTE.md#cmd-leo-fust) |
| <img src="menu/LEONARDO/leo_fust_0_8_16.bmp" width="16" height="16" alt="leo_fust_0_8_16.bmp"> | <img src="menu/LEONARDO/leo_fust_0_8.bmp" width="32" height="32" alt="leo_fust_0_8.bmp"> | Fustella 0.8mm | [`LEO_FUST`](README_UTENTE.md#cmd-leo-fust) |
| <img src="menu/LEONARDO/leo_fust_1_16.bmp" width="16" height="16" alt="leo_fust_1_16.bmp"> | <img src="menu/LEONARDO/leo_fust_1.bmp" width="32" height="32" alt="leo_fust_1.bmp"> | Fustella 1mm | [`LEO_FUST`](README_UTENTE.md#cmd-leo-fust) |
| <img src="menu/LEONARDO/leo_fust_1_5_16.bmp" width="16" height="16" alt="leo_fust_1_5_16.bmp"> | <img src="menu/LEONARDO/leo_fust_1_5.bmp" width="32" height="32" alt="leo_fust_1_5.bmp"> | Fustella 1.5mm | [`LEO_FUST`](README_UTENTE.md#cmd-leo-fust) |
| <img src="menu/LEONARDO/leo_fust_2_16.bmp" width="16" height="16" alt="leo_fust_2_16.bmp"> | <img src="menu/LEONARDO/leo_fust_2.bmp" width="32" height="32" alt="leo_fust_2.bmp"> | Fustella 2mm | [`LEO_FUST`](README_UTENTE.md#cmd-leo-fust) |
| <img src="menu/LEONARDO/leo_fust_2_5_16.bmp" width="16" height="16" alt="leo_fust_2_5_16.bmp"> | <img src="menu/LEONARDO/leo_fust_2_5.bmp" width="32" height="32" alt="leo_fust_2_5.bmp"> | Fustella 2.5mm | [`LEO_FUST`](README_UTENTE.md#cmd-leo-fust) |
| <img src="menu/LEONARDO/leo_fust_3_16.bmp" width="16" height="16" alt="leo_fust_3_16.bmp"> | <img src="menu/LEONARDO/leo_fust_3.bmp" width="32" height="32" alt="leo_fust_3.bmp"> | Fustella 3mm | [`LEO_FUST`](README_UTENTE.md#cmd-leo-fust) |
| <img src="menu/LEONARDO/leo_fust_3_5_16.bmp" width="16" height="16" alt="leo_fust_3_5_16.bmp"> | <img src="menu/LEONARDO/leo_fust_3_5.bmp" width="32" height="32" alt="leo_fust_3_5.bmp"> | Fustella 3.5mm | [`LEO_FUST`](README_UTENTE.md#cmd-leo-fust) |
| <img src="menu/LEONARDO/leo_fust_4_16.bmp" width="16" height="16" alt="leo_fust_4_16.bmp"> | <img src="menu/LEONARDO/leo_fust_4.bmp" width="32" height="32" alt="leo_fust_4.bmp"> | Fustella 4mm | [`LEO_FUST`](README_UTENTE.md#cmd-leo-fust) |
| <img src="menu/LEONARDO/leo_fust_4_5_16.bmp" width="16" height="16" alt="leo_fust_4_5_16.bmp"> | <img src="menu/LEONARDO/leo_fust_4_5.bmp" width="32" height="32" alt="leo_fust_4_5.bmp"> | Fustella 4.5mm | [`LEO_FUST`](README_UTENTE.md#cmd-leo-fust) |
| <img src="menu/LEONARDO/leo_fust_5_16.bmp" width="16" height="16" alt="leo_fust_5_16.bmp"> | <img src="menu/LEONARDO/leo_fust_5.bmp" width="32" height="32" alt="leo_fust_5.bmp"> | Fustella 5mm | [`LEO_FUST`](README_UTENTE.md#cmd-leo-fust) |
| <img src="menu/LEONARDO/leo_fust_6_16.bmp" width="16" height="16" alt="leo_fust_6_16.bmp"> | <img src="menu/LEONARDO/leo_fust_6.bmp" width="32" height="32" alt="leo_fust_6.bmp"> | Fustella 6mm | [`LEO_FUST`](README_UTENTE.md#cmd-leo-fust) |

### Modaris

| Piccola | Grande | Pulsante | Comando |
|:-:|:-:|---|---|
| <img src="menu/LEONARDO/Modaris-AAMA_16.bmp" width="16" height="16" alt="Modaris-AAMA_16.bmp"> | <img src="menu/LEONARDO/Modaris-AAMA.bmp" width="32" height="32" alt="Modaris-AAMA.bmp"> | Modaris AAMA | [`MODARIS-AAMA`](README_UTENTE.md#cmd-modaris-aama) |
| <img src="menu/LEONARDO/MA-config_16.bmp" width="16" height="16" alt="MA-config_16.bmp"> | <img src="menu/LEONARDO/MA-config.bmp" width="32" height="32" alt="MA-config.bmp"> | Modaris Config | [`MA-CONFIG`](README_UTENTE.md#cmd-ma-config) |
| <img src="menu/LEONARDO/modaris_batch_16.bmp" width="16" height="16" alt="modaris_batch_16.bmp"> | <img src="menu/LEONARDO/modaris_batch.bmp" width="32" height="32" alt="modaris_batch.bmp"> | Modaris su Cartella | [`MODARIS-AAMA-BATCH`](README_UTENTE.md#cmd-modaris-aama-batch) |
| <img src="menu/LEONARDO/CONP_16.bmp" width="16" height="16" alt="CONP_16.bmp"> | <img src="menu/LEONARDO/CONP.bmp" width="32" height="32" alt="CONP.bmp"> | CONP - Centro Polilinee | [`CONP`](README_UTENTE.md#cmd-conp) |
| <img src="menu/LEONARDO/conp_c_16.bmp" width="16" height="16" alt="conp_c_16.bmp"> | <img src="menu/LEONARDO/conp_c.bmp" width="32" height="32" alt="conp_c.bmp"> | CONP_C - Cerchi in Punti | [`CONP_C`](README_UTENTE.md#cmd-conp-c) |

### Diciture Standard

| Piccola | Grande | Pulsante | Comando |
|:-:|:-:|---|---|
| <img src="menu/LEONARDO/dicitura_16.bmp" width="16" height="16" alt="dicitura_16.bmp"> | <img src="menu/LEONARDO/dicitura.bmp" width="32" height="32" alt="dicitura.bmp"> | Testo Personalizzato | [`DICITURA`](README_UTENTE.md#cmd-dicitura) |
| <img src="menu/LEONARDO/EDG_16.bmp" width="16" height="16" alt="EDG_16.bmp"> | <img src="menu/LEONARDO/EDG.bmp" width="32" height="32" alt="EDG.bmp"> | COSTOLA | [`EDG`](README_UTENTE.md#cmd-edg) |
| <img src="menu/LEONARDO/FIL_16.bmp" width="16" height="16" alt="FIL_16.bmp"> | <img src="menu/LEONARDO/FIL.bmp" width="32" height="32" alt="FIL.bmp"> | FILO | [`FIL`](README_UTENTE.md#cmd-fil) |
| <img src="menu/LEONARDO/SCA_16.bmp" width="16" height="16" alt="SCA_16.bmp"> | <img src="menu/LEONARDO/SCA.bmp" width="32" height="32" alt="SCA.bmp"> | SCARNIRE | [`SCA`](README_UTENTE.md#cmd-sca) |
| <img src="menu/LEONARDO/SOT_16.bmp" width="16" height="16" alt="SOT_16.bmp"> | <img src="menu/LEONARDO/SOT.bmp" width="32" height="32" alt="SOT.bmp"> | SOTTOMETTITURA | [`SOT`](README_UTENTE.md#cmd-sot) |
| <img src="menu/LEONARDO/RIM_16.bmp" width="16" height="16" alt="RIM_16.bmp"> | <img src="menu/LEONARDO/RIM.bmp" width="32" height="32" alt="RIM.bmp"> | RIMBOCCO | [`RIM`](README_UTENTE.md#cmd-rim) |
| <img src="menu/LEONARDO/TAL_16.bmp" width="16" height="16" alt="TAL_16.bmp"> | <img src="menu/LEONARDO/TAL.bmp" width="32" height="32" alt="TAL.bmp"> | TALYN | [`TAL`](README_UTENTE.md#cmd-tal) |
| <img src="menu/LEONARDO/SAL_16.bmp" width="16" height="16" alt="SAL_16.bmp"> | <img src="menu/LEONARDO/SAL.bmp" width="32" height="32" alt="SAL.bmp"> | SALPA | [`SAL`](README_UTENTE.md#cmd-sal) |
| <img src="menu/LEONARDO/ANT_16.bmp" width="16" height="16" alt="ANT_16.bmp"> | <img src="menu/LEONARDO/ANT.bmp" width="32" height="32" alt="ANT.bmp"> | ANTISTRAPPO | [`ANT`](README_UTENTE.md#cmd-ant) |
| <img src="menu/LEONARDO/BOM_16.bmp" width="16" height="16" alt="BOM_16.bmp"> | <img src="menu/LEONARDO/BOM.bmp" width="32" height="32" alt="BOM.bmp"> | BOMBATURA | [`BOM`](README_UTENTE.md#cmd-bom) |
| <img src="menu/LEONARDO/RIN_16.bmp" width="16" height="16" alt="RIN_16.bmp"> | <img src="menu/LEONARDO/RIN.bmp" width="32" height="32" alt="RIN.bmp"> | RINFORZO | [`RIN`](README_UTENTE.md#cmd-rin) |
| <img src="menu/LEONARDO/BOR_16.bmp" width="16" height="16" alt="BOR_16.bmp"> | <img src="menu/LEONARDO/BOR.bmp" width="32" height="32" alt="BOR.bmp"> | BORDATURA | [`BOR`](README_UTENTE.md#cmd-bor) |
| <img src="menu/LEONARDO/VAL_16.bmp" width="16" height="16" alt="VAL_16.bmp"> | <img src="menu/LEONARDO/VAL.bmp" width="32" height="32" alt="VAL.bmp"> | VALIGIAIA | [`VAL`](README_UTENTE.md#cmd-val) |
| <img src="menu/LEONARDO/C5_16.bmp" width="16" height="16" alt="C5_16.bmp"> | <img src="menu/LEONARDO/C5.bmp" width="32" height="32" alt="C5.bmp"> | CUC.ROV. 5MM | [`C5`](README_UTENTE.md#cmd-c5) |
| <img src="menu/LEONARDO/C5P_16.bmp" width="16" height="16" alt="C5P_16.bmp"> | <img src="menu/LEONARDO/C5P.bmp" width="32" height="32" alt="C5P.bmp"> | CUC.ROV. 5MM + PIPING | [`C5P`](README_UTENTE.md#cmd-c5p) |
| <img src="menu/LEONARDO/C7_16.bmp" width="16" height="16" alt="C7_16.bmp"> | <img src="menu/LEONARDO/C7.bmp" width="32" height="32" alt="C7.bmp"> | CUC.ROV. 7MM | [`C7`](README_UTENTE.md#cmd-c7) |
| <img src="menu/LEONARDO/C7P_16.bmp" width="16" height="16" alt="C7P_16.bmp"> | <img src="menu/LEONARDO/C7P.bmp" width="32" height="32" alt="C7P.bmp"> | CUC.ROV. 7MM + PIPING | [`C7P`](README_UTENTE.md#cmd-c7p) |
| <img src="menu/LEONARDO/c5a_16.bmp" width="16" height="16" alt="c5a_16.bmp"> | <img src="menu/LEONARDO/c5a.bmp" width="32" height="32" alt="c5a.bmp"> | CUC.ROV. 5MM APERTA | [`C5A`](README_UTENTE.md#cmd-c5a) |
| <img src="menu/LEONARDO/c7a_16.bmp" width="16" height="16" alt="c7a_16.bmp"> | <img src="menu/LEONARDO/c7a.bmp" width="32" height="32" alt="c7a.bmp"> | CUC.ROV. 7MM APERTA | [`C7A`](README_UTENTE.md#cmd-c7a) |
| <img src="menu/LEONARDO/crov_16.bmp" width="16" height="16" alt="crov_16.bmp"> | <img src="menu/LEONARDO/crov.bmp" width="32" height="32" alt="crov.bmp"> | CUC.ROV. a misura | [`CROV`](README_UTENTE.md#cmd-crov) |
| <img src="menu/LEONARDO/crovp_16.bmp" width="16" height="16" alt="crovp_16.bmp"> | <img src="menu/LEONARDO/crovp.bmp" width="32" height="32" alt="crovp.bmp"> | CUC.ROV. a misura + PIPING | [`CROVP`](README_UTENTE.md#cmd-crovp) |
| <img src="menu/LEONARDO/crova_16.bmp" width="16" height="16" alt="crova_16.bmp"> | <img src="menu/LEONARDO/crova.bmp" width="32" height="32" alt="crova.bmp"> | CUC.ROV. a misura RIAPERTA | [`CROVA`](README_UTENTE.md#cmd-crova) |
| <img src="menu/LEONARDO/crovar_16.bmp" width="16" height="16" alt="crovar_16.bmp"> | <img src="menu/LEONARDO/crovar.bmp" width="32" height="32" alt="crovar.bmp"> | CUC.ROV. a misura RIAPERTA E RIBADITA | [`CROVAR`](README_UTENTE.md#cmd-crovar) |
| <img src="menu/LEONARDO/cip_16.bmp" width="16" height="16" alt="cip_16.bmp"> | <img src="menu/LEONARDO/cip.bmp" width="32" height="32" alt="cip.bmp"> | CUC. IN PIEDI | [`CIP`](README_UTENTE.md#cmd-cip) |
| <img src="menu/LEONARDO/VR_16.bmp" width="16" height="16" alt="VR_16.bmp"> | <img src="menu/LEONARDO/VR.bmp" width="32" height="32" alt="VR.bmp"> | Direzione Verticale | [`VR`](README_UTENTE.md#cmd-vr) |
| <img src="menu/LEONARDO/OR_16.bmp" width="16" height="16" alt="OR_16.bmp"> | <img src="menu/LEONARDO/OR.bmp" width="32" height="32" alt="OR.bmp"> | Direzione Orizzontale | [`OR`](README_UTENTE.md#cmd-or) |
| <img src="menu/LEONARDO/WAR_16.bmp" width="16" height="16" alt="WAR_16.bmp"> | <img src="menu/LEONARDO/WAR.bmp" width="32" height="32" alt="WAR.bmp"> | Attenzione | [`WAR`](README_UTENTE.md#cmd-war) |
| <img src="menu/LEONARDO/EQ_16.bmp" width="16" height="16" alt="EQ_16.bmp"> | <img src="menu/LEONARDO/EQ.bmp" width="32" height="32" alt="EQ.bmp"> | Equalizzare | [`EQ`](README_UTENTE.md#cmd-eq) |
| <img src="menu/LEONARDO/TABT_16.bmp" width="16" height="16" alt="TABT_16.bmp"> | <img src="menu/LEONARDO/TABT.bmp" width="32" height="32" alt="TABT.bmp"> | Tabella Testi | [`TABT`](README_UTENTE.md#cmd-tabt) |
| <img src="menu/LEONARDO/PELLE_ind_16.bmp" width="16" height="16" alt="PELLE_ind_16.bmp"> | <img src="menu/LEONARDO/PELLE_ind.bmp" width="32" height="32" alt="PELLE_ind.bmp"> | Pelle | [`PEL`](README_UTENTE.md#cmd-pel) |
| <img src="menu/LEONARDO/FOD_ind_16.bmp" width="16" height="16" alt="FOD_ind_16.bmp"> | <img src="menu/LEONARDO/FOD_ind.bmp" width="32" height="32" alt="FOD_ind.bmp"> | Fodera | [`FOD`](README_UTENTE.md#cmd-fod) |

## Comandi dei plugin senza voce di menu

Questi comandi esistono nei plugin ma non hanno (ancora) una voce nel menu: si digitano sulla riga di comando.

- [`AAMA_NEST_SETUP`](README_UTENTE.md#cmd-aama-nest-setup)
- [`AAMA_RUN_FOLDER`](README_UTENTE.md#cmd-aama-run-folder)
- [`CAMBIALAYERBATCH`](README_UTENTE.md#cmd-cambialayerbatch)
- [`CERCASAGOME3`](README_UTENTE.md#cmd-cercasagome3)
- [`COMPARA`](README_UTENTE.md#cmd-compara)
- [`COMPARAMODELLI`](README_UTENTE.md#cmd-comparamodelli)
- [`CONTROLLA_CONTORNI_CORREGGI`](README_UTENTE.md#cmd-controlla-contorni-correggi)
- [`CONTROLLA_CONTORNI_GIRO`](README_UTENTE.md#cmd-controlla-contorni-giro)
- [`CONTROLLA_CONTORNI_SEMPLICI`](README_UTENTE.md#cmd-controlla-contorni-semplici)
- [`CONTROLLA_CORREGGI`](README_UTENTE.md#cmd-controlla-correggi)
- [`CONTROLLA_GIRO`](README_UTENTE.md#cmd-controlla-giro)
- [`CS3`](README_UTENTE.md#cmd-cs3)
- [`CS3AGGIUNGI`](README_UTENTE.md#cmd-cs3aggiungi)
- [`DG`](README_UTENTE.md#cmd-dg)
- [`DISEGNAGUANTI`](README_UTENTE.md#cmd-disegnaguanti)
- [`DQ`](README_UTENTE.md#cmd-dq)
- [`DQC`](README_UTENTE.md#cmd-dqc)
- [`DQF`](README_UTENTE.md#cmd-dqf)
- [`DQFM`](README_UTENTE.md#cmd-dqfm)
- [`DQI`](README_UTENTE.md#cmd-dqi)
- [`DQL`](README_UTENTE.md#cmd-dql)
- [`DQLM`](README_UTENTE.md#cmd-dqlm)
- [`DQM`](README_UTENTE.md#cmd-dqm)
- [`DQP`](README_UTENTE.md#cmd-dqp)
- [`DQT`](README_UTENTE.md#cmd-dqt)
- [`PIE`](README_UTENTE.md#cmd-pie)
- [`PLDREV`](README_UTENTE.md#cmd-pldrev)
- [`SCHEDA_ESEGUI`](README_UTENTE.md#cmd-scheda-esegui)
- [`SPRO`](README_UTENTE.md#cmd-spro)
- [`SPROC`](README_UTENTE.md#cmd-sproc)
- [`SPROH`](README_UTENTE.md#cmd-sproh)
- [`TRAD`](README_UTENTE.md#cmd-trad)
- [`TRAD-DICT`](README_UTENTE.md#cmd-trad-dict)
- [`TRAD-SETUP`](README_UTENTE.md#cmd-trad-setup)
- [`VLMOVEROTATE`](README_UTENTE.md#cmd-vlmoverotate)

## Scorciatoie da tastiera

| Tasti | Comando |
|---|---|
| `CONTROL+Q` | `DIMALIGNED` |
| `CONTROL+E` | `EXTEND` |
| `CONTROL+W` | `TRIM` |
| `TOOLBAR+F6` | [`CUCITURA`](README_UTENTE.md#cmd-cucitura) |
| `TOOLBAR+F5` | [`CONTINUA`](README_UTENTE.md#cmd-continua) |
