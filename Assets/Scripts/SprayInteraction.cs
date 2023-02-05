using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprayInteraction : Interactable
{
    public override void TextToAppear()
    {
        Globals.foundSpray = true;
        if (Globals.foundLighter)
        {
            Globals.foundFlameThrower = true;
            Globals.foundSpray = false;
            Globals.foundLighter = false;
            textBoxText.text = "Found a Spray Can and with the Lighter I can burn those roots!";
        }
        else
        {
            textBoxText.text = "Found a Spray Can. It is full!";
        }

        Destroy(this.gameObject);
    }
}
