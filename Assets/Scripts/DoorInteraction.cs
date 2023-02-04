using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DoorInteraction : GnomeInteraction
{
    
    override public void Interact()
    {
        if (!found)
        {
            textBoxText.text = "The Door is locked";
            found = true;
        }
        else
        {
            textBoxText.text = "sfx door opening nhhhhh";
        }
    }
}
