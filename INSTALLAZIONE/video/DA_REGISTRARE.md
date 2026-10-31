# Video da registrare per il sito

Clip brevi (10-25 s), senza audio, 1280x720, MP4 (H.264) + poster JPG.
CAD: ZWCAD 2024 con Leonardo in `C:\LEONARDO`. Disegno nuovo, sfondo scuro, menu LEONARDO visibile.
Nel disegno i clic non selezionano bene: usare `_L`, `_W` o coordinate scritte.

Quando un video è pronto: mettilo in questa cartella e aggiungi una riga in `VIDEO` dentro `index.html`
(`["nome.mp4","Didascalia"]`): la sezione video della galleria compare da sola.

| # | File | Cosa si vede | Comandi |
|---|---|---|---|
| 1 | `dq.mp4` | Dalla finestra del quadrante al pezzo nel disegno: cambio dei raggi, anteprima, Disegna | `DQ` |
| 2 | `dqt.mp4` | Tracciatura fondo tondo → bocca rettangolare, sviluppo nel disegno | `DQT` |
| 3 | `contorni.mp4` | Contorno con un buco e tratti staccati: controllo, "Correggi i semplici", contorno chiuso | `CONTROLLA_CONTORNI` |
| 4 | `tacche.mp4` | Tacche a misura sul contorno, poi tagliate a V | `TACCA_DA_MISURA`, `METTI_V` |
| 5 | `dati.mp4` | Nome e materiale ai pezzi, poi la mappa colorata dei materiali | `NOM`, `MAT`, `MAPPAMAT` |
| 6 | `nesting.mp4` | Confronto delle strategie, scelta della migliore, pezzi sulla tavola | `NESTING_CONFRONTA` |
| 7 | `consumi.mp4` | Calcolo consumi e documento HTML dei risultati | `NOG` |
| 8 | `aama.mp4` | Controllo dei pezzi AAMA e scrittura del DXF | `AAMA`, `AAMA_ESTRAI` |

Registrazione: `ffmpeg` di ZWCAD 2026 (`C:\Program Files\ZWSOFT\ZWCAD 2026\ffmpeg.exe`), cattura `gdigrab` della finestra del CAD,
poi `-vf scale=1280:-2 -c:v libx264 -crf 26 -preset slow -movflags +faststart -an`.
