# UFO ABDUCTION — Task List
### File task terpisah | Urut M1 → M3 | Centang [x] saat DONE

## M1 — Bisa sedot, bisa skor (minggu 1)
**DONE = UFO terbang + beam angkat 1 manusia + skor tampil.**
- [ ] Project Unity 6 URP baru + scene Map-80x80 + folder prefabs/audio/UI
- [ ] UFO: cakram + kubah + lampu keliling + blob shadow + Rigidbody kinematic MovePosition
- [ ] Kamera: pitch 50°, jarak 25m, FOV 55, follow smoothing 3 dtk + look-ahead
- [ ] Kontrol: joystick kiri 8 arah + tombol BEAM kanan (min 96px)
- [ ] Beam: cone transparan + lingkaran hijau radius 4m + kunci target terdekat
- [ ] Manusia 1 tipe: cuek → panik zigzag → pasrah → terangkat (lerp 0,8 dtk)
- [ ] Skor HUD + abduction (+poin, +meter)
- [ ] Panas beam: max 5 dtk tahan → cooldown 2 dtk

## M2 — Loop penuh main-kalah (minggu 2)
**DONE = sedot → deposit → wanted → HP 0 = game over.**
- [ ] Kapasitas 3 + beam mati saat penuh + panah tepi layar ke drop zone
- [ ] Drop zone ungu edge map: deposit = meter -50%, HP +1, uang masuk
- [ ] HP 3 + HUD + crash game over + layar skor + Main Lagi
- [ ] Meter wanted 0–100 (+15/abduction, -2/dtk aman) + bar HUD
- [ ] L0/L1: 1 mobil path + sorot sweeping + ketahuan meter +20
- [ ] Sorot adil: 3 dtk penuh = damage, putus 0,5 dtk = reset
- [ ] Tutorial 3 tooltip (gerak → beam → deposit), bisa skip
- [ ] File tuning ScriptableObject (semua angka Section 5–6 GDD, tanpa hardcode)

## M3 — Game utuh 5 menit (minggu 3)
**DONE = build APK playable: L2/L3 + hewan + upgrade + audio.**
- [ ] L2: +1 mobil + 2 polisi kaki + senter bikin target kabur
- [ ] L3: helikopter orbit delay 2 dtk + spotlight + barikade
- [ ] Ayam (10) + sapi (30, beam 2 dtk) + respawn + max count
- [ ] Petani Bram: kejar + lempar batu (1 HP, cooldown 4 dtk) + respawn 45 dtk
- [ ] Polisi kaki bisa disedot (150) + event Dodi agresif 2x 30 dtk
- [ ] Combo x2 (3 abduction/10 dtk) + timer HUD
- [ ] Upgrade shop antar run (5 item GDD Section 9) + save lokal
- [ ] Highscore lokal + tanggal + koran pagi dinamis
- [ ] Audio: dengung beam + pitch + pop + sirene + teriak (2 varian) + 1 loop musik
- [ ] Efek: partikel beam + shake sukses + slowmo 0,3 dtk + vignette L3
- [ ] Siklus siang–senja–malam 90 dtk (pengaruh jumlah target luar)
- [ ] Vex radio 6 teks (intro, deposit, L1, L2, L3, menang/kalah)
- [ ] Budget check device nyata: 30fps, draw calls <80, tris <150k
- [ ] Build APK + playtest 5 menit penuh tanpa crash

## Backlog (SETELAH M3, bukan sekarang)
- [ ] Telur jatuh dari ayam (+5 mid-air catch)
- [ ] Pak Kades rare spawn 300 poin
- [ ] Tukang bakso + gerobak
- [ ] Pasar malam kerumunan dinamis
- [ ] Bahasa Indonesia
- [ ] Mode malam saja / challenge harian
