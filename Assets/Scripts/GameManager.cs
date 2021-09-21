using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public Text scoreText;

    private void Start()
    {
        score = 0;
        scoreText.text = score.ToString();
    }

    public void UpdateScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void ReStartGame()
    {
        SceneManager.LoadScene(0);
    }
}
