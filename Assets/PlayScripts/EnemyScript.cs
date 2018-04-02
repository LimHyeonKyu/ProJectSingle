using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour {

    public float enemySpeed;
    public float enemyHP;
    public int dieScore;
    public GameObject[] itemIns;
    public GameObject[] coinItem;
    private int i;
    public GameObject hpText;
    public GameObject effect;
    public GameObject playerObj;
    public GameObject petObj;
    void Start()
    {
        playerObj = GameObject.Find("Player1");
        petObj = GameObject.Find("Pet1");
    }
	void Update ()
    {
        if(enemyHP<0)
        {
            enemyHP = 0;
        }
        hpText.GetComponent<TextMesh>().text = "HP :" + enemyHP.ToString();
        transform.Translate(0, -enemySpeed * Time.deltaTime, 0);
        if (transform.position.y < -1.5f)
        {
            Destroy(gameObject);
        }
        if (enemyHP<=0)
        {
            i = Random.Range(0, 100);
            if (i <= 91 && i >= 71)
            {
                Instantiate(itemIns[0], transform.position, transform.rotation);
            }
            if (i <= 70 && i >= 50)
            {
                Instantiate(itemIns[1], transform.position, transform.rotation);
            }
            if (i <= 30 && i >= 20)
            {
                Instantiate(itemIns[2], transform.position, transform.rotation);
            }
            if(i<=16&&i>=0)
            {
                Instantiate(itemIns[3], transform.position, transform.rotation);
            }
            int d = Random.Range(0, 2);
            if(d>=1)
            {
                Instantiate(coinItem[1], transform.position, transform.rotation);
            }
            Instantiate(coinItem[0], transform.position, transform.rotation);
            Instantiate(coinItem[0], transform.position, transform.rotation);
            Instantiate(coinItem[0], transform.position, transform.rotation);
            ScoreManager.instance._myScore += dieScore;
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "Bullet")
        {
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            enemyHP -= playerObj.GetComponent<PlayerScript>().playerDM;
            Instantiate(effect, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "Bullet2")
        {
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            enemyHP -= playerObj.GetComponent<PlayerScript>().playerDM;
            Instantiate(effect, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "Bullet3")
        {
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            enemyHP -= playerObj.GetComponent<PlayerScript>().playerDM;
            Instantiate(effect, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "Bullet4")
        {
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            enemyHP -= playerObj.GetComponent<PlayerScript>().playerDM;
            Instantiate(effect, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "Bullet5")
        {
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            enemyHP -= playerObj.GetComponent<PlayerScript>().playerDM;
            Instantiate(effect, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "Bullet6")
        {
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            enemyHP -= playerObj.GetComponent<PlayerScript>().playerDM;
            Instantiate(effect, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "Bullet7")
        {
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            enemyHP -= playerObj.GetComponent<PlayerScript>().playerDM;
            Instantiate(effect, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "PetBullet")
        {
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            enemyHP -= petObj.GetComponent<PetDamage>().damage;
            Instantiate(effect, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "PetBullet2")
        {
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            enemyHP -= petObj.GetComponent<PetDamage>().damage;
            Instantiate(effect, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "PetBullet3")
        {
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            enemyHP -= petObj.GetComponent<PetDamage>().damage;
            Instantiate(effect, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "PetBullet4")
        {
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            enemyHP -= petObj.GetComponent<PetDamage>().damage;
            Instantiate(effect, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "PetBullet5")
        {
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            enemyHP -= petObj.GetComponent<PetDamage>().damage;
            Instantiate(effect, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "PetBullet6")
        {
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            enemyHP -= petObj.GetComponent<PetDamage>().damage;
            Instantiate(effect, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "PowerBullet")
        {
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            enemyHP -= 40;
            Instantiate(effect, transform.position, transform.rotation);
        }
        if (col.gameObject.tag=="HyPerBK")
        {
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[0]);
            ScoreManager.instance._myScore += dieScore;
            i = Random.Range(0, 100);
            if (i <= 91 && i >= 71)
            {
                Instantiate(itemIns[0], transform.position, transform.rotation);
            }
            if (i <= 70 && i >= 50)
            {
                Instantiate(itemIns[1], transform.position, transform.rotation);
            }
            if (i <= 30 && i >= 20)
            {
                Instantiate(itemIns[2], transform.position, transform.rotation);
            }
            int d = Random.Range(0, 2);
            if (d >= 1)
            {
                Instantiate(coinItem[1], transform.position, transform.rotation);
            }
            Instantiate(coinItem[0], transform.position, transform.rotation);
            Instantiate(coinItem[0], transform.position, transform.rotation);
            Instantiate(coinItem[0], transform.position, transform.rotation);
            Instantiate(effect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "HyPerBK2")
        {
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[0]);
            ScoreManager.instance._myScore += dieScore;
            i = Random.Range(0, 100);
            if (i <= 91 && i >= 71)
            {
                Instantiate(itemIns[0], transform.position, transform.rotation);
            }
            if (i <= 70 && i >= 50)
            {
                Instantiate(itemIns[1], transform.position, transform.rotation);
            }
            if (i <= 30 && i >= 20)
            {
                Instantiate(itemIns[2], transform.position, transform.rotation);
            }
            int d = Random.Range(0, 2);
            if (d >= 1)
            {
                Instantiate(coinItem[1], transform.position, transform.rotation);
            }
            Instantiate(coinItem[0], transform.position, transform.rotation);
            Instantiate(coinItem[0], transform.position, transform.rotation);
            Instantiate(coinItem[0], transform.position, transform.rotation);
            Instantiate(effect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
