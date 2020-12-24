using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    Rigidbody2D myRB;
    [SerializeField] internal float movementSpeed = 10f;
    internal float movementInput;
    [SerializeField] internal int playerID;
    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
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

        
        // print(movementInput);

        ApplyMovement(movementInput);
    }
    void ApplyMovement(float movementInput){
        myRB.velocity = Vector2.up * movementInput * movementSpeed;
    }
}
