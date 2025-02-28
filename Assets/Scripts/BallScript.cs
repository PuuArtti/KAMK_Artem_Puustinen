using UnityEngine;

public class BallScript : MonoBehaviour
{
    public GameManager GM;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GM = Camera.main.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Ground") 
        {

            GM.lives -= 1;
            Destroy(gameObject);
        
        }
    }

}

