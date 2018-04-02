using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaterManager : MonoBehaviour {

    public GameObject[] charaterS;
    public GameObject parentObj;
    public int chint = 0;
	void Start ()
    {
        chint = IntManager.insTance.character;
        parentObj = GameObject.Find("Player1");
        charaterS[chint] =Instantiate(charaterS[chint], transform.position, transform.rotation) as GameObject;
        charaterS[chint].transform.parent = parentObj.transform;
	}
}
