using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 targetPos;
    public Rigidbody rb;
    public float speed;


    void Start()
    {
        Invoke("Deactivate", 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ThrowBulletTo(Vector3 enemyPos)
    {
        targetPos = enemyPos - gameObject.transform.position;
        rb.velocity = Vector3.zero;
        rb.AddForce(targetPos * speed * Time.deltaTime);
    }
    private void Deactivate()
    {

        gameObject.SetActive(false);

    }
}
