using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperclipInteraction : Interactable
{
    public override void TextToAppear()
    {
        Globals.foundPaperclip = true;
        if (Globals.foundScrewdriver)
        {
            Globals.foundLockpick = true;
            Globals.foundScrewdriver = false;
            Globals.foundPaperclip = false;
            textBoxText.text = "Found a Paperclip and with the Screwdriver I can unlock the door!";
        }
        else
        {
            textBoxText.text = "Found a Paperclip. But there is no paper around.";
        }

        Destroy(this.gameObject);
    }
}
