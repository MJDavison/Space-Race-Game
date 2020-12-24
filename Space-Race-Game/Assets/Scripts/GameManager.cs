using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    [Header("Game States")]
    [SerializeField] private GameObject MenuParent;
    [SerializeField] private GameObject GameParent;
    [SerializeField] private GameObject EndGameParent;

    [Header("Game State Scripts")]
    [SerializeField] private GameOver gameOverScript;

    [Header("Management Script References")]
    [SerializeField] private AsteroidManager asteroidManager;

    [Header("")]
    [Range(45,180)][SerializeField] public float fullGameTime;
    public float gameTimeRemaining;
    [SerializeField] float elapsedGameTime;
    [SerializeField] public bool gameActive = false;
    
    [Range(1,2)][SerializeField] public float gameSpeed = 1;
    [Range(0,100)] [SerializeField] private float debugGameSpeed = 1;

    [SerializeField] private int playerOneScore;
    [SerializeField] private int playerTwoScore;

    

    public GameResult result;

    public int PlayerOneScore { get => playerOneScore; set {
        if(value > 0){
            playerOneScore += value;
        }
    } }
    
    public int PlayerTwoScore { get => playerTwoScore; set {
        if(value > 0){
            playerTwoScore += value;
        }
    } }

    private void Awake() {
        GameParent.SetActive(false);
        EndGameParent.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameLoop();        
    }

    private void GameLoop(){
        if(gameActive){
            elapsedGameTime += Time.deltaTime * gameSpeed * debugGameSpeed;
            gameTimeRemaining = fullGameTime - elapsedGameTime;

            if(gameTimeRemaining <= 0){
                gameActive = false;
                GameEnd();
            }
            
        }
    }

    private void GameEnd(){
        GameParent.SetActive(false);
        asteroidManager.WipeAllAsteroids();
        if(playerOneScore < playerTwoScore){
            result = GameResult.PlayerTwo;
        } else if(playerOneScore > playerTwoScore){
            result = GameResult.PlayerOne;
        } else{
            result = GameResult.Drawed;
        }
        string finalScore =  playerOneScore+":"+playerTwoScore;                
        gameOverScript.GameResults(finalScore, result);
        EndGameParent.SetActive(true);

    }  

    public void GameStart(){
        MenuParent.SetActive(false);   
        GameParent.SetActive(true);
        gameActive = true;                     
    }

    
    

}

public enum GameResult{   
    PlayerOne,
    Drawed,    
    PlayerTwo,    
}




