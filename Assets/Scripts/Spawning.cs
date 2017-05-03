using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public Transform target;
    public GameObject Bill;
    public Vector3 spawnValues;
    public int enemyCount;
    public float spawnWait;
    public float startWait;

    // Use this for initialization
    void Start()
    {
        StartCoroutine (SpawnWaves ());
    }

   IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        // Spawns enemies until a certain amount at a random range
        for (int i = 0; i < enemyCount; i++)
        {
            Vector3 pos = transform.position;
            Vector3 spawnPosition = new Vector3(pos.x, pos.y, Random.Range(-pos.z, pos.z));
            Quaternion spawnRotation = Quaternion.identity;
            GameObject clone = Instantiate(Bill, spawnPosition, spawnRotation);
            Enemy enemyScript = clone.GetComponent<Enemy>();
            enemyScript.target = target;
            yield return new WaitForSeconds(spawnWait);
        }
        
    }

}
