using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour {

    public float mapSpeed;
    public GameObject[] mapMG;
    public Dictionary<int, string> mapBG;
    void Awake()
    {
        mapBG = new Dictionary<int, string>();
        mapBG.Add(0, "Map1");
        mapBG.Add(1, "Map2");
        mapBG.Add(2, "Map3");
        mapBG.Add(3, "Map4");
        mapBG.Add(4, "Map5");
        mapBG.Add(5, "Map6");
        int m = Random.Range(0, 6);
        mapMG[0].GetComponent<UISprite>().spriteName = mapBG[m];
        mapMG[1].GetComponent<UISprite>().spriteName = mapBG[m];
        mapMG[2].GetComponent<UISprite>().spriteName = mapBG[m];
    }

    void Update ()
    {
        gameObject.transform.Translate(0, -mapSpeed * Time.deltaTime, 0);
        if(gameObject.transform.localPosition.y <= -2500)
        {
            gameObject.transform.localPosition = new Vector3(0, 0, 0);
        }
	}
}
