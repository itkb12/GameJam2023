using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerActions : MonoBehaviour
{
    public GameObject textBox;
    private void Start()
    {
        textBox.SetActive(false);
    }
    void Update()
    {
        
        if (Input.GetButtonDown("Jump"))
        {
            if (textBox.activeInHierarchy)
            {
                Time.timeScale = 1f;
                textBox.SetActive(false);
            }
            else
            {
                float interactiveRange = 1f;
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
