using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerScript : MonoBehaviour {

    public GameObject playeR;

    public void PoweShoT()
    {
        playeR.GetComponent<PlayerScript>().coolT = 0;
        playeR.GetComponent<PlayerScript>().playState = PlayerScript.PLAYSTATE.HYPER;
    }
	
	
}
