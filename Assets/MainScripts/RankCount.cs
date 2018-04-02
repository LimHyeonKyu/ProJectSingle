using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RankCount : MonoBehaviour {

    public GameObject rankLB;
    public int rankSC;
    void Start()
    {
        rankSC = ScoreManager.instance.bestScore;
        rankLB.GetComponent<UILabel>().text = GetThousandCommaText3(rankSC)+" 점";
    }
    public string GetThousandCommaText3(int data)
    {
        return string.Format("{0:#,###0}", data);
    }
}
