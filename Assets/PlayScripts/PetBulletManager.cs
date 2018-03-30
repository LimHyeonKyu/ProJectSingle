using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetBulletManager : MonoBehaviour {


    public GameObject[] petBT;
    public float coolTime;
    public float respawnTime;


    void Update()
    {
        coolTime += Time.deltaTime;
        if (coolTime > respawnTime)
        {
            coolTime = 0;
            Instantiate(petBT[0], transform.position, transform.rotation);
        }
    }
}
