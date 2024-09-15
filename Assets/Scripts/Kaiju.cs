using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Kaiju : MonoBehaviour
{
    [SerializeField]
    private KaijuCommandService commandService;

    [SerializeField]
    private Command command;
    [SerializeField]
    private GameObject TargetUI;

    [SerializeField]
    KaijuStatSheet statSheet;

    private void OnEnable()
    {
        commandService.AddKaiju(this);
        command.goal = GetComponent<Transform>();
        if (command != null) IssueCommand(command);
    }

    private void OnDisable()
    {
        commandService.RemoveKaiju(this);
    }

    void Update()
    {
        //Navigate to target
    }

    public void ChoosePrioTarget()
    {
        print("click");
        TargetUI.SetActive(true);
    }

    public void ChooseTarget(TargetType target)
    {

    }

    void Attack()
    {

    }

    public void IssueCommand(Command command) {
        GetComponent<NavMeshAgent>().destination = command.goal.position;
        this.command = command;
    }

    
}
