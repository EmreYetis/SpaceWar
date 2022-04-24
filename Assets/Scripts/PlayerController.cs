using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
   
    private float xRange = 18;
    private float yRange = 9;

    
    
    private void Start()
    {
        
        
            transform.position = new Vector2(-12, 0);
        
        
    }
    void FixedUpdate()
    {
        
            BoundriesPlayer();

            transform.Translate(Vector2.left * speed * Time.deltaTime * Input.GetAxis("Vertical"));
            transform.Translate(Vector2.up * speed * Time.deltaTime * Input.GetAxis("Horizontal"));

       


    }

    void BoundriesPlayer()
    {
        if (transform.position.y >= yRange)
        {
            transform.position = new Vector2(transform.position.x, yRange);
        }
        if (transform.position.y <= -yRange)
        {
            transform.position = new Vector2(transform.position.x, -yRange);
        }
        if (transform.position.x >= xRange)
        {
            transform.position = new Vector2(xRange, transform.position.y);
        }
        if (transform.position.x <= -xRange)
        {
            transform.position = new Vector2(-xRange, transform.position.y);
        }
    }

}
