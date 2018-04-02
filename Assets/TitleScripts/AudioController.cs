using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour {

    private static AudioController _iNstance = null;
    public static AudioController iNstance
    {
        get
        {
            if (_iNstance == null)
            {
                _iNstance = FindObjectOfType(typeof(AudioController)) as AudioController;
            }
            return _iNstance;
        }
    }
    public AudioClip[] audioClip = null;
    public int bgmInt;
    public int soundInt;
    void Start ()
    {
        if (_iNstance == null)
            _iNstance = this;
        else if (_iNstance != this)
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
        LoadedMute();
    }

    void Update()
    {
        SaveMute();
        //LoadedMute();
        if(soundInt==1)
        {
            GetComponent<AudioSource>().enabled = false;
        }
        if (soundInt == 0)
        {
            GetComponent<AudioSource>().enabled = true;
        }
    }

    public void PlaySFX(AudioClip clip)
    {
        GetComponent<AudioSource>().PlayOneShot(clip);
    }
    public void SaveMute()
    {
        PlayerPrefs.SetInt("Mute", bgmInt);
        PlayerPrefs.SetInt("MuTe", soundInt);
    }
    public void LoadedMute()
    {
        bgmInt = PlayerPrefs.GetInt("Mute", bgmInt);
        soundInt= PlayerPrefs.GetInt("MuTe", soundInt);
    }
}
