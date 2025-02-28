using UnityEngine;

public class BasicEnemy : MonoBehaviour
{

    public float xPos;
    public float enemySpeed = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xPos -= enemySpeed * Time.deltaTime;
        transform.position = new Vector3(xPos,0,0);
    }
}
