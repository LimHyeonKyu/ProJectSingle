using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakingCamera : MonoBehaviour {

    public GameObject shakingCamera;
    public bool shaking = false;
    public float coolTime;
	
	void Update ()
    {
        coolTime -= Time.deltaTime;
        if(coolTime<0)
        {
            coolTime = 0;
            shaking = false;
        }
        if(coolTime>0)
        {
            shaking = true;
        }
        if (shaking == true)
        {
            ShakeCamera();
        }
        else
        {
            FixedCamera();
        }
	}
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            coolTime += 0.2f;
        }
        if (col.gameObject.tag == "Enemy2")
        {
            coolTime += 0.2f;
        }
        if (col.gameObject.tag == "Enemy3")
        {
            coolTime += 0.2f;
        }
        if (col.gameObject.tag == "Enemy4")
        {
            coolTime += 0.2f;
        }
        if (col.gameObject.tag == "Enemy5")
        {
            coolTime += 0.2f;
        }
        if (col.gameObject.tag == "BossBT")
        {
            coolTime += 0.2f;
        }
        if (col.gameObject.tag == "BossBT2")
        {
            coolTime += 0.2f;
        }
        if (col.gameObject.tag == "BossBT3")
        {
            coolTime += 0.2f;
        }
        if (col.gameObject.tag == "BossBT4")
        {
            coolTime += 0.2f;
        }
        if (col.gameObject.tag == "EnemyBullet")
        {
            coolTime += 0.2f;
        }
        if (col.gameObject.tag == "EnemyBullet2")
        {
            coolTime += 0.2f;
        }
    }
    void ShakeCamera()
    {
        shakingCamera.transform.localPosition = new Vector3(Random.Range(0,15f), Random.Range(-0.75f,15f), -0.1f);
    }
    void FixedCamera()
    {
        shakingCamera.transform.localPosition = new Vector3(0,-0.75f, -0.1f);
    }
}
