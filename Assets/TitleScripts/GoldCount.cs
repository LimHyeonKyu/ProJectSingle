using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldCount : MonoBehaviour {

    public GameObject coinLB;
    public int goldSC;
    public int totalGold;
    void Start ()
    {
        LoadedCOIN();
        goldSC = ScoreManager.instance.coinscore;
        totalGold += goldSC;
        coinLB.GetComponent<UILabel>().text = GetThousandCommaText4(totalGold);
    }
    void Update()
    {
        SaveCOIN();
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
}
