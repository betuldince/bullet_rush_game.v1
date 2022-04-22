using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class enemyModel : MonoBehaviour
{
    protected Transform player;
    protected NavMeshAgent enemy;
    protected int health = 100;
    
    // Start is called before the first frame update
    protected virtual void Awake()
    {
        
        enemy = GetComponent<NavMeshAgent>();
        player = GameObject.FindWithTag("Player").gameObject.transform;

    }
    protected virtual void FindTarget()
    {
        enemy.SetDestination(player.position);
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
        health =health -100;
        
    }


    // Update is called once per frame
    protected virtual void Update()
    {

    }
}
