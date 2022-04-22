using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
public class enemyStructure : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] protected float health = 100f;
    [SerializeField] protected Transform player;
    [SerializeField] protected GameObject finish;
     protected NavMeshAgent enemy;
    
    protected virtual void Start()
    {
        enemy = GetComponent<NavMeshAgent>();
        player = GameObject.FindWithTag("Player").gameObject.transform;
        finish.SetActive(false);
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
 
    protected virtual void Update()
    {
        
    }

}
