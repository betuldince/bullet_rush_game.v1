using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform SpawningPoint;
    void Start()
    {
        SpawningPoint = objectPool.instance.SpawnPoint;
       
    }
    public void SpawnEnemy()
    {
        //GameObject bullet = Instantiate(bulletP,  Point.position,  Point.rotation);
        for(int i = 0; i < 4; i++)
        {
            GameObject enemySpawn = objectPool.instance.GetPooledEnemy();

            if (enemySpawn != null)
            {
                enemySpawn.transform.position = SpawningPoint.position;
                SpawningPoint.position = SpawningPoint.position + new Vector3(1.0f, 0f, 0f);
                enemySpawn.SetActive(true);

            }
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
