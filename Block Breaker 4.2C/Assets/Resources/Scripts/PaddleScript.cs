﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour {


	// Use this for initialization
	void Start () {
        
		
	}
	
	// Update is called once per frame
	void Update () {

        //print(Input.mousePosition.x);

        float mousePosInUnits = (Input.mousePosition.x / Screen.width * 16) - 8;

        Vector3 newPaddlePos = new Vector3(mousePosInUnits, 
                                this.transform.position.y, this.transform.position.z);

        newPaddlePos.x = Mathf.Clamp(mousePosInUnits, -7.5f, 7.5f);


        this.transform.position = newPaddlePos;
		
	}
}
