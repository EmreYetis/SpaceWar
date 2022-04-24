using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnemyX : MonoBehaviour
{
    public float speed = 5.0f;
    public float xRange = -30f;  
   
    void Update()
    {
        BoundriesEnemy();        
    }

    void FixedUpdate()
    {      
            transform.Translate(Vector2.up * speed * Time.deltaTime);              
    }  
    public void Die()
    {      
        Destroy(gameObject);      
    }
    public void BoundriesEnemy()
    {      
        if (transform.position.x <= xRange)
        {           
            Die();            
        }
    }
    
}
