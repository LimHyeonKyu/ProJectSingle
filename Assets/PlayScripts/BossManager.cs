using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossManager : MonoBehaviour {

    public List<GameObject> bossObj;
    public float coolTi;
    public float respawnTi;
    public bool bossDT = true;
    public List<GameObject> bossImage;
    public GameObject warning;
    public GameObject player1;
    void Start()
    {
        player1 = GameObject.Find("Player1");
        bossObj[0].GetComponent<BossScript>().hitSC =10;
        bossObj[1].GetComponent<BossScript>().hitSC = 20;
        bossObj[2].GetComponent<BossScript>().hitSC = 30;
        bossObj[3].GetComponent<BossScript>().hitSC = 40;
        bossObj[0].GetComponent<BossScript>().bossHP = 1000;
        bossObj[1].GetComponent<BossScript>().bossHP = 1200;
        bossObj[2].GetComponent<BossScript>().bossHP = 1500;
        bossObj[3].GetComponent<BossScript>().bossHP = 2200;
    }

    void Update ()
    {
        if (player1.GetComponent<PlayerScript>().playerHP <= 0)
        {
            gameObject.SetActive(false);
        }
        if (bossDT == true)
        {
            BossTrue();
        }
        if(bossDT==false)
        {
            coolTi = 0;
        }
    }
    public void BossTrue()
    {
        coolTi += Time.deltaTime;
        if (coolTi > respawnTi)
        {
            coolTi = 0;
            warning.SetActive(true);
            bossImage[0].SetActive(true);
            Instantiate(bossObj[0], transform.position, transform.rotation);
            bossImage.Insert(4, bossImage[0]);
            bossObj.Insert(4, bossObj[0]);
            bossObj[4].GetComponent<BossScript>().bossHP += 300;
            bossObj[4].GetComponent<BossScript>().hitSC += 10;
            bossObj.Remove(bossObj[0]);
            bossImage.Remove(bossImage[0]);
            bossDT = false;
            respawnTi += 5f;
        }
    }
}
