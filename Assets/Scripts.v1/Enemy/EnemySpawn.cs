using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public static EnemySpawn Instance { get; private set; }
    public int littleEnemyNumber=1;
    public int bigEnemyNumber=1;

    public ArrayList enemies = new ArrayList();
    public GameObject spawnPoint;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    void Start()
    {
        
        littleEnemyNumber = levelManager.Instance.simple_enemy_num;
        bigEnemyNumber = levelManager.Instance.big_enemy_num;
        SpawnEnemies(littleEnemyNumber, bigEnemyNumber);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SpawnEnemies(int littleEnemyNum, int bigEnemyNum)
    {
        for (int i = 0; i < littleEnemyNum; i++)          
        {
            Vector3 spawnPosition = spawnPoint.transform.position+new Vector3(0.5f,0f,0.5f);
            GameObject smallEnemy = ObjectPooler.Instance.SpawnEnemySmall(spawnPosition, Quaternion.identity);
            smallEnemy.SetActive(true);
            enemies.Add(smallEnemy);

        }
        for (int i = 0; i < bigEnemyNumber; i++)
        {
            Vector3 spawnPosition = spawnPoint.transform.position+ new Vector3(1.0f,0f,1.0f);
            GameObject bigEnemy = ObjectPooler.Instance.SpawnEnemyBig(spawnPosition, Quaternion.identity);
            bigEnemy.SetActive(true);
            enemies.Add(bigEnemy);

        }
    }
}
