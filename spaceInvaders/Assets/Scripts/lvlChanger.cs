using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;
using UnityEngine.SceneManagement;
public class lvlChanger : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {

            restart();

        }
    }
    public void restart()
    {
        EnemyMover.deaths = 0;
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
        
    }
}