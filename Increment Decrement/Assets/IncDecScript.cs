using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class IncDecScript : MonoBehaviour
{

    int num = 50;

    // Use this for initialization
    void Start()
    {
        print("Press up arrow to increment and down arrow to decrement");
        print(num);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("up"))
        {
            num++;
            print(num);
        }
        else if (Input.GetKeyDown("down"))
        {
            num--;
            print(num);
        }
        else if (Input.GetKeyDown("return"))
        {
            EditorApplication.isPlaying = false;
        }
    }
}