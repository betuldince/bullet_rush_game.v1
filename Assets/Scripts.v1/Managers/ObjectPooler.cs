using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    // Start is called before the first frame update
    public static ObjectPooler Instance { get; private set; }
    public List<Queue<GameObject>> pooledObjects;
    [SerializeField] public int poolSize;
    [SerializeField] private GameObject enemyPrefabS;
    [SerializeField] private GameObject enemyPrefabB;
    [SerializeField] private GameObject bullet;
    private int i = 0;

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
        pooledObjects = new List<Queue<GameObject>>();
        Queue<GameObject> queue = new Queue<GameObject>();
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(bullet);
            obj.SetActive(false);
            queue.Enqueue(obj);
        }
        pooledObjects.Add(queue);

    }
    public GameObject SpawnObject(Vector3 position, Quaternion rotation)
    {
        for(int i = 0; i < poolSize; i++)
        {
            GameObject newObjectSpawned = pooledObjects[i].Dequeue();
            newObjectSpawned.transform.position = position;
            newObjectSpawned.transform.rotation = rotation;

            pooledObjects[i].Enqueue(newObjectSpawned);
            return newObjectSpawned;
        }
        return null;


        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
