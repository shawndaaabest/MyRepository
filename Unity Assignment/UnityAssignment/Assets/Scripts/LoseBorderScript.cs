using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseBorderScript : MonoBehaviour {

    LevelManager levelManager;
    int score = 0;

	// Use this for initialization
	void Start () {

        levelManager = GameObject.FindObjectOfType<LevelManager>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(score != 5)
        {
            score++;
            
        }
        else
        {
            levelManager.loadNextScene();
        }
    }
}
