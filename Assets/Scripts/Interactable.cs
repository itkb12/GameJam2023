using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class Interactable : MonoBehaviour
{
    LayerMask layer;
    public GameObject textBox;
    public TMP_Text textBoxText;
    private string text = "Interact";

    private void Start()
    {
        textBox.SetActive(false);
    }
    virtual public void Interact()
    {

        textBoxText.text = text;

        textBox.SetActive(true);
    }
}
