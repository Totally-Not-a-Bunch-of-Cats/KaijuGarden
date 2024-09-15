using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Building : MonoBehaviour
{

    [SerializeField] protected EnemyCommandService commandService;

    protected void OnEnable()
    {
        commandService.AddBuilding(this);
    }

    protected void OnDisable()
    {
        commandService.RemoveBuilding(this);
    }
}
