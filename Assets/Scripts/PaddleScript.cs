using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    public float BounceForce = 35f;
    public GameManager GM;


    private void Awake()
    {
        GM = Camera.main.GetComponent<GameManager>();
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

            other.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * BounceForce);
            GM.score += 100;
        }
    }
}

