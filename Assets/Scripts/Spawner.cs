using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public int numberOfEnemies;
    public float spawnRadius = 5;
    private Vector3 spawnPosition;

	void Start ()
    {
        SpawnObject();
	}
    void SpawnObject()
    {
        for (int i = 0; i < numberOfEnemies; i++)
        {
            spawnPosition = transform.position + Random.insideUnitSphere * spawnRadius;
            Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
        } 
    }
}
