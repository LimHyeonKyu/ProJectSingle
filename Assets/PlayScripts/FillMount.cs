using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillMount : MonoBehaviour {

    public float coolTIME;
    public float resPawnTIME;
    public GameObject[] gameOver;
    public bool overFill = false;

    void Start ()
    {
		
	}
	
	
	void Update ()
    {
		if(overFill==true)
        {
            gameOver[0].SetActive(true);
            coolTIME += Time.deltaTime;
            if(coolTIME>resPawnTIME)
            {
                coolTIME = 0;
                gameOver[0].GetComponent<UISprite>().fillAmount += 0.02f;
            }
        }
        if(gameOver[0].GetComponent<UISprite>().fillAmount>=1)
        {
            overFill = false;
            gameOver[0].SetActive(false);
            gameOver[1].SetActive(true);
        }
	}
}
