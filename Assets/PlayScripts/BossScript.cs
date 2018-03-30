using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossScript : MonoBehaviour {

    private int c;
    public float bossHP;
    public float bossSpeed;
    public float bossYSpeed;
    public bool bossTL = false;
    public bool bulletDM = false;
    public GameObject player;
    public GameObject bossMG;
    public GameObject[] enemyMG;
    public GameObject[] fireMG;
    public GameObject[] iTem;
    public GameObject[] coinitem;
    public GameObject[] topazItem;
    public GameObject bombEffect;
    public GameObject hPText;
    public int deadSC;
    public int hitSC;
    public int k;
    public int q;
    public enum BOSSSTATE
    {
        NONE,
        MOVE,
        DEAD
    }
    public BOSSSTATE bossState;
    void Start()
    {
        player = GameObject.Find("Player1");
        bossMG = GameObject.Find("BossManager");
        enemyMG[0] = GameObject.Find("EnemyManager11");
        enemyMG[1] = GameObject.Find("EnemyManager22");
        enemyMG[2] = GameObject.Find("EnemyManager33");
        enemyMG[3] = GameObject.Find("EnemyManager44");
        enemyMG[4] = GameObject.Find("EnemyManager55");
        fireMG[0] = GameObject.Find("FireManager1");
        fireMG[1] = GameObject.Find("FireManager2");
        fireMG[2] = GameObject.Find("FireManager3");
        c = Random.Range(0, 100);
    }
	void Update ()
    {
        switch (bossState)
        {
            case BOSSSTATE.NONE:
                player.GetComponent<PlayerScript>().resPawnT3 = 0;
                fireMG[0].SetActive(false);
                fireMG[1].SetActive(false);
                fireMG[2].SetActive(false);
                enemyMG[0].GetComponent<EnemyManager>().enumDT = false;
                enemyMG[1].GetComponent<EnemyManager2>().enemyDT = false;
                enemyMG[2].GetComponent<EnemyManager>().enumDT = false;
                enemyMG[3].GetComponent<EnemyManager>().enumDT = false;
                enemyMG[4].GetComponent<EnemyManager3>().enemyDt = false;
                transform.Translate(0, -bossYSpeed * Time.deltaTime, 0);
                if (transform.position.y < 0.73f)
                {
                    bossYSpeed = 0;
                    bossState = BOSSSTATE.MOVE;
                    bossTL = true;
                    bossMG.GetComponent<BossManager>().warning.SetActive(false);
                    bossMG.GetComponent<BossManager>().bossImage[3].SetActive(false);
                }
                break;
            case BOSSSTATE.MOVE:
                hPText.GetComponent<TextMesh>().text = "HP:" + bossHP.ToString();
                if (bossTL == true)
                {
                    bulletDM = true;
                    transform.Translate(bossSpeed * Time.deltaTime, 0, 0);
                    if (transform.position.x > 0.35f)
                    {
                        bossSpeed = -0.3f;
                    }
                    if (transform.position.x <= -0.35f)
                    {
                        bossSpeed = 0.3f;
                    }
                }
                break;
            case BOSSSTATE.DEAD:
                if (c <= 91 && c >= 71)
                {
                    Instantiate(iTem[0], transform.position, transform.rotation);
                    Instantiate(iTem[0], transform.position, transform.rotation);
                    Instantiate(iTem[1], transform.position, transform.rotation);
                }
                if (c <= 70 && c >= 50)
                {
                    Instantiate(iTem[2], transform.position, transform.rotation);
                    Instantiate(iTem[1], transform.position, transform.rotation);
                    Instantiate(iTem[1], transform.position, transform.rotation);
                }
                if (c <= 30 && c >= 20)
                {
                    Instantiate(iTem[2], transform.position, transform.rotation);
                    Instantiate(iTem[2], transform.position, transform.rotation);
                    Instantiate(iTem[1], transform.position, transform.rotation);
                }
                for (int i = 0; i < coinitem.Length; i++)
                {
                    Instantiate(coinitem[i], transform.position, transform.rotation);
                }
                for (int w = 0; w < topazItem.Length; w++)
                {
                    Instantiate(topazItem[w], transform.position, transform.rotation);
                }
                player.GetComponent<PlayerScript>().resPawnT3 = 10f;
                ScoreManager.instance._myScore += deadSC;
                enemyMG[0].GetComponent<EnemyManager>().enumDT = true;
                enemyMG[1].GetComponent<EnemyManager2>().enemyDT = true;
                enemyMG[2].GetComponent<EnemyManager>().enumDT = true;
                enemyMG[3].GetComponent<EnemyManager>().enumDT = true;
                enemyMG[4].GetComponent<EnemyManager3>().enemyDt = true;
                fireMG[0].SetActive(true);
                fireMG[1].SetActive(true);
                fireMG[2].SetActive(true);
                bossMG.GetComponent<BossManager>().bossDT=true;
                Destroy(gameObject);
                break;
            default:
                break;
        }
        if (bossHP < 0)
        {
            bossHP = 0;
            bossState = BOSSSTATE.DEAD;
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if(bulletDM==true)
        {
            if (col.gameObject.tag == "Bullet")
            {
               bossHP -= 15;
               ScoreManager.instance._myScore += hitSC;
               Instantiate(bombEffect, transform.position, transform.rotation);
            }
            if (col.gameObject.tag == "Bullet2")
            {
                bossHP -= 20;
                Instantiate(bombEffect, transform.position, transform.rotation);
                ScoreManager.instance._myScore += hitSC;
            }
            if (col.gameObject.tag == "Bullet3")
            {
                bossHP -= 15;
                Instantiate(bombEffect, transform.position, transform.rotation);
                ScoreManager.instance._myScore += hitSC;
            }
            if (col.gameObject.tag == "Bullet4")
            {
                bossHP -= 25;
                Instantiate(bombEffect, transform.position, transform.rotation);
                ScoreManager.instance._myScore += hitSC;
            }
            if (col.gameObject.tag == "Bullet5")
            {
                bossHP -= 25;
                Instantiate(bombEffect, transform.position, transform.rotation);
                ScoreManager.instance._myScore += hitSC;
            }
            if (col.gameObject.tag == "Bullet6")
            {
                bossHP -= 30;
                Instantiate(bombEffect, transform.position, transform.rotation);
                ScoreManager.instance._myScore += hitSC;
            }
            if (col.gameObject.tag == "Bullet7")
            {
                bossHP -= 35;
                Instantiate(bombEffect, transform.position, transform.rotation);
                ScoreManager.instance._myScore += hitSC;
            }
            if (col.gameObject.tag == "PowerBullet")
            {
                bossHP -= 40;
                Instantiate(bombEffect, transform.position, transform.rotation);
                ScoreManager.instance._myScore += hitSC;
            }
            if (col.gameObject.tag == "PetBullet")
            {
                bossHP -= 10;
                Instantiate(bombEffect, transform.position, transform.rotation);
                ScoreManager.instance._myScore += hitSC;
            }
            if (col.gameObject.tag == "PetBullet2")
            {
                bossHP -= 15;
                Instantiate(bombEffect, transform.position, transform.rotation);
                ScoreManager.instance._myScore += hitSC;
            }
            if (col.gameObject.tag == "PetBullet3")
            {
                bossHP -= 8.5f;
                Instantiate(bombEffect, transform.position, transform.rotation);
                ScoreManager.instance._myScore += hitSC;
            }
            if (col.gameObject.tag == "PetBullet4")
            {
                bossHP -= 10;
                Instantiate(bombEffect, transform.position, transform.rotation);
                ScoreManager.instance._myScore += hitSC;
            }
            if (col.gameObject.tag == "PetBullet5")
            {
                bossHP -= 20;
                Instantiate(bombEffect, transform.position, transform.rotation);
                ScoreManager.instance._myScore += hitSC;
            }
            if (col.gameObject.tag == "PetBullet6")
            {
                bossHP -= 25;
                Instantiate(bombEffect, transform.position, transform.rotation);
                ScoreManager.instance._myScore += hitSC;
            }
        }        
    }
}
