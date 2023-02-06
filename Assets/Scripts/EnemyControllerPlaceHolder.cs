using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyControllerPlaceHolder : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform playerObj;

    public float timer;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(playerObj.position);
        if (agent.remainingDistance< 1.5)
        {
            timer = timer + Time.deltaTime;
            if (timer > 1)
            {
                //Level1
                Globals.foundKey2 = false;
                Globals.foundPiece[0] = false;
                Globals.foundPiece[1] = false;
                Globals.foundPiece[2] = false;
                Globals.foundPiece[3] = false;
                //Level1+2
                Globals.foundSpray = false;
                Globals.foundFlameThrower= false;
                Globals.foundLighter = false;
                //Level2
                Globals.foundScissors = false;
                Globals.foundTablecloth = false;
                Globals.foundScrewdriver = false;
                Globals.foundPaperclip = false;
                Globals.foundLockpick = false;
                SceneManager.LoadScene("GameOver");
            }
        }
        else
        {
            timer = 0;
        }
    }
}
