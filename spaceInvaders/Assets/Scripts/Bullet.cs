using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed;
    private Score score;
    [SerializeField] int pointsToPlus;

    void Start()
    {
        score = GameObject.Find("Points").GetComponent<Score>();
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

            EnemyMover.deaths++;
            
            Destroy(collision.gameObject);
            score.updateScore(pointsToPlus);
            Destroy(gameObject);
           
        } 
        
    }
    
}
