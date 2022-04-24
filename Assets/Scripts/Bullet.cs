using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public float damage = 1f;
    public float xRange = 25f;
    public Rigidbody2D rb;
    

    void Start()
    {
        
            rb.velocity = transform.up * speed;
        
        
    }
    void Update()
    {
        BoundriesBullet();
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        EnemyX enemyX = hitInfo.GetComponent<EnemyX>();
        if (enemyX != null)
        {
            enemyX.Die();
        }
               
        Destroy(gameObject);              
    }

    void BoundriesBullet()
    {

        if (transform.position.x >= xRange)
        {
            Destroy(gameObject);
        }
        
    }
}

    
