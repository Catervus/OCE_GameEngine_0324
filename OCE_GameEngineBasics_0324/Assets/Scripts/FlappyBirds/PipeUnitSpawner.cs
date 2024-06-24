using UnityEngine;

public class PipeUnitSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject pipeUnit;

    [SerializeField]
    private float pipeSpeed;

    [SerializeField]
    private float spawnCooldown;

    private float curSpawnCD;

    [SerializeField]
    private float despawnTime;

    [SerializeField]
    private Transform[] spawnPositions;



    void Update()
    {
        curSpawnCD -= Time.deltaTime;

        if (curSpawnCD <= 0)
        {
            // Spawn
            SpawnPipeUnit();
            curSpawnCD = spawnCooldown;
        }

    }

    void SpawnPipeUnit()
    {
        int idx = Random.Range(0, spawnPositions.Length);
        GameObject go = Instantiate(pipeUnit, spawnPositions[idx].position, Quaternion.identity, transform);
        // go.transform.parent = transform;
        PipeUnitMovement pum = go.GetComponent<PipeUnitMovement>();
        if (pum != null)
        {
            pum.Initialise(pipeSpeed);
        }

        Destroy(go, despawnTime);
    }
}
