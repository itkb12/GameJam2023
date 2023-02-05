using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RootInteraction2 : Interactable
{
    bool root = true;
    bool windowGrid = true;
    bool fearHighPlaces = true;
    public override void TextToAppear()
    {
        if (root)
        {
            if (Globals.foundFlameThrower)
            {
                Time.timeScale = 0f;
                textBoxText.text = "sfx roots burning fsshhh";
                Globals.foundFlameThrower = false;
                root = false;
            }
            else
            {
                textBoxText.text = "The roots are reaching the window already and I'm pretty sure I did go up a floor. I need do to something about it.";
            }
            return;
        }
        if (windowGrid)
        {
            if (Globals.foundScissors)
            {
                Time.timeScale = 0f;
                textBoxText.text = "sfx window grid being cut clack clack clack";
                Globals.foundScissors = false;
                windowGrid = false;
            }
            else
            {
                textBoxText.text = "Now I should make something about the window grid. Maybe I can cut it with something.";
            }
            return;
        }
        if (fearHighPlaces)
        {
            if (Globals.foundTablecloth)
            {
                Time.timeScale = 0f;
                textBoxText.text = "sfx using the tablecloth (i dont now how it should sound)";
                Globals.foundTablecloth = false;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                fearHighPlaces = false;
            }
            else
            {
                textBoxText.text = "I can't barely see the ground, maybe i did go up on floor...I should use something do get down safely.";
            }
            return;
        }
    }
}
