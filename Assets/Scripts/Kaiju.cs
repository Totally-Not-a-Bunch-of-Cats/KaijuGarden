using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        this.command = command;
    }

    
}
