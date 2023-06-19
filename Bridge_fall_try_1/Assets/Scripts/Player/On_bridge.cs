using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class On_bridge : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 moveVector;
    private float gravity = 12.0f;
    private float verticalVelocity = 0.0f;
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
        }

        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }

        moveVector.y = verticalVelocity;

        controller.Move(moveVector * Time.fixedDeltaTime);
    }
}
