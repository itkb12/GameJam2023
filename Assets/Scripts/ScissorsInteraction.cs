using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScissorsInteraction : Interactable
{
    override public void TextToAppear()
    {
        Globals.foundScissors = true;
        textBoxText.text = "Found a pair of scissors. Maybe I can cut something with this.";
        Destroy(this.gameObject);
    }
}
