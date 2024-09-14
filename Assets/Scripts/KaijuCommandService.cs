using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KaijuCommandService : MonoBehaviour
{

    List<Kaiju> kaijus = new List<Kaiju>();

    public void AddKaiju(Kaiju kaiju)
    {
        kaijus.Add(kaiju);
    }

    public void RemoveKaiju(Kaiju kaiju)
    {
        kaijus.Remove(kaiju);
    }

    public void CommandAll(Command command)
    {
        //This should send a command to all available 
        kaijus.ForEach(kaiju => kaiju.IssueCommand(command));
        
    }
}
