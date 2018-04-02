using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainStart : MonoBehaviour {


    void Start()
    {

    }

    public void MainStartBTN()
    {
        AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[2]);
        Application.LoadLevel(1);
    }
}
