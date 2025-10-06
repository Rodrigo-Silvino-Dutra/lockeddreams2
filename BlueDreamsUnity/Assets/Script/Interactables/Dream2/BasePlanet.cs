using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlanet : MonoBehaviour
{
    [SerializeField] private Transform planetFloatingPoint;
    [SerializeField] private GameObject particles;
    [SerializeField] private GameObject worf;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("jupiter"))
        {
            Debug.Log("Entrou no Range");
            particles.SetActive(true);
            collision.rigidbody.isKinematic = true;
            collision.gameObject.transform.position = planetFloatingPoint.position;
            collision.gameObject.transform.SetParent(planetFloatingPoint, true);
            ProgressionDream2._instance.jupiterInPlace = true;
            worf.SetActive(true);
        }
    }
}
