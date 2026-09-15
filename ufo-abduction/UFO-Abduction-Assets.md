# UFO ABDUCTION — Daftar Aset & Scene
### Nama di sini RESMI. AI dilarang mengarang nama lain. Update file ini tiap tambah aset.

## Scene
| Nama | Guna |
|---|---|
| `Map-80x80` | Scene utama (SATU-SATUNYA di Build) |
| `Sandbox_Nama` | Test per fitur, TIDAK masuk Build |

## Prefab Player & FX
| Nama | Guna |
|---|---|
| `UFO` | cakram + kubah + lampu + blob shadow, tag `Player` |
| `FX_BeamCone` | cone transparan + lingkaran hijau tanah |
| `FX_AbductParticles` | partikel naik saat angkat |
| `FX_SpotlightCone` | cone sorot polisi (kuning) / senter (putih) |

## Prefab Agen
| Nama | AI file | Catatan |
|---|---|---|
| `Human_Sipil` | HumanAI.cs | kapsul + kepala, baju beda per instance via material |
| `Chicken_Ayam` | ChickenAI.cs | kandang pinggir |
| `Cow_Sapi` | CowAI.cs | kandang pinggir |
| `Human_Bram` | BramAI.cs | petani + garpu, di kandang |
| `Car_Police` | PoliceCarAI.cs | box + strobo + sorot, path jalan utama |
| `Police_Kaki` | FootPoliceAI.cs | spawn dari mobil saat L2 |
| `Heli` | HelicopterAI.cs | orbit, spawn saat L3 |

## Prefab Props
`House_Atap` (cover sorot) · `Barn_Kandang` · `Lamp_Jalan` · `Barricade` (L3) · `DropZone` (ungu, edge utara) · `Pos_Polisi` · `Tree_Pisang` (cover heli) · `Stone_BatuBram` (proyektil, pooled).

## Tuning
`Tuning.asset` (ScriptableObjects/Tuning/) — SATU file semua angka. Field ikut GDD Section 5–6.

## Audio (mono, <44kHz)
`beam_loop` · `pop` · `siren` · `scream1` `scream2` · `music_night` · `throw_stone` · `combo`.

## Sumber & Lisensi (isi saat import)
| Aset | Sumber | Lisensi |
|---|---|---|
| (contoh) Mini Village | Asset Store | Standard EULA |
| (contoh) UFO CC0 | CGTrader | CC0, tanpa kredit |
