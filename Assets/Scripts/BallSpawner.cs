using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ball;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawn()
    {
        Instantiate(ball, transform.position, transform.rotation);
    }
}
