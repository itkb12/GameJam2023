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
        if (!Globals.playerIsAlive)
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        float deathRange = 1f;
        Collider[] testeArray = Physics.OverlapSphere(transform.position, deathRange);
        foreach (Collider collider in testeArray)
        {
            if (collider.tag == "Enemy")
            {
                //Globals.playerIsAlive = false;
                Debug.Log("Player is Dead");
            }
        }
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
