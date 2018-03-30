using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    public GameObject mySC;
    public GameObject _coinScore;
    public int coinSC = 0;
    public int coinscore;
    public GameObject _distanceScore;
    public int disTanceSC;
    public float scoreTM;
    public int totalScore = 0;
    public bool disScore = false;

	void Start ()
    {
        if (_instance == null)
            _instance = this;
        else if (_instance != this)
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }
	
	
	void Update ()
    {
        if(Application.loadedLevel==1)
        {
            _myScore = 0;
            totalScore = 0;
            disTanceSC = 0;
            coinSC = 0;
            LoadedBestScore();
        }
        if (Application.loadedLevel==2)
        {
            LoadedBestScore();
            mySC = GameObject.Find("MainScore");
            _coinScore = GameObject.Find("CoinScore");
            _distanceScore = GameObject.Find("DistanceScore");
            if (disScore == true)
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
            if (totalScore > bestScore)
            {
                bestScore = totalScore;
                SaveBestScore();
            }
            if (totalScore < bestScore)
            {
                bestScore = bestScore;
            }
            coinscore = coinSC;
        }
    }
    
    public void MainScore()
    {
        mySC.GetComponent<UILabel>().text = GetThousandCommaText2(_myScore);
    }
    public void CoinScore()
    {
        _coinScore.GetComponent<UILabel>().text = coinSC.ToString();
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
