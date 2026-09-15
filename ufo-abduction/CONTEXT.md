# CONTEXT — UFO ABDUCTION
### Baca file ini DULU sebelum kerjakan task apa pun. Ini peta repo + aturan main AI.

## Game ini apa (1 paragraf)
UFO Abduction: arcade top-down 3D, Unity 6 URP Android. Alien culik manusia/hewan pakai beam, hindari polisi 4 level, deposit ke drop zone. Run 5 menit. Detail sistem: `UFO-Abduction-GDD.md`.

## Peta file (baca sesuai kebutuhan, JANGAN semua sekaligus)
| File | Guna | Kapan dibaca |
|---|---|---|
| `UFO-Abduction-GDD.md` | Sistem + angka + teknis (sumber kebenaran desain) | Butuh angka/aturan sistem |
| `UFO-Abduction-Tasks.md` | Urutan kerja M1→M3 + state machine per agen | Selalu — task aktif ada di sini |
| `UFO-Abduction-CodeRules.md` | Pattern kode + larangan | Sebelum tulis kode pertama |
| `UFO-Abduction-Story.md` | Rasa, teks radio, jokes | Butuh teks/nama/konteks rasa |
| `UFO-Abduction-Assets.md` | Nama prefab/scene/aset persis | Butuh referensi objek (dilarang mengarang nama) |
| `ContohHumanAI.cs` | Contoh kode BENAR 1 agen lengkap | Sebelum tulis AI agen mana pun — tiru polanya |
| `UFO-Abduction-Design.md` | Ringkasan 1 halaman | Orientasi cepat saja |

## Cara kerja per task (wajib)
1. Kerjakan HANYA 1 task (ada ID: M1-01 … M3-15). Jangan merembet ke task lain.
2. Baca state machine task itu di Tasks.md + tiru `ContohHumanAI.cs`.
3. Angka HANYA dari Tuning (ScriptableObject). Tak ada angka baru di kode.
4. Output: 1 file + daftar transisi state + cara test di Sandbox.
5. Selesai = lolos checklist CodeRules Section 4.

## Larangan cepat (detail di CodeRules)
Angka hardcode • Find/Instantiate di Update • NavMesh/ML-Agents/IK • boolean ganda pengganti state enum • ubah file di luar task • teks/label game di-generate AI (tulis manual).
