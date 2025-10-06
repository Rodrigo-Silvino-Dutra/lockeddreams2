using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WakeUpManager : MonoBehaviour
{
    [SerializeField] public GameObject fadeout;
    [SerializeField] public GameObject fadein;
    [SerializeField] public GameObject reallife;
    [SerializeField] public GameObject dream1;
    [SerializeField] public GameObject dream2;
    [SerializeField] public GameObject dream3;
    [SerializeField] public GameObject Light1;
    

IEnumerator WAKE1(){
            fadeout.SetActive(true); 
            fadein.SetActive(false);
            yield return new WaitForSeconds(5f);
            reallife.SetActive(true);
            dream1.SetActive(false);
            yield return new WaitForSeconds(0.5f);
            fadein.SetActive(true);
            fadeout.SetActive(false);
        }
        IEnumerator WAKE2(){
            fadeout.SetActive(true); 
            fadein.SetActive(false);
            yield return new WaitForSeconds(5f);
            reallife.SetActive(true);
            dream2.SetActive(false);
            yield return new WaitForSeconds(0.5f);
            fadein.SetActive(true);
            fadeout.SetActive(false);
        }
        IEnumerator WAKE3(){
            fadeout.SetActive(true); 
            fadein.SetActive(false);
            yield return new WaitForSeconds(5f);
            reallife.SetActive(true);
            dream3.SetActive(false);
            Light1.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            fadein.SetActive(true);
            fadeout.SetActive(false);
            ProgressionChart._instance.dream3 = true;
            
        }
    void Start()
    {
            
    }

    
    void Update()
    {
<<<<<<< Updated upstream
        if (DrawKid.drawviewed == true)
        {
            StartCoroutine(WAKE1());
            DrawKid.drawviewed = false;
        }
        if (DivorcePaperManager.divorceviewed == true)
=======
        if (ProgressionDream2._instance.dream2Completed)
>>>>>>> Stashed changes
        {
            StartCoroutine(WAKE2());
            ProgressionDream2._instance.dream2Completed = false;
        }
        if (DivorcePaperManager.divorceviewed == true)
            {
                StartCoroutine(WAKE3());
                DivorcePaperManager.divorceviewed = false;
            }
        StopCoroutine(WAKE1());
        StopCoroutine(WAKE2());
        StopCoroutine(WAKE3());
    }
}
