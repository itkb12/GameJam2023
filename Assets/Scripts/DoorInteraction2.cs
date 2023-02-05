using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorInteraction2 : Interactable
{
    override public void TextToAppear()
    {
        if (!Globals.foundKey2)
        {
            textBoxText.text = "The Door is locked";
        }
        else
        {
            Time.timeScale = 0f;
            textBoxText.text = "sfx door opening nhhhhh";
            Globals.foundKey2 = false;
            Destroy(this.gameObject);
        }
    }
}
