using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Text remainingEnemy;
    public static levelManager Instance { get; private set; }

    [SerializeField] levels[] levels;
    public levels currentLevel;

    public int level_count=0;
    public int simple_enemy_num;
    public int big_enemy_num;

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


        currentLevel = levels[level_count];
        simple_enemy_num = currentLevel.simple_enemy_number;
        big_enemy_num = currentLevel.big_enemy_number;


    }

    // Update is called once per frame
    void Update()
    {
        PrintNumberOfEnemy();
        currentLevel = levels[level_count];
    }
    void PrintNumberOfEnemy()
    {
        remainingEnemy.text = gameManager.Instance.numberEnemy.ToString();
    }
    public void NextLevel()
    {
        level_count++;
    }
}
