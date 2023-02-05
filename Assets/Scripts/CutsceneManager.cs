using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneManager : MonoBehaviour
{
    public void PressedContinue()
    {
        Debug.Log("Proxima Fase");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PressedTheEnd()
    {
        Debug.Log("Cabou");
        SceneManager.LoadScene("MainMenu");
    }
}
