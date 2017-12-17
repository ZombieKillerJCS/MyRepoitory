using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Player2Score : MonoBehaviour {

    public static BallScript Instance;
    int player2Goals;
    int totalGoals;
    public static int finalScorePLayer2;
    public Text Player2ScoreShow;
    public int sceneNumber = SceneManager.GetActiveScene().buildIndex;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (player2Goals == totalGoals && sceneNumber != 4)
        {
            player2Goals = 0;
            SceneManager.LoadScene(sceneNumber + 1);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (sceneNumber == 1)
        {
            player2Goals += 1;
            finalScorePLayer2 += 1;
        }
        else if (sceneNumber == 2)
        {
            player2Goals += 2;
            finalScorePLayer2 += 2;
        }
        else if (sceneNumber == 3)
        {
            player2Goals += 3;
            finalScorePLayer2 += 3;
        }

        Player2ScoreShow.text = player2Goals.ToString();

        BallScript ball;
        ball = FindObjectOfType<BallScript>();
        ball.gameStart = false;
    }
}
