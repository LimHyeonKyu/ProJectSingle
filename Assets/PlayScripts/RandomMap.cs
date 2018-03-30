using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomMap : MonoBehaviour {

    public Dictionary<int,string> mapBG;

    void Start ()
    {
        mapBG = new Dictionary<int,string>();
        mapBG.Add(0, "Map1");
        mapBG.Add(1, "Map2");
        mapBG.Add(2, "Map3");
        mapBG.Add(3, "Map4");
        mapBG.Add(4, "Map5");
        mapBG.Add(5, "Map6");
        mapBG.Add(6, "Map7");
        //gameObject.GetComponent<UISprite>().spriteName = "Map1"
        int m = Random.Range(0, 7);
        gameObject.GetComponent<UISprite>().spriteName = mapBG[m];
    }
	
}
