using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntManager : MonoBehaviour {

    private static IntManager _insTance = null;
    public static IntManager insTance
    {
        get
        {
            if (_insTance == null)
            {
                _insTance = FindObjectOfType(typeof(ScoreManager)) as IntManager;
            }
            return _insTance;
        }
    }
    public int character=0;
    public int pet=0;
    void Start ()
    {
        if (_insTance == null)
            _insTance = this;
        else if (_insTance != this)
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
        LoadedInt();
    }

    void Update()
    {
        SaveInt();
        LoadedInt();
    }

    public void SaveInt()
    {
        PlayerPrefs.SetInt("Character", character);
        PlayerPrefs.SetInt("Pet", pet);
    }
    public void LoadedInt()
    {
        character= PlayerPrefs.GetInt("Character", character);
        pet= PlayerPrefs.GetInt("Pet", pet);
    }
}
