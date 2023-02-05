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
                Debug.Log("Game Over!");
                SceneManager.LoadScene("GameOver");
            }
        }
        else
        {
            timer = 0;
        }
    }
}
