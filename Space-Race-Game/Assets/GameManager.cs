using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [Range(45,180)][SerializeField] public float fullGameTime;
    public float gameTimeRemaining;
    [SerializeField] float elapsedGameTime;
    [SerializeField] public bool gameActive = false;
    
    [Range(1,2)][SerializeField] public float gameSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        GameLoop();
    }

    // Update is called once per frame
    void Update()
    {
        GameLoop();
    }

    private void GameLoop(){
        if(gameActive){
            elapsedGameTime += Time.deltaTime;
            gameTimeRemaining = fullGameTime - elapsedGameTime;

            if(gameTimeRemaining == 0){
                gameActive = false;
            }
        }
    }

    public void GameStart(){
        gameActive = true;
    }


}
