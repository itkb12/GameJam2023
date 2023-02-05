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
            textBoxText.text = "The Door is locked";
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
