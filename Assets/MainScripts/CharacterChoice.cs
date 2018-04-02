using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterChoice : MonoBehaviour {

    public GameObject[] characterObj;
    public GameObject chChang;
    void Update()
    {
        if(IntManager.insTance.character ==0)
        {
            characterObj[0].SetActive(true);
            characterObj[1].SetActive(false);
            characterObj[2].SetActive(false);
            characterObj[3].SetActive(false);
            characterObj[4].SetActive(false);
            characterObj[5].SetActive(false);
            characterObj[6].SetActive(false);
        }
        if (IntManager.insTance.character == 1)
        {
            characterObj[0].SetActive(false);
            characterObj[1].SetActive(true);
            characterObj[2].SetActive(false);
            characterObj[3].SetActive(false);
            characterObj[4].SetActive(false);
            characterObj[5].SetActive(false);
            characterObj[6].SetActive(false);
        }
        if (IntManager.insTance.character == 2)
        {
            characterObj[0].SetActive(false);
            characterObj[1].SetActive(false);
            characterObj[2].SetActive(true);
            characterObj[3].SetActive(false);
            characterObj[4].SetActive(false);
            characterObj[5].SetActive(false);
            characterObj[6].SetActive(false);
        }
        if (IntManager.insTance.character == 3)
        {
            characterObj[0].SetActive(false);
            characterObj[1].SetActive(false);
            characterObj[2].SetActive(false);
            characterObj[3].SetActive(true);
            characterObj[4].SetActive(false);
            characterObj[5].SetActive(false);
            characterObj[6].SetActive(false);
        }
        if (IntManager.insTance.character == 4)
        {
            characterObj[0].SetActive(false);
            characterObj[1].SetActive(false);
            characterObj[2].SetActive(false);
            characterObj[3].SetActive(false);
            characterObj[4].SetActive(true);
            characterObj[5].SetActive(false);
            characterObj[6].SetActive(false);
        }
        if (IntManager.insTance.character == 5)
        {
            characterObj[0].SetActive(false);
            characterObj[1].SetActive(false);
            characterObj[2].SetActive(false);
            characterObj[3].SetActive(false);
            characterObj[4].SetActive(false);
            characterObj[5].SetActive(true);
            characterObj[6].SetActive(false);
        }
        if (IntManager.insTance.character == 6)
        {
            characterObj[0].SetActive(false);
            characterObj[1].SetActive(false);
            characterObj[2].SetActive(false);
            characterObj[3].SetActive(false);
            characterObj[4].SetActive(false);
            characterObj[5].SetActive(false);
            characterObj[6].SetActive(true);
        }
    }
	public void CharacterOne()
    {
        AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[3]);
        IntManager.insTance.character = 0;
        chChang.SetActive(false);

    }
    public void CharacterTwo()
    {
        AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[3]);
        IntManager.insTance.character = 1;
        chChang.SetActive(false);
    }
    public void CharacterThree()
    {
        AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[3]);
        IntManager.insTance.character = 2;
        chChang.SetActive(false);
    }
    public void CharacterFour()
    {
        AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[3]);
        IntManager.insTance.character = 3;
        chChang.SetActive(false);
    }
    public void CharacterFive()
    {
        AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[3]);
        IntManager.insTance.character = 4;
        chChang.SetActive(false);
    }
    public void CharacterSix()
    {
        AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[3]);
        IntManager.insTance.character = 5;
        chChang.SetActive(false);
    }
    public void CharacterSeven()
    {
        AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[3]);
        IntManager.insTance.character = 6;
        chChang.SetActive(false);
    }
}
