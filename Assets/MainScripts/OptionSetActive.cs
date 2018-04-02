using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionSetActive : MonoBehaviour {


    public GameObject[] onOff;
	
	void Update ()
    {
        if (AudioController.iNstance.bgmInt == 1)
        {
            onOff[0].SetActive(false);
            onOff[1].SetActive(true);
        }
        if (AudioController.iNstance.bgmInt == 0)
        {
            onOff[0].SetActive(true);
            onOff[1].SetActive(false);
        }
        if(AudioController.iNstance.soundInt==1)
        {
            onOff[2].SetActive(false);
            onOff[3].SetActive(true);
        }
        if (AudioController.iNstance.soundInt == 0)
        {
            onOff[2].SetActive(true);
            onOff[3].SetActive(false);
        }
    }
}
