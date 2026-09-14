# UFO ABDUCTION - Top-Down 3D (Unity URP, Android)
### Game Simple: Alien di Piring Terbang Culik Manusia & Hewan
Versi: Desain 1.0 | Target: Unity 6 URP Android, run 5 menit, top-down 45°, HP-friendly

## 1. Premis (2 kalimat)
Kamu alien nyasar dengan piring terbang. Tugas: sedot manusia dan hewan dengan beam tractor, hindari polisi, deposit tangkapan ke drop zone sebelum kapasitas penuh.

## 2. Core Loop
Terbang → kunci target di bawah UFO → tahan BEAM sampai keangkat → penuh (3) → antar ke drop zone → upgrade → ulangi. Kalah: HP 0 (crash).

## 3. Kamera & Kontrol (Top-Down 45°)
- Perspective, pitch 50°, yaw 0, jarak ~25m, FOV 55. Follow UFO smoothing 3 detik + look-ahead arah gerak. Map 80x80m muat 1 layar, no zoom.
- Kiri: joystick virtual 8 arah (8 m/s). Kanan: 1 tombol BEAM (tahan) — auto-kunci target terdekat radius 4m.
- Beam panas: tahan max 5 detik → overheat cooldown 2 detik.

## 4. Beam Feel (70% fun-nya di sini)
- Beam = cone transparan + partikel naik + lingkaran hijau di tanah (radius = area sedot).
- Target di lingkaran 1,5 detik → goyang + kaki ke atas + meronta 1 detik → keangkat.
- Audio: dengung pitch naik saat angkat + "pop" sukses. Screen shake kecil + slowmo 0,3 detik per abduction sukses.

## 5. AI Panik (komedi = retention)
- Manusia: cuek → lihat UFO = panik (lari zigzag + "!" + teriak) → kena beam = pasrah (angkat tangan).
- Hewan (sapi/ayam): lari muter random waypoint — lucu, gampang di-code.
- 1 petani pemberani: kejar UFO, lempar batu (damage 1 HP kalau kena).

## 6. Sistem Polisi (satu-satunya ancaman)
| Level | Meter | Isi |
|---|---|---|
| 0 Aman | 0–29 | 1 mobil patroli keliling, lampu mati. Bebas sedot. |
| 1 Curiga | 30–59 | Mobil berhenti, sorot sweeping. Kena sorot 2 detik = ketahuan, meter loncat. Counter: terbang rendah di balik rumah/pohon, matikan beam 3 detik. |
| 2 Kejar | 60–99 | +1 mobil + 2 polisi kaki bawa senter. Mobil cepat tapi tak bisa masuk gang/kebun. Senter polisi bikin target kabur = susah sedot. |
| 3 Lockdown | 100 | Helikopter orbit + spotlight besar + barikade jalan. Helikopter tak bisa ditembak — hindari 30 detik atau deposit. |

- Meter: +15 per abduction, -2/detik saat beam mati + jauh dari sorot.
- Kena sorot penuh 3 detik = drop 1 tangkapan (jatuh + kabur) + HP -1.
- HP 3, kapasitas 3. Deposit ke drop zone (edge map) = meter reset 50% + HP +1.
- AI murah: mobil ikut path jalan, kejar POSISI TERAKHIR terlihat (bisa dikibuli). Polisi kaki seek ke arah sorotan. Helikopter orbit delay 2 detik (selalu ketinggalan dikit = terasa bisa lolos).

## 7. Poin (risk-reward)
Ayam 10 (kandang terbuka, gampang) · Sapi 30 (lambat, beam lama) · Manusia 50 (zigzag) · Petani shotgun 150 (high risk) · Polisi kaki 150 (bisa disedot, temannya nyorot terus).

## 8. Map 80x80 (desain dukung polisi)
- Jalan utama diagonal (mobil cepat) + 4 gang sempit (mobil tak masuk) + kebun (cover helikopter 5 detik).
- Kandang pinggir (farming aman, poin kecil). Pasar malam tengah (ramai, risiko tinggi). Pos polisi sudut (jauhi). Rumah = atap, terbang di atasnya aman dari sorot mobil 3 detik.
- Drop zone lingkaran ungu di edge map + panah penunjuk di tepi layar saat penuh.

## 9. Progression (bikin nagih)
- Uang antar run → upgrade: beam lebih lebar / lebih cepat / HP +1 / magnet sapi.
- Combo: 3 abduction dalam 10 detik = x2 + teks meriah.
- Variasi: siang → senja → malam per 90 detik. Malam: lampu rumah nyala = manusia pulang = lebih susah.

## 10. Implementasi Unity (URP, murah di HP)
- 1 directional light, fog off, blob shadow (circle sprite, bukan real shadow).
- UFO: Rigidbody kinematic + MovePosition (presisi, anti drift).
- Beam: cylinder transparan + particle naik + circle decal tanah (1 draw call).
- AI: waypoint/path array sederhana, tanpa NavMesh untuk MVP.
- Target visual: UFO cakram + lampu keliling + bayangan tanah (= info posisi). Manusia = titik + arah lari + "!" saat panik.
- Audio: dengung beam + sirene level 2+ + "pop".

## 11. MVP Urut Kerja (2-3 minggu solo)
1. Minggu 1: UFO gerak + kamera follow + beam + 1 manusia + skor.
2. Minggu 2: deposit zone + kapasitas + 1 mobil patroli + sorot + meter + HP.
3. Minggu 3: level 2-3 + upgrade + highscore + suara + partikel + shake.
- Definisi jadi: 1 map malam, 5 menit/run, skor + highscore, menang/kalah jelas, build Android jalan.

## 12. Yang SENGAJA Tidak Ada (biar jadi)
Multiplayer, kustom UFO, banyak map, cerita, cuaca, ragdoll penuh, HDRP/realistis, senjata UFO.
