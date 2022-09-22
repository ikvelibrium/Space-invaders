using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPref;
    
    void Start()
    {
        
    }

   
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Instantiate(bulletPref, transform.position, Quaternion.identity);
        }
    }
   
}
