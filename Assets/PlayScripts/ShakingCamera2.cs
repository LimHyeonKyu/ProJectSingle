using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakingCamera2 : MonoBehaviour {

    public GameObject shakingCM;
    public bool shaKing = false;
    public float coolTM;

    void Update()
    {
        coolTM -= Time.deltaTime;
        if (coolTM < 0)
        {
            coolTM = 0;
            shaKing = false;
        }
        else
        {
            shaKing = true;
        }
        if (shaKing == true)
        {
            ShakeCamera();
        }
        else
        {
            FixedCamera();
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            coolTM += 0.3f;
        }
        if (col.gameObject.tag == "Enemy2")
        {
            coolTM += 0.3f;
        }
        if (col.gameObject.tag == "Enemy3")
        {
            coolTM += 0.3f;
        }
        if (col.gameObject.tag == "Enemy4")
        {
            coolTM += 0.3f;
        }
        if (col.gameObject.tag == "Enemy5")
        {
            coolTM += 0.3f;
        }
    }
    void ShakeCamera()
    {
        shakingCM.transform.localPosition = new Vector3(Random.Range(0, 15f), Random.Range(-0.75f, 15f), -0.1f);
    }
    void FixedCamera()
    {
        shakingCM.transform.localPosition = new Vector3(0, -0.75f, -0.1f);
    }
}
