using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GnomeInteraction : Interactable
{
    // Start is called before the first frame update
    protected bool found = false;


    // Update is called once per frame
    override public void Interact()
    {
        if (!found)
        {
            textBoxText.text = "Found a Key.";
            found = true;
        }
        else
        {
            textBoxText.text = "There nothing under it now.";
        }
        textBox.SetActive(true);
    }
}
