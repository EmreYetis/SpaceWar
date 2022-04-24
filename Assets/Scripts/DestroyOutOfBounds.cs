using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float minX = -25.0f;

    
    void Update()
    {
        if (transform.position.x < minX)
        {
            Destroy(gameObject);
        }
    }
}
