using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mob : MonoBehaviour
{
    public static int maxhp = 100;
    public static int hp = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float hp1;
    public int damage;
    public BaseHealth baseHealth;
    int q = 0;
    //public class Enemy : MonoBehaviour
    
        public  float health = 100f;

        // Функция для нанесения урона врагу
        public void TakeDamage(float damage)
        {
            health -= damage;
            if (health <= 0f)
            {
                Die();
            }
        }
        // Update is called once per frame
        void Update()
    {
        //hp1 = hp;
        var enemy1 = gameObject.GetComponent<hp>();
        hp1 = health;
        enemy1.hp1 = health;


        if (baseHealth != null && Vector3.Distance(transform.position, baseHealth.transform.position) < 0.5)
        {
            if (q == 0)
            {
                q = 1;

                baseHealth.TakeDamage(damage);
                TakeDamage(100);

            }
        }
        else { q = 0; }
        //if(hp <= 0)
        //{
        //    Destroy(gameObject);
        //}

    }
    private void Die()
    {
        Destroy(gameObject);
    }
}
    


