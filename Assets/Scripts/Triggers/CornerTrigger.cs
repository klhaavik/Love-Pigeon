using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CornerTrigger : MonoBehaviour
{
    bool triggered = false;
    public bool isRightTurn;
    KaiMovement movement;

    void Start(){
        movement = GameObject.Find("Player").GetComponent<KaiMovement>();
    }

    public void OnTriggerEnter(Collider col){
        if(!triggered){
            movement.ToggleCorner(isRightTurn);
            triggered = true;
        }
    }
    void Update(){
        if(movement.ResetInProgress){
            triggered = false;
        }
    }

}
