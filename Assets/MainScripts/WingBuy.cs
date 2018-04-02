using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WingBuy : MonoBehaviour {

    public GameObject wingObj;

    public void OneWing()
    {
        wingObj.GetComponent<GoldCount>().wingCt += 1;
    }
    public void ThreeWing()
    {
        wingObj.GetComponent<GoldCount>().wingCt += 3;
    }
    public void FiveWing()
    {
        wingObj.GetComponent<GoldCount>().wingCt += 5;
    }
    public void EightWing()
    {
        wingObj.GetComponent<GoldCount>().wingCt += 8;
    }
    public void TenWing()
    {
        wingObj.GetComponent<GoldCount>().wingCt += 10;
    }
    public void FiveteenWing()
    {
        wingObj.GetComponent<GoldCount>().wingCt += 15;
    }
}
