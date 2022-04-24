using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigEnemy : bigEnemyStructure
{
    // Start is called before the first frame update
    // Start is called before the first frame update
 
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
             
            gameObject.SetActive(false);            
            gameManager.Instance.numberEnemy--;

        }
    }
    public void KilledEnemy()
    {
        gameObject.SetActive(false);
    }

}
