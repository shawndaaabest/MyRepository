using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayerScript : MonoBehaviour {

    static MusicPlayerScript instance = null;

    void Awake()
    {
        print("Player Awake");
        if (instance != null)
        {
            print("Duplicate Music Player Self Destructing!");
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }


    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        DontDestroyOnLoad(gameObject);
	}
}
