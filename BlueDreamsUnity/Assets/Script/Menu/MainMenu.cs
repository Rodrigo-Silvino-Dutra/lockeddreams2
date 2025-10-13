using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject fade;
    

    // Start is called before the first frame update
    public void Play(){
        IEnumerator FADE(){
            fade.SetActive(true);

            yield return new WaitForSeconds(5f);
            
            SceneManager.LoadScene("MainRoom");
        }
        StartCoroutine(FADE());
        
    }
    public void Quit(){
        Application.Quit();
    }
}
