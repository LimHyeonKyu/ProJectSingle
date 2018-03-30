using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBTManager : MonoBehaviour {

    public GameObject bossBT;
    public float coolT;
    public float respawnT;
    public bool bulletShot = false;
    public GameObject bossGB;
	void Update ()
    {
        if(bossGB.transform.position.y<=0.8f)
        {
            bulletShot = true;
        }
       if(bulletShot==true)
        {
            coolT += Time.deltaTime;
            if (coolT >= respawnT)
            {
                coolT = 0;
                Instantiate(bossBT, transform.position, transform.rotation);
            }
        }
        //transform.Translate(btmSpeed * Time.deltaTime, 0, 0);
        //if (transform.localPosition.x > 0.5f)
        //{
        //    btmSpeed = -0.2f;
        //}
        //if (transform.localPosition.x < -0.5f)
        //{
        //    btmSpeed = 0.2f;
        //}
    }
}
