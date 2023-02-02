using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController controller;
    private float movementSpeed;
    private float turningSpeed = 180f;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        movementSpeed = 5f;
        Vector3 movementDirection;
        if (Input.GetButton("Fire3"))
        {
            movementSpeed = 10f;
        }
        transform.Rotate(0, Input.GetAxis("Horizontal") * turningSpeed * Time.deltaTime, 0);
        movementDirection = transform.forward * Input.GetAxis("Vertical") * movementSpeed;

        controller.Move(movementDirection * Time.deltaTime - Vector3.up * .1f);

    }
}