using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseBorderScript : MonoBehaviour {

    LevelManager levelManager;

	// Use this for initialization
	void Start () {

        levelManager = GameObject.FindObjectOfType<LevelManager>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collision");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        print("Trigger");
        levelManager.LoadNewScene("Lose");
    }
}
