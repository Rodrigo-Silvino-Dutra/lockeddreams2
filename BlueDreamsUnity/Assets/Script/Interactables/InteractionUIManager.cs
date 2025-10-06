using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InteractionUIManager : MonoBehaviour
{
    public static InteractionUIManager _instance;
    [SerializeField] private GameObject triggerReticlePointer;
    [SerializeField] private GameObject textOfInteraction;
    void Awake()
    {
        if(_instance == null)_instance = this;
        DontDestroyOnLoad(_instance);
    }
    public void TriggerCursor(bool state)
    {
        triggerReticlePointer.SetActive(state);
        textOfInteraction.SetActive(state);
    }
}
