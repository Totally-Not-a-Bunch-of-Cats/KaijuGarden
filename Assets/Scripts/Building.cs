using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Building : MonoBehaviour
{

    [SerializeField] EnemyCommandService commandService;

    private void OnEnable()
    {
        commandService.AddBuilding(this);
    }

    private void OnDisable()
    {
        commandService.RemoveBuilding(this);
    }
}
