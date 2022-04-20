using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class bigEnemyFollow : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform PlayerBack;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(PlayerBack.position);
    }

    protected virtual void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {

        }

    }
}
