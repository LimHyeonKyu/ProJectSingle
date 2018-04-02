using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    public int playerHP;
    public int playerDM;
    public int powerCT = 0;
    public GameObject[] bulletMG;
    public GameObject[] bosst;
    public GameObject[] hyperBK;
    public GameObject magnetic;
    public GameObject[] fireMG;
    public GameObject powerCount;
    public GameObject bombEFT;
    public GameObject gameOver;
    public GameObject scoreMG;
    public List<GameObject> playHeart;
    public float coolT;
    public float coolT2;
    public float coolT3;
    public float coolT4;
    public float resPawnT;
    public float resPawnT2;
    public float resPawnT3;
    public float resPawnT4;
    public bool multiShot = false;
    public bool powerShot = false;
    public bool magnetics = false;
    public bool hyperMode = false;
    public enum PLAYSTATE
    {
        NONE,
        MULTI,
        POWER,
        HYPER,
        MAGNET,
        DEAD
    }
    public PLAYSTATE playState;
    void Start()
    {
        if(IntManager.insTance.character==0)
        {
            playerHP = 20;
            playerDM = 15;
        }
        if (IntManager.insTance.character == 1)
        {
            playerHP = 20;
            playerDM = 20;
        }
        if (IntManager.insTance.character == 2)
        {
            playerHP = 30;
            playerDM = 15;
        }
        if (IntManager.insTance.character == 3)
        {
            playerHP = 30;
            playerDM = 25;
        }
        if (IntManager.insTance.character == 4)
        {
            playerHP = 30;
            playerDM = 30;
        }
        if (IntManager.insTance.character == 5)
        {
            playerHP = 40;
            playerDM = 35;
        }
        if (IntManager.insTance.character == 6)
        {
            playerHP = 40;
            playerDM = 40;
        }
        scoreMG = GameObject.Find("ScoreManager");
    }
	void Update ()
    {
        if(playerHP>40)
        {
            playerHP = 40;
        }
        powerCount.GetComponent<UILabel>().text = powerCT.ToString();
        switch (playerHP)
        {
            case 0:
                playHeart[0].SetActive(false);
                playHeart[1].SetActive(false);
                playHeart[2].SetActive(false);
                playHeart[3].SetActive(false);
                break;
            case 10:
                playHeart[0].SetActive(true);
                playHeart[1].SetActive(false);
                playHeart[2].SetActive(false);
                playHeart[3].SetActive(false);
                break;
            case 20:
                playHeart[0].SetActive(true);
                playHeart[1].SetActive(true);
                playHeart[2].SetActive(false);
                playHeart[3].SetActive(false);
                break;
            case 30:
                playHeart[0].SetActive(true);
                playHeart[1].SetActive(true);
                playHeart[2].SetActive(true);
                playHeart[3].SetActive(false);
                break;
            case 40:
                playHeart[0].SetActive(true);
                playHeart[1].SetActive(true);
                playHeart[2].SetActive(true);
                playHeart[3].SetActive(true);
                break;
            default:
                break;
        }
        if (multiShot == true)
        {
            coolT += Time.deltaTime;
            bulletMG[0].SetActive(false);
            bulletMG[1].SetActive(true);
            bulletMG[2].SetActive(true);
            bulletMG[3].SetActive(false);
            playState = PLAYSTATE.MULTI;
        }
        if(powerShot==true)
        {
            coolT = 0;
            coolT2 += Time.deltaTime;
            multiShot = false;
            bulletMG[0].SetActive(false);
            bulletMG[1].SetActive(false);
            bulletMG[2].SetActive(false);
            bulletMG[3].SetActive(true);
            playState = PLAYSTATE.POWER;
        }
        if (magnetics==true)
        {
            coolT4 += Time.deltaTime;
            playState = PLAYSTATE.MAGNET;
        }
        if (hyperMode==true)
        {
            coolT3 += Time.deltaTime;
            playState = PLAYSTATE.HYPER;
        }
        switch (playState)
        {
            case PLAYSTATE.NONE:
                //Time.timeScale = 1;
                break;
            case PLAYSTATE.MULTI:
                if (coolT > resPawnT)
                {
                    multiShot = false;
                    if (multiShot == false)
                    {
                        coolT = 0;
                        playState = PLAYSTATE.NONE;
                        bulletMG[0].SetActive(true);
                        bulletMG[1].SetActive(false);
                        bulletMG[2].SetActive(false);
                        bulletMG[3].SetActive(false);
                    }
                }
                if (playerHP <= 0)
                {
                    multiShot = false;
                    playState = PLAYSTATE.DEAD;
                }
                break;
            case PLAYSTATE.POWER:
                if (coolT2 > resPawnT2)
                {
                    powerShot = false;
                    if(powerShot==false)
                    {
                        coolT2 = 0;
                        playState = PLAYSTATE.NONE;
                        bulletMG[0].SetActive(true);
                        bulletMG[1].SetActive(false);
                        bulletMG[2].SetActive(false);
                        bulletMG[3].SetActive(false);
                    }
                }
                if (playerHP <= 0)
                {
                    powerShot = false;
                    playState = PLAYSTATE.DEAD;
                }
                break;
            case PLAYSTATE.HYPER:
                coolT = 0;
                coolT2 = 0;
                multiShot = false;
                powerShot = false;
                this.GetComponent<ShakingCamera>().shaking = false;
                Time.timeScale = 3f;
                this.GetComponent<PlayerMoving>().playerSpeed = 1.6f;
                hyperBK[0].SetActive(true);
                hyperBK[1].SetActive(true);
                hyperBK[2].SetActive(true);
                bosst[0].SetActive(true);
                bosst[1].SetActive(true);
                bulletMG[0].SetActive(false);
                bulletMG[1].SetActive(false);
                bulletMG[2].SetActive(false);
                bulletMG[3].SetActive(false);
                bulletMG[4].SetActive(false);
                bulletMG[5].SetActive(false);
                bulletMG[6].SetActive(false);
                fireMG[0].GetComponent<FireManager>().fireB2 = false;
                fireMG[1].GetComponent<FireManager>().fireB2 = false;
                fireMG[2].GetComponent<FireManager>().fireB2 = false;
                if (coolT3 > resPawnT3)
                {
                    hyperMode = false;
                    if(hyperMode==false)
                    {
                        this.GetComponent<PlayerMoving>().playerSpeed = 5.5f;
                        coolT3 = 0;
                        hyperBK[0].SetActive(false);
                        hyperBK[1].SetActive(false);
                        hyperBK[2].SetActive(false);
                        bosst[0].SetActive(false);
                        bosst[1].SetActive(false);
                        bulletMG[0].SetActive(true);
                        bulletMG[1].SetActive(false);
                        bulletMG[2].SetActive(false);
                        bulletMG[3].SetActive(false);
                        bulletMG[4].SetActive(true);
                        fireMG[0].GetComponent<FireManager>().fireB2 = true;
                        fireMG[1].GetComponent<FireManager>().fireB2 = true;
                        fireMG[2].GetComponent<FireManager>().fireB2 = true;
                        playState = PLAYSTATE.NONE;
                        Time.timeScale = 1;
                    }
                }
                if (playerHP <= 0)
                {
                    hyperMode = false;
                    playState = PLAYSTATE.DEAD;
                }
                break;
            case PLAYSTATE.MAGNET:
                magnetics = true;
                magnetic.SetActive(true);
                if (coolT4 > resPawnT4)
                {
                    magnetics = false;
                    if(magnetics==false)
                    {
                        coolT4 = 0;
                        magnetic.SetActive(false);
                        playState = PLAYSTATE.NONE;
                    }
                }
                if (playerHP <= 0)
                {
                    magnetics = false;
                    playState = PLAYSTATE.DEAD;
                }
                break;
            case PLAYSTATE.DEAD:
                gameObject.SetActive(false);
                gameOver.GetComponent<FillMount>().overFill = true;
                break;
            default:
                break;
        }
        if(playerHP<=0)
        {
            scoreMG.GetComponent<ScoreManager>().disScore = false;
            playState = PLAYSTATE.DEAD;
        }
        if(playerHP<0)
        {
            playerHP = 0;
        }
        if(playerHP>0)
        {
            scoreMG.GetComponent<ScoreManager>().disScore = true;
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            playerHP -= 10;
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            Instantiate(bombEFT, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "Enemy2")
        {
            playerHP -= 10;
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            Instantiate(bombEFT, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "Enemy3")
        {
            playerHP -= 10;
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            Instantiate(bombEFT, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "Enemy4")
        {
            playerHP -= 10;
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            Instantiate(bombEFT, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "Enemy5")
        {
            playerHP -= 10;
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            Instantiate(bombEFT, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "BossBT")
        {
            playerHP -= 10;
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            Instantiate(bombEFT, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "BossBT2")
        {
            playerHP -= 20;
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            Instantiate(bombEFT, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "BossBT3")
        {
            playerHP -= 20;
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            Instantiate(bombEFT, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "BossBT4")
        {
            playerHP -= 30;
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            Instantiate(bombEFT, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "EnemyBullet")
        {
            playerHP -= 10;
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            Instantiate(bombEFT, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "EnemyBullet2")
        {
            playerHP -= 10;
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[1]);
            Instantiate(bombEFT, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "Fire")
        {
            playerHP -= 20;
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[0]);
            Instantiate(bombEFT, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "Multi")
        {
            coolT = 0;
            multiShot = true;
        }
        if (col.gameObject.tag == "Hyper")
        {
            hyperMode = true;
        }
        if (col.gameObject.tag == "Magnet")
        {
            coolT4 = 0;
            magnetics = true;
        }
        if (col.gameObject.tag == "Coin")
        {
            ScoreManager.instance.coinSC += 5;
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[5]);
        }
        if (col.gameObject.tag == "Topaz")
        {
            ScoreManager.instance.coinSC += 10;
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[5]);
        }
        if (col.gameObject.tag == "PowerItem")
        {
            powerCT += 1;
        }
    }
    public void PowerShot()
    {
        powerShot = true;
        if(powerShot==true)
        {
            coolT2 = 0;
            powerCT -= 1;
        }
        if (powerCT < 0)
        {
            powerCT = 0;
            powerShot = false;
        }
    }
}
