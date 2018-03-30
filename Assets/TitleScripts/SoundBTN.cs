using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundBTN : MonoBehaviour {

    public GameObject[] soundchang;
    public void OnBTN1()
    {
        soundchang[0].SetActive(false);
        soundchang[1].SetActive(true);
    }
    public void OffBTN1()
    {
        soundchang[0].SetActive(true);
        soundchang[1].SetActive(false);
    }
    public void OnBTN2()
    {
        soundchang[2].SetActive(false);
        soundchang[3].SetActive(true);
    }
    public void OffBTN2()
    {
        soundchang[2].SetActive(true);
        soundchang[3].SetActive(false);
    }
}
