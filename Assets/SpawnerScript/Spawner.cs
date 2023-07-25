using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject clone; // Reference
    public float spawnInterval = 1f; // How frequently to spawn a new bubble
    private float timeSinceLastSpawn = 0f;

    void Update()
    {
        // Check if it's time to spawn a new bubble
        timeSinceLastSpawn += Time.deltaTime;
        if (timeSinceLastSpawn >= spawnInterval)
        {
            // Reset the timer
            timeSinceLastSpawn = 0f;

            // Spawn a new bubble at the current position
            Instantiate(clone, transform.position, Quaternion.identity);
        }
    }
}


