using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void NewGame()
    {
        SceneManager.LoadScene("Overworld");
    }

    public void QuitToDesktop()
    {
        Application.Quit();
    }
}
