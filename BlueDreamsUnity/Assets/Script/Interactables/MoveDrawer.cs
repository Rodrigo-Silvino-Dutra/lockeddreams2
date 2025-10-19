using System.Collections;
using UnityEngine;

public class MoveDrawer : MonoBehaviour, IInteractable
{
    [Header("Configurações")]
    [SerializeField] private float openDistance = 0.5f; // quanto a gaveta abre no eixo X
    [SerializeField] private float speed = 3f;

    private float closedX;
    private float openX;
    private bool isOpen = false;
    private Coroutine currentCoroutine;

    private void Start()
    {
        closedX = transform.localPosition.x;
        openX = closedX + openDistance;
    }

    public void OnFocusEnter() { }
    public void OnFocusExit() { }

    public void OnInteract()
    {
        ToggleDrawer();
        ProgressionChart._instance.lastInteractable.Pop();
    }

    private void ToggleDrawer()
    {
        isOpen = !isOpen;
        
        if (currentCoroutine != null)
            StopCoroutine(currentCoroutine);

        currentCoroutine = StartCoroutine(Move(isOpen));
    }

    private IEnumerator Move(bool open)
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Drawer", transform.position);
        float targetX = open ? openX : closedX;

        while (Mathf.Abs(transform.localPosition.x - targetX) > 0.001f)
        {
            
            Vector3 pos = transform.localPosition;
            pos.x = Mathf.MoveTowards(pos.x, targetX, speed * Time.deltaTime);
            transform.localPosition = pos;

            yield return null;
        }

        // Garante posição exata no final
        Vector3 finalPos = transform.localPosition;
        finalPos.x = targetX;
        transform.localPosition = finalPos;

        currentCoroutine = null;
    }
}