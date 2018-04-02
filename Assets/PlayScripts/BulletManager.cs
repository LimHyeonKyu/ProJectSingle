using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour {

    public GameObject[] bullet;
    public float coolTime;
    public float respawnTime;
    public int t;
    
    void Start()
    {
        t = IntManager.insTance.character;
    }
	void Update ()
    {
        coolTime += Time.deltaTime;
        if(coolTime>respawnTime)
        {
            coolTime = 0;
            Instantiate(bullet[t], transform.position, transform.rotation);
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[6]);
        }	
	}
}
