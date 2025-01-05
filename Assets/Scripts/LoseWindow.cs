using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LoseWindow : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI bestscoreText;
    public Sprite[] medals;
    public void PlayerLose()
    {
           int score = ScoreManager.Instance.score;
           scoreText.text = score.ToString();
           int bestScore = PlayerPrefs.GetInt("BestScore");
           if(score>bestScore)
           {
            bestScore=score;
           }
           bestscoreText.text=bestScore.ToString();
           PlayerPrefs.SetInt("BestScore",bestScore);
    }
}
