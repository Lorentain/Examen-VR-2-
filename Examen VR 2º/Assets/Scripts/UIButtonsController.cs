using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtonsController : MonoBehaviour
{

    public void Salir()
    {
        Application.Quit();
    }

    public void SceneGameBaked()
    {
        SceneManager.LoadScene("Juego Baked");
    }

    public void SceneGame()
    {
        SceneManager.LoadScene("Juego");
    }

    public void SceneMenu() {
        SceneManager.LoadScene("Inicio");
    }
}
