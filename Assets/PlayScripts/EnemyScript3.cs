using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript3 : MonoBehaviour {

    private int b;
    public float enemySP;
    public float enemyHp;
    public float yPT;
    public GameObject enemyMg;
    public GameObject[] iteM;
    public GameObject[] coiniteM;
    public GameObject hpTexT;
    public GameObject effect22;
    public int dieSC;
    public enum ENEMYSTATE
    {
        NONE,
        DEAD,
        ALIVE
    }
    public ENEMYSTATE enemyState;

    void Start()
    {
        enemyMg = GameObject.Find("EnemyManager55");
    }

    void Update()
    {
        switch (enemyState)
        {
            case ENEMYSTATE.NONE:
                break;
            case ENEMYSTATE.DEAD:
                ScoreManager.instance._myScore += dieSC;
                enemyMg.GetComponent<EnemyManager3>().enemyDt = true;
                b = Random.Range(0, 100);
                if (b <= 91 && b >= 71)
                {
                    Instantiate(iteM[0], transform.position, transform.rotation);
                }
                if (b <= 70 && b >= 50)
                {
                    Instantiate(iteM[1], transform.position, transform.rotation);
                }
                if (b <= 30 && b >= 20)
                {
                    Instantiate(iteM[2], transform.position, transform.rotation);
                }
                if (b <= 16 && b >= 1)
                {
                    Instantiate(iteM[3], transform.position, transform.rotation);
                }
                int f = Random.Range(0, 2);
                if(f>=1)
                {
                    Instantiate(coiniteM[1], transform.position, transform.rotation);
                    Instantiate(coiniteM[1], transform.position, transform.rotation);
                }
                Instantiate(coiniteM[0], transform.position, transform.rotation);
                Instantiate(coiniteM[0], transform.position, transform.rotation);
                Instantiate(coiniteM[0], transform.position, transform.rotation);
                Instantiate(coiniteM[0], transform.position, transform.rotation);
                Destroy(gameObject);
                break;
            case ENEMYSTATE.ALIVE:
                hpTexT.GetComponent<TextMesh>().text = "HP:" + enemyHp;
                enemyMg.GetComponent<EnemyManager3>().enemyDt = false;
                transform.Translate(0, -enemySP * Time.deltaTime, 0);
                if (transform.position.y <= yPT)
                {
                    enemySP = 0;
                    transform.position = new Vector3(transform.position.x, 0.45f, transform.position.z);
                }
                break;
            default:
                break;
        }
        if (enemyHp <= 0)
        {
            EnemyDIE();
        }
        if(enemyHp<0)
        {
            enemyHp = 0;
        }
        if (enemyHp > 0)
        {
            EnemyLIVE();
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            enemyHp -= 15;
            Instantiate(effect22, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "Bullet2")
        {
            enemyHp -= 20;
            Instantiate(effect22, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "Bullet3")
        {
            enemyHp -= 15;
            Instantiate(effect22, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "Bullet4")
        {
            enemyHp -= 25;
            Instantiate(effect22, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "Bullet5")
        {
            enemyHp -= 25;
            Instantiate(effect22, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "Bullet6")
        {
            enemyHp -= 30;
            Instantiate(effect22, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "Bullet7")
        {
            enemyHp -= 35;
            Instantiate(effect22, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "PowerBullet")
        {
            enemyHp -= 40;
            Instantiate(effect22, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "PetBullet")
        {
            enemyHp -= 10;
            Instantiate(effect22, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "PetBullet2")
        {
            enemyHp -= 15;
            Instantiate(effect22, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "PetBullet3")
        {
            enemyHp -= 8.5f;
            Instantiate(effect22, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "PetBullet4")
        {
            enemyHp -= 10;
            Instantiate(effect22, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "PetBullet5")
        {
            enemyHp -= 20;
            Instantiate(effect22, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "PetBullet6")
        {
            enemyHp -= 25;
            Instantiate(effect22, transform.position, transform.rotation);
        }
    }
    public void EnemyLIVE()
    {
        enemyState = ENEMYSTATE.ALIVE;
    }
    public void EnemyDIE()
    {
        enemyState = ENEMYSTATE.DEAD;
    }
}
