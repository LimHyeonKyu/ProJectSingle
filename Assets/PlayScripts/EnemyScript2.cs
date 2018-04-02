using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript2 : MonoBehaviour {

    private int a;
    public float enemySpeed;
    public float enumHp;
    public float yPosition;
    public GameObject enemyMG;
    public GameObject[] item;
    public GameObject[] coinIteM;
    public GameObject playerOBJ;
    public GameObject petOBJ;
    public GameObject effect2;
    public int scoreDie;
    public GameObject hpTT;
    public enum ENEMYSTATE
    {
        NONE,
        DIE,
        LIVE
    }
    public ENEMYSTATE enemystate;

    void Start()
    {
        enemyMG = GameObject.Find("EnemyManager22");
        playerOBJ = GameObject.Find("Player1");
        petOBJ = GameObject.Find("Pet1");
    }

    void Update()
    {
        switch (enemystate)
        {
            case ENEMYSTATE.NONE:
                break;
            case ENEMYSTATE.DIE:
                a = Random.Range(0, 100);
                if (a <= 91 && a >= 71)
                {
                    Instantiate(item[0], transform.position, transform.rotation);
                }
                if (a <= 70 && a >= 50)
                {
                    Instantiate(item[1], transform.position, transform.rotation);
                }
                if (a <= 30 && a >= 20)
                {
                    Instantiate(item[2], transform.position, transform.rotation);
                }
                if(a<=16&& a>=1)
                {
                    Instantiate(item[3], transform.position, transform.rotation);
                }
                ScoreManager.instance._myScore += scoreDie;
                enemyMG.GetComponent<EnemyManager2>().enemyDT = true;
                int n = Random.Range(0, 2);
                if(n>=1)
                {
                    Instantiate(coinIteM[1], transform.position, transform.rotation);
                    Instantiate(coinIteM[1], transform.position, transform.rotation);
                }
                Instantiate(coinIteM[0], transform.position, transform.rotation);
                Instantiate(coinIteM[0], transform.position, transform.rotation);
                Instantiate(coinIteM[0], transform.position, transform.rotation);
                Instantiate(coinIteM[0], transform.position, transform.rotation);
                Destroy(gameObject);
                break;
            case ENEMYSTATE.LIVE:
                hpTT.GetComponent<TextMesh>().text = "HP:" + enumHp;
                enemyMG.GetComponent<EnemyManager2>().enemyDT = false;
                transform.Translate(0, -enemySpeed * Time.deltaTime, 0);
                if (transform.position.y <= yPosition)
                {
                    enemySpeed = 0;
                    transform.position = new Vector3(transform.position.x, 0.45f, transform.position.z);
                }
                break;
            default:
                break;
        }
        if (enumHp <= 0)
        {
            EnemyDIE();
        }
        if(enumHp<0)
        {
            enumHp = 0;
        }
        if(enumHp>0)
        {
            EnemyLIVE();
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            enumHp -=playerOBJ.GetComponent<PlayerScript>().playerDM;
            Instantiate(effect2, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "Bullet2")
        {
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            enumHp -=  playerOBJ.GetComponent<PlayerScript>().playerDM;
            Instantiate(effect2, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "Bullet3")
        {
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            enumHp -=  playerOBJ.GetComponent<PlayerScript>().playerDM;
            Instantiate(effect2, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "Bullet4")
        {
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            enumHp -= playerOBJ.GetComponent<PlayerScript>().playerDM;
            Instantiate(effect2, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "Bullet5")
        {
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            enumHp -= playerOBJ.GetComponent<PlayerScript>().playerDM;
            Instantiate(effect2, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "Bullet6")
        {
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            enumHp -=  playerOBJ.GetComponent<PlayerScript>().playerDM;
            Instantiate(effect2, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "Bullet7")
        {
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            enumHp -=  playerOBJ.GetComponent<PlayerScript>().playerDM;
            Instantiate(effect2, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "PowerBullet")
        {
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            enumHp -= 40;
            Instantiate(effect2, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "PetBullet")
        {
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            enumHp -= petOBJ.GetComponent<PetDamage>().damage;
            Instantiate(effect2, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "PetBullet2")
        {
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            enumHp -= petOBJ.GetComponent<PetDamage>().damage;
            Instantiate(effect2, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "PetBullet3")
        {
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            enumHp -= petOBJ.GetComponent<PetDamage>().damage;
            Instantiate(effect2, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "PetBullet4")
        {
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            enumHp -= petOBJ.GetComponent<PetDamage>().damage;
            Instantiate(effect2, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "PetBullet5")
        {
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            enumHp -= petOBJ.GetComponent<PetDamage>().damage;
            Instantiate(effect2, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "PetBullet6")
        {
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            enumHp -= petOBJ.GetComponent<PetDamage>().damage;
            Instantiate(effect2, transform.position, transform.rotation);
        }
    }
    public void EnemyLIVE()
    {
        enemystate = ENEMYSTATE.LIVE;
    }
    public void EnemyDIE()
    {
        enemystate = ENEMYSTATE.DIE;
    }
}
