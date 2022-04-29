using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int remainingEnemy;
    public int totalEnemy;
    public static GameManager Instance { get; private set; }

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
        remainingEnemy = EnemySpawn.Instance.enemies.Count;
        CanvasManager.Instance.PrintNumberOfEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnemyLost()
    {
        if (remainingEnemy <= 0)
        {
            Win();
        }
    }
    public void Win()
    {
        levelManager.Instance.NextLevel();
    }
    public void EnemyDied()
    {
        remainingEnemy--;
    }
}
