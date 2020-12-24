using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    Rigidbody2D myRB;
    [SerializeField] GameManager myGM;
    [SerializeField] internal float movementSpeed = 10f;
    internal float movementInput;
    [SerializeField] internal int playerID;
    Vector2 startingPos;
    // Start is called before the first frame update

    private void Awake() {
         startingPos = transform.position;
    }
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();       
        //startingPos.position = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {

        CheckInput();
        CheckPlayerPosition();
        // if(playerID == 1){
        //     if(Input.GetKey(KeyCode.W)){
        //         movementInput = 1;
        //         print("W Pressed");
        //     }
                            
        //     if(Input.GetKey(KeyCode.S)){
        //         movementInput = -1;
        //         print("S Pressed");
        //     } 

        //     if(Input.GetKeyUp(KeyCode.W)||Input.GetKeyUp(KeyCode.S)){
        //         movementInput = 0;
        //         print("W or S Released");
        //     }           
        // }

        // if(playerID == 2){
        //     if(Input.GetKey(KeyCode.UpArrow)){
        //         movementInput = 1;
        //         print("Up Arrow Pressed");
        //     }
                            
        //     if(Input.GetKey(KeyCode.DownArrow)){
        //         movementInput = -1;
        //          print("Down Arrow Pressed");
        //     } 

        //     if(Input.GetKeyUp(KeyCode.UpArrow)||Input.GetKeyUp(KeyCode.DownArrow)){
        //         movementInput = 0;
        //         print("Up or Down Arrow Released");
        //     }           
        // }

        

        
        // print(movementInput);

        ApplyMovement(movementInput);
    }    

    private void CheckInput()
    {
       if(playerID == 1){
            if(Keyboard.current.wKey.isPressed){
                movementInput = 1;
                // print("W Pressed");
            } else if(Keyboard.current.sKey.isPressed){
                movementInput = -1;
                // print("S Pressed");
            } 
            else{
                movementInput = 0;
            }                                                                
        }

        if(playerID == 2){
            if(Keyboard.current.upArrowKey.isPressed){
                movementInput = 1;
                // print("W Pressed");
            } else if(Keyboard.current.downArrowKey.isPressed){
                movementInput = -1;
                // print("S Pressed");
            } else{
                movementInput = 0;
            }                                                        
        }
    }

    void ApplyMovement(float movementInput){
        myRB.velocity = Vector2.up * movementInput * movementSpeed;
    }

    private void CheckPlayerPosition()
    {
        if(transform.position.y >= 8.5f){
            if(transform.name == "PlayerOne"){
                myGM.PlayerOneScore = 1; //Increases player score by 1
            } else{
                myGM.PlayerTwoScore = 1;
            }
            transform.SetPositionAndRotation(startingPos, Quaternion.identity);
        } else if(transform.position.y < 0){
            transform.SetPositionAndRotation(startingPos, Quaternion.identity);
            //print("That's a bit low mate.");
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Asteroid")){
            transform.SetPositionAndRotation(startingPos, Quaternion.identity);
        }
    }
}
