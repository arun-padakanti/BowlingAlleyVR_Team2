using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu_control : MonoBehaviour
{
    public Text T1;
    public Text T2;
    public Text T3;
    public Text T4;
    public Text T5;
    public Text T6;
    public Text T7;
    public Text T8;
    public Text T9;
    public Text T10;
    public HighScore score_hist;
    public void Start()
    {
        T1.text = score_hist.scores[0].ToString();
        T2.text = score_hist.scores[1].ToString();
        T3.text = score_hist.scores[2].ToString();
        T4.text = score_hist.scores[3].ToString();
        T5.text = score_hist.scores[4].ToString();
        T6.text = score_hist.scores[5].ToString();
        T7.text = score_hist.scores[6].ToString();
        T8.text = score_hist.scores[7].ToString();
        T9.text = score_hist.scores[8].ToString();
        T10.text = score_hist.scores[9].ToString();
    }
    public void QuitGame()
    {
        SceneManager.LoadScene("Main");
    }
}
