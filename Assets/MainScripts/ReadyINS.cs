using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadyINS : MonoBehaviour {

    public float coolTime;
    public float resPawnTime;
    public bool ready = false;
    void Update()
    {
        if(ready==true)
        {
            coolTime += Time.deltaTime;
            if (coolTime > resPawnTime)
            {
                coolTime = 0;
                gameObject.SetActive(false);
                ready = false;
            }
        }
    }
    
	
}
