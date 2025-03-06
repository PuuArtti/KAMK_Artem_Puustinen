using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PaddleScript : MonoBehaviour
{
    public float BounceForce = 35f;

    public GameManager GMan;


    private void Awake()
    {
        
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            other.gameObject.GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
            other.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * BounceForce);
           
            GMan.UpdateScore();

            if (GMan.newBallScore >= 500)
            {
                GMan.SpawnBall();
                GMan.newBallScore = 0;
            }

        }

        
    }
}

