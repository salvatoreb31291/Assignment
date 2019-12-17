using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
     // Start is called before the first frame update
    [SerializeField] GameObject Ghost;
    [SerializeField] Transform firstSpwanPoint;
    [SerializeField] int maximumEnemies;
    [SerializeField] float spawnTime=5f;

    int currentEnemies=1;

    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        while(currentEnemies<=maximumEnemies)
        {
            GameObject enemy = Instantiate(Ghost, firstSpwanPoint.transform.position,transform.rotation);
            currentEnemies++;
            yield return new WaitForSeconds(spawnTime);
        }
    }
}
