using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    [SerializeField] public GameObject tutorial;
    [SerializeField] public GameObject fadein;
    public bool done = false;

    IEnumerator tuto()
    {
        tutorial.SetActive(true);
        yield return new WaitForSeconds(4f);
        fadein.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        tutorial.SetActive(false);
        done = true;
    }


    void Awake()
    {
        if (done == false)
        {
            StartCoroutine(tuto());

        }
            StopCoroutine(tuto());
        }
    }

