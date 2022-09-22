using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed;
    
    

    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Vector2.up * bulletSpeed * Time.deltaTime);
        Destroy(gameObject, 5);
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
           
          
           
            Destroy(gameObject);
           
        } 
        
    }
    
}
