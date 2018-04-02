using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetBulletManager : MonoBehaviour {


    public GameObject[] petBT;
    public float coolTime;
    public float respawnTime;
    public int e;

    void Start()
    {
        e = IntManager.insTance.pet;
        if(IntManager.insTance.pet==3)
        {
            respawnTime = 0.55f;
        }
        if (IntManager.insTance.pet == 5)
        {
            respawnTime = 0.7f;
        }

    }
    void Update()
    {
        coolTime += Time.deltaTime;
        if (coolTime > respawnTime)
        {
            coolTime = 0;
            if(IntManager.insTance.pet==2)
            {
                Instantiate(petBT[2], transform.position, transform.rotation);
            }
            Instantiate(petBT[e], transform.position, transform.rotation);
        }
    }
}
