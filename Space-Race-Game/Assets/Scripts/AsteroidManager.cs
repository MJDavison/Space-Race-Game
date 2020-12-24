using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidManager : MonoBehaviour
{
    [SerializeField] private GameObject asteroidPrefab;
    [SerializeField] internal int numOfAsteroids;
    [SerializeField] private GameObject[] asteroidArray;
    [SerializeField] private GameObject[] asteroidSpawnPoints;
    [SerializeField] private float asteroidSpeed;
    // Start is called before the first frame update
    void Start()
    {
        asteroidArray = new GameObject[numOfAsteroids];
        SpawnAsteroids();
    }

    private void SpawnAsteroids(){
        // int callCount = 0;
        Vector2 velocityDir = Vector2.zero;
        float xPos;
        for (int i = 0; i < asteroidArray.Length / 2; i++)
        {
            for (int j = 0; j <= 1; j++)
            {                
                if(j == 0){
             
                    xPos = asteroidSpawnPoints[j].transform.position.x + Random.Range(0f,30);
                } else{
                    velocityDir = Vector2.left;
                    xPos = asteroidSpawnPoints[j].transform.position.x - Random.Range(0,30);
                }
                Instantiate(asteroidPrefab, new Vector3(xPos, Random.Range(2f,8.6f), asteroidSpawnPoints[j].transform.position.z),Quaternion.identity);  
                // callCount++;
                // print("called "+ callCount);                                  
            }
            
        }
        asteroidArray = GameObject.FindGameObjectsWithTag("Asteroid");
        foreach (GameObject asteroid in asteroidArray)
        {
            if(asteroid.transform.position.x < 0){
                velocityDir = Vector2.right;
            } else{
                velocityDir = Vector2.left;            }
            asteroid.GetComponent<Rigidbody2D>().velocity = velocityDir * asteroidSpeed;
        }
    }
    
    public void WipeAllAsteroids(){
        for (int i = 0; i < asteroidArray.Length; i++)
        {
            Destroy(asteroidArray[i]);
            asteroidArray[i] = null;            
        }
        // print("All Asteroids Cleared");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
