using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject object1;
    public GameObject object2;
    public GameObject object3;


    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void OpenWebpage()
    {
        Application.OpenURL("http://localhost/IPC/index.html");
    }

    public void ActivateObject(int objectNumber)
    {
        // Desativar todos os objetos primeiro
        object1.SetActive(false);
        object2.SetActive(false);
        object3.SetActive(false);

        // Ativar o objeto correspondente ao número inserido
        switch (objectNumber)
        {
            case 1:
                object1.SetActive(true);
                break;
            case 2:
                object1.SetActive(true);
                object2.SetActive(true);
                break;
            case 3:
                object1.SetActive(true);
                object2.SetActive(true);
                object3.SetActive(true);
                break;
            default:
                Debug.Log("Número inválido. Por favor, insira um número de 1 a 3.");
                break;
        }
    }

}
