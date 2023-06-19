using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    private CharacterController controller;
    public DynamicJoystick variableJoystick;

    public Animator anim;

    public float forwardspeed = 10.0f;
    public float dragSpeed = 5.0f;
    public Vector3 moveVector;
    private float gravity = 12.0f;
    private float verticalVelocity = 0.0f;
    private bool check_if_falling = false;
    public bool Allow_Forward_Movement = true;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        moveVector = Vector3.zero;

        if (controller.isGrounded)
        {
            verticalVelocity = 0.0f;
            //print("notfalling");
        }

        else 
        {
            verticalVelocity -= gravity * Time.deltaTime;
            //print("falling");
            if (check_if_falling == false)
            {
                check_if_falling = true;
                //FindObjectOfType<GameManager>().EndGame();
                //print("failed game");

            }
        }


        Movement_With_moveVector();

        moveVector.y = verticalVelocity;

        moveVector.z = forwardspeed;

        if (!Allow_Forward_Movement)
        {
            moveVector.z = 0.0f;
        }

   
        this.anim.SetFloat("vertical", moveVector.z);
        this.anim.SetFloat("horizontal", moveVector.x);


        controller.Move(moveVector *Time.fixedDeltaTime);


    }

    void Movement_With_moveVector()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0f;

            moveVector = Vector3.left * variableJoystick.Horizontal * dragSpeed;

            

            //print(touch.position.x);
        }
    }

}
