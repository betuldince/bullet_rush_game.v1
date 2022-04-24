using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectPool : MonoBehaviour
{
    // Start is called before the first frame update
    public static objectPool instance;
    private List<GameObject> pooledObjectsBullet = new List<GameObject>();
    private int amountToPoolBullet = 20;
    [SerializeField] private GameObject bulletPrefab;
    private List<GameObject> pooledObjectsEnemy = new List<GameObject>();
    private int amountToPoolEnemy = 5;
    [SerializeField] private GameObject enemyPrefabS;
    [SerializeField] private GameObject enemyPrefabB;

    [SerializeField] public Transform spawnPointSimple;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        for(int i = 0; i < amountToPoolEnemy; i++)
        {
            GameObject obj0 = Instantiate(enemyPrefabS);
            obj0.SetActive(false);
            pooledObjectsEnemy.Add(obj0);

        }
        for (int i = 0; i < amountToPoolEnemy; i++)
        {
            GameObject obj0 = Instantiate(enemyPrefabB);
            obj0.SetActive(false);
            pooledObjectsEnemy.Add(obj0);

        }
        for (int i = 0; i < amountToPoolBullet; i++)
        {
            GameObject obj = Instantiate(bulletPrefab);
            obj.SetActive(false);
            pooledObjectsBullet.Add(obj);

        }
    }

    public GameObject GetPooledBullet()
    {
        for(int i = 0; i < pooledObjectsBullet.Count; i++)
        {
            if (!pooledObjectsBullet[i].activeInHierarchy)
            {
                return pooledObjectsBullet[i];
            }
        }
        return null;
    }
    public GameObject GetPooledEnemy()
    {
        for (int i = 0; i < pooledObjectsEnemy.Count; i++)
        {
            if (!pooledObjectsEnemy[i].activeInHierarchy)
            {
                return pooledObjectsEnemy[i];
            }
        }
        return null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
