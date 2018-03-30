using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBTN : MonoBehaviour {

    public GameObject wing ;
    public GameObject fill;
    public int wingCT = 0;
    public float coolTimes;
    public float resPawnTimes;
    public bool startApp = false;
	
    void Start()
    {
        LoadedWing();
        if(wingCT<=0)
        {
            wingCT = 10;
        }
    }
	void Update ()
    {
		if(startApp==true)
        {
            coolTimes += Time.deltaTime;
            if(coolTimes>resPawnTimes)
            {
                coolTimes = 0;
                fill.GetComponent<UISprite>().fillAmount += 0.02f;
            }
            if(fill.GetComponent<UISprite>().fillAmount >= 1)
            {
                startApp = false;
                Application.LoadLevel(2);
            }
        }
        if(wingCT<0)
        {
            wingCT = 0;
        }
        wing.GetComponent<UILabel>().text = wingCT.ToString();
        SaveWing();
	}
    public void StartButton()
    {
        if(wingCT>0)
        {
            startApp = true;
            wingCT -= 1;
        }
        if(wingCT<0)
        {
            startApp = false;
        }
    }
    void SaveWing()
    {
        PlayerPrefs.SetInt("wing", wingCT);
    }
    void LoadedWing()
    {
        wingCT = PlayerPrefs.GetInt("wing", wingCT);
    }
}
