using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController controller;
    private float movementSpeed;
    private float turningSpeed = 180f;

    private Animator anim;
    private enum MovementState { idleStatic, idleScared, walking, running};
    MovementState state;
    GameObject player;


    void Start()
    {
        controller = GetComponent<CharacterController>();

        anim = GetComponentInChildren<Animator>();
        

    }

    // Update is called once per frame
    void Update()
    {
        movementSpeed = 3f;
        Vector3 movementDirection;
        if (Input.GetButton("Fire3"))
        {
            movementSpeed = 5f;
        }
        transform.Rotate(0, Input.GetAxis("Horizontal") * turningSpeed * Time.deltaTime, 0);
        movementDirection = transform.forward * Input.GetAxis("Vertical") * movementSpeed;

        controller.Move(movementDirection * Time.deltaTime - Vector3.up * .1f);

        

        if (movementDirection != Vector3.zero && movementSpeed == 3f)
        {
            state = MovementState.walking;
        }else if (movementDirection != Vector3.zero && movementSpeed == 5f)
        {
            state = MovementState.running;
        }
        else
        {
            state = MovementState.idleStatic;
        }

        anim.SetInteger("state",(int) state);
       

    }

}