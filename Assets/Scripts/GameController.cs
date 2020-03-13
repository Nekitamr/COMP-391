using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //variables that control spawning hazards
    [Header("Wave Settings")]
    public GameObject hazard;   // What
    public Vector2 spawnValue;  // Where
    public int hazardCount;     // How many per wave

    [Header("Wave Time Settings")]
    public float startWait;     // Time until first wave
    public float spawnWait;     // Time between hazards IN waves
    public float waveWait;      // Time between waves


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Coroutine to spawn waves of hazards
    IEnumerator SpawnWaves()
    {
        // Initial delay before the first wave
        yield return new WaitForSeconds(startWait);

        // Start spawning waves of hazards
        while (true)
        {
            // Spawn some hazards
            for (int i = 0; i < hazardCount; i++)
            {
                // Spawn a single hazard
                Vector2 spawnPosition = new Vector2(spawnValue.x, Random.Range(-spawnValue.y, spawnValue.y));

                Instantiate(hazard, spawnPosition, Quaternion.identity);
                yield return new WaitForSeconds(spawnWait); // Wait for the next hazard
            }

            yield return new WaitForSeconds(waveWait); // Wait for the next wave
        }
    }
}
