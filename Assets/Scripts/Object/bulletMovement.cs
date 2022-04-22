using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 25f;
    private Rigidbody rb;
    private float counter = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Destroy(gameObject, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        rb.MovePosition(rb.position + (transform.forward * Time.deltaTime * speed));
    }
    private void OnCollisionEnter(Collision collision)
    {

        collision.gameObject.GetComponent<enemyModel>().Damage();
        Destroy(gameObject);


    }
}
