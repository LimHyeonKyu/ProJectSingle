using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerShotScript : MonoBehaviour {

    public GameObject bullet;
    public float coolTime;
    public float respawnTime;
    void Update()
    {
        coolTime += Time.deltaTime;
        if (coolTime > respawnTime)
        {
            coolTime = 0;
            Instantiate(bullet, transform.position, transform.rotation);
            AudioController.iNstance.PlaySFX(AudioController.iNstance.audioClip[6]);
        }
    }
}
