using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleEnemy : enemyStructure
{
    // Start is called before the first frame update
    [SerializeField] protected gameManager GameManager;

    protected override void Start()
    {
        base.Start();   
    }
    protected override void Update()
    {
        FindTarget();
        EnemyDamaged();
    }
    protected override void OnCollisionEnter(Collision collision)
    {
        base.OnCollisionEnter(collision);
    }
    public virtual void EnemyDamaged()
    {
        if (health == 0)
        {
            //KilledEnemy();
            gameObject.SetActive(false);
            GameManager.enemyKilled();

        }
    }
 



}
