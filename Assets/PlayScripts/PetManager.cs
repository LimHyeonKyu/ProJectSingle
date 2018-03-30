using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetManager : MonoBehaviour {

    public GameObject[] petS;
    public GameObject parentObject;
	void Start ()
    {
        parentObject = GameObject.Find("Pet1");
        petS[0]=Instantiate(petS[0], transform.position, transform.rotation) as GameObject;
        petS[0].transform.parent = parentObject.transform;
	}
}
