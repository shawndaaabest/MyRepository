using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPaddleScript : MonoBehaviour {

    float speed = 260f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 v3 = transform.position;

        if (Input.GetKey(KeyCode.W))
        {
            v3.y += speed * Time.deltaTime;
            transform.position = v3;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            v3.y -= speed * Time.deltaTime;
            transform.position = v3;
        }
        
    }
}
