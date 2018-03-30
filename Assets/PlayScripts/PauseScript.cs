using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour {

    public GameObject pauseText;

    public void PauseBTN()
    {
        pauseText.SetActive(true);
        Time.timeScale = 0;
        //Debug.Log(Time.timeScale);
    }
    public void BackBTN()
    {
        pauseText.SetActive(false);
        Time.timeScale = 1;
    }
    public void MainBTN()
    {
        Application.LoadLevel(1);
        Time.timeScale = 1;
    }
}
