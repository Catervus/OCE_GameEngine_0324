using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    private int score;
    private int highscore;

    [SerializeField]
    private TMP_Text scoreText;

    [SerializeField]
    private TMP_Text highscoreText;


    void Start()
    {

        LoadHighscore();

        UpdateScoreUI();
        UpdateHighscoreUI();
    }

    public void AddScore(int _scoreamount)
    {
        score += _scoreamount;
        UpdateScoreUI();

        if(score > highscore)
        {
            highscore = score;
            UpdateHighscoreUI();
        }
    }

    public void ResetHighscore()
    {
        Debug.Log("Reset Highscore");
        highscore = 0;
        SaveHighscore();
        UpdateHighscoreUI();
    }

    public void AddScore()
    {
        AddScore(1);
    }

    private void UpdateScoreUI()
    {
        scoreText.text = score.ToString();
    }

    private void UpdateHighscoreUI()
    {
        highscoreText.text = highscore.ToString();
    }

    private void LoadHighscore()
    {
        highscore = PlayerPrefs.GetInt("Highscore");
    }

    public void SaveHighscore()
    {
        PlayerPrefs.SetInt("Highscore", highscore);
        Debug.Log("Saving Highscore!");
    }


}
