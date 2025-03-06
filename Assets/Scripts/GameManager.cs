using JetBrains.Annotations;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{//Variables

    public int score;
    public int HiScore;
    public int lives = 3;

    public GameObject scoreUI;
    public GameObject HiScoreUI;
    public GameObject LivesUI;

    public GameObject Ball;

    public GameObject[] ballsInGame;
    public int newBallScore;

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
      public void GameOver() 
    {

        //Find Remaining Balls and destroy them
        ballsInGame = GameObject.FindGameObjectsWithTag("Ball");
        for (int i=0;i <ballsInGame.Length; i++) 
        {
            Destroy(ballsInGame[i]);
        }

        if(score > HiScore) 
        {
            HiScore = score;
            HiScoreUI.GetComponent<TextMeshProUGUI>().text = "HiScore:" + HiScore.ToString();

        }

        


        print("GameOver");
    
    }

    public void UpdateScore() 
    {
        score += 100;
        newBallScore += 100;
        scoreUI.GetComponent<TextMeshProUGUI>().text = "Score:" + score.ToString();

    }


    }