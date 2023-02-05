using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Invetory : MonoBehaviour
{
    public GameObject invetory;
    private void Start()
    {
        for (int i = 0;i <= 7;i++)
        {
            invetory.transform.GetChild(i).gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        if (Globals.foundKey)
        {
            invetory.transform.GetChild(0).gameObject.SetActive(true);
        }
        if (Globals.foundKey2)
        {
            invetory.transform.GetChild(0).gameObject.SetActive(true);
            for (int i = 1; i <= 4; i++ )
            {
                invetory.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        if (Globals.foundPiece[0])
        {
            invetory.transform.GetChild(1).gameObject.SetActive(true);
        }
        if (Globals.foundPiece[1])
        {
            invetory.transform.GetChild(2).gameObject.SetActive(true);
        }
        if (Globals.foundPiece[2])
        {
            invetory.transform.GetChild(3).gameObject.SetActive(true);
        }
        if (Globals.foundPiece[3])
        {
            invetory.transform.GetChild(4).gameObject.SetActive(true);
        }
        if (Globals.foundLighter)
        {
            invetory.transform.GetChild(5).gameObject.SetActive(true);
        }
        if (Globals.foundSpray)
        {
            invetory.transform.GetChild(6).gameObject.SetActive(true);
        }
        if (Globals.foundFlameThrower)
        {
            invetory.transform.GetChild(7).gameObject.SetActive(true);
            invetory.transform.GetChild(5).gameObject.SetActive(false);
            invetory.transform.GetChild(6).gameObject.SetActive(false);
        }
    }

}
