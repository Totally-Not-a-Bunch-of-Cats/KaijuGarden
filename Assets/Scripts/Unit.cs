using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{

    [SerializeField] EnemyCommandService commandService;

    private void OnEnable()
    {
        commandService.AddUnit(this);
    }

    private void OnDisable()
    {
        commandService.RemoveUnit(this);
    }
}
