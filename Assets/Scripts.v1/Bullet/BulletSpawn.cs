using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;
    private float wait;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        wait = wait + Time.deltaTime;
        if (wait > 0.2f)
        {
          SpawnBullet(enemy.transform.position);
          wait = 0f;
        }
    }
    private void SpawnBullet(Vector3 target)
    {
        GameObject bullet = ObjectPooler.Instance.SpawnObject( transform.position, Quaternion.identity);
        bullet.SetActive(true);
        bullet.GetComponent<Bullet>().ThrowBulletTo(target);
    }
}
