using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundBTN : MonoBehaviour {

    public void OnBTN1()
    {
        AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[3]);
        AudioController.iNstance.bgmInt = 1;
    }
    public void OffBTN1()
    {
        AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[3]);
        AudioController.iNstance.bgmInt = 0;
    }
    public void OnBTN2()
    {
        AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[3]);
        AudioController.iNstance.soundInt = 1;
    }
    public void OffBTN2()
    {
        AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[3]);
        AudioController.iNstance.soundInt = 0;
    }
}
