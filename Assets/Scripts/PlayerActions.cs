using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            float interactiveRange = 2f;
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactiveRange);
            foreach (Collider collider in colliderArray)
            {
                if (collider.TryGetComponent(out DoorInteractable doorInteractable))
                {
                    doorInteractable.Interact();
                }
            }
        }
    }
}
