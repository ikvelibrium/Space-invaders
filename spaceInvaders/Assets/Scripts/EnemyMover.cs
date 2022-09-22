using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    public float Speed;
    public float rightSpeed;
    public float leftSpeed;
    private bool goingRight = true;
    public float goingDownScale = 1;

    
    void Start()
    {
        
    }

    
    void Update()
    {
        
        if (goingRight == true)
        {
            Speed = rightSpeed;
        }
        if(goingRight == false)
        {
            Speed = leftSpeed;
        }
        transform.Translate(Vector2.right * Speed * Time.deltaTime);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "rightWall") // заменить на collision со слоем
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - goingDownScale, transform.position.z);
            goingRight = false;
        }
        if(collision.gameObject.tag == "leftWall")
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - goingDownScale, transform.position.z);
            goingRight = true;
        }
    }
}
