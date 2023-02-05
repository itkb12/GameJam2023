using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableclothInteraction : Interactable
{
    override public void TextToAppear()
    {
        Globals.foundTablecloth = true;
        textBoxText.text = "Found a tablecloth. Maybe I should try the window.";
        Destroy(this.gameObject);
    }
}
