using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

    public Vector3 ballSpawn;
    public bool gameStart = false;

	// Use this for initialization
	void Start () {

        ballSpawn = new Vector3(525f, 392f, 0f);
	}
	
	// Update is called once per frame
	void Update () {
        if (!gameStart)
        {
            this.transform.position = ballSpawn;
        }

        if(Input.GetMouseButtonDown(0) && !gameStart)
        {
            gameStart = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(400, Random.Range(-250, 250));
        }


	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 tweak = new Vector2(Random.Range(0f, 0.2f), Random.Range(0f, 0.2f));
        GetComponent<Rigidbody2D>().velocity += tweak;
    }
}
