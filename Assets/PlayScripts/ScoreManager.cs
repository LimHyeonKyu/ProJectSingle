using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    private static ScoreManager _instance = null;
    public static ScoreManager instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType(typeof(ScoreManager)) as ScoreManager;
            }
            return _instance;
        }
    }
    public int bestScore = 0;
    public int _myScore = 0;
    public UILabel mySC;
    public UILabel _coinScore;
    public int coinSC = 0;
    public UILabel _distanceScore;
    public int disTanceSC;
    public float scoreTM;
    public int totalScore = 0;
    public bool disScore = true;
    //public int bestScore
    //{
    //    get
    //    {
    //        return _bestScore;
    //    }
    //}
    //public int _myScore
    //{
    //    get
    //    {
    //        return myScore;
    //    }
    //    set
    //    {
    //        myScore = value;
    //        if(myScore>_bestScore)
    //        {
    //            _bestScore = myScore;
    //            SaveBestScore();
    //        }
    //    }
    //}
    public GameObject mainPlayer;

	void Start ()
    {
        mainPlayer = GameObject.Find("Player1");
        LoadedBestScore();
    }
	
	
	void Update ()
    {
        if(disScore==true)
        {
            scoreTM += Time.deltaTime;
            if (scoreTM >= 0.01f)
            {
                scoreTM = 0;
                disTanceSC += 1;
                _distanceScore.GetComponent<UILabel>().text = GetThousandCommaText(disTanceSC);
            }
        }
        MainScore();
        CoinScore();
        totalScore = _myScore + disTanceSC;
        if(totalScore>bestScore)
        {
            bestScore = totalScore;
            SaveBestScore();
        }
        if(totalScore<bestScore)
        {
            bestScore = bestScore;
        }
        if(mainPlayer.GetComponent<PlayerScript>().playerHP<=0)
        {
            disScore = false;
        }
    }
    
    public void MainScore()
    {
        mySC.GetComponent<UILabel>().text = GetThousandCommaText2(_myScore);
    }
    public void CoinScore()
    {
        _coinScore.GetComponent<UILabel>().text = coinSC.ToString();
        SaveCoin();
    }
    public  void SaveCoin()
    {
        PlayerPrefs.SetInt("CoinCount", coinSC);
    }
    public void LoadedCoin()
    {
        coinSC = PlayerPrefs.GetInt("CoinCount", coinSC);
    }
    public void SaveBestScore()
    {
        PlayerPrefs.SetInt("TotalScore", bestScore);
    }
    public void LoadedBestScore()
    {
        bestScore = PlayerPrefs.GetInt("TotalScore", bestScore);
    }
    public string GetThousandCommaText(int data)
    {
        return string.Format("{0:#,###0}", data);
    }
    public string GetThousandCommaText2(int data)
    {
        //if (data == 0)
        //{
        //    return "0";
        //}
        //else
        //{
        //    return string.Format("{0:#,###}", data);
        //}
        return string.Format("{0:#,###0}", data);
    }
}
