using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void Continue()
    {
        SceneManager.LoadScene("Overworld");
    }

    public void QuitToDesktop()
    {
        Application.Quit();
    }
}
