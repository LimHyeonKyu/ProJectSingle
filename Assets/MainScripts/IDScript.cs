using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDScript : MonoBehaviour {

    public GameObject idLabel;

    void Update ()
    {
		if (IntManager.insTance.character==0)
        {
            idLabel.GetComponent<UILabel>().text = "진돌이";
        }
        if (IntManager.insTance.character == 1)
        {
            idLabel.GetComponent<UILabel>().text = "데이라";
        }
        if (IntManager.insTance.character == 2)
        {
            idLabel.GetComponent<UILabel>().text = "브레넘";
        }
        if (IntManager.insTance.character == 3)
        {
            idLabel.GetComponent<UILabel>().text = "뉴비스";
        }
        if (IntManager.insTance.character == 4)
        {
            idLabel.GetComponent<UILabel>().text = "아더스";
        }
        if (IntManager.insTance.character == 5)
        {
            idLabel.GetComponent<UILabel>().text = "하사기";
        }
        if (IntManager.insTance.character == 6)
        {
            idLabel.GetComponent<UILabel>().text = "벨제브";
        }
    }
}
