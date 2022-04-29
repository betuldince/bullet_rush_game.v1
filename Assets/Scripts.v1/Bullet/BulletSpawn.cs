using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    
    private float wait;
    private Vector3 closestEnemy;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        wait = wait + Time.deltaTime;


        ArrayList allEnemies = EnemySpawn.Instance.enemies;
        GameObject[] enemyArray = allEnemies.ToArray(typeof(GameObject)) as GameObject[];
        closestEnemy = GetClosestEnemyPos(enemyArray);
        if (wait > 0.2f)
        {
            SpawnBullet(closestEnemy);
            wait = 0f;
        }
        //SpawnBullet(closestEnemy);
    }
    private void SpawnBullet(Vector3 target)
    {
        GameObject bullet = ObjectPooler.Instance.SpawnObject( transform.position, Quaternion.identity);
        bullet.SetActive(true);
        bullet.GetComponent<Bullet>().ThrowBulletTo(target);
    }
    private Vector3 GetClosestEnemyPos(GameObject[] enemies)
    {
        Vector3 closestEnemyPos = enemies[0].transform.position;
        float closestDistance = (closestEnemyPos - gameObject.transform.position).magnitude;

        for (int i = 0; i < enemies.Length; i++)
        {
            float distanceWithPlayer = (gameObject.transform.position - enemies[i].transform.position).magnitude;

            if (distanceWithPlayer < closestDistance)
            {
                closestDistance = distanceWithPlayer;
                closestEnemyPos = enemies[i].transform.position;
            }
        }

        return closestEnemyPos;
    }
}
