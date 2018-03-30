using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour {

    public GameObject[] overchang;
    
    void Start()
    {
        overchang[0].GetComponent<UILabel>().text = ScoreManager.instance.totalScore.ToString();
        overchang[1].GetComponent<UILabel>().text = ScoreManager.instance.disTanceSC.ToString();
        overchang[2].GetComponent<UILabel>().text = ScoreManager.instance._myScore.ToString();
        overchang[3].GetComponent<UILabel>().text = ScoreManager.instance.coinSC.ToString();
        overchang[4].GetComponent<UILabel>().text = ScoreManager.instance.bestScore.ToString();
    }
     public void MainScence()
    {
        gameObject.SetActive(false);
        Application.LoadLevel(1);
        Time.timeScale = 1;
    }
}
