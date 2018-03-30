using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager2 : MonoBehaviour {


    public GameObject[] enemyObj;
    public GameObject player2;
    public float coolTi;
    public float respawnTi;
    public float coolTi2;
    public float respawnTi2;
    public bool enemyDT = true;
    public float coolTime;
    public float resPawnTime;

    void Start()
    {
        player2 = GameObject.Find("Player1");
        enemyObj[0].GetComponent<EnemyScript>().enemySpeed = 1.1f;
        enemyObj[1].GetComponent<EnemyScript>().enemySpeed = 1.1f;
        enemyObj[2].GetComponent<EnemyScript>().enemySpeed = 1.5f;
        enemyObj[3].GetComponent<EnemyScript>().enemySpeed = 1.1f;
        enemyObj[4].GetComponent<EnemyScript>().enemySpeed = 1.1f;
        enemyObj[0].GetComponent<EnemyScript>().enemyHP = 50;
        enemyObj[1].GetComponent<EnemyScript>().enemyHP = 60;
        enemyObj[2].GetComponent<EnemyScript>().enemyHP = 35;
        enemyObj[3].GetComponent<EnemyScript>().enemyHP = 70;
        enemyObj[4].GetComponent<EnemyScript>().enemyHP = 70;
        enemyObj[5].GetComponent<EnemyScript2>().enumHp = 75;
        enemyObj[0].GetComponent<EnemyScript>().dieScore = 120;
        enemyObj[1].GetComponent<EnemyScript>().dieScore = 130;
        enemyObj[2].GetComponent<EnemyScript>().dieScore = 80;
        enemyObj[3].GetComponent<EnemyScript>().dieScore = 150;
        enemyObj[4].GetComponent<EnemyScript>().dieScore = 150;
        enemyObj[5].GetComponent<EnemyScript2>().scoreDie = 160;
    }

    void Update ()
    {
        if (player2.GetComponent<PlayerScript>().playerHP <= 0)
        {
            gameObject.SetActive(false);
        }
        coolTime += Time.deltaTime;
        if(coolTime>resPawnTime)
        {
            coolTime = 0;
            enemyObj[0].GetComponent<EnemyScript>().enemyHP += 5;
            enemyObj[1].GetComponent<EnemyScript>().enemyHP += 10;
            enemyObj[2].GetComponent<EnemyScript>().enemyHP += 5;
            enemyObj[3].GetComponent<EnemyScript>().enemyHP += 15;
            enemyObj[4].GetComponent<EnemyScript>().enemyHP += 15;
            enemyObj[5].GetComponent<EnemyScript2>().enumHp += 10;
            enemyObj[0].GetComponent<EnemyScript>().dieScore += 5;
            enemyObj[1].GetComponent<EnemyScript>().dieScore += 10;
            enemyObj[2].GetComponent<EnemyScript>().dieScore += 5;
            enemyObj[3].GetComponent<EnemyScript>().dieScore += 15;
            enemyObj[4].GetComponent<EnemyScript>().dieScore += 15;
            enemyObj[5].GetComponent<EnemyScript2>().scoreDie += 20;
        }
        if(enemyDT==true)
        {
            EnemyTrue();
        }
        if(enemyDT==false)
        {
            coolTi = 0;
        }
    }
    public void EnemyTrue()
    {
        coolTi += Time.deltaTime;
        coolTi2 += Time.deltaTime;
        if (coolTi > respawnTi)
        {
            coolTi = 0;
            int i = Random.Range(0, 6);
            Instantiate(enemyObj[i], transform.position, transform.rotation);
        }
        if (coolTi2 > respawnTi2)
        {
            coolTi2 = 0;
            enemyObj[0].GetComponent<EnemyScript>().enemySpeed += 0.1f;
            enemyObj[1].GetComponent<EnemyScript>().enemySpeed += 0.1f;
            enemyObj[2].GetComponent<EnemyScript>().enemySpeed += 0.15f;
            enemyObj[3].GetComponent<EnemyScript>().enemySpeed += 0.1f;
            enemyObj[4].GetComponent<EnemyScript>().enemySpeed += 0.1f;
        }
    }
}
