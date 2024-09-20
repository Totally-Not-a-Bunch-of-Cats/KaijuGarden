using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KaijuCommandService : MonoBehaviour
{
    [SerializeField]
    List<Kaiju> inactiveKaiju = new List<Kaiju>();
    [SerializeField]
    List<Kaiju> activeKaiju = new List<Kaiju>();
    [SerializeField]
    List<Kaiju> selectedKaiju = new List<Kaiju>();

    EnemyCommandService enemyCommandService;

    private void Start()
    {
        selectedKaiju.Add(activeKaiju[0]);
    }

    public void AddKaiju(Kaiju kaiju)
    {
        activeKaiju.Add(kaiju);
    }

    public void RemoveKaiju(Kaiju kaiju)
    {
        activeKaiju.Remove(kaiju);
        inactiveKaiju.Add(kaiju);
    }

    public void CommandAll(Command command)
    {
        //This should send a command to all available 
        activeKaiju.ForEach(kaiju => kaiju.IssueCommand(command));
        
    }

    public void CommandSelectedKaiju(Command command)
    {
        selectedKaiju.ForEach(kaiju => kaiju.IssueCommand(command));
    }

    public Command CreateAttackCommand(Transform attackTransform)
    {
        return new Command(attackTransform, CommandType.ATTACK);
    }

    public Command CreateSpecialCommand(Transform specialTransform)
    {
        return new Command(specialTransform, CommandType.SPECIAL);
    }

    public Command CreateRetreatCommand(Transform retreatTransform)
    {
        return new Command(retreatTransform, CommandType.RETREAT);
    }
}
