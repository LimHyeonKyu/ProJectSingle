using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetDamage : MonoBehaviour {

    public int damage;
    public GameObject[] btMg;
    public void Start()
    {
        if(IntManager.insTance.pet==0)
        {
            btMg[0].SetActive(true);
            btMg[1].SetActive(false);
            btMg[2].SetActive(false);
            damage = 10;
        }
        if (IntManager.insTance.pet == 1)
        {
            btMg[0].SetActive(true);
            btMg[1].SetActive(false);
            btMg[2].SetActive(false);
            damage = 12;
        }
        if (IntManager.insTance.pet == 2)
        {
            btMg[0].SetActive(false);
            btMg[1].SetActive(true);
            btMg[2].SetActive(true);
            damage = 8;
        }
        if (IntManager.insTance.pet == 3)
        {
            btMg[0].SetActive(true);
            btMg[1].SetActive(false);
            btMg[2].SetActive(false);
            damage = 10;
        }
        if (IntManager.insTance.pet == 4)
        {
            btMg[0].SetActive(true);
            btMg[1].SetActive(false);
            btMg[2].SetActive(false);
            damage = 20;
        }
        if (IntManager.insTance.pet == 5)
        {
            btMg[0].SetActive(true);
            btMg[1].SetActive(false);
            btMg[2].SetActive(false);
            damage = 25;
        }
    }

}
