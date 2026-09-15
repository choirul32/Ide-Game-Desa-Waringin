# UFO ABDUCTION — Aturan Struktur & Code Pattern
### Wajib dibaca sebelum tulis kode pertama | Versi 1.0

## 1. Struktur Folder Unity (Assets/_Game/)
```
Assets/_Game/
├── Scenes/          # Map-80x80.unity saja (+ Sandbox_Tes, TIDAK di-build)
├── Scripts/
│   ├── Core/        # GameManager, Tuning (ScriptableObject), SaveSystem, Pooling
│   ├── Player/      # UfoMovement, BeamController, BeamHeat
│   ├── AI/          # satu file per agen: HumanAI, ChickenAI, CowAI, BramAI,
│   │                #   PoliceCarAI, FootPoliceAI, HelicopterAI + AIBase.cs
│   ├── Systems/     # WantedSystem, ScoreSystem, ComboSystem, SpawnSystem,
│   │                #   UpgradeShop, DayNightCycle, VexRadio
│   └── UI/          # HUD, JoystickInput, BeamButton, Tutorial, GameOverScreen
├── Prefabs/
│   ├── Player/      # UFO.prefab
│   ├── Agents/      # Human, Chicken, Cow, Bram, PoliceCar, FootPolice, Helicopter
│   ├── Props/       # House, Barn, LampPost, Barricade, DropZone
│   └── FX/          # BeamCone, AbductParticles, MuzzleFlashStone
├── ScriptableObjects/
│   └── Tuning/      # Tuning.asset (SATU file, semua angka game)
├── Audio/           # beam_loop, pop, siren, scream1-2, music_night
└── Materials/       # 1 material per tipe agen (bukan per instance)
```
Aturan: TIDAK ada script di luar `Scripts/`. TIDAK ada prefab di root. Scene test diawali `Sandbox_` dan tidak masuk Build Settings.

## 2. Aturan Emas (5, tidak bisa ditawar)
1. **Angka hidup di Tuning.asset, bukan di kode.** Speed, radius, waktu, poin, meter — semua dari ScriptableObject. Kode baca `tuning.ufoSpeed`, bukan `8f`. Langgar = PR ditolak.
2. **Satu agen = satu file + satu state machine.** `HumanAI.cs` hanya urus manusia. Logic bersama (gerak, deteksi jarak) di `AIBase.cs`. Tidak ada `if (type == "cow")` di file manusia.
3. **Sistem tidak saling panggil langsung.** WantedSystem tidak memanggil PoliceCarAI. Semua komunikasi lewat event C# (`GameEvents.OnWantedLevelChanged += ...`). Sistem boleh baca state, tidak boleh perintah sistem lain.
4. **Tak ada Find/GameObject.Find di Update.** Cache di Awake/Start. Cari objek = via Inspector reference atau SpawnSystem registry.
5. **Tak ada Instantiate/Destroy saat main.** Semua spawn (manusia, ayam, partikel, batu Bram) lewat Object Pooler di Core. Instantiate hanya saat loading.

## 3. Pattern Wajib
### 3.1 State machine agen (WAJIB untuk semua AI)
```csharp
public enum HumanState { Calm, Alert, Grabbed }
public class HumanAI : AIBase {
    public HumanState state;
    float stateTimer;
    void Update() {
        switch (state) { case HumanState.Calm: TickCalm(); break; ... }
    }
    void ChangeState(HumanState next) { state = next; stateTimer = 0f; /* efek masuk state */ }
}
```
- State = enum, transisi = method `ChangeState`, timer per state. Dilarang boolean ganda (`isPanicking && !isGrabbed && ...`).
- Setiap transisi HARUS ada kondisi jelas di komentar (contoh: `// CALM->ALERT: jarak UFO < 12m`).

### 3.2 AIBase (semua agen extends ini)
```csharp
public abstract class AIBase : MonoBehaviour {
    protected Transform player;       // cache UFO
    protected Tuning tuning;          // angka dari SO
    protected float DistanceToPlayer() => Vector3.Distance(transform.position, player.position);
    protected void MoveToward(Vector3 target, float speed) => /* MovePosition */;
}
```

### 3.3 Event bus (komunikasi antar sistem)
```csharp
public static class GameEvents {
    public static System.Action<int> OnWantedLevelChanged;
    public static System.Action<int> OnAbducted;      // poin
    public static System.Action OnDeposited;
    public static System.Action OnGameOver;
}
```
Contoh: BeamController panggil `OnAbducted?.Invoke(50)`. ScoreSystem, WantedSystem, ComboSystem masing-masing subscribe. BeamController TIDAK TAHU mereka ada.

### 3.4 Tuning ScriptableObject (satu-satunya sumber angka)
```csharp
[CreateAssetMenu(menuName = "UFO/Tuning")]
public class Tuning : ScriptableObject {
    [Header("UFO")] public float ufoSpeed = 8f; public float beamRadius = 4f;
    public float beamLockTime = 1.5f; public float beamHeatMax = 5f; public float beamCooldown = 2f;
    [Header("Wanted")] public float meterPerAbduct = 15f; public float meterDecay = 2f;
    [Header("Police")] public float spotDamageTime = 3f; public float spotResetGap = 0.5f;
    // ... dst, cermin GDD Section 5-6
}
```

### 3.5 Naming
- File = nama class persis (`UfoMovement.cs` → `class UfoMovement`).
- Method: `TickCalm()`, `ChangeState()`, `TryAbduct()`. Boolean: `isOverheated`, `canBeam`.
- Prefab: `Human_Sipil`, `Car_Police`, `FX_BeamCone`. Scene: `Map-80x80`.
- TIDAK ada `Test123`, `NewBehaviourScript`, `Scriptbaru`.

## 4. Checklist Per Task (sebelum centang DONE di Tasks.md)
- [ ] Kode ikut pattern Section 3 (state enum? event? tuning?)
- [ ] Tidak ada angka hardcode baru (cari `= [0-9]` di file — harusnya cuma `0f` inisialisasi)
- [ ] Tidak ada Find/Instantiate di Update (cari di file)
- [ ] Jalan di Sandbox scene tanpa error console
- [ ] Kartu tuning diuji 2 nilai ekstrem (mis. speed 4 dan 12) — game tetap adil

## 5. Larangan Keras
- NavMesh, ML-Agents, Behavior Tree asset, Animation Rigging IK — DITOLAK (alasan di GDD).
- Singleton selain GameManager. Sistem akses via event atau Inspector reference.
- Coroutine untuk timer gameplay — pakai `stateTimer += Time.deltaTime` (jelas, bisa pause).
- Update() kosong, Debug.Log di build, SerializeField yang tidak dipakai.
