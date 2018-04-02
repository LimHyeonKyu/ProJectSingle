using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldCount : MonoBehaviour {

    public GameObject coinLB;
    public GameObject starLB;
    public GameObject wingLB;
    public int goldSC;
    public int totalGold;
    public int starCt;
    public int wingCt;
    void Start ()
    {
        LoadedCOIN();
        LoadedStar();
        LoadedWing();
        goldSC = ScoreManager.instance.coinscore;
        totalGold += goldSC;
        if(wingCt<=0)
        {
            wingCt += 5;
        }
    }
    void Update()
    {
        coinLB.GetComponent<UILabel>().text = GetThousandCommaText4(totalGold);
        starLB.GetComponent<UILabel>().text = starCt.ToString();
        wingLB.GetComponentInChildren<UILabel>().text = wingCt.ToString();
        SaveCOIN();
        SaveStar();
        SaveWing();
    }

    public string GetThousandCommaText4(int data)
    {
        return string.Format("{0:#,###0}", data);
    }

    public void SaveCOIN()
    {
        PlayerPrefs.SetInt("CoinScore", totalGold);
    }
    public void LoadedCOIN()
    {
        totalGold = PlayerPrefs.GetInt("CoinScore", totalGold);
    }

    public void SaveStar()
    {
        PlayerPrefs.SetInt("Star", starCt);
    }
    public void LoadedStar()
    {
        starCt = PlayerPrefs.GetInt("Star", starCt);
    }
    public void SaveWing()
    {
        PlayerPrefs.SetInt("Wing", wingCt);
    }
    public void LoadedWing()
    {
        wingCt = PlayerPrefs.GetInt("Wing", wingCt);
    }
}
