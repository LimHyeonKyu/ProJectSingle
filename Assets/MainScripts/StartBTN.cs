using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBTN : MonoBehaviour {

    public GameObject wing ;
    public GameObject fill;
    public GameObject wingIcon;
    public float coolTimes;
    public float resPawnTimes;
    public bool startApp = false;
	
    void Start()
    {

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
        if(wingIcon.GetComponent<GoldCount>().wingCt < 0)
        {
            wingIcon.GetComponent<GoldCount>().wingCt = 0;
        }
	}
    public void StartButton()
    {
        AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[2]);
        if (wingIcon.GetComponent<GoldCount>().wingCt > 0)
        {
            startApp = true;
            wingIcon.GetComponent<GoldCount>().wingCt -= 1;
        }
        if(wingIcon.GetComponent<GoldCount>().wingCt < 0)
        {
            startApp = false;
        }
    }
}
