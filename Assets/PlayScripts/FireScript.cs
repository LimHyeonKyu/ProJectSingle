using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour {

    public float mvSpeed;
    public GameObject eFFect;
	
	void Start()
    {
        mvSpeed = 1.5f;
    }

	void Update ()
    {
        transform.Translate(0, -mvSpeed * Time.deltaTime, 0);
        if (transform.position.y < -2f)
        {
            Destroy(gameObject);
        }
	}
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag=="Player")
        {
            Destroy(gameObject);
            Instantiate(eFFect, transform.position, transform.rotation);
        }
        if(col.gameObject.tag== "HyPerBK")
        {
            Instantiate(eFFect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        if(col.gameObject.tag=="HyPerBK2")
        {
            Instantiate(eFFect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        if(col.gameObject.tag=="PowerBullet")
        {
            Instantiate(eFFect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
