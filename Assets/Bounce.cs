using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public int bounceStrength;

    void OnCollisionEnter(Collision col){
        if(col.gameObject.name == "Player"){
            Rigidbody rb = col.gameObject.GetComponent<Rigidbody>();
            rb.velocity = new Vector3(rb.velocity.x, bounceStrength, rb.velocity.z);
            // col.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, bounceStrength, 0), ForceMode.Impulse);
        }
    }
}
