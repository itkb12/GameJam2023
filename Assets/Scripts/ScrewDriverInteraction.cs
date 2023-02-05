using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrewDriverInteraction : Interactable
{
    public override void TextToAppear()
    {
        Globals.foundScrewdriver = true;
        if (Globals.foundPaperclip)
        {
            Globals.foundLockpick = true;
            Globals.foundScrewdriver = false;
            Globals.foundPaperclip = false;
            textBoxText.text = "Found a Screwdriver and with the Paperclip I can unlock the door!";
        }
        else
        {
            textBoxText.text = "Found a Screwdriver. Seems old.";
        }

        Destroy(this.gameObject);
    }
}
