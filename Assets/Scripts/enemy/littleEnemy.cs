using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class littleEnemy : enemyMain
{
    [SerializeField] protected int health_simple = 100;
    Animator anim;

    // Start is called before the first frame update
    protected override void Awake()
    {
        base.Awake();

        health = health_simple;

    }
    protected override void Start()
    {
        base.Start();
        anim = GetComponent<Animator>();

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
            //anim.SetBool("isDying", true);
            gameManager.Instance.numberEnemy--;

        }
    }
}
