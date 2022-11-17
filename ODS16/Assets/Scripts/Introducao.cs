using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Introducao : MonoBehaviour
{
    string[] textos = new string[3];
    public TMP_Text narrativa;

    //[tentativa 1]
    // GameObject[] imagens;

    
    void Start()
    {
        StartCoroutine(rotina());
        textos[0] = "Era uma vez uma escola de referência...";
        textos[1] = "... onde todos tinham vontade de estudar lá...";
        textos[2] = "... mas que por conta de um incidente, tudo mudou. Agora cabe a você mudar isso.";

        narrativa.GetComponent<TMP_Text>().text = textos[0];

        //tentativa 1
        // imagens = GameObject.FindGameObjectsWithTag("Imagens");
    }

        int cont = 0;

    public IEnumerator rotina(){
        
        //habilitar imagem
 
        //[tentativa 1]
        // imagens[cont].SetActive(true);

        //[tentativa 2]
        // GameObject img = GameObject.Find("Img"+cont);
        // img.GetComponent<RawImage>().enabled = true;
 
        

        narrativa.GetComponent<TMP_Text>().text = textos[cont];
        cont++;

        //trocar texto
        if(cont < 3){
            yield return new WaitForSeconds(3);
            StartCoroutine(rotina());
        }
        else{
            yield return new WaitForSeconds(5);
            SceneManager.LoadScene("Menu");
        }
    }

}
