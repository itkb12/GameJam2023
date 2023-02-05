using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSFX : MonoBehaviour
{
    public AudioSource step;
    public AudioSource run;
    // Start is called before the first frame update
    
    public void StepSFX()
    {
        step.Play();
    }

    public void RunSFX()
    {
        run.Play();
    }
}
