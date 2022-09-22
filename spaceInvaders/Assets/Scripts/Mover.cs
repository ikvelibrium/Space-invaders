using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float Speed;
    public float hInput;
    
    void Start()
    {
       
    }

    
    void Update()
    {
        hInput = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector2.right * hInput * Speed * Time.deltaTime);
    }
}
