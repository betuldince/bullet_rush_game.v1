using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicEnemy : enemyModel
{
    // Start is called before the first frame update
    [SerializeField] protected int health_simple = 100;
    protected override void Awake()
    {
        base.Awake();
        health = health_simple;
        
    }
    protected override void Update()
    {
        FindTarget();
        

    }
    protected override void OnCollisionEnter(Collision collision)
    {
        base.OnCollisionEnter(collision);
    }

    public override void Damage()
    {
        base.Damage();
        if (health == 0)
        {
            gameObject.SetActive(false);
            gameManager.Instance.numberEnemy--;

        }
    }


}
