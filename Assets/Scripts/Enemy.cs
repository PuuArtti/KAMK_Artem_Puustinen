using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 1000f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.left * speed * Time.deltaTime);
        
    }
}
