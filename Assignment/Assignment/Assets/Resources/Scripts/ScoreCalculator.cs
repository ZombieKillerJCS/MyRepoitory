using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCalculator : MonoBehaviour {

    public Text FinalScorePlayer1;
    int Player1show;
    public Text FinalScorePlayer2;
    int Player2show;

    public Text Winner;

// Use this for initialization
    void Start () {
        Player1show = Player1Score.finalScorePLayer1;
        FinalScorePlayer1.text = "Player 1 Score: " + Player1show;

        Player2show = Player2Score.finalScorePLayer2;
        FinalScorePlayer2.text = "Player 2 Score: " + Player2show;

        if(Player2show > Player1show)
        {
            Winner.text = "Winner is: PLayer 1";
        }
        else if (Player1show > Player2show)
        {
            Winner.text = "Winner is: PLayer 2";
        }



    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
