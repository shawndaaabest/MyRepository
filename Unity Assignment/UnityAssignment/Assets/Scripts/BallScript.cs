using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallScript : MonoBehaviour {

    public static int leftScore = 0;
    public static int rightScore = 0;

    public static int totalLeftScore = 0;
    public static int totalRightScore = 0;

    public Text finalText1;
    public Text finalText2;

    public Text text1;
    public Text text2;

    // Use this for initialization
    void Start () {
	}

	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(300f, -40f);
        }


        text1.text = "" + leftScore;
        text2.text = "" + rightScore;


        if ((leftScore == 5 || rightScore == 5) && SceneManager.GetActiveScene().buildIndex == 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

            totalLeftScore = leftScore;
            leftScore = 0;

            totalRightScore = rightScore;
            rightScore = 0;
        }
        else if ((leftScore == 8 || rightScore == 8) && SceneManager.GetActiveScene().buildIndex == 2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

            totalLeftScore = leftScore;
            leftScore = 0;

            totalRightScore = rightScore;
            rightScore = 0;
        }
        else if ((leftScore == 12 || rightScore == 12) && SceneManager.GetActiveScene().buildIndex == 3)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

            totalLeftScore = leftScore;
            leftScore = 0;

            totalRightScore = rightScore;
            rightScore = 0;
        }

        finalText1.text = "Final P1: " + totalLeftScore;
        finalText2.text = "Final P2: " + totalRightScore;
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if (gameStart && (colName == "Paddle" || colName == "Left Bprder" || colName == "Right Border"))
        if (collision.collider.tag == "left" || collision.collider.tag == "right")
        {
            this.transform.position = new Vector3(393, 158, -3);
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
        }

        if(collision.collider.tag == "left")
        {
            if(SceneManager.GetActiveScene().buildIndex == 1)
            {
                leftScore++;
            }

            else if(SceneManager.GetActiveScene().buildIndex == 2)
            {
                leftScore += 2;
            }

            else
            {
                leftScore += 3;
            }

        }
        else if(collision.collider.tag == "right")
        {
            if (SceneManager.GetActiveScene().buildIndex == 1)
            {
                rightScore++;
            }

            else if (SceneManager.GetActiveScene().buildIndex == 2)
            {
                rightScore += 2;
            }

            else
            {
                rightScore += 3;
            }
        }
        

    }
}