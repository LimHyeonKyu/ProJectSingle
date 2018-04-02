using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldBuy : MonoBehaviour {

    public GameObject goldObj;

    public void TwoThouGold()
    {
        goldObj.GetComponent<GoldCount>().totalGold += 2000;
    }
    public void FourThouGold()
    {
        goldObj.GetComponent<GoldCount>().totalGold += 4000;
    }
    public void SixThouGold()
    {
        goldObj.GetComponent<GoldCount>().totalGold += 6000;
    }
    public void EightThouGold()
    {
        goldObj.GetComponent<GoldCount>().totalGold += 8000;
    }
    public void TenThouGold()
    {
        goldObj.GetComponent<GoldCount>().totalGold += 10000;
    }
    public void TwoElevenGold()
    {
        goldObj.GetComponent<GoldCount>().totalGold += 12000;
    }

}
