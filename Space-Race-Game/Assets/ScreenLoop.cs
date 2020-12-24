using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenLoop : MonoBehaviour
{
    [SerializeField] private GameObject oppositeScreenEdge;
    [SerializeField] private int teleportDistance;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.transform.position.x > 0){
            other.transform.position = new Vector2(other.transform.position.x - teleportDistance, other.transform.position.y);
        } else{
            other.transform.position = new Vector2(other.transform.position.x + teleportDistance, other.transform.position.y);
        }
        
    }
}
