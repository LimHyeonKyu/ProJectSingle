using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour {

    public GameObject pauseText;

    public void PauseBTN()
    {
        AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[3]);
        pauseText.SetActive(true);
        Time.timeScale = 0;
        //Debug.Log(Time.timeScale);
    }
    public void BackBTN()
    {
        AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[3]);
        pauseText.SetActive(false);
        Time.timeScale = 1;
    }
    public void MainBTN()
    {
        AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[3]);
        Application.LoadLevel(1);
        Time.timeScale = 1;
    }
}
