using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class bigEnemyStructure : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] protected float health = 200f;
    [SerializeField] protected Transform player;
    protected NavMeshAgent enemy;

    protected virtual void Start()
    {
        enemy = GetComponent<NavMeshAgent>();
        player = GameObject.FindWithTag("Player").gameObject.transform;
        
    }
    public virtual void Damage()
    {
        health = health - 100;
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

    // Update is called once per frame
    protected virtual void Update()
    {

    }
}
