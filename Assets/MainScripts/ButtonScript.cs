using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour {

    public GameObject readyChang;
    public GameObject[] moreChang;
    public void ReadyChang()
    {
        AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[3]);
        readyChang.SetActive(true);
        readyChang.GetComponent<ReadyINS>().ready = true;
    }
    public void CharacterChang()
    {
        AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[3]);
        moreChang[0].SetActive(true);
        moreChang[1].SetActive(false);
        moreChang[2].SetActive(false);
        moreChang[3].SetActive(false);
        moreChang[4].SetActive(false);
        readyChang.SetActive(false);
    }
    public void PetChang()
    {
        AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[3]);
        moreChang[0].SetActive(false);
        moreChang[1].SetActive(true);
        moreChang[2].SetActive(false);
        moreChang[3].SetActive(false);
        moreChang[4].SetActive(false);
        readyChang.SetActive(false);
    }
    public void HelpChang()
    {
        AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[3]);
        moreChang[0].SetActive(false);
        moreChang[1].SetActive(false);
        moreChang[2].SetActive(true);
        moreChang[3].SetActive(false);
        moreChang[4].SetActive(false);
        readyChang.SetActive(false);
    }
    public void OptionChang()
    {
        AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[3]);
        moreChang[0].SetActive(false);
        moreChang[1].SetActive(false);
        moreChang[2].SetActive(false);
        moreChang[3].SetActive(true);
        moreChang[4].SetActive(false);
        readyChang.SetActive(false);
    }
    public void RankChang()
    {
        AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[3]);
        moreChang[0].SetActive(false);
        moreChang[1].SetActive(false);
        moreChang[2].SetActive(false);
        moreChang[3].SetActive(false);
        moreChang[4].SetActive(true);
        readyChang.SetActive(false);
    }
    public void CharacterChangDT()
    {
        AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[3]);
        moreChang[0].SetActive(false);
    }
    public void PetChangDT()
    {
        AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[3]);
        moreChang[1].SetActive(false);
    }
    public void HelpChangDT()
    {
        AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[3]);
        moreChang[2].SetActive(false);
    }
    public void OptionDT()
    {
        AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[3]);
        moreChang[3].SetActive(false);
    }
    public void RankDT()
    {
        AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[3]);
        moreChang[4].SetActive(false);
    }
}
