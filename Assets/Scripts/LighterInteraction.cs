using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LighterInteraction : Interactable
{
    public override void TextToAppear()
    {
        Globals.foundLighter = true;
        if (Globals.foundSpray)
        {
            Globals.foundFlameThrower = true;
            Globals.foundSpray = false;
            Globals.foundLighter = false;
            textBoxText.text = "Found a Lighter and with the Spray Can I can burn those roots!";
        }
        else
        {
            textBoxText.text = "Found a Lighter";
        }

        Destroy(this.gameObject);
    }
}
