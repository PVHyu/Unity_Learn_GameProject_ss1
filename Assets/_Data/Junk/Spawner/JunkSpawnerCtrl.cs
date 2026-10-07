using UnityEngine;

public class JunkSpawnerCtrl : BaseMonoBehaviour
{
    [SerializeField] protected JunkSpawner junkSpawner;
    public JunkSpawner JunkSpawner => junkSpawner;
    [SerializeField] protected SpawnPoints spawnPoints;
    public SpawnPoints SpawnPoints => spawnPoints;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadJunkSpawner();
        this.LoadSpawnPoints();
    }

    protected virtual void LoadJunkSpawner()
    {
        if(this.junkSpawner != null) return;
        this.junkSpawner = GetComponent<JunkSpawner>();
        Debug.Log(transform.name + ":LoadJunkSpawner", gameObject);
    }

    protected virtual void LoadSpawnPoints()
    {
        if(this.spawnPoints != null) return;
        this.spawnPoints = Transform.FindAnyObjectByType<SpawnPoints>();
        Debug.Log(transform.name + ": LoadSpawnPoints", gameObject);
    }
}