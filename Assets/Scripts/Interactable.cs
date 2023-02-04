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
    [SerializeField] private string text = "Interact";
    private void Start()
    {
        textBox.SetActive(false);
    }
    public void Interact()
    {
        textBox.SetActive(true);
        textBoxText.text = text;
        if (Input.GetButtonDown("Fire2"))
        {
            textBox.SetActive(false);
        }
    }
}
