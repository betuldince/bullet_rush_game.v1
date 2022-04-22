using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Text remainingEnemy;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PrintNumberOfEnemy();
    }
    void PrintNumberOfEnemy()
    {
        remainingEnemy.text = gameManager.Instance.numberEnemy.ToString();
    }
}
