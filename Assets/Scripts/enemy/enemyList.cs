using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyList : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] List<GameObject> enemys = new List<GameObject>();
    [SerializeField] GameObject player;
    public int numEnemy=0;
    void Start()
    {
        enemyNumber();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Transform ClosestEnemy()
    {


        if (enemys.Count == 0) return null;


        Transform temp = enemys[0].transform;
        float dist = Mathf.Infinity;
        for (int i = 0; i < enemys.Count; i++)
        {
            if (dist >= Vector3.Distance(player.transform.position, enemys[i].transform.position))
            {
                temp = enemys[i].transform;
                dist = Vector3.Distance(player.transform.position, enemys[i].transform.position);
            }

        }

        return temp;

    }
    public void enemyNumber()
    {
        numEnemy= enemys.Count;

    }
    public void enemyNumberDecrease()
    {
        numEnemy--;
        

    }
}
