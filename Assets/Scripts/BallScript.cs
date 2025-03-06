using UnityEngine;

public class BallScript : MonoBehaviour
{
    public GameManager GM;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GM = GameObject.Find("GameManagerObject").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.CompareTag("Floor")) 
        {
            GM.LoseLife();
            Destroy(gameObject);
        
        
        }


    
    }
    

}

