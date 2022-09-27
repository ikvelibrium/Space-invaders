using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    
    [SerializeField] int score;
    public TMP_Text pointsAmout;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void updateScore(int pointsToPlus)
    {
        score += pointsToPlus;
        pointsAmout.text = "¬аш счет: " + score;
    }
}
