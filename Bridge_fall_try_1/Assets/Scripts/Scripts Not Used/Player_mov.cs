using UnityEngine;

public class Player_mov : MonoBehaviour
{
    // Start is called before the first frame update
    //void Start()
    //{

    //}
    public Rigidbody rb;

    public float forwardForce = 300f;
    public float sidewaysForce = 200f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0f;
           // transform.position = touch.position;

            if(touch.position.x < (float)(Screen.width / 2.0f))
            {
                rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
                print("Right press");
            }

            if(touch.position.x > (float)(Screen.width / 2.0f) )
            {
                rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
                print("Left press");
            }

            print(touch.position.x);
        }
    }
}
 