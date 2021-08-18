using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private Text scoreText;

     private int score;

    public int Score
    {
        get { return score; }
        set
        {
            score = value;
            scoreText.text = "SCORE: " + score.ToString();
        }
    }

    private void Awake()
    {
        Score = 0;
    }
}


