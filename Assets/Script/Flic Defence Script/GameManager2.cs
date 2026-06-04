
using UnityEngine;

using TMPro;



public class GameManager2 : MonoBehaviour

{

    public static GameManager2 instance;



    public int score;

    public bool isGameOver;



    public TextMeshProUGUI scoreText;

    public GameObject gameOverPanel;



    void Awake()

    {

        instance = this;

    }



    void Start()

    {

        score = 0;

        isGameOver = false;



        if (gameOverPanel != null)

            gameOverPanel.SetActive(false);



        UpdateScoreText();

    }



    public void AddScore(int point)

    {

        if (isGameOver) return;



        score += point;

        UpdateScoreText();

    }



    void UpdateScoreText()

    {

        if (scoreText != null)

            scoreText.text = "Score : " + score;

    }



    public void GameOver()

    {

        isGameOver = true;



        if (gameOverPanel != null)

            gameOverPanel.SetActive(true);

    }

}

