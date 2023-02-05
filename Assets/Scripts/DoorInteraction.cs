using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorInteraction : Interactable
{
    override public void TextToAppear()
    {
        if (!Globals.foundKey)
        {
            textBoxText.text = "It's locked, we used to keep the key under the garden gnome";
        }
        else
        {
            Time.timeScale = 1f;
            textBoxText.text = "sfx door opening nhhhhh";
            Globals.foundKey = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
