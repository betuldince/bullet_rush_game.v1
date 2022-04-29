using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigEnem : enemyMain
{
    [SerializeField] protected int health_big = 200;

    // Start is called before the first frame update
    protected override void Awake()
    {
        base.Awake();

        health = health_big;

    }
    protected override void Start()
    {
        base.Start();
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
            Destroy(gameObject);
            EnemySpawn.Instance.enemies.Remove(gameObject);
            CanvasManager.Instance.PrintNumberOfEnemy();
            GameManager.Instance.EnemyDied();

        }
    }
}
