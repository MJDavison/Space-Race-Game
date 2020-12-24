using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] GameManager myGM;
    [SerializeField] Text playerOneScoreText;
    [SerializeField] Text playerTwoScoreText;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        playerOneScoreText.text = myGM.PlayerOneScore.ToString();
        playerTwoScoreText.text = myGM.PlayerTwoScore.ToString();
    }
}
