using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    public PlayerMotor playerMotor;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Obstacle")
        {
            playerMotor.anim.SetFloat("vertical", 0f);
            playerMotor.anim.SetFloat("horizontal", 0f);
            playerMotor.Allow_Forward_Movement = false;
            print("Entered playerhit");
        }

        if(other.tag == "Allow movement")
        {
            playerMotor.Allow_Forward_Movement = true;
            print("Movement Allowed");
        }

        if (other.tag == "Finish_Line")
        {
            
            playerMotor.anim.SetFloat("vertical", -1.0f);
            playerMotor.anim.SetFloat("horizontal", 0.0f);
            playerMotor.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            print("Reached Finish Line" + playerMotor.anim.GetFloat("vertical"));
        }

        if(other.tag == "base")
        {
            print("hit base");
            FindObjectOfType<GameManager>().RetryScreen();
        }
    }
}
