using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    public float bulletSpeed;
	void Update ()
    {
        transform.Translate(0, bulletSpeed * Time.deltaTime, 0);
        if(transform.position.y>0.98f)
        {
            Destroy(gameObject);
        }
	}
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag=="Enemy")
        {
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "Enemy2")
        {
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "Enemy3")
        {
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "Enemy4")
        {
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "Enemy5")
        {
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "Enemy6")
        {
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "Enemy7")
        {
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "Boss")
            Destroy(gameObject);
        if (col.gameObject.tag == "Boss2")
            Destroy(gameObject);
        if (col.gameObject.tag == "Boss3")
            Destroy(gameObject);
        if (col.gameObject.tag == "Boss4")
            Destroy(gameObject);
    }
}
