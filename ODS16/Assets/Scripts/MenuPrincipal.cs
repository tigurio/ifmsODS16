using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public void Jogar(){
        SceneManager.LoadScene("level1");
    }
    
    public void Sair(){
        Debug.Log("Saiu");
        Application.Quit();
    }
}
