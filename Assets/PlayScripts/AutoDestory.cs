using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestory : MonoBehaviour {

    public float deadTime;

    void Start()
    {
        Destroy(gameObject, deadTime);
    }
}
