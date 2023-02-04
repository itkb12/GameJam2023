using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorInteraction : Interactable
{
    public bool locked = false; //for test purposes
    override public void Interact()
    {
        if (locked)
        {
            textBoxText.text = "The Door is locked";
        }
        else
        {
            textBoxText.text = "sfx door opening nhhhhh";
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        textBox.SetActive(true);
    }
}
