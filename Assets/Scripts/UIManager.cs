using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private KaijuCommandService commandService;
    [SerializeField]
    private GameObject infoPannel;
    public List<GameObject> KaijuCards;
    void Start()
    {
        //finds the Kaiju Command Service
        commandService = GameObject.FindGameObjectWithTag("KaijuCommand").GetComponent<KaijuCommandService>();
    }
}
