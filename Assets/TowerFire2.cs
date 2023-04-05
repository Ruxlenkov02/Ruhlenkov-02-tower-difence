using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TowerFire2 : MonoBehaviour
{
    public float topBound = 30.0f;
    public float bottomBound = -10.0f;
    public float leftBound = -20.0f;
    public float rightBound = 20.0f;

    public GameObject bulletPrefab;
    public float fireRate;
    private float nextFire;

    void Update()
    {
        if (tower2.w == 2)
        {
            GameObject[] bullets = GameObject.FindGameObjectsWithTag("bullet");
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

            foreach (GameObject enemy in enemies)

            {

                if (Vector3.Distance(transform.position, enemy.transform.position) < 10)
                { //задаем радиус обзора башни
                    if (Time.time > nextFire)
                    {
                        nextFire = Time.time + fireRate;
                        Vector3 direction = enemy.transform.position - transform.position;
                        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity) as GameObject;
                        bullet.GetComponent<Rigidbody>().AddForce(direction * 100); //задаем скорость и направление пули
                        var enemy1 = enemy.GetComponent<mob>();
                        enemy1.TakeDamage(2);
                    }
                    //else Destroy(bullet);
                }
            }
            foreach (GameObject bullet in bullets)
                if (bullet.transform.position.y > topBound || bullet.transform.position.y < bottomBound || bullet.transform.position.x < leftBound || bullet.transform.position.x > rightBound)
                {
                    Destroy(bullet);
                }
        }
    }
}

