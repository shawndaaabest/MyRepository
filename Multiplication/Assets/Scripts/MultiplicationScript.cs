using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultiplicationScript : MonoBehaviour
{

    public Text myText;
    public InputField input;
    public Button button;

    int randomInt1;
    int randomInt2;

    // Use this for initialization
    void Start()
    {
        randomInt1 = Random.Range(1, 11);
        randomInt2 = Random.Range(1, 11);
        int ans = randomInt1 * randomInt2;

        myText.text = "What is " + randomInt1 + " x " + randomInt2 + ":";
        input.text = "Input text here: ";
    }

    // Update is called once per frame
    void Update()
    {
        button.onClick.AddListener(buttonMethod);
    }
    void buttonMethod()
    {
        int num = int.Parse(input.text);
        int ans = randomInt1 * randomInt2;
        if (num == ans)
        {
            myText.text = "Correct!";
        }
        else
        {
            myText.text = "Incorrect!";
        }
    }
}
