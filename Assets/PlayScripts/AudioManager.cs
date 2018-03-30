using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {


    private static AudioManager _insTance = null;
    public static AudioManager insTance()
    {
        return _insTance;
    }
    public AudioClip music = null;

    void Start ()
    {
        if (_insTance == null)
            _insTance = this;
        if(music !=null)
        {
            GetComponent<AudioSource>().clip = music;
            GetComponent<AudioSource>().loop = true;
            GetComponent<AudioSource>().Play();
        }
	}
	public void PlaySFX(AudioClip clip)
    {
        GetComponent<AudioSource>().PlayOneShot(clip);
    }
}
