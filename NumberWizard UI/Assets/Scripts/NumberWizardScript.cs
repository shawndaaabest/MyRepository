using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NumberWizardScript : MonoBehaviour
{
    public Text CompGuess;
    public int count;

    int min = 1;
    int max = 1000;
    int guess;

    bool restart = false;

    // Use this for initialization
    void Start()
    {
        NextGuess();
    }

    void NextGuess()
    {
        // guess = (min + max) / 2;
        System.Random rand = new System.Random();
        guess = rand.Next(min, (max + 1));
        CompGuess.text = guess + "?";
    }

    void Restart()
    {
        min = 1;
        max = 1000;
        NextGuess();
        restart = false;
    }
    public void GuessHigher() {
        min = guess;
        NextGuess();
        count++;
    }

    public void GuessCorrect()
    {
        SceneManager.LoadScene("Lose");
    }

    public void GuessLower()
    {
        max = guess;
        NextGuess();
        count++;
    }

    // Update is called once per frame
    void Update()
    {
        if (restart == false)
        {
            if (Input.GetKeyDown("up"))
            {
                min = guess + 1;
                NextGuess();
            }
            else if (Input.GetKeyDown("down"))
            {
                max = guess + 1;
                NextGuess();
            }
            else if (Input.GetKeyDown("return"))
            {
                restart = true;
            }
        }
        else
        {
            Restart();
        }

        if(count == 6)
        {
            SceneManager.LoadScene("Win");
        }
    }
}