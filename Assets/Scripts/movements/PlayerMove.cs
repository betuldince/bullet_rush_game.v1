using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update

    float xt, yt;
    [SerializeField] float speed = 0.05f;
    public static bool isSwipe = false;
    private Vector2 startPos;
    private Vector2 swipe;
    public static float x, y;
    [SerializeField] private bulletFire fire;
    [SerializeField] private enemyList EnemyList;
    public GameObject gun;
    public static float distance;
    private bool isAttacked=false;
    private enemySpawner enemySpawned;
    [SerializeField] private enemySpawner _enemySpawner;


    // Update is called once per frame


    void Update()
    {
        

        if (Input.touches.Length > 0)
        {
            if (Input.touches[0].phase == TouchPhase.Began)
            {

                isSwipe = true;
                startPos = Input.touches[0].position;
            }
            else if (Input.touches[0].phase == TouchPhase.Ended || Input.touches[0].phase == TouchPhase.Canceled)
            {
                isSwipe = false;
                startPos = Vector2.zero;
            }
        }

        if (isSwipe)
        {
            if (Input.touches.Length < 0)
                swipe = Input.touches[0].position - startPos;
            else if (Input.GetMouseButton(0))
                swipe = (Vector2)Input.mousePosition - startPos;
        }



        if (isSwipe)
        {
            xt = swipe.x * Time.deltaTime * speed;
            yt = swipe.y * Time.deltaTime * speed;
            transform.Translate(xt, 0, yt);

        }
        RotateGun();
        //StartCoroutine(firebullet());
        distance = Vector3.Distance(gameObject.transform.position, EnemyList.ClosestEnemy().position);
        if (distance > 15f)
        {
            stop();
        }
        else
        {
            if (!isAttacked)
            {
                StartCoroutine(firebullet());
            }
        }

    }

    private void RotateGun()
    {
        Transform c_enemy = EnemyList.ClosestEnemy();

        Quaternion lookRot = Quaternion.LookRotation(c_enemy.position - transform.position);
        gun.transform.rotation = Quaternion.RotateTowards(gun.transform.rotation, lookRot, 30f * Time.deltaTime);
    }




    private void Start()
    {
        //StartCoroutine(firebullet());
        _enemySpawner.SpawnEnemy();

    }
    private void stop()
    {
        StopCoroutine(firebullet());
        isAttacked = false;
    }


    private IEnumerator firebullet()
    {
        isAttacked = true;
        while (isAttacked)
        {
 
                fire.FireBullet();
                yield return new WaitForSeconds(0.3f);
 
        }
        isAttacked = false;

    }


}
