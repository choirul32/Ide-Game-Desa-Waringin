# UFO ABDUCTION — Task List
### File task terpisah | Urut M1 → M3 | Centang [x] saat DONE
### State machine tiap agen ada di bawah task-nya. Semua angka dari GDD Section 5–6, via ScriptableObject Tuning (M2-08) — tidak ada hardcode baru setelah M2.

## M1 — Bisa sedot, bisa skor (minggu 1)
**DONE = UFO terbang + beam angkat 1 manusia + skor tampil.**
- [ ] M1-01 Project Unity 6 URP baru + scene Map-80x80 + folder prefabs/audio/UI
- [ ] M1-02 UFO: cakram + kubah + lampu keliling + blob shadow + Rigidbody kinematic MovePosition, speed 8 m/s, tilt visual max 12°
- [ ] M1-03 Kamera: pitch 50°, jarak 25m, FOV 55, follow smoothing 3 dtk + look-ahead arah gerak
- [ ] M1-04 Kontrol: joystick kiri 8 arah + tombol BEAM kanan (min 96px), auto-kunci target terdekat radius 4m
- [ ] M1-05 Beam: cone transparan + lingkaran hijau tanah + fase kunci 1,5 dtk → meronta 1 dtk → angkat lerp 0,8 dtk
- [ ] M1-06 AI-MANUSIA v1 (1 tipe, sipil):
  - State CALM: wander waypoint random radius 10m, speed 1,5 m/s. Transisi → ALERT jika jarak UFO <12m ATAU beam aktif <8m.
  - State ALERT: lari zigzag menjauhi UFO (arah = dari UFO + random ±40°, ganti tiap 0,5 dtk), speed 3,5 m/s, tampil "!" + teriak 1x. Transisi → CALM jika UFO >18m selama 4 dtk. Transisi → GRABBED jika dalam lingkaran beam 1,5 dtk.
  - State GRABBED: terkunci di posisi (tak bisa kabur), animasi goyang + tangan ke atas 1 dtk → terangkat lerp ke perut UFO 0,8 dtk → hilang + skor/poin/meter.
  - Tanpa NavMesh: gerak = MovePosition arah langsung, halangan diabaikan untuk MVP (map terbuka).
- [ ] M1-07 Skor HUD + abduction (+50 poin, +15 meter)
- [ ] M1-08 Panas beam: max 5 dtk tahan → cooldown paksa 2 dtk + indikator overheat di tombol

## M2 — Loop penuh main-kalah (minggu 2)
**DONE = sedot → deposit → wanted → HP 0 = game over.**
- [ ] M2-01 Kapasitas 3 + beam mati saat penuh + panah tepi layar arah drop zone
- [ ] M2-02 Drop zone ungu radius 5m edge map: deposit = meter -50%, HP +1, uang masuk
- [ ] M2-03 HP 3 + HUD + crash game over + layar skor + Main Lagi
- [ ] M2-04 Meter wanted 0–100 (+15/abduction, -2/dtk saat beam mati DAN jarak sorot >15m) + bar HUD + label level
- [ ] M2-05 AI-MOBIL PATROLI (L0/L1):
  - State PATROL: loop waypoint jalan utama, speed 6 m/s, lampu mati.
  - Naik L1: State ALERT — berhenti di waypoint terdekat, sorot sweeping rotasi 40°/dtk, cone 15m.
  - Deteksi UFO: raycast jarak <20m + sudut depan 60° + tidak terhalang rumah (cek garis vs daftar atap). Terlihat 2 dtk = ketahuan (meter +20 instan + bunyi).
  - Kejar = menuju POSISI TERAKHIR terlihat (bukan real-time), sampai → kembali sweeping. Sengaja bisa dikibuli belok gang.
  - Turun L0: kembali PATROL saat meter <30.
- [ ] M2-06 Sorot adil: 3 dtk PENUH terkunci = drop 1 tangkapan + HP -1. Putus 0,5 dtk = timer reset. Cone kuning jelas + sirene + meter merah sebagai telegraph.
- [ ] M2-07 Tutorial 3 tooltip (gerak → beam → deposit), tap-tahan 2 dtk untuk skip
- [ ] M2-08 File tuning ScriptableObject: semua angka Sections 5–6 GDD (speed, radius, waktu, poin, meter). Tidak ada angka baru di kode setelah ini.

## M3 — Game utuh 5 menit (minggu 3)
**DONE = build APK playable: L2/L3 + hewan + upgrade + audio.**
- [ ] M3-01 AI-MOBIL #2 + AI-POLISI KAKI (L2):
  - Mobil #2: sama seperti M2-05, path offset (berpapasan, bukan konvoi).
  - Polisi kaki (2 unit, spawn dari mobil saat L2 on, despawn saat off): State SEEK — jalan speed 3 m/s ke arah titik sorotan mobil; State SWEEP — senter cone 8m sapu ±30°. Manusia yang kena senter → paksa ALERT kabur ke rumah terdekat (susah disedot = pressure, bukan damage).
  - Polisi kaki bisa disedot (150 poin): GRABBED sama seperti manusia, tapi butuh beam penuh 1,5 dtk tanpa putus (temannya terus menyorot = susah).
- [ ] M3-02 AI-HELIKOPTER (L3):
  - Orbit UFO radius 12m, tinggi 18m, ikuti POSISI UFO 2 DETIK LALU (delay buffer — selalu ketinggalan dikit = terasa bisa lolos).
  - Spotlight cone 6m ke bawah. Aturan damage sama M2-06. Kebun pisang = cone tak tembus 5 detik (cover).
  - Barikade: 2 titik jalan utama diblokir (visual + collider) selama L3. Turun <60 = barikade hilang.
- [ ] M3-03 AI-AYAM (10 poin): State PECK (diam mematuk, 2–4 dtk) ↔ State SCATTER (lari random cepat 4 m/s 2 dtk saat UFO <8m). Beam time 1,0 dtk. Respawn 20 dtk di kandang, max 6.
- [ ] M3-04 AI-SAPI (30 poin): State GRAZE (diam/jalan pelan 0,8 m/s) → State STARTLE (UFO <10m: meraung, nada naik tiap detik) → lari lambat 2 m/s lurus (gampang dikejar). Beam time 2,0 dtk. Respawn 30 dtk, max 4.
- [ ] M3-05 AI-BRAM PETANI (150 poin): State GUARD di kandang (idle + garpu). UFO <12m → State CHASE: kejar UFO speed 4,5 m/s (lebih lambat dari UFO 8 m/s = bisa kabur, tapi dia motong jalan). Serang: lempar batu jika jarak <10m, cooldown 4 dtk, proyektil speed 12 m/s, kena = 1 HP. Lari dari beam? TIDAK — Bram berani (bedakan dari sipil). Respawn 45 dtk di rumahnya.
- [ ] M3-06 Event Dodi: jika polisi kaki disedot → 1 polisi tersisa agresif 2x (speed 6 m/s, sorot +50% lebar) 30 detik + teriak nama. Timer HUD.
- [ ] M3-07 Combo x2 (3 abduction/10 dtk) + timer bar HUD
- [ ] M3-08 Upgrade shop antar run (5 item GDD Section 9) + save JSON lokal
- [ ] M3-09 Highscore lokal + tanggal + koran pagi dinamis (<500 / 500–1500 / >1500)
- [ ] M3-10 Audio: dengung beam + pitch naik + pop + sirene (volume ikut jarak) + teriak (2 varian) + 1 loop musik malam
- [ ] M3-11 Efek: partikel naik beam + shake sukses + slowmo 0,3 dtk + vignette L3
- [ ] M3-12 Siklus siang–senja–malam 90 dtk: jumlah target luar (siang 100%, senja 70%, malam 40% + sorot lebih terlihat)
- [ ] M3-13 Vex radio 6 teks (intro, deposit, L1, L2, L3, menang/kalah), tampil 3 dtk, tak hentikan permainan
- [ ] M3-14 Budget check device nyata: 30fps, draw calls <80, tris <150k, partikel <200
- [ ] M3-15 Build APK + playtest 5 menit penuh tanpa crash

## Backlog (SETELAH M3, bukan sekarang)
- [ ] Telur jatuh dari ayam (+5 mid-air catch)
- [ ] Pak Kades rare spawn 300 poin
- [ ] Tukang bakso + gerobak
- [ ] Pasar malam kerumunan dinamis
- [ ] Bahasa Indonesia
- [ ] Mode malam saja / challenge harian
