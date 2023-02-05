using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Globals : MonoBehaviour
{
    public static bool playerIsAlive;
    //Level0 
    public static bool foundKey;
    
    //Level1
    public static bool foundKey2;
    public static bool[] foundPiece = { false, false, false, false };
    public static bool foundSpray;
    public static bool foundLighter;
    public static bool foundFlameThrower;
    void Start()
    {
        playerIsAlive = true;

        foundKey = false;
        foundKey2 = false;
        foundSpray = false;
        foundLighter = false;
        foundFlameThrower = false;
    }
}
