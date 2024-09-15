using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "Command", menuName = "ScriptableObjects/Command", order = 1)]
public class Command : ScriptableObject
{

    [SerializeField]
    private CommandType commandTypes;


    [SerializeField]
    public Transform goal;

    public Command(Transform goal, CommandType commandTypes)
    {
        this.goal = goal;
        this.commandTypes = commandTypes;
    }
}
