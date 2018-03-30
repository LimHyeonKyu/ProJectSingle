using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour {

    public GameObject readyChang;

    public void ReadyChang()
    {
        readyChang.SetActive(true);
        readyChang.GetComponent<ReadyINS>().ready = true;
    }
}
