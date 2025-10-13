using UnityEngine;

//Classe Exemplo, cada coletável pode ter um script para cada funçao, desde que o script herde de IInteractable
public class PickUpItem : MonoBehaviour, IInteractable//herda de IInteractable
{    
    //todo script de coletável necessita possuir as 3 funçoes basicas 
    public void OnFocusEnter()
    {
    }

    public void OnFocusExit()
    {
        GetComponent<Renderer>().material.color = Color.white;
    }

    public void OnInteract()
    {
        GetComponent<Renderer>().material.color = Color.yellow;
        Debug.Log("Vc Pegou o item");
    }
}
