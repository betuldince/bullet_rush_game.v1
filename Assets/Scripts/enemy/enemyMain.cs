using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class enemyMain : MonoBehaviour
{
    // Start is called before the first frame update
    protected Transform player;
    protected int health = 100;
    protected NavMeshAgent enemy;//tagla çalıştır
    //public Animator anim;

    protected virtual void Awake()
    {
        enemy = GetComponent<NavMeshAgent>();

        player = GameObject.FindWithTag("Player").gameObject.transform;

    }
    protected virtual void Start()
    {

         
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
        
        health = health - 100;

    }
    //protected virtual void EnemyRun(bool isRunning)
    //{
    //    anim.SetBool("isRunning", isRunning);
    //}


    // Update is called once per frame
    protected virtual void Update()
    {

    }

}
