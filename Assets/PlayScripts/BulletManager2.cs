using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager2 : MonoBehaviour {

    public GameObject[] bullets;
    public float coolTime;
    public float respawnTime;
    public int v;

    void Start()
    {
        v = IntManager.insTance.character;
    }
    void Update()
    {
        coolTime += Time.deltaTime;
        if (coolTime > respawnTime)
        {
            coolTime = 0;
            Instantiate(bullets[v], transform.position, transform.rotation);
        }
    }
}
