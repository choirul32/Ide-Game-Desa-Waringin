# GDD — UFO ABDUCTION (Top-Down 3D)
### Game Design Document v1.0 | Unity 6 URP Android | Solo, 2-3 minggu MVP

## 1. High Concept
Kamu alien nyasar dengan piring terbang di atas desa kecil malam hari. Sedot manusia dan hewan dengan beam tractor, hindari sistem polisi 4 level, deposit tangkapan sebelum kapasitas penuh. Satu run 5 menit: skor setinggi-tingginya, jangan crash.

- Genre: arcade action / casual abduction, top-down 3D.
- Platform: Android (portrait atau landscape, 1 layar penuh, no zoom).
- Audience: pemain kasual 13+, sesi pendek, offline, tanpa akun.
- Fantasy inti: jadi UFO yang ditakuti + komedi panik warga.

## 2. Design Pillars
1. **Beam terasa enak** — 70% fun dari feel sedot (partikel, suara, shake, slowmo).
2. **Satu ancaman, jelas** — hanya polisi; mudah dibaca, adil, bisa diakali.
3. **Risk-reward tiap target** — poin besar = bahaya besar.
4. **Run pendek, nagih** — 5 menit, highscore lokal, upgrade antar run.

## 3. Core Loop (30 detik)
Terbang cari target → kunci (auto dalam radius 4m) → tahan BEAM 1,5 detik → target keangkat (+skor, +meter) → kapasitas 3 penuh → terbang ke drop zone → deposit (meter -50%, HP +1, uang) → belanja upgrade → ulangi. Fail: HP 0 = crash = game over.

## 4. Mekanik Pemain
### 4.1 Gerak
- Rigidbody kinematic + MovePosition. Kecepatan 8 m/s, akselerasi instan (arcade, anti drift).
- Joystick virtual kiri 8 arah. UFO miring visual ke arah gerak (tilt max 12°, kosmetik).
- Bayangan blob di tanah = info posisi presisi (wajib, bukan hiasan).

### 4.2 Beam Tractor
- Tombol kanan BEAM (tahan). Auto-kunci 1 target terdekat dalam radius 4m di bawah UFO.
- Target dalam lingkaran hijau 1,5 detik → fase meronta 1 detik (goyang + kaki ke atas) → terangkat (lerp ke perut UFO 0,8 detik).
- Panas: tahan max 5 detik → overheat, cooldown paksa 2 detik. Mencegah sedot nonstop + memaksa timing.
- Visual: cone transparan + partikel naik + lingkaran hijau di tanah + lampu kedip di titik target.
- Audio: dengung naik pitch saat mengangkat + "pop" sukses.

### 4.3 Kapasitas, HP, Uang
- Kapasitas 3. Penuh = beam mati + panah tepi layar arah drop zone.
- HP 3. Kena sorot penuh 3 detik = drop 1 tangkapan + HP -1. HP 0 = crash.
- Deposit: meter wanted -50%, HP +1, uang masuk. Uang = skor + currency upgrade.

## 5. Sistem Wanted (Polisi)
### 5.1 Meter
- 0–100. +15 per abduction. -2/detik saat beam mati DAN jauh dari sorot (>15m).
- Ambang: L1 ≥30, L2 ≥60, L3 =100.

### 5.2 Level & Isi
- **L0 Aman (0–29):** 1 mobil patroli keliling path, lampu mati. Bebas sedot.
- **L1 Curiga (30–59):** mobil berhenti, sorot sweeping (rotasi 40°/detik). Kena sorot 2 detik = ketahuan (meter +20 instan). Counter: terbang rendah di balik rumah/pohon, matikan beam 3 detik.
- **L2 Kejar (60–99):** +1 mobil + 2 polisi kaki keluar dari mobil. Mobil cepat (10 m/s) tapi hanya di jalan utama. Polisi kaki lambat (3 m/s) bawa senter cone; manusia yang kena senter kabur ke rumah (susah disedot).
- **L3 Lockdown (100):** helikopter orbit radius 12m delay 2 detik (selalu ketinggalan dikit) + spotlight besar + barikade blokir jalan utama. Turun ke <60 untuk keluar L3 (deposit adalah jalan tercepat).

### 5.3 AI Polisi (murah, tanpa NavMesh)
- Mobil: array waypoint jalan utama, loop. Lihat UFO = raycast jarak <20m + sudut depan 60°. Kejar = menuju POSISI TERAKHIR terlihat (bisa dikibuli belok gang).
- Polisi kaki: seek titik sorotan, senter cone 8m. Keluar/masuk mobil otomatis saat L2 on/off.
- Helikopter: orbit target + delay posisi 2 detik + spotlight cone 6m. Tak bisa ditembak, hanya dihindari.
- Keadilan: sorot butuh 3 detik PENUH terkunci untuk damage; putus 0,5 detik = reset. Pemain selalu tahu bahaya (cone kuning jelas + bunyi sirene + meter merah).

## 6. Target & Poin
| Target | Poin | Perilaku | Beam time | Catatan |
|---|---|---|---|---|
| Ayam | 10 | random waypoint cepat, kandang terbuka | 1,0 dtk | farming aman |
| Sapi | 30 | lambat, meraung, susah panik | 2,0 dtk | gampang kena, lama angkat |
| Manusia | 50 | cuek → panik zigzag + "!" → pasrah angkat tangan | 1,5 dtk | inti permainan |
| Petani shotgun | 150 | kejar UFO, lempar batu (1 HP jika kena, cooldown 4 dtk) | 1,5 dtk | high risk |
| Polisi kaki | 150 | bisa disedot; temannya terus menyorot | 1,5 dtk | high risk |

- Combo: 3 abduction dalam 10 detik = x2 + teks + suara meriah. Timer combo tampil di HUD.
- Spawn: ayam/sapi di kandang (respawn 20 detik, max 6). Manusia 12 berkeliaran (respawn di rumah, max 12). Petani 1 (respawn 45 detik). Polisi kaki hanya saat L2+.

## 7. Map 80x80 (1 level)
- Jalan utama diagonal (mobil cepat). 4 gang sempit lebar 2m (mobil tak masuk = rute aman). Kebun pisang barat (cover helikopter 5 detik: spotlight tak tembus).
- Kandang ayam/sapi pinggir peta (farming). Pasar malam tengah (6–8 manusia berkumpul, risiko tinggi). Pos polisi sudut tenggara (radius bahaya 15m). Rumah-rumah: atap = cover sorot mobil 3 detik.
- Drop zone: lingkaran ungu radius 5m di tepi utara + panah tepi layar saat kapasitas penuh.
- Set dressing murah: warung, gerobak, lampu jalan (2 nyala, sisanya mati), pohon (cover visual).

## 8. Variasi Waktu (anti bosan, 1 map)
- Siklus 90 detik: siang (visibilitas jauh, manusia di luar) → senja → malam (lampu rumah nyala = manusia pulang ke dalam = lebih susah, tapi sorot polisi lebih terlihat = lebih adil).
- Efek gameplay nyata, bukan kosmetik: jumlah target luar ruangan berubah per fase.

## 9. Progression & Ekonomi
- Uang = total poin run. Belanja antar run (tersimpan lokal):
  - Beam lebar +1m — 300
  - Beam cepat -0,3 dtk angkat — 400
  - HP max +1 (max 5) — 500
  - Magnet sapi (radius kunci +2m untuk hewan) — 250
  - Cooldown overheat -0,5 dtk — 350
- Highscore lokal + tanggal. Tanpa IAP, tanpa iklan wajib (MVP).

## 10. UI/UX (HP)
- HUD: skor kiri atas, HP (3 ikon UFO) + kapasitas (3 slot) kanan atas, meter wanted bar bawah + level, tombol BEAM kanan bawah (min 96px), joystick kiri (muncul di sentuhan).
- Panah tepi layar ke drop zone saat penuh. Teks combo tengah-atas. Tutorial: 3 tooltip run pertama (gerak → beam → deposit), bisa skip.
- Game over: skor, highscore (NEW BEST jika pecah), tombol Main Lagi + Upgrade.
- Bahasa: Inggris dulu (target global), Indonesia nanti.

## 11. Audio
- Dengung beam (loop, pitch naik saat angkat). "Pop" sukses. Sirene L2+ (loop, volume ikut jarak). Kentongan? TIDAK (itu Desa Waringin). Teriak panik (2 varian). Musik: 1 loop malam tegang (royalty-free). Semua SFX <44kHz mono biar ringan.

## 12. Art Direction
- Low-poly stylized, URP, malam biru tua + lampu kuning + beam hijau + sorot kuning + drop zone ungu. Warna fungsi: hijau = aman/sedot, kuning = waspada, merah = bahaya, ungu = tujuan.
- UFO: cakram abu + kubah kaca + lampu keliling kedip + bayangan blob. Manusia: kapsul + kepala + warna baju beda per tipe. Mobil polisi: box + strobo merah-biru + cone sorot. Semua <5k tris, 1 material per tipe.
- Efek: partikel naik beam, shake kecil sukses, slowmo 0,3 dtk sukses, vignette menutup saat L3.

## 13. Teknis & Budget Performa (Android kentang)
- Unity 6 URP, 1 directional light (baked-ish, no realtime shadow; blob shadow sprite), fog off, post: vignette saja.
- Target 30fps di Adreno 610: draw calls <80, tris layar <150k, partikel aktif <200, audio mono, texture max 1024.
- Gerak kinematic, AI waypoint (tanpa NavMesh), save JSON lokal (highscore + upgrade).

## 14. Milestone MVP
- M1 (minggu 1): UFO gerak + kamera follow + beam + 1 manusia + skor. DONE = bisa sedot + skor tampil.
- M2 (minggu 2): deposit + kapasitas + 1 mobil + sorot + meter + HP + game over. DONE = loop penuh main-kalah.
- M3 (minggu 3): L2/L3 + hewan + petani + upgrade + highscore + audio + partikel + siklus waktu. DONE = build APK playable 5 menit.
- Polish: tutorial, combo, panah drop zone, tuning angka Section 5–6.

## 15. Out of Scope (sengaja TIDAK ada)
Multiplayer, banyak map, cerita/dialog, kustom UFO, cuaca, ragdoll penuh, senjata UFO, HDRP/realistis, IAP/iklan, mode malam saja.

## 16. Risiko & Mitigasi
- Beam tidak terasa enak → tuning duluan (M1), playtest tiap hari, referensi feel: magnet + vacuum, bukan senjata.
- Polisi terlalu susah/gampang → semua angka wanted di Section 5 dalam 1 file tuning (ScriptableObject), bukan hardcode.
- Scope merayap → definisi DONE per milestone di Section 14; fitur baru masuk backlog, bukan sprint.
- HP kentang lag → budget Section 13 diukur di device nyata tiap milestone, bukan akhir.
