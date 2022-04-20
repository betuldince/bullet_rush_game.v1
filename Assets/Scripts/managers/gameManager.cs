using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int numEnemy = 48;
    public static gameManager ins;
    public enemyList EnemyList;
    void Awake()
    {
        ins = this;
    }
     void Start()
    {
         
    }
    public void enemyKilled()
    {
        numEnemy--;
    }

    // Update is called once per frame
    void Update()
    {
        
        Debug.Log(numEnemy);

    }
}
