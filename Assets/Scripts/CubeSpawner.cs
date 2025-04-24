using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cubePrefab;
    public float spawnInterval = 1f;
    public Vector2 spawnRangeX = new Vector2(-8f, 8f);
    public Vector2 spawnRangeY = new Vector2(-4f, 4f);

    void Start()
    {
        InvokeRepeating(nameof(SpawnCube), 1f, spawnInterval);
    }

    void SpawnCube()
    {
        float x = Random.Range(spawnRangeX.x, spawnRangeX.y);
        float y = Random.Range(spawnRangeY.x, spawnRangeY.y);
        Vector3 spawnPos = new Vector3(x, y, 0f);

        Instantiate(cubePrefab, spawnPos, Quaternion.identity);
    }
}
