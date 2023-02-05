using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GnomeInteraction : Interactable
{

    // Update is called once per frame
    override public void TextToAppear()
    {
        if (!Globals.foundKey)
        {
            textBoxText.text = "Found a Key.";
            Globals.foundKey = true;
        }
        else
        {
            textBoxText.text = "There nothing under it now.";
        }
    }
}
