using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] Enemy;
    public float timer;
    public float spawnTime;
    public float SpawnPointY;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnTime = Random.Range(1f, 5f);
        SpawnPointY = Random.Range(0f, 12f);
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        
        if (timer > spawnTime)
        {
            Spawn();
           
        }
    }
      
           
        
    
    public void Spawn()
    {

        Instantiate(Enemy[Random.Range(0, Enemy.Length) ], new Vector3(transform.position.x, SpawnPointY, 0f), transform.rotation );
        timer = 0f;
        spawnTime = Random.Range(1f, 5f);
        SpawnPointY = Random.Range(0f, 12f);
       
    }
}
