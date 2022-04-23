using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class control : MonoBehaviour
{
    // Start is called before the first frame update

    public void QuitGame()
    {
        Application.Quit();
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Bowl");
    }
    public void ScoreGame()
    {
        SceneManager.LoadScene("Score");
    }
}
