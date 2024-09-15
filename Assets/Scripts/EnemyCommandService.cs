using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCommandService : MonoBehaviour
{

    private List<Building> buildingList;

    private List<Unit> unitList;

    public void AddBuilding(Building buiding)
    {
        buildingList.Add(buiding);
    }

    public void RemoveBuilding(Building buiding)
    {
        buildingList.Remove(buiding);
    }

    public void AddUnit(Unit unit)
    {
        unitList.Add(unit);
    }

    public void RemoveUnit(Unit unit)
    {
        unitList.Remove(unit);
    }

    public List<Building> GetBuildings() { return buildingList; }
    public List<Unit> GetUnits() { return unitList; }

}
