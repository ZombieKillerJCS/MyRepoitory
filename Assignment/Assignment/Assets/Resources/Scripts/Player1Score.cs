using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player1Score : MonoBehaviour {

    public static BallScript Instance;
    int player1Goals;
    int totalGoals;
    public static int finalScorePLayer1;
    public Text Player1ScoreShow;
    public int sceneNumber = SceneManager.GetActiveScene().buildIndex;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (player1Goals == totalGoals && sceneNumber != 4)
        {
            player1Goals = 0;
            SceneManager.LoadScene(sceneNumber + 1);
        }
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (sceneNumber == 1)
        {
            player1Goals += 1;
            finalScorePLayer1 += 1;
        }
        else if (sceneNumber == 2)
        {
            player1Goals += 2;
            finalScorePLayer1 += 2;
        }
        else if (sceneNumber == 3)
        {
            player1Goals += 3;
            finalScorePLayer1 += 3;
        }

        Player1ScoreShow.text = player1Goals.ToString();

        BallScript ball;
        ball = FindObjectOfType<BallScript>();
        ball.gameStart = false;
    }

    private void LevelLoaded(int sceneNumber)
    {
        if(sceneNumber == 1)
        {
            finalScorePLayer1 = 0;
            totalGoals = 5;
        }
        if(sceneNumber == 2)
        {
            totalGoals = 10;
        }
        if(sceneNumber == 3)
        {
            totalGoals = 15;
        }
    }
}
