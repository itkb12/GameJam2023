using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortraitInteraction : Interactable
{
    public Material completePortrait;

    public override void TextToAppear()
    {
        if (Globals.foundKey2)
        {
            textBoxText.text = "Already got the key.";
            return;
        }

        foreach (bool x in Globals.foundPiece)
        {
            if (!x)
            {
                textBoxText.text = "There is a big Portrait here but the photagraph appears to be missing";
                return;
            }
            
        }
        textBoxText.text = "Found all four pieces of the picture";
        this.gameObject.GetComponent<Renderer>().material = completePortrait;
        
        Globals.foundKey2 = true;
        for (int i = 0; i < 4; i++)
        {
            Globals.foundPiece[i] = false;
        }

    }
}
