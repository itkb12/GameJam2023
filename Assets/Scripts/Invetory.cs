using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invetory : MonoBehaviour
{
    List<string> items = new List<string>();
    
    public void addToInventory(string item)
    {
        if(item != null)
        {
            items.Add(item);
        }
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            foreach (string x in items)
            {
                Debug.Log(x);
            }
        }
    }

}
