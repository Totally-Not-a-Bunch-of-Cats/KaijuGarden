using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Command : MonoBehaviour
{

    [SerializeField]
    private CommandType commandTypes;


    [SerializeField]
    public Transform goal;

    NavMeshAgent agent;

    public Command(Transform goal, CommandType commandTypes)
    {
        this.goal = goal;
        this.commandTypes = commandTypes;
    }

    void Start()
    {
        NavMeshAgent agent = GetComponentInParent<NavMeshAgent>();
        agent.destination = goal.position;
    }

    public bool hasReachedDestination()
    {
        return agent == null || agent.isStopped;
    }

    
}
