using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 25f;
    private Rigidbody rb;
    [SerializeField] private enemyList EnemyList; //eski haline döndür dene
    private Vector3 _movement;

    //private float counter = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.MovePosition(rb.position + (-transform.right.normalized * Time.deltaTime * speed));
   

    }


    private void OnCollisionEnter(Collision collision)
    {

        //if (collision.gameObject.tag == "enemySpawned"|| collision.gameObject.tag == "Simple"|| collision.gameObject.tag == "Big")
        //{
        //    collision.gameObject.GetComponent<enemyMain>().Damage();
        //    gameObject.SetActive(false);


        //}
        //else
        //{
        //    collision.gameObject.GetComponent<enemyModel>().Damage();
        //    gameObject.SetActive(false);


        //}
        collision.gameObject.GetComponent<enemyMain>().Damage();
        gameObject.SetActive(false);



    }
}
