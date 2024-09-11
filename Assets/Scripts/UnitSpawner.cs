using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSpawner : MonoBehaviour
{
    public GameObject Soldiers;
    public Transform Arena;

    private void Start()
    {
        StartCoroutine(SpawnCountDown());
    }

    IEnumerator SpawnCountDown()
    {
        yield return new WaitForSeconds(5);
        Spawn();
    }

    void Spawn()
    {
        Instantiate(Soldiers, Arena);
    }
}
