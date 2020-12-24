using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameOver : MonoBehaviour
{
    [SerializeField] GameManager myGM;
    [SerializeField] Text finalScoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameResults(string finalScore, GameResult result){
        string gameResult;
        switch(result){
            case GameResult.PlayerOne:
                gameResult = "Player One";
                finalScoreText.text =  gameResult +" Won!" + "\n\nFinal Score: \n" + finalScore;
                break;
            case GameResult.PlayerTwo:
                gameResult = "Player Two";
                finalScoreText.text =  gameResult +" Won!" + "\n\nFinal Score: \n" + finalScore;
                break;
            default:                
                finalScoreText.text = "Too bad! It's a draw... \n\nFinal Score: \n"+ finalScore;
                break;
        }

                 
        
    }
}
