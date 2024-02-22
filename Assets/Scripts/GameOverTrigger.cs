using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GameOverTrigger : MonoBehaviour
{
    public GameManager gameManager;

    public TextMeshProUGUI txtScoreText;
    public GameObject gameOver;
    public GameObject ball;
    public GameObject paddle;
    public GameObject resetButton;
    public GameObject timeText;
    public GameObject timerText;
    public float currentScore;

    void Update()
    {
        currentScore = gameManager.score;
        currentScore = Mathf.FloorToInt(currentScore);
    }

    public void OnCollisionEnter2D(Collision2D actor)
    {
        if (actor.gameObject.CompareTag("Ball"))
        {
            Time.timeScale = 0f;
            gameOver.SetActive(true);
            ball.gameObject.SetActive(false);
            paddle.gameObject.SetActive(false);
            resetButton.gameObject.SetActive(false);
            timeText.gameObject.SetActive(false);
            timerText.gameObject.SetActive(false);
            txtScoreText.text = gameManager.score.ConvertTo<int>().ToString() + " seconds";
        }
    }
}
