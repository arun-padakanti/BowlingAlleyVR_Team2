using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Bowl");
    }

    public void HighScore()
    {
        SceneManager.LoadScene("Score");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
