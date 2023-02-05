using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyControllerPlaceHolder : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform playerObj;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();  
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(playerObj.position);
    }
}
