using JetBrains.Annotations;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{//Variables

    public int score;
    public int HiScore;
    public int lives = 3;

    public GameObject scoreUI;
    public GameObject HiScoreUI;
    public GameObject LivesUI;
    public GameObject RetryButton;
    public GameObject QuitButtonUI;
    public GameObject GameOverText;

    public GameObject Ball;

    public GameObject[] ballsInGame;
    public int newBallScore;

    private void Awake()
    {
        RetryButton.SetActive(false);
        QuitButtonUI.SetActive(false);
        GameOverText.SetActive(false);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ballsInGame = GameObject.FindGameObjectsWithTag("Ball");
        scoreUI.GetComponent<TextMeshProUGUI>().text = "Score:" + score.ToString();
        LivesUI.GetComponent<TextMeshProUGUI>().text = "Lives:" + lives.ToString();
        HiScoreUI.GetComponent<TextMeshProUGUI>().text = "HiScore:" + HiScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {

        


    }

    public void SpawnBall() 
    
    {
        Instantiate(Ball, transform.position, transform.rotation);
        ballsInGame = GameObject.FindGameObjectsWithTag("Ball");


    }

    public void LoseLife()
    {
        lives -= 1;
        LivesUI.GetComponent<TextMeshProUGUI>().text = "Lives:" + lives.ToString();

        if (lives <= 0)
        {
            GameOver();



        }

        //Check How many balls are left and if there are zero balls but player still have live, spawn one ball
        ballsInGame = GameObject.FindGameObjectsWithTag("Ball");
        int BallsLeft = ballsInGame.Length;
        if (BallsLeft <= 1 && lives >=1)
        {
            SpawnBall();


        }
    }

    public void Retry() 
    {
        lives = 3;
        score = 0;
        RetryButton.SetActive(false);
        SpawnBall();
        scoreUI.GetComponent<TextMeshProUGUI>().text = "Score:" + score.ToString();
        LivesUI.GetComponent<TextMeshProUGUI>().text = "Lives:" + lives.ToString();
        HiScoreUI.GetComponent<TextMeshProUGUI>().text = "HiScore:" + HiScore.ToString();
        GameOverText.SetActive(false);
        QuitButtonUI.SetActive(false);


    }



      public void GameOver() 
    {

        //Find Remaining Balls and destroy them
        ballsInGame = GameObject.FindGameObjectsWithTag("Ball");
        for (int i=0;i <ballsInGame.Length; i++) 
        {
            Destroy(ballsInGame[i]);
        }
        //Update Hiscore
        if(score > HiScore) 
        {
            HiScore = score;
            HiScoreUI.GetComponent<TextMeshProUGUI>().text = "HiScore:" + HiScore.ToString();

        }

        //Show Retry Button
        RetryButton.SetActive(true);
        QuitButtonUI.SetActive(true);
        GameOverText.SetActive(true);


        print("GameOver");
    
    }

   

    public void UpdateScore() 
    {
        score += 100;
        newBallScore += 100;
        scoreUI.GetComponent<TextMeshProUGUI>().text = "Score:" + score.ToString();

    }
     public void QuitGame() 
    {
        
    
    }

    }