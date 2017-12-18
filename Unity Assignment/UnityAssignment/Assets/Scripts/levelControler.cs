using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelControler : MonoBehaviour {

    public static int leftScore;
    public static int rightScore;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        int totalLeftScore = 0;
        int totalRightScore = 0;

        leftScore = BallScript.leftScore;
        rightScore = BallScript.rightScore;

        if((leftScore == 5 || rightScore == 5) && SceneManager.GetActiveScene().buildIndex == 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if((leftScore == 7 || rightScore == 7) && SceneManager.GetActiveScene().buildIndex == 2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if ((leftScore == 10 || rightScore == 10) && SceneManager.GetActiveScene().buildIndex == 3)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        }
    }
}
