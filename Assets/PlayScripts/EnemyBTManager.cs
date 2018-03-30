using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBTManager : MonoBehaviour
{

    public GameObject enemyBT;
    public float coolT;
    public float respawnT;
    public bool bulletShot = false;
    public GameObject enemyGB;
    void Update()
    {
        if (enemyGB.transform.position.y <= 0.8f)
        {
            bulletShot = true;
        }
        if (bulletShot == true)
        {
            coolT += Time.deltaTime;
            if (coolT >= respawnT)
            {
                coolT = 0;
                Instantiate(enemyBT, transform.position, enemyBT.transform.rotation);
            }
        }
    }
}
