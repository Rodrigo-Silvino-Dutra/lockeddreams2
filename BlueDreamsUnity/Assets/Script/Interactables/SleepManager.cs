using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepManager : MonoBehaviour, IInteractable
{
    [SerializeField] public GameObject fadeout;
    [SerializeField] public GameObject fadein;
    [SerializeField] public GameObject reallife;
    [SerializeField] public GameObject dream1;
    [SerializeField] public GameObject dream2;
    [SerializeField] public GameObject dream3;
    public void OnFocusEnter()
    {
         
    }

    public void OnFocusExit()
    {

    }

    public void OnInteract()
    {
        IEnumerator SLEEP1(){
            fadeout.SetActive(true); 
            fadein.SetActive(false);
            yield return new WaitForSeconds(5f);
            reallife.SetActive(false);
            dream1.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            fadein.SetActive(true);
            fadeout.SetActive(false);
        }
        IEnumerator SLEEP2(){
            fadeout.SetActive(true); 
            fadein.SetActive(false);
            yield return new WaitForSeconds(5f);
            reallife.SetActive(false);
            dream2.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            fadein.SetActive(true);
            fadeout.SetActive(false);
        }
        IEnumerator SLEEP3(){
            fadeout.SetActive(true); 
            fadein.SetActive(false);
            yield return new WaitForSeconds(5f);
            reallife.SetActive(false);
            dream3.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            fadein.SetActive(true);
            fadeout.SetActive(false);
        }
//Progression dreams 1, 2 and 3
        if(ProgressionChart._instance.light >= 2)
        {
        StartCoroutine(SLEEP3());
        ProgressionChart._instance.light = 0;
        }
        

        StopCoroutine(SLEEP1());
        StopCoroutine(SLEEP2());
        StopCoroutine(SLEEP3());
    }
}
