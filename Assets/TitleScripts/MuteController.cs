using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteController : MonoBehaviour {

	
	
	void Update ()
    {
		if(AudioController.iNstance.bgmInt == 1)
        {
            GetComponent<AudioSource>().mute = true;
        }
        if (AudioController.iNstance.bgmInt == 0)
        {
            GetComponent<AudioSource>().mute = false;
        }
    }
}
