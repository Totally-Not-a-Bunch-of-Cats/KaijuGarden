using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Building : MonoBehaviour
{

    [SerializeField] EnemyCommandService commandService;

    private void OnEnable()
    {
        Debug.Log(this.gameObject.name);
        commandService.AddBuilding(this);
    }

    private void OnDisable()
    {
        commandService.RemoveBuilding(this);
    }
}
