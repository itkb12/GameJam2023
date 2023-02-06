using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    bool isChasing = false;
    public Vector3 originalPosition;
    public Transform playerObj;
    NavMeshAgent agent;
    public float maxDistance = 10f;
    public float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        originalPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, playerObj.position) <= 1.5)
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
                Globals.foundFlameThrower = false;
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

        if (!agent.pathPending)
        {
            if (agent.remainingDistance <= agent.stoppingDistance)
            {
                if (!agent.hasPath || Mathf.Approximately(agent.velocity.sqrMagnitude, 0f))
                {

                }
                else
                {
                    Debug.Log("Achou2!");
                }
            }
        }
        

        if (Vector3.Distance(transform.position,playerObj.position) <= maxDistance)
        {
            bool hasWall = false;
            RaycastHit[] hits = Physics.RaycastAll(transform.position,playerObj.position-transform.position,maxDistance);

            foreach (RaycastHit hit in hits)
            {
                if (hit.transform != transform && hit.transform != playerObj.transform)
                {
                    if (Vector3.Distance(transform.position,playerObj.position) > Vector3.Distance(transform.position,hit.transform.position))
                    {
                        hasWall = true;
                        break;
                    }
                }
                
            }
            if (!hasWall) 
            {
                isChasing = true;
                agent.SetDestination(playerObj.position);
            }
            else if(isChasing)
            {
                isChasing= false;
                agent.SetDestination(playerObj.position);
                agent.ResetPath();
            }
        }
        else if(isChasing)
        {
            agent.SetDestination(playerObj.position);
        }
        
    }
}
