using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 2f;
    private float timer = 0f;

    public float gapSize = 3.5f; // Space between top and bottom pipes
    public float minY = -1f;     // Minimum center Y of the gap
    public float maxY = 3f;      // Maximum center Y of the gap

    void Start()
    {
        timer = spawnRate;
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnRate)
        {
            SpawnPipe();
            timer = 0f;
        }
    }

    void SpawnPipe()
    {
        float yCenter = Random.Range(minY, maxY);
        Vector3 spawnPos = new Vector3(transform.position.x, yCenter, 0);
        GameObject newPipe = Instantiate(pipePrefab, spawnPos, Quaternion.identity);

        // Assign LogicScript to the PipeMiddleScript on the new pipe
        PipeMiddleScript middleScript = newPipe.GetComponentInChildren<PipeMiddleScript>();
        if (middleScript != null)
        {
            middleScript.logic = FindFirstObjectByType<LogicScript>();
        }
    }
}
