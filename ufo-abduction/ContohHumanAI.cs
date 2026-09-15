// ContohHumanAI.cs — CONTOH REFERENSI, bukan dipakai langsung.
// Tugas M1-06. Tiru pola ini untuk SEMUA agen (ayam, sapi, Bram, polisi, heli).
// Aturan yang ditunjukkan: state enum + ChangeState + timer, event bus,
// angka dari Tuning, tanpa Find/Instantiate di Update.
using UnityEngine;

public enum HumanState { Calm, Alert, Grabbed }

public class ContohHumanAI : AIBase
{
    public HumanState state = HumanState.Calm;

    float stateTimer;
    Vector3 wanderTarget;
    bool shouted;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform; // SEKALI di Start, bukan Update
        PickWanderTarget();
    }

    void Update()
    {
        stateTimer += Time.deltaTime;
        switch (state)
        {
            case HumanState.Calm: TickCalm(); break;
            case HumanState.Alert: TickAlert(); break;
            case HumanState.Grabbed: TickGrabbed(); break;
        }
    }

    void ChangeState(HumanState next)
    {
        state = next;
        stateTimer = 0f;
        shouted = false;
    }

    // CALM: jalan santai. -> ALERT jika UFO < 12m.
    void TickCalm()
    {
        MoveToward(wanderTarget, tuning.humanWanderSpeed);
        if (Vector3.Distance(transform.position, wanderTarget) < 1f) PickWanderTarget();
        if (DistanceToPlayer() < tuning.humanAlertRadius) ChangeState(HumanState.Alert);
    }

    // ALERT: zigzag menjauh + "!" + teriak 1x. -> CALM jika aman 4 dtk. -> GRABBED jika kena beam.
    void TickAlert()
    {
        if (!shouted) { shouted = true; GameEvents.OnShout?.Invoke(transform.position); }
        Vector3 away = (transform.position - player.position).normalized;
        // zigzag: arah digeser tiap 0,5 dtk — pakai stateTimer, bukan Coroutine
        float sway = Mathf.Sin(stateTimer * 12f) * 0.7f;
        Vector3 dir = Quaternion.Euler(0, sway * 40f, 0) * away;
        MoveToward(transform.position + dir * 5f, tuning.humanFleeSpeed);
        if (DistanceToPlayer() > tuning.humanSafeRadius && stateTimer > 4f) ChangeState(HumanState.Calm);
        // BeamController yang memanggil TryGrab(), bukan cek dari sini
    }

    // Dipanggil BeamController saat lingkaran beam penuh 1,5 dtk.
    public void TryGrab()
    {
        if (state != HumanState.Grabbed) ChangeState(HumanState.Grabbed);
    }

    // GRABBED: terkunci 1 dtk (goyang + tangan ke atas via animasi) -> naik 0,8 dtk -> event.
    void TickGrabbed()
    {
        if (stateTimer < 1f) return; // fase meronta, posisi dikunci
        float t = (stateTimer - 1f) / 0.8f;
        transform.position = Vector3.Lerp(transform.position, player.position, t * Time.deltaTime * 5f);
        if (t >= 1f)
        {
            GameEvents.OnAbducted?.Invoke(tuning.humanPoints);
            gameObject.SetActive(false); // kembali ke pool, bukan Destroy
        }
    }

    void PickWanderTarget()
    {
        Vector2 r = Random.insideUnitCircle * 10f;
        wanderTarget = transform.position + new Vector3(r.x, 0, r.y);
    }
}
