using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUIManager : MonoBehaviour
{
    [SerializeField] GameManager myGM;
    [SerializeField] GameObject timerHolder;
    [SerializeField] Slider mySlider;

    
    // Start is called before the first frame update
    void Start()
    {
        //mySlider = timerHolder.GetComponent<Slider>();
        mySlider.maxValue = myGM.fullGameTime;
        mySlider.minValue = 0;        
    }    
    // Update is called once per frame
      
    void Update()
    {               
        // print(timerImage.GetComponent<RectTransform>().anchorMax);
        // if(timerImage.GetComponent<RectTransform>().anchorMax.y < 0f){
        //     timerImage.GetComponent<RectTransform>().anchorMax = new Vector2(timerImage.GetComponent<RectTransform>().anchorMax.x,timerImage.GetComponent<RectTransform>().anchorMax.y-(Time.deltaTime/myGM.gameSpeed));
        // }

        mySlider.value = myGM.gameTimeRemaining;

        
        
        
        

    }
}
