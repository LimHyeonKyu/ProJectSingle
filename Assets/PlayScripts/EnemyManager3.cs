using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager3 : MonoBehaviour {

    public GameObject[] enemyObj;
    public GameObject player3;
    public float coolTI;
    public float respawnTI;
    public float coolTI2;
    public float respawnTI2;
    public bool enemyDt = true;
    public float coolTime;
    public float resPawnTime;

    void Start()
    {
        player3 = GameObject.Find("Player1");
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
        enemyObj[5].GetComponent<EnemyScript3>().enemyHp = 80;
        enemyObj[0].GetComponent<EnemyScript>().dieScore = 120;
        enemyObj[1].GetComponent<EnemyScript>().dieScore = 130;
        enemyObj[2].GetComponent<EnemyScript>().dieScore = 80;
        enemyObj[3].GetComponent<EnemyScript>().dieScore = 150;
        enemyObj[4].GetComponent<EnemyScript>().dieScore = 150;
        enemyObj[5].GetComponent<EnemyScript3>().dieSC = 170;
    }
    void Update()
    {
        if (player3.GetComponent<PlayerScript>().playerHP <= 0)
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
            enemyObj[5].GetComponent<EnemyScript3>().enemyHp += 10;
            enemyObj[0].GetComponent<EnemyScript>().dieScore += 5;
            enemyObj[1].GetComponent<EnemyScript>().dieScore += 10;
            enemyObj[2].GetComponent<EnemyScript>().dieScore += 5;
            enemyObj[3].GetComponent<EnemyScript>().dieScore += 15;
            enemyObj[4].GetComponent<EnemyScript>().dieScore += 15;
            enemyObj[5].GetComponent<EnemyScript3>().dieSC += 20;
        }
        if (enemyDt == true)
        {
            EnemyTrue();
        }
        if(enemyDt==false)
        {
            coolTI = 0;
            coolTime = 0;
        }
    }
    public void EnemyTrue()
    {
        coolTI += Time.deltaTime;
        coolTI2 += Time.deltaTime;
        if (coolTI > respawnTI)
        {
            coolTI = 0;
            int a = Random.Range(0, 6);
            Instantiate(enemyObj[a], transform.position, transform.rotation);
        }
        if (coolTI2 > respawnTI2)
        {
            coolTI2 = 0;
            enemyObj[0].GetComponent<EnemyScript>().enemySpeed += 0.1f;
            enemyObj[1].GetComponent<EnemyScript>().enemySpeed += 0.1f;
            enemyObj[2].GetComponent<EnemyScript>().enemySpeed += 0.15f;
            enemyObj[3].GetComponent<EnemyScript>().enemySpeed += 0.1f;
            enemyObj[4].GetComponent<EnemyScript>().enemySpeed += 0.1f;
        }
    }
}

