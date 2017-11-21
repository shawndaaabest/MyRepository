using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]
public class Brick : MonoBehaviour {

    public static int breakableCount = 0;

    public int maxHits;
    AudioClip crack;

    int timesHit;

    LevelManager levelManager = new LevelManager();

	// Use this for initialization
	void Start () {

        breakableCount++;

        crack = Resources.Load("Sounds/crack", typeof(AudioClip)) as AudioClip;
        timesHit = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void testWin()
    {
        levelManager.loadNextScene();
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        timesHit++;
        print(gameObject.name + " : " + timesHit);

        if (timesHit >= maxHits)
        {
            //testWin();
            AudioSource.PlayClipAtPoint(crack, this.transform.position);
            Destroy(gameObject);
        }
    }
}
