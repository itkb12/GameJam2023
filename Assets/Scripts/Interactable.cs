using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class Interactable : MonoBehaviour
{
    public GameObject textBox;
    public TMP_Text textBoxText;
    private string text = "Interact";

    private void Start()
    {
        //textBox.SetActive(false);
    }
    public void Interact()
    {
        Time.timeScale = 0f;

        TextToAppear();

        textBox.SetActive(true);
    }

    virtual public void TextToAppear() 
    {
        textBoxText.text = text;
    }
}
