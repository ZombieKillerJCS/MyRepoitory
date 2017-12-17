using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddlePlayer2 : MonoBehaviour {
	// Use this for initialization 
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float mousePosInUnits = (Input.mousePosition.y / Screen.width * 750) + 100;

        Vector3 mouseMovement = new Vector3(this.transform.position.x, 
                                             mousePosInUnits, 
                                             this.transform.position.z);

        //Stop paddle from going out side map
        mouseMovement.y = Mathf.Clamp(mousePosInUnits, -650f, 650f);


        this.transform.position = mouseMovement;

    }
}
