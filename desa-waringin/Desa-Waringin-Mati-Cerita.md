# DESA WARINGIN MATI
### Game Horror FPS Android - Cerita Lengkap + Quest + Asset Siap Pakai
Versi: Lengkap 1.1 | Target: Unity 6, Android (URP), 20-30 menit, FPS sentuh

## 1. Premis
Arga (21) pulang ke Desa Waringin setelah 10 tahun merantau, karena ibunya — Lastri — hilang seminggu sebelum Jumat Kliwon.

Surat terakhir ibunya cuma berisi:
> "Ojo bali yen durung wani kelangan. Golekono kembangku."
> (Jangan pulang kalau belum berani kehilangan. Carilah kembangku.)

Warga bilang Lastri "dijemput penunggu beringin kembar". Tidak ada yang mau mengantar Arga ke kuburan belakang desa. Sejak ibunya hilang, warung tutup, mushola mati lampu, dan anak-anak dilarang keluar lewat magrib.

Arga harus keliling desa, berdialog dengan 4 orang, memecahkan 3 teka-teki kecil, dan masuk ke kuburan untuk tahu kebenarannya.

## 2. Setting Desa Waringin
Desa kecil di lembah, dikelilingi sawah mati dan hutan bambu. Hanya ada satu jalan utama.

1. **Gerbang Desa:** Gapura bambu + dua pohon beringin raksasa yang akarnya menutup jalan setapak lama. Banyak sesajen basi, dupa mati, kain putih diikat.
2. **Tengah Desa:** Warung kayu Mbok Darmi yang tutup, gerobak bakso terguling, pos ronda dengan kentongan pecah, mushola yang lampunya kedip-kedip.
3. **Pinggir Desa:** Rumah panggung kayu Arga yang berdebu, foto keluarga sobek separuh.
4. **Belakang Desa - Area Terlarang:** Kuburan tua penuh pohon kamboja, rumpun bambu kuning yang bunyi sendiri kalau ada angin, kebun pisang yang buahnya busuk di pohon, dan sumur tua yang ditutup papan + rantai.

Nuansa:
- Malam berkabut tipis, fog tipis jarak 15-25m
- Lampu jalan kuning cuma 2 yang nyala, sisanya mati/kedip
- Suara jangkrik + kentongan jauh padahal pos ronda kosong
- Bau kemenyan dari arah kuburan (visual: asap tipis + dupa)
- Suara adzan jauh yang kepotong

## 3. Karakter + Tujuan Dialog

### Arga (pemain)
Anak Lastri. Keras kepala, tidak percaya mistis, bawa senter + HP lowbat.

### Pak RT Samin (50-an)
Ramah berlebihan. "wis, ikhlaske ae". Menyembunyikan kunci gudang pos ronda berisi buku catatan desa 10 tahun lalu. Arc: dari menutupi jadi memberi kunci diam-diam.

Contoh dialog:
- Arga: "Pak, ibu kulo ten pundi?"
- Samin: "Wis Le, ibumu... dijogo Mbah. Ojo digoleki. Ikhlaske ae."
- Arga: "Mboten saget. Kulo kedah mlebet kuburan."
- Samin: (nada turun) "Yen ngono... ojo ngomong sopo-sopo. Gudang pos... bukaken. Catetane ojo digowo metu." [Dapat: Kunci Gudang]

### Mbok Darmi (60-an)
Pemilik warung. Satu-satunya yang nangis waktu Lastri hilang. Takut gelap karena sekring rusak.

Contoh dialog:
- Darmi: "Arga? Ya Allah... kowe persis bapakmu."
- Arga: "Mbok, ibu pamit nopo ten panjenengan?"
- Darmi: "Ibumu tiap Kliwon tuku kembang... ngomong 'Darmi, yen aku ilang, tutupon warungmu'. Lampu mati Le, Mbok wedi... benerno dhisik ya?"
- [Setelah lampu nyala] Darmi: "Iki lengo tanah. Lan iki... kertas belanja, ana gambare Ilham nang mburine. Bocah kuwi weruh opo-opo." [Dapat: Minyak Tanah + Kertas Petunjuk Ilham]

### Ilham (9 tahun)
Tidak bicara langsung, bicara lewat gambar dan ajak main.

Contoh interaksi:
- Ilham: (menyodorkan gambar gembok + angka 17-08-45 terbalik) "Kene... kanggo om ronda."
- Arga: "Iki opo Ham?"
- Ilham: "Ngko dolanan petak umpet nang kebon gedang. Aku ngitung, kowe sing umpet... eh kuwalik. Kowe sing nggoleki suaraku." [Quest: Ikuti suara sandal]
- Di kebun pisang, setelah pocong lewat: Ilham ketawa "iku Mbah Cong, koncone aku. Dheweke seneng ngetung beras."

### Mbah Kunci (80-an)
Juru kunci. Buta satu mata. Tidak bicara sebelum kembang telon lengkap.

Contoh dialog:
- Mbah Kunci: "...gowo opo kowe?"
- Arga: "Kembang Mbah. Kantil, kenongo, mawar."
- Mbah Kunci: "Lungguh. Bapakmu mati mergo nolak. Ibumu matur 'nyowoku ijolane anakku, nanging ojo saiki'. Saiki... wayahe nagih."
- Mbah Kunci: "Sumur kuwi lawange. Korekmu... kanggo ngobong opo kanggo madhangi? Milihono dhewe."

### Penunggu / Lastri
Tidak bicara sampai finale. Hanya suara: "Arga... ojo digowo." dan tangisan di beringin.

## 4. Alur Lengkap + Quest

### PROLOG - Rumah Arga
Lokasi: interior rumah kayu gelap.
- Ambil Senter di meja (tutorial interaksi E / tap Interaksi)
- Baca sobekan buku: "Tumbal njaluk ganti. Aku melu dadi wit."
- Lihat jendela: beringin bergoyang tanpa angin (trigger sinematik 5 detik)
- Keluar rumah -> Bab 1 terbuka

Quest: [Tutorial] Ambil senter, baca buku, keluar rumah.

### BAB 1 - Desa yang Bungkam (Sore ke Magrib)
Lokasi: warung, gerobak bakso, pos ronda.

1. Ke warung Mbok Darmi, dialog buka.
2. Cari Sekring di kolong gerobak bakso + Kabel di pos ronda.
3. Puzzle 1 - Sekring: susun merah-kuning-hitam. Salah = lampu meledak kecil + suara.
4. Lampu warung nyala -> dialog penuh Mbok Darmi -> dapat Minyak Tanah + Kertas Ilham.
5. Pak RT datang, cutscene larangan singkat, pemain dapat Kunci Gudang (jatuh diam-diam, ada sparkle).
6. PMasuk gudang pos ronda -> baca Buku Catatan Desa (lore 10 tahun lalu).

Keluar Bab 1: pemain tahu ritual nandur nyowo + bapak gantung diri + ibu naruh kembang tiap Kliwon.

### BAB 2 - Anak dan Kuburan (Isya)
Lokasi: pos ronda gudang, kebun pisang, gerobak.

1. Buka gudang -> hadapi Gembok Kombinasi.
2. Puzzle 2 - Kode: gambar Ilham 17-08-45 dibaca di cermin jadi 54-80-71. Isi peti: Kunci Makam + Dupa Basah + Senter UV.
3. Ilham ajak petak umpet suara: ikuti suara sandal (audio 3D) ke kebun pisang. Tanpa peta, hanya suara.
4. Jumpscare 1 (ringan): pocong lewat cepat di sela pisang. Ilham ketawa. Dapat Gambar Sesajen (3 bunga + sumur + ibu digandeng).
5. Ke gerobak ambil Kantil liar. Harus jongkok / tap Intip Kolong.
6. Jumpscare 2: wajah Lastri 0.5 detik di kaca gerobak + "Arga... ojo digowo." Kantil masuk inventory.

Keluar Bab 2: Kantil + Kunci Makam + Dupa + Gambar Sesajen lengkap.

### BAB 3 - Waringin Mati (Tengah Malam - Kuburan)
Lokasi: gerbang kuburan, makam, bambu kuning, sumur tua.

1. Buka gerbang kuburan pakai Kunci Makam.
2. Jelajah: makam miring, kamboja rontok, bambu merunduk jadi gapura, pisang kelilingi sumur.
3. Temui Mbah Kunci di sumur. Dia minta Kembang Telon.
4. Cari susulan:
   - Kenanga di makam bapak Arga (baca nisan: "Sarkum 1975-2016. Ngapunten.")
   - Mawar Merah di makam kosong tanpa nama (saat diambil: nama ARGA muncul pelan + slowmo + trigger kejar)
5. Sekuen Kejar Mbah Cong -> pilih jalan -> sembunyi sumur/mushola (lihat Bagian 7).
6. Kembali ke Mbah Kunci, pasang Sesajen lengkap: Kembang 3 + Dupa + Foto Ibu. Dialog lore penuh terbuka.
7. Finale Kuntilanak/Lastri: muncul di pisang, terbang ke beringin, nangis suara Lastri. Dikejar bayangan ke sumur.
8. Turun ke ruang akar: radio tua nyala, adzan kepotong, foto Arga kecil.
9. Pilihan Ending di depan sumur (lihat Bagian 8).

## 5. Puzzle Detail
1. Sekring Warung: 3 slot warna. Petunjuk di tutup box sekring digambar kapur. Gagal 3x = lampu kedip + suara tawa jauh (tanpa game over).
2. Gembok Pos Ronda: 3 digit putar. Petunjuk cermin di gudang (kaca + angka terbalik). Ilham kasih kertas.
3. Sesajen Sumur: urutan Kembang - Dupa - Foto. Salah urutan = dupa mati + Mbah Kunci geleng. Benar = api biru + angin + tangis.

## 6. Item / Inventory
- Senter + Baterai (konsumabel, habis = gelap)
- Foto Ibu Sobek (quest + ending)
- Minyak Tanah + Korek (ending bakar)
- Kantil, Kenanga, Mawar Merah (sesajen)
- Dupa Basah (harus dikeringkan dulu di warung? opsional)
- Kunci Gudang + Kunci Makam
- Beras Kuning 3x (pengalih, konsumabel)
- Gambar Ilham 2x (petunjuk kode + sesajen)
- Senter UV (lihat bercak darah akar di Bab 3, opsional tapi bagus)

## 7. Sekuen Kejar-Kejaran Kuburan (Android)
Lokasi: gerbang kuburan -> bambu kuning -> pertigaan sumur/mushola. 60-90 detik.

Brief Ilham: "Lek, nek Mbah Cong ngamuk, sawurno berase. Dheweke wajib ngetung."

1. Trigger: ambil mawar -> slowmo 0.3x 2 detik + teks "OJO NOLEH!" + pocong muncul + senter kedip.
2. Lari: auto-lari, joystick kiri atur arah. Tombol besar [SAWUR BERAS] -> lempar ke belakang, pocong berhenti "siji... loro... telu..." dapat 5 detik.
3. Pertigaan slowmo: KIRI sumur (pendek-buntu, lanjut sembunyi) / KANAN mushola (jauh-aman ada pintu). Tidak pilih 3 detik = auto kiri.
4. Sembunyi: matikan senter (wajib) + tahan [TAHAN NAPAS] 6 detik. Lepas = jumpscare + ulang dari pertigaan (bukan game over). Berhasil = pocong hilang ke pisang.

Aturan hantu: dia tahu kamu di mana, tapi wajib nurut kontrak ritual. Beras tidak mempan ke Lastri final karena ibu kenal bau anaknya.

Kontrol Android: joystick kiri, swipe kanan kamera, tombol Interaksi besar kanan bawah, tombol Senter kecil, tombol Tas kecil. Tidak ada lompat manual, tidak ada jongkok manual (auto trigger).

## 8. Ending
A. **Bakar Beringin:** bakar akar. Api menyebar, pisang roboh, jeritan hilang. Besoknya sumur kering, sawah mati. Arga pulang bawa abu dalam kain putih. Teks: "Desa urip, ning atine mati."
B. **Gantikan Ibu:** pasang foto sendiri, turun ke sumur. Layar hitam, suara Mbok manggil. Ilham lihat makam baru ARGA + kembang fresh tiap Jumat. Teks: "Ibuku mulih, aku sing njogo wit."

## 9. Asset Siap Pakai - System (Gratis, Unity Asset Store)

Fondasi cepat. Install berurutan:

1. **FPS Horror Game Starter Pack - GRATIS - HDRP Unity 6**
   FPS controller + interaksi + dialogue + inventory. Base paling cocok untuk cerita ini di PC. Untuk Android, pakai sebagai referensi lalu pindah ke URP.
   https://assetstore.unity.com/packages/templates/packs/fps-horror-game-starter-pack-310075

2. **Meet and Talk Dialogue System Free Version - GRATIS - Built-in/URP/HDRP**
   Untuk dialog Pak RT, Mbok Darmi, Ilham, Mbah Kunci.
   https://assetstore.unity.com/packages/tools/visual-scripting/meet-and-talk-dialogue-system-free-version-245191

3. **Free Save Forge (Save + Inventory) - GRATIS - Unity 6**
   Save JSON + inventory untuk beras, kembang, kunci, foto.
   https://assetstore.unity.com/packages/templates/systems/free-save-forge-save-and-inventory-for-games-387958

4. **Simple FPS Controller v1.4 - GRATIS - Semua pipeline**
   Cadangan ringan untuk Android URP kalau starter pack keberatan. 1.2 MB.
   https://assetstore.unity.com/packages/tools/input-management/simple-fps-controller-v1-4-173881

5. **FREE Haunted Jump Scares - GRATIS - Audio**
   Stinger jumpscare 1-2 + kejar-kejaran.
   https://assetstore.unity.com/packages/audio/sound-fx/free-haunted-jump-scares-198111

Rekomendasi Android: project baru URP -> Simple FPS Controller + Meet and Talk + Save Forge + Jump Scares. Starter Pack HDRP dipakai untuk contek sistem interaksi/puzzle di PC.

## 10. Asset Siap Pakai - 3D Environment + Props (Gratis)

Desa:
- **Indonesian Traditional House Modular Kit - GRATIS - Built-in only** (185 MB, perlu upgrade material ke URP/HDRP). Base rumah kampung.
  https://assetstore.unity.com/packages/3d/environments/indonesian-traditional-house-modular-kit-372796
- **House Interior Free - GRATIS - Built-in/URP/HDRP** (73 MB). Interior rumah Arga + warung dalam.
  https://assetstore.unity.com/packages/3d/props/interior/house-interior-free-258782
- **Low Poly Mini Village Free - GRATIS**. Blockout layout desa cepat.
  https://assetstore.unity.com/packages/3d/environments/low-poly-mini-village-free-131677
- **Horror Starter Pack FREE - GRATIS**. Props horror biar rumah biasa jadi seram.
  https://assetstore.unity.com/packages/3d/props/horror-starter-pack-free-178413

Kuburan + Sumur + Lampu:
- **Low Poly Simple Graveyard - GRATIS**. Nisan, makam rusak, crypt, tulang + skeleton, demo scene.
  https://assetstore.unity.com/packages/3d/environments/dungeons/low-poly-simple-graveyard-134110
- **The Village Well - GRATIS**. Sumur tua finale Bab 3.
  https://assetstore.unity.com/packages/3d/props/exterior/the-village-well-115166
- **Street Lamp - GRATIS**. Lampu jalan kuning redup.
  https://assetstore.unity.com/packages/3d/environments/urban/street-lamp-7738

Pohon:
- **FREE Low Poly Trees Pack - GRATIS - Built-in/URP/HDRP**. Ada dead trees untuk beringin mati.
  https://assetstore.unity.com/packages/3d/vegetation/trees/free-low-poly-trees-pack-273724
- **Low poly trees free nature pack - GRATIS**. Tambahan vegetasi murah HP.
  https://assetstore.unity.com/packages/3d/vegetation/trees/low-poly-trees-free-nature-pack-300824
- Bambu + pisang + beringin besar spesifik: ambil gratis di Sketchfab (FBX/GLB) karena yang Asset Store bagus kebanyakan berbayar. Cari tag indonesianhouse. Pisang/bambu yang berbayar sebagai referensi: Banana Tree V1, Bamboo Tree Pack.

Khas Indonesia (di luar Asset Store, gratis, cek lisensi CC-BY):
- **Gerobak Bakso FBX - GRATIS - CGTrader**. Tinggal drag ke Unity.
  https://www.cgtrader.com/free-3d-models/vehicle/other/gerobak-bakso-indonesian-street-food-cart
- **Sketchfab gerobak**: https://sketchfab.com/tags/gerobak
- **Sketchfab warung**: https://sketchfab.com/tags/warung + https://sketchfab.com/tags/indonesian-warung
- **Sketchfab rumah kampung**: https://sketchfab.com/tags/indonesianhouse

Mapping cepat ke Bab:
- Prolog rumah: House Interior Free + Horror Starter Pack
- Bab 1 warung/pos/gerobak: Indonesian House Kit + Gerobak CGTrader + Warung Sketchfab + Street Lamp
- Bab 2 kebun pisang: Low Poly Trees + pisang Sketchfab + Jump Scares audio
- Bab 3 kuburan/sumur: Graveyard + Village Well + Dead Trees + Street Lamp dimatikan 80%

## 11. Urutan Kerja Cepat (Android)
1. Buat project Unity 6 URP (bukan HDRP biar ringan HP).
2. Install: Simple FPS Controller -> Meet and Talk Free -> Save Forge -> Jump Scares.
3. Blockout desa pakai Low Poly Mini Village (5 menit).
4. Ganti blockout dengan rumah Indo + interior + warung + gerobak.
5. Pasang kuburan + sumur + lampu + pohon mati. Bake lighting, 1 spotlight senter saja.
6. Masukkan dialog Bab 1-3 ke Meet and Talk sesuai Bagian 3.
7. Masukkan item Bagian 6 ke Save Forge (beras stok 3).
8. Buat trigger jumpscare + kejar Bagian 7 pakai trigger box + Time.timeScale 0.3.
9. Post-processing URP bawaan: vignette + film grain + exposure gelap + fog. Tanpa asset tambahan.
10. Autosave tiap dialog/puzzle selesai. UI font besar, tombol minimal.

Catatan lisensi: Asset Store pakai Standard Unity EULA aman untuk komersial. Sketchfab/CGTrader free pastikan downloadable + CC-BY/royalty-free dan cantumkan kredit pembuat.

## 12. Detail Teknis Pemain (Android, URP)

### 12.1 Konsep Pemain - Arga
- FPS tanpa senjata. Fokus: jalan, lihat, ambil, bicara, sembunyi.
- Stat hanya 3: Stamina lari, Baterai senter, Beras pengalih stok 3.
- Jalan 3 m/s, lari 5 m/s, stamina 6 detik lari + 4 detik recovery.
- Tidak ada lompat manual dan jongkok manual (auto trigger) agar simpel di HP.
- Senter 1 spotlight saja. Baterai 100% habis 5 menit nyala terus. Pickup baterai di warung dan pos ronda.
- HP lowbat hanya properti cerita, bukan mekanik.

### 12.2 Kontrol Android
- Kiri: joystick virtual untuk gerak.
- Kanan: swipe untuk kamera (sensitivitas 1.2, invert off).
- Kanan bawah tombol besar: INTERAKSI (ambil, baca, bicara, pasang).
- Tombol kecil: Senter on/off, Tas, Lari toggle (bukan tahan).
- Khusus kejar: tombol berubah jadi SAWUR BERAS, TAHAN NAPAS (press-and-hold), panah KIRI/KANAN.
- Semua tombol minimal 64px, font dialog minimal 18sp.

### 12.3 Sistem Inti
- Interaksi: raycast tengah layar 2.5m. Muncul ikon + label misal Ambil Kantil, Baca Buku, Ajak Bicara.
- Dialog: tap untuk next. Pilihan 2 opsi khusus ke Pak RT dan Mbah Kunci. Auto-save tiap dialog selesai.
- Inventory 8 slot (Save Forge): item quest tidak bisa dibuang, beras berkurang tiap lempar, baterai berkurang tiap detik senter nyala.
- Puzzle: UI fullscreen terpisah, game pause kecuali sekuen kejar.
- State hantu: Tenang, Curiga, Kejar, Hilang. Bukan jarak pandang murni, tapi trigger quest agar stabil di HP.
- Checkpoint: tiap dialog selesai, tiap puzzle selesai, tiap item kunci didapat, sebelum dan sesudah kejar. Gagal = ulang dari checkpoint, bukan game over.

### 12.4 Alur Main Menit per Menit (0-25 menit)
- 0-1 mnt: loading + judul + tap mulai. Spawn di rumah gelap.
- 1-3 mnt Prolog: ambil senter (tutorial interaksi), baca buku robek, lihat jendela 5 detik, keluar rumah, auto-save, Bab 1 terbuka.
- 3-5 mnt: jalan ke warung, dialog buka Mbok Darmi, terima quest lampu.
- 5-8 mnt: cari sekring di kolong gerobak (tap Intip) + kabel di pos ronda. Kembali ke warung.
- 8-10 mnt: puzzle sekring merah-kuning-hitam. Lampu nyala. Dialog penuh. Dapat minyak + kertas Ilham. Pak RT datang, drop kunci gudang. Baca buku desa. Bab 2 terbuka.
- 10-12 mnt: buka gudang, puzzle cermin 54-80-71. Dapat kunci makam + dupa + UV.
- 12-15 mnt: ikut suara sandal Ilham ke kebun pisang (audio 3D, tanpa peta). Jumpscare 1 pocong lewat. Dapat gambar sesajen. Ilham jelaskan beras.
- 15-17 mnt: ke gerobak ambil kantil (jongkok auto). Jumpscare 2 wajah Lastri 0.5 detik. Bab 3 terbuka.
- 17-19 mnt: buka gerbang kuburan. Jelajah makam. Temui Mbah Kunci. Ambil kenanga di makam bapak. Ambil mawar di makam tanpa nama -> nama ARGA muncul -> trigger kejar.
- 19-21 mnt: sekuen kejar Mbah Cong (slowmo 0.3x, sawur beras 5 detik waktu, pilih kiri sumur / kanan mushola, matikan senter + tahan napas 6 detik).
- 21-23 mnt: pasang sesajen kembang-dupa-foto. Dialog lore Mbah Kunci penuh. Auto-save.
- 23-25 mnt: finale Lastri terbang pisang ke beringin. Dikejar bayangan ke sumur. Turun ruang akar (radio + adzan + foto kecil). Pilihan ending bakar atau ganti. Credit + teks akhir.

### 12.5 Implementasi Cepat di Unity
- Player: Simple FPS Controller + tambah script Stamina, Baterai, Inventory bridge ke Save Forge.
- Interaksi: 1 script Interactable (id, label, action) + trigger box. Semua item quest pakai prefab sama.
- Dialog: Meet and Talk node per NPC sesuai Bagian 3. Flag sudahBicara_Darmi, sudahDapat_KunciGudang, dst.
- Puzzle: 3 UI Canvas terpisah (Sekring, Gembok, Sesajen). Validasi sederhana, gagal 3x hanya efek suara/kedip.
- Kejar: trigger box makam mawar -> Time.timeScale 0.3 selama 2 detik -> spawn pocong waypoint -> UI beras -> pertigaan UI kiri/kanan -> trigger sembunyi (cek senter mati + tombol tahan 6 detik).
- Audio: Jump Scares pack untuk stinger. Jangkrik loop + kentongan jauh loop + tangis one-shot finale.
- Lighting mobile: URP, bake semua lampu statis, hanya senter real-time. Fog 15-25m. Post: vignette + grain + exposure -1.5.
- Save: Save Forge JSON tiap checkpoint Bagian 12.3. Slot 1 saja agar simpel.

## 13. Shooting Script Sinematik (Cinematic Opening + Transisi)

Format: SHOT | LOKASI | KAMERA | AKSI | AUDIO/DIALOG | DURASI | Implementasi Unity.
Semua sinematik bisa di-skip dengan tap 2 detik (wajib untuk Android).

### 13.1 OPENING - Masuk Desa (0:00-1:40, non-interaktif)

S01 - Jalan tanah luar desa, sore gelap. Drone wide-shot maju pelan ke gapura bambu. Plang kayu "DESA WARINGIN" miring, kain putih berkibar. | Audio: jangkrik + motor bebek menjauh + adzan jauh kepotong. | 12 detik | Cinemachine Dolly Track + Timeline.

S02 - POV boncengan motor (player = Arga). Kamera goyang halus, lihat punggung tukang ojek + spion. Tukang ojek: "Waringin? Mas... yakin? Niki lho... Jumat Kliwon." Arga (VO): "Minggah mawon Pak. Kulo bayar dobel." | 10 detik | POV cam + head-bob anim.

S03 - Motor berhenti di gapura. Close-up kaki Arga turun, bayar, motor pergi. Sepi mendadak. | SFX motor hilang, sisa jangkrik. | 6 detik.

S04 - Wide beringin kembar. Angin tidak ada tapi daun bergoyang. Kain putih + sesajen basi di akar. Arga jalan masuk frame dari belakang (third-person 3 detik, lalu blend ke FPS). | Musik drone rendah masuk. | 10 detik.

S05 - Montase jalan desa POV jalan kaki: gerobak bakso terguling (pan kanan 2 detik), warung tutup (tilt up ke papan WARUNG DARMI), pos ronda kosong tapi kentongan bunyi sendiri (whip-pan ke pos). | Kentongan 3x + napas Arga. | 15 detik.

S06 - Rumah Arga. Push-in ke pintu kayu. Tangan Arga (FPS hands) buka kunci berkarat. | SFX kunci + engsel. | 8 detik.

S07 - Interior gelap. Senter meja menyala sendiri kedip. Tangan Arga ambil senter -> layar jadi terang senter = kontrol pindah ke pemain. Teks tutorial: "Seret kanan untuk melihat. Tap INTERAKSI." | 10 detik.

S08 - SHOT GELAS KE MUKA (signature shot): Arga ambil gelas air di meja (POV tangan kanan). Dia minum. Kamera follow gelas turun, lalu tilt-up pelan dari gelas ke jendela kaca yang memantulkan wajah Arga + di belakangnya terlihat beringin bergoyang. Arga (VO): "Bu... aku mulih." | 12 detik | FPS hands anim + reflective window material + face mesh Arga hanya di refleksi (hemat performa).

Total opening 83 detik. Setelah S08 -> gameplay Prolog bebas.

### 13.2 Transisi Bab (masing-masing 10-15 detik, Timeline + fade)

T-Bab1: Close-up foto ibu sobek di meja -> match-cut ke lampu warung mati. Mbok batuk dari dalam. Teks: "BAB 1 - DESA YANG BUNGKAM".

T-Bab2: Lampu warung nyala terang -> flicker -> cut ke langit gelap + suara sandal Ilham. Teks: "BAB 2 - ANAK DAN KUBURAN".

T-Bab3: Gambar sesajen Ilham dipegang tangan Arga -> zoom ke gambar sumur -> match-cut ke gerbang kuburan asli malam berkabut. Teks: "BAB 3 - WARINGIN MATI".

### 13.3 Sinematik Jumpscare & Kejar (in-engine, tidak full cutscene agar tidak mabuk di HP)

J1 Kebun pisang: kamera paksa lerp 30 derajat ke kanan (scripted look), pocong slide 0.8 detik di sela pisang + stinger. Kamera kembali ke pemain 1 detik. Total 3 detik.

J2 Kaca gerobak: saat Intip Kolong, kamera FOV 60->40 (zoom), pantulan kaca ganti ke wajah Lastri 0.5 detik + bisik "Arga... ojo digowo." FOV kembali.

K-Kejar Mbah Cong: ambil mawar -> slowmo 0.3x 2 detik + teks OJO NOLEH + kamera auto 180 derajat ke belakang lihat pocong 1 detik, lalu balik depan. Selama lari: kamera shake + vignette menutup. Saat sembunyi: kamera turun ke jongkok (Y 1.6->0.9m) + fade hitam tepi.

### 13.4 Finale & Ending (1:00-1:30)

F1: Sesajen api biru -> crane-up (drone naik 5m) lihat Kuntilanak berdiri di pohon pisang -> terbang (lerp cepat) ke beringin kembar. Tangis Lastri + angin.

F2: Ruang akar sumur: slow push-in ke radio tua -> foto Arga kecil -> radio bunyi adzan kepotong.

E-A Bakar: close-up tangan tuang minyak ke akar -> korek nyala (bloom) -> wide api menyebar -> fade putih -> pagi abu di kain putih.

E-B Ganti: close-up foto Arga dipasang di sesajen -> kamera turun ke sumur gelap (fade hitam 3 detik) -> buka di kuburan pagi, makam baru ARGA + kembang fresh + Ilham jalan menjauh.

### 13.5 Catatan Kamera Android (anti mabuk)
- FOV 60 (jangan 70+), sensitivitas swipe 1.2, head-bob 30% dari PC.
- Semua paksa-gerak kamera maksimal 2 detik + bisa di-skip.
- Jangan putar 360 derajat mendadak. Maksimal 180 derajat pelan.
- Senter selalu jadi sumber cahaya utama agar mata ada fokus.
