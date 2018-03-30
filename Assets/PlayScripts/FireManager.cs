using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireManager : MonoBehaviour
{
    public GameObject[] fireBall;
    public GameObject player;
    public float coolTime;
    public float coolTime2;
    public float coolTime3;
    public float resPawnTime;
    public float resPawnTime2;
    public float resPawnTime3;
    public float speedX;
    public float limitX;
    public float limitXX;
    public bool fireB = false;
    public bool fireB2 = true;

    void Start()
    {
        player = GameObject.Find("Player1");
    }
    void Update()
    {
        if(player.GetComponent<PlayerScript>().playerHP<=0)
        {
            gameObject.SetActive(false);
        }
        transform.Translate(speedX * Time.deltaTime, 0, 0);
        if (transform.position.x >= limitX)
            speedX = -0.25f;
        if (transform.position.x <= limitXX)
            speedX = 0.25f;
        if (fireB2 == true)
        {
            coolTime += Time.deltaTime;
            coolTime3 += Time.deltaTime;
        }
        if (coolTime > resPawnTime)
        {
            coolTime = 0;
            fireB2 = false;
            fireB = true;
        }
        if(coolTime3>resPawnTime3)
        {
            fireBall[0].GetComponent<FireScript>().mvSpeed += 0.3f;
        }
        if (fireB == true)
        {
            coolTime2 += Time.deltaTime;
            fireBall[1].SetActive(true);
            fireBall[2].SetActive(true);
            if (coolTime2 > resPawnTime2)
            {
                fireBall[1].SetActive(false);
                fireBall[2].SetActive(false);
                coolTime2 = 0;
                fireB = false;
                fireB2 = true;
                Instantiate(fireBall[0], transform.position, transform.rotation);
            }
        }
    }
}
