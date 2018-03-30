using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBulletScript : MonoBehaviour {

    public float btSpeed;

    void Update()
    {
        transform.Translate(0, -btSpeed * Time.deltaTime, 0);
        Destroy(gameObject, 1.5f);
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
        if(col.gameObject.tag == "PowerBullet")
        {
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "HyPerBK")
        {
            Destroy(gameObject);
        }
        if(col.gameObject.tag=="HyPerBK2")
        {
            Destroy(gameObject);
        }
    }
}
