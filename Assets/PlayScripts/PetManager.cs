using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetManager : MonoBehaviour {

    public GameObject[] petS;
    public GameObject parentObject;
    public int petint;
	void Start ()
    {
        petint = IntManager.insTance.pet;
        parentObject = GameObject.Find("Pet1");
        petS[petint]=Instantiate(petS[petint], transform.position, transform.rotation) as GameObject;
        petS[petint].transform.parent = parentObject.transform;
	}
}
