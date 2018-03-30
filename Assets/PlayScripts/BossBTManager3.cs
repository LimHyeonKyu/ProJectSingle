using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBTManager3 : MonoBehaviour {

    public GameObject bossBT;
    public GameObject[] bulletMG;
    public float coolT1;
    public float coolT2;
    public float respawnT;
    public float respawnT2;
    public GameObject bossGB;
    public float rotSpeed;
    public bool bTShot = true;

    void Update()
    {
        coolT2 += Time.deltaTime;
        if (bossGB.transform.position.y <= 0.8f)
        {
            bTShot = true;
        }
        if (bTShot == true)
        {
            coolT1 += Time.deltaTime;
            transform.Rotate(0, 0, rotSpeed * Time.deltaTime);
        }
        if (coolT1 > respawnT)
        {
            coolT1 = 0;
            Instantiate(bossBT, transform.position, transform.rotation);
        }
        if (coolT2 > respawnT2)
        {
            coolT1 = 0;
            coolT2 = 0;
            this.gameObject.SetActive(false);
            bulletMG[0].SetActive(true);
            bulletMG[1].SetActive(true);
            bulletMG[2].SetActive(true);
        }
    }
}
