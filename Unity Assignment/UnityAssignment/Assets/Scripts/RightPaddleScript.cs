using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPaddleScript : MonoBehaviour {


	// Use this for initialization
	void Start () {
        
		
	}
	
	// Update is called once per frame
	void Update () {

        //print(Input.mousePosition.x);

        float mousePosInUnits = (Input.mousePosition.y / Screen.height * 325) - 8;

        Vector3 newPaddlePos = new Vector3(this.transform.position.x, mousePosInUnits, 
                                this.transform.position.z);


        this.transform.position = newPaddlePos;
		
	}
}
