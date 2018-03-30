using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaterManager : MonoBehaviour {

    public GameObject[] charaterS;
    public GameObject parentObj;
	void Start ()
    {
        parentObj = GameObject.Find("Player1");
        charaterS[0] =Instantiate(charaterS[0], transform.position, transform.rotation) as GameObject;
        charaterS[0].transform.parent = parentObj.transform;
	}
}
