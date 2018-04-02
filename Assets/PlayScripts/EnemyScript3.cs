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
    public GameObject playobj;
    public GameObject petobj;
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
        playobj = GameObject.Find("Player1");
        petobj = GameObject.Find("Pet1");
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
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            enemyHp -= playobj.GetComponent<PlayerScript>().playerDM;
            Instantiate(effect22, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "Bullet2")
        {
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            enemyHp -= playobj.GetComponent<PlayerScript>().playerDM;
            Instantiate(effect22, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "Bullet3")
        {
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            enemyHp -= playobj.GetComponent<PlayerScript>().playerDM;
            Instantiate(effect22, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "Bullet4")
        {
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            enemyHp -= playobj.GetComponent<PlayerScript>().playerDM;
            Instantiate(effect22, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "Bullet5")
        {
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            enemyHp -= playobj.GetComponent<PlayerScript>().playerDM;
            Instantiate(effect22, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "Bullet6")
        {
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            enemyHp -= playobj.GetComponent<PlayerScript>().playerDM;
            Instantiate(effect22, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "Bullet7")
        {
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            enemyHp -= playobj.GetComponent<PlayerScript>().playerDM;
            Instantiate(effect22, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "PowerBullet")
        {
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            enemyHp -= 40;
            Instantiate(effect22, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "PetBullet")
        {
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            enemyHp -= petobj.GetComponent<PetDamage>().damage;
            Instantiate(effect22, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "PetBullet2")
        {
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            enemyHp -= petobj.GetComponent<PetDamage>().damage;
            Instantiate(effect22, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "PetBullet3")
        {
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            enemyHp -= petobj.GetComponent<PetDamage>().damage;
            Instantiate(effect22, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "PetBullet4")
        {
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            enemyHp -= petobj.GetComponent<PetDamage>().damage;
            Instantiate(effect22, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "PetBullet5")
        {
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            enemyHp -= petobj.GetComponent<PetDamage>().damage;
            Instantiate(effect22, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "PetBullet6")
        {
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            enemyHp -= petobj.GetComponent<PetDamage>().damage;
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
