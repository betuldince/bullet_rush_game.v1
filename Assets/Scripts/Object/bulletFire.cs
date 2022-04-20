using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletFire : MonoBehaviour
{
    [SerializeField] private GameObject bulletP ;
    [SerializeField] private Transform  Point;

    public void FireBullet()
    {
        GameObject bullet = Instantiate(bulletP,  Point.position,  Point.rotation);

    }
}
