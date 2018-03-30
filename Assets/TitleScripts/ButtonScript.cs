using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour {

    public GameObject readyChang;
    public GameObject[] moreChang;
    public void ReadyChang()
    {
        readyChang.SetActive(true);
        readyChang.GetComponent<ReadyINS>().ready = true;
    }
    public void CharacterChang()
    {
        moreChang[0].SetActive(true);
        moreChang[1].SetActive(false);
        moreChang[2].SetActive(false);
        moreChang[3].SetActive(false);
        moreChang[4].SetActive(false);
        moreChang[5].SetActive(false);
    }
    public void PetChang()
    {
        moreChang[0].SetActive(false);
        moreChang[1].SetActive(true);
        moreChang[2].SetActive(false);
        moreChang[3].SetActive(false);
        moreChang[4].SetActive(false);
        moreChang[5].SetActive(false);
    }
    public void HelpChang()
    {
        moreChang[0].SetActive(false);
        moreChang[1].SetActive(false);
        moreChang[2].SetActive(true);
        moreChang[3].SetActive(false);
        moreChang[4].SetActive(false);
        moreChang[5].SetActive(false);
    }
    public void OptionChang()
    {
        moreChang[0].SetActive(false);
        moreChang[1].SetActive(false);
        moreChang[2].SetActive(false);
        moreChang[3].SetActive(true);
        moreChang[4].SetActive(false);
        moreChang[5].SetActive(false);
    }
    public void RankChang()
    {
        moreChang[0].SetActive(false);
        moreChang[1].SetActive(false);
        moreChang[2].SetActive(false);
        moreChang[3].SetActive(false);
        moreChang[4].SetActive(true);
        moreChang[5].SetActive(false);
    }
    public void ShopChang()
    {
        moreChang[0].SetActive(false);
        moreChang[1].SetActive(false);
        moreChang[2].SetActive(false);
        moreChang[3].SetActive(false);
        moreChang[4].SetActive(false);
        moreChang[5].SetActive(true);
    }
    public void CharacterChangDT()
    {
        moreChang[0].SetActive(false);
    }
    public void PetChangDT()
    {
        moreChang[1].SetActive(false);
    }
    public void HelpChangDT()
    {
        moreChang[2].SetActive(false);
    }
    public void OptionDT()
    {
        moreChang[3].SetActive(false);
    }
    public void RankDT()
    {
        moreChang[4].SetActive(false);
    }
    public void ShopDT()
    {
        moreChang[5].SetActive(false);
    }
}
