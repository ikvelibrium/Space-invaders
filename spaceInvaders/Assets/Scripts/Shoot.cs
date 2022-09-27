using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline.Actions;
using UnityEngine;
public class Shoot : MonoBehaviour
{
    public GameObject bulletPref;
    private float reloadTime = 0;
    void Start()
    {

    }

    void Update()
    {

        reloadTime -= Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) && reloadTime <= 0)
        {
            Instantiate(bulletPref, transform.position, Quaternion.identity);
            reloadTime = 0;
        }


    }

}
