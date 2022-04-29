using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{

    public static gameManager Instance { get; private set;}
    public int numberEnemy;

    public int healthSimple=100;
    public int healthBig=200;
    [SerializeField] private enemySpawner _enemySpawner;

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
    private void Start()
    {
        _enemySpawner.SpawnEnemy();

    }






}
