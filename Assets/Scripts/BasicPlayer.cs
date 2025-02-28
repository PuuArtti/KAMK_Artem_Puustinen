using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BasicPLayer : MonoBehaviour
{

    public Rigidbody2D myRB;
    public float power = 200f;
    public float movementSpeed = 20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();




    }

    // Update is called once per frame
    void Update()
    {
        //Moves the player according to keyboard inputs, and limit X and Y movement range
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -16.3f, 14f), Mathf.Clamp(transform.position.y,-5f, 12.5f), 0 );

        float hor = Input.GetAxis("Horizontal");
        print(hor);

        transform.Translate(Vector3.right * hor * movementSpeed * Time.deltaTime);

        //Jump the player using rigid body

        if (Input.GetKeyDown(KeyCode.W))
        {
            myRB.linearVelocity = Vector2.zero;
            myRB.AddForce(Vector2.up * power);
        }

        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        //Reload level if hit Object tagged "Enemy"
        if (other.gameObject.CompareTag("Enemy")) 
        {
            SceneManager.LoadScene(0);
        
        }
    }

}
