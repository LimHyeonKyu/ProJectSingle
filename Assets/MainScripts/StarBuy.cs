using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarBuy : MonoBehaviour {

    public GameObject starObj;

    public void OngHun()
    {
        starObj.GetComponent<GoldCount>().starCt += 100;
    }
    public void TwoHun()
    {
        starObj.GetComponent<GoldCount>().starCt += 200;
    }
    public void ThreeHun()
    {
        starObj.GetComponent<GoldCount>().starCt += 300;
    }
    public void FourHun()
    {
        starObj.GetComponent<GoldCount>().starCt += 400;
    }
    public void FIveHun()
    {
        starObj.GetComponent<GoldCount>().starCt += 500;
    }
    public void SixHun()
    {
        starObj.GetComponent<GoldCount>().starCt += 600;
    }

}
