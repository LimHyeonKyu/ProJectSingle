using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBTManager33 : MonoBehaviour {

    public GameObject bossBT;
    public GameObject[] btMGR;
    public float coolT;
    public float coolT22;
    public float respawnT;
    public float respawnt;
    public bool bulletShot = false;
    public GameObject bossGB;
    void Update()
    {
        if (bossGB.transform.position.y <= 0.8f)
        {
            coolT22 += Time.deltaTime;
            bulletShot = true;
        }
        if (bulletShot == true)
        {
            coolT += Time.deltaTime;
            if (coolT >= respawnT)
            {
                coolT = 0;
                Instantiate(bossBT, transform.position, transform.rotation);
            }
        }
        if (coolT22 > respawnt)
        {
            coolT22 = 0;
            coolT = 0;
            this.gameObject.SetActive(false);
            btMGR[0].SetActive(true);
            btMGR[1].SetActive(true);
        }
    }
}