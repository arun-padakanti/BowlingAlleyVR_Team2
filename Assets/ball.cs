using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using System.Threading;
using UnityEngine.SceneManagement;
using System.IO;


public class ball : MonoBehaviour
{
    public Rigidbody body;
    public Transform originalpin;
    public int turns = 0;
    public GameObject[] pins;
    public Vector3[] positions;
    public int score = 0;
    public Quaternion[] rot;
    public Text scoreUI;
    public Vector3 ballpos;
    public HighScore score_hist;
    public int finalScore;
    
    void Start()
    {
        body = GetComponent<Rigidbody>();
        pins = GameObject.FindGameObjectsWithTag("Pin");
        positions = new Vector3[pins.Length];
        rot = new Quaternion[pins.Length];
        ballpos = body.transform.position;
        for (int i = 0; i < pins.Length; i++)
        {
            positions[i] = pins[i].transform.position;
            rot[i] = pins[i].transform.rotation;
        }
        originalpin = pins[0].transform;
        //body.maxAngularVelocity = 7 * 7;
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    //Debug.Log(other.gameObject.name);
    //    if (other.gameObject.name == "Ball")
    //    {
    //        CountPins();
    //        //Thread.Sleep(5000);
    //        turns++;
    //        // Debug.Log(turns);
    //        Reset();
    //    }
    //}


    // Update is called once per frame
    void Update()
    {
        // if(body.GetComponent<Rigidbody>().velocity != Vector3.zero)
        // {
        //     AudioSource sound = GetComponent<AudioSource>();
        //     sound.Play();
        // }
        //if(body.transform.position.x >= 5.6 || (body.GetComponent<Rigidbody>().velocity == Vector3.zero && body.transform.position != ballpos))
        //if(body.transform.position.y < -20)
        //body.transform.position += new Vector3(3, 0, 0);
        //body.AddForce(Vector3.forward * 21);
        if (body.transform.position.x >= 9.2)
        {
            CountPins();
            //Thread.Sleep(5000);
            turns++;
            // Debug.Log(turns);
            Reset();
        }
    }

    void CountPins()
    {
        for (int i = 0; i < pins.Length; i++)
        {
            if ((pins[i].transform.eulerAngles.z > -90 && pins[i].transform.eulerAngles.z < 265) && pins[i].activeSelf)
            //if((pins[i].transform.position.x != positions[i].x || pins[i].transform.position.z != positions[i].z) && pins[i].activeSelf)
            {
                score++;
                Debug.Log(score);
                pins[i].SetActive(false);
            }
        }
        Debug.Log(score);
        finalScore += score;
        scoreUI.text = finalScore.ToString();
        score=0;
    }
    void Reset()
    {
        for (int i = 0; i < pins.Length; i++)
        {
            pins[i].SetActive(true);
            pins[i].transform.position = positions[i];
            //to remove the physics after a throw
            pins[i].GetComponent<Rigidbody>().velocity = Vector3.zero;
            pins[i].GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            //pins[i].transform.rotation = Quaternion.Slerp(pins[i].transform.rotation, originalpin.rotation, Time.time * rotationResetSpeed);
            //pins[i].transform.rotation.z=-90;
            pins[i].transform.rotation = rot[i];
        }
        //initial ball position
        //body.transform.position = new Vector3(0.03f, 0.25f, 1.31f);
        body.transform.position = ballpos;
        body.GetComponent<Rigidbody>().velocity = Vector3.zero;
        body.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        body.transform.rotation = Quaternion.identity;
        if (turns == 10)
        {
            //Debug.Log("bye");
            //if (score_hist.index < 10)
            //{
            //    using (StreamWriter sw = File.AppendText("scoreFile.txt"))
            //    {
            //        sw.WriteLine(finalScore.ToString());
            //    }
            //    score_hist.scores[score_hist.index++] = finalScore;
            //}
            //else
            //{
            //    if (score_hist.scores[9] < finalScore)
            //    {
            //        using (StreamWriter sw = File.AppendText("scoreFile.txt"))
            //        {
            //            sw.WriteLine(finalScore.ToString());
            //        }
            //        score_hist.scores[9] = finalScore;
            //    }
            //}
            //for (int j = 9; j > 0; j--)
            //{
            //    if (score_hist.scores[j] > score_hist.scores[j - 1])
            //    {
            //        int k = score_hist.scores[j];
            //        score_hist.scores[j] = score_hist.scores[j - 1];
            //        score_hist.scores[j - 1] = k;
            //    }
            //}
            SceneManager.LoadScene("Main");
        }
    }

}