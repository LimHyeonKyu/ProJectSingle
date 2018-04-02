using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopBTN : MonoBehaviour {

    public GameObject[] shopMenual;

    public void GoldShop()
    {
        shopMenual[0].SetActive(true);
        shopMenual[1].SetActive(false);
        shopMenual[2].SetActive(false);
    }
    public void StarShop()
    {
        shopMenual[0].SetActive(false);
        shopMenual[1].SetActive(true);
        shopMenual[2].SetActive(false);
    }
    public void WingShop()
    {
        shopMenual[0].SetActive(false);
        shopMenual[1].SetActive(false);
        shopMenual[2].SetActive(true);
    }
}
