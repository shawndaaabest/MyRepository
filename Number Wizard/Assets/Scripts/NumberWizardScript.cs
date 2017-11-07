using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizardScript : MonoBehaviour
{

    int min = 1;
    int max = 1000;
    int guess;

    bool restart = false;

    void Welcome()
    {
        print("");
        print("Welcome to NumberWizard");
        print("Pick a number between 1 and 1000");
        print("Higher: UP, Lower: Down, Equal: Enter");
    }


    // Use this for initialization
    void Start()
    {
        Welcome();
        NextGuess();
    }

    void NextGuess()
    {
        // guess = (min + max) / 2;
        System.Random rand = new System.Random();
        guess = rand.Next(min, (max+1));
        print("Is the number higher, lower or equal to " + guess + " ?");
    }

    void Restart()
    {
        min = 1;
        max = 1000;
        Welcome();
        NextGuess();
        restart = false;
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
                print("your number is " + guess + "! I won ;)");
                restart = true;
            }
        }
        else
        {
            Restart();
        }
    }
}