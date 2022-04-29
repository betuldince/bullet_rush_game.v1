using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 25f;
    private Rigidbody rb;
    private Rigidbody pb;

    [SerializeField] private enemyList EnemyList; //eski haline döndür dene
    private Vector3 _movement;
    //private float counter = 0;
    private GameObject player;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindWithTag("Player");
        pb=player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.MovePosition(rb.position + (-transform.right.normalized * Time.deltaTime * speed));
        objectPool.instance.GetPooledBullet();

        //eğer çok uzaklaşırsa da set active false
        if ((rb.position.x-pb.position.x)>10.0f || (rb.position.z - pb.position.z) > 10.0f || (rb.position.y - pb.position.y) > 10.0f)
        {
            gameObject.SetActive(false);

        }


    }


    private void OnCollisionEnter(Collision collision)
    {

        
        collision.gameObject.GetComponent<enemyMain>().Damage();
        gameObject.SetActive(false);



    }
}
