using UnityEngine;

public class CdTray : MonoBehaviour
{
    [Header("Configurações de Movimento")]
    [SerializeField] private float moveDistance = 0.2f; // quanto o objeto se move no eixo X
    [SerializeField] private float moveSpeed = 2f; // velocidade da animação

    private Vector3 initialPosition;
    private Vector3 targetPosition;
    private Coroutine currentCoroutine;

    private void Start()
    {
        initialPosition = transform.localPosition;
        targetPosition = initialPosition + Vector3.right * moveDistance; // movimento no eixo X
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // interrompe qualquer animação anterior
            if (currentCoroutine != null) StopCoroutine(currentCoroutine);
            currentCoroutine = StartCoroutine(MoveTo(targetPosition));

        }
    }

    private void OnTriggerExit(Collider other)
    {
     FMODUnity.RuntimeManager.PlayOneShot("event:/ClosingCDCase", transform.position);
        if (other.CompareTag("Player"))
        {
            if (currentCoroutine != null) StopCoroutine(currentCoroutine);
            currentCoroutine = StartCoroutine(MoveTo(initialPosition));
        }
    }

    private System.Collections.IEnumerator MoveTo(Vector3 destination)
    {
        Vector3 start = transform.localPosition;
        float t = 0f;

        while (t < 1f)
        {
            t += Time.deltaTime * moveSpeed;
            transform.localPosition = Vector3.Lerp(start, destination, t);
            yield return null;
        }

        transform.localPosition = destination;
    }
}
