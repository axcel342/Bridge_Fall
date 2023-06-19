using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitbyplayer : MonoBehaviour
{
    public PlayerMotor playerMotor;
    bool firsthit = true; 
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "MainPlayer" && firsthit == true)
        {
            
            this.gameObject.tag = other.tag;
            playerMotor.enabled = true;
            print("Player hit");
            firsthit = false;

        }
    }

}
