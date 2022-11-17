using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void StartButton()
    {
        //CUANDO SE PULSA EL BOTON DE START DERIBA AL COROUTINE//
        StartCoroutine(NewGameCoroutin());
    }

    //CUANDO SE PULSA EL BOTON DE EXIT SALE DEL JUEGO//
    public void ExitButton()
    {
        Application.Quit();
    }

    IEnumerator NewGameCoroutin()
    {
        //ESPERA 2 SEG A QUE SE INICIE LA ESCENA CITADA//
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene("World");
    }
}

