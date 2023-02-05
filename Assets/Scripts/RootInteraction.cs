using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RootInteraction : Interactable
{
    public override void TextToAppear()
    {

        if (Globals.foundFlameThrower)
        {
            Time.timeScale = 0f;
            textBoxText.text = "sfx roots burning fsshhh";
            Globals.foundFlameThrower = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        }
        else
        {
            textBoxText.text = "The roots on this stairs are not letting me go up! I need do to something about it.";
        }
    }
}
