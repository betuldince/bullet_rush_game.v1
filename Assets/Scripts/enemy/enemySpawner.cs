using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform SpawningPointS;
    private int total_enemy;
    public static enemySpawner instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

    }
    void Start()
    {
        SpawningPointS = objectPool.instance.spawnPointSimple;
        total_enemy = levelManager.Instance.simple_enemy_num + levelManager.Instance.big_enemy_num;

    }
    public void SpawnEnemy()
    {
        //GameObject bullet = Instantiate(bulletP,  Point.position,  Point.rotation);
        for(int i = 0; i < total_enemy; i++)
        {
            GameObject enemySpawnS = objectPool.instance.GetPooledEnemy();
            
            if (enemySpawnS != null)
            {
                enemySpawnS.transform.position = SpawningPointS.position;
                SpawningPointS.position = SpawningPointS.position + new Vector3(2.0f, 0f, 0f);
                enemySpawnS.SetActive(true);


            }

        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
