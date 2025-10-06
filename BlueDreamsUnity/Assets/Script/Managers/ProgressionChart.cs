using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressionChart : MonoBehaviour
{
    public static ProgressionChart _instance;
    public Stack<IInteractable> lastInteractable = new Stack<IInteractable>();
    public bool isInteracting = false;
    public int light = 0;
    public bool dream1 = false;
    public bool dream2 = true;
    public bool dream3 = false;
    public bool datacheck = false;

    void Start()
    {

    }
    void Awake()
    {
        if(_instance == null)_instance = this;
        DontDestroyOnLoad(_instance);
    }

}
