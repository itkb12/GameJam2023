using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    public LayerMask layer;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            float interactiveRange = 2f;
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactiveRange,layer);
            if (colliderArray.Length != 0)
            {
                Debug.Log("Interact");
            }
        }
    }
}
