using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public float lives;
    [SerializeField] private GameObject looseScreen;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.layer == 10)
        {
            lives -= 1;
            if(lives <= 0)
            {
                looseScreen.SetActive(true);
            }
        }
        if (collision.gameObject.layer == 9)
        {
            lives -= 3;
            if (lives <= 0)
            {
                looseScreen.SetActive(true);
            }
        }

    }
}
