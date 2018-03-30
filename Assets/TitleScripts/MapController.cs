using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour {


    public float speed;


	void Update ()
    {
        transform.Translate(0, -speed * Time.deltaTime, 0);
		if(transform.localPosition.y<-2540)
        {
            transform.localPosition = new Vector3(0, 0, 0);
        }
	}
}
