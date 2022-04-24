using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class enemyMain : MonoBehaviour
{
    // Start is called before the first frame update
    protected Transform player;
    private enemySpawner enemySpawned;
    protected int health = 100;
    GameObject[] enemies;
    protected virtual void Awake()
    {
        //enemySpawned.SpawnEnemy();
        enemies = GameObject.FindGameObjectsWithTag("enemySpawned");
        player = GameObject.FindWithTag("Player").gameObject.transform;

    }
    protected virtual void Start()
    {


    }

    protected virtual void FindTarget()
    {



        foreach(var x in enemies)
        {
            x.transform.position= Vector3.MoveTowards(transform.position, player.transform.position, .06f); 
        }
    }
    protected virtual void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            SceneManager.UnloadSceneAsync("SampleScene");
            SceneManager.LoadScene("FinishedScene");

        }
    }
    public virtual void Damage()
    {
        
        health = health - 100;
        Debug.Log(health);

    }


    // Update is called once per frame
    protected virtual void Update()
    {

    }
}
