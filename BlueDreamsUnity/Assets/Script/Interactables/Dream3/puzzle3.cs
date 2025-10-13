using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzle3 : MonoBehaviour, IInteractable
{
   [SerializeField] GameObject Puzzle3, fadein, fadeout;
   public static bool puzzledone = false;
    public void OnFocusEnter()
    {
    }

    public void OnFocusExit()
    {
        
    }

    public void OnInteract()
    {
        IEnumerator PUZZLE3(){
            FMODUnity.RuntimeManager.PlayOneShot("event:/Puting_Book", transform.position);
            fadeout.SetActive(true); 
            fadein.SetActive(false);
            yield return new WaitForSeconds(4f);
            Puzzle3.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            fadein.SetActive(true);
            fadeout.SetActive(false);
                BookCollect.booksremaining = 3;
                puzzledone = true;
        }
        if(BookCollect.booksremaining == 0) 
        { 
           StartCoroutine(PUZZLE3());

        }
        StopCoroutine(PUZZLE3());
    }


}
