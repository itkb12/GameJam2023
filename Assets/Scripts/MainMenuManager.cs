using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void PressedPlay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    public void PressedControls()
    {
        //TODO
    }

    public void PressedQuit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
