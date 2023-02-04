using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    public GameObject textBox;
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (textBox.activeInHierarchy)
            {
                textBox.SetActive(false);
            }
            else
            {
                float interactiveRange = 2f;
                Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactiveRange);
                foreach (Collider collider in colliderArray)
                {
                    if (collider.TryGetComponent(out Interactable interactable))
                    {
                        interactable.Interact();
                    }
                }
            }
            
        }
    }
}
