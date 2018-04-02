using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetChoice : MonoBehaviour {

    public GameObject[] flypet;
    public GameObject petChang;

    void Update()
    {
        if(IntManager.insTance.pet==0)
        {
            flypet[0].SetActive(true);
            flypet[1].SetActive(false);
            flypet[2].SetActive(false);
            flypet[3].SetActive(false);
            flypet[4].SetActive(false);
            flypet[5].SetActive(false);
        }
        if (IntManager.insTance.pet == 1)
        {
            flypet[0].SetActive(false);
            flypet[1].SetActive(true);
            flypet[2].SetActive(false);
            flypet[3].SetActive(false);
            flypet[4].SetActive(false);
            flypet[5].SetActive(false);
        }
        if (IntManager.insTance.pet == 2)
        {
            flypet[0].SetActive(false);
            flypet[1].SetActive(false);
            flypet[2].SetActive(true);
            flypet[3].SetActive(false);
            flypet[4].SetActive(false);
            flypet[5].SetActive(false);
        }
        if (IntManager.insTance.pet == 3)
        {
            flypet[0].SetActive(false);
            flypet[1].SetActive(false);
            flypet[2].SetActive(false);
            flypet[3].SetActive(true);
            flypet[4].SetActive(false);
            flypet[5].SetActive(false);
        }
        if (IntManager.insTance.pet == 4)
        {
            flypet[0].SetActive(true);
            flypet[1].SetActive(false);
            flypet[2].SetActive(false);
            flypet[3].SetActive(false);
            flypet[4].SetActive(true);
            flypet[5].SetActive(false);
        }
        if (IntManager.insTance.pet == 5)
        {
            flypet[0].SetActive(false);
            flypet[1].SetActive(false);
            flypet[2].SetActive(false);
            flypet[3].SetActive(false);
            flypet[4].SetActive(false);
            flypet[5].SetActive(true);
        }
    }

    public void PetOne()
    {
        AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[3]);
        IntManager.insTance.pet = 0;
        petChang.SetActive(false);
    }
    public void PetTwo()
    {
        AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[3]);
        IntManager.insTance.pet = 1;
        petChang.SetActive(false);
    }
    public void PetThree()
    {
        AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[3]);
        IntManager.insTance.pet = 2;
        petChang.SetActive(false);
    }
    public void PetFour()
    {
        AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[3]);
        IntManager.insTance.pet = 3;
        petChang.SetActive(false);
    }
    public void PetFive()
    {
        AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[3]);
        IntManager.insTance.pet = 4;
        petChang.SetActive(false);
    }
    public void PetSix()
    {
        AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[3]);
        IntManager.insTance.pet = 5;
        petChang.SetActive(false);
    }
}
