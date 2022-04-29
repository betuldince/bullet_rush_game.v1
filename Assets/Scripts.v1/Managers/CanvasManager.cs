using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static CanvasManager Instance { get; private set; }
    public Text remainingEnemy;
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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PrintNumberOfEnemy()
    {
        remainingEnemy.text = "Remaining Enemies: " + EnemySpawn.Instance.enemies.Count;
    }
    public void PassNextLevel()
    {
        SceneManager.LoadScene(0);
    }
}
