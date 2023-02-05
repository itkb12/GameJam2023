using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteraction3 : Interactable
{
    override public void TextToAppear()
    {
        if (!Globals.foundLockpick)
        {
            textBoxText.text = "Another locked door.";
        }
        else
        {
            Time.timeScale = 0f;
            textBoxText.text = "sfx door opening nhhhhh";
            Globals.foundLockpick = false;
            Destroy(this.gameObject);
        }
    }
}
