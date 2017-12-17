using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddlePlayer1 : MonoBehaviour {

    public int velocity = 250;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 keyboardMovement = transform.position;
            keyboardMovement.y = keyboardMovement.y + (velocity * Time.deltaTime);

            //Stop paddle from going out side map
            keyboardMovement.y = Mathf.Clamp(keyboardMovement.y, -100f, 650f);
            this.transform.position = keyboardMovement;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 keyboardMovement = transform.position;
            keyboardMovement.y = keyboardMovement.y - (velocity * Time.deltaTime);

            //Stop paddle from going out side map but it doesnt work i dont know why
            keyboardMovement.y = Mathf.Clamp(keyboardMovement.y, -100f, 650f);
            this.transform.position = keyboardMovement;
        }

    }
}
