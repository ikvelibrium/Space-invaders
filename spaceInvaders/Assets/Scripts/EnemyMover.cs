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
    private int amountOfShips = 0;
    public GameObject invader;
    public Transform parent;
    
    [SerializeField] private GameObject looseScreen;
    [SerializeField] private GameObject winScreen;
    public int deaths = 0;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (amountOfShips < 14)
        {
            Instantiate(invader, transform.position, Quaternion.identity, parent);
            amountOfShips++;
        }
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
        if(collision.gameObject.layer == 7) 
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - goingDownScale, transform.position.z);
            goingRight = false;
        }
        if(collision.gameObject.layer == 6)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - goingDownScale, transform.position.z);
            goingRight = true;
        } 
        if(collision.gameObject.layer == 11)
        {
            
            looseScreen.SetActive(true);
            Time.timeScale = 0f;
        }
        if (deaths ==  13)
        {
            winScreen.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
