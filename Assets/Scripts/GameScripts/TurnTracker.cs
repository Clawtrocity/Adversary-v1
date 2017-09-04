using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnTracker : MonoBehaviour {

    public Text turnCounter;
    public int turnNumber;
    public int playerLocked;
    public int enemyLocked;
    float timer = 60.0F;
    public Text Timer;

	// Use this for initialization
	void Start ()
    {
        turnNumber = 1;
        LabelControlGame.label.playerGoldTracker = 1;
        LabelControlGame.label.enemyGoldTracker = 1;
        LabelControlGame.label.playerPointsTracker = 0;
        LabelControlGame.label.enemyPointsTracker = 0;
    }
	
    public void NextTurn()
    {
        playerLocked = 0;
        enemyLocked = 0;
        timer = 60.0F;
        turnNumber += 1;
        LabelControlGame.label.playerGoldTracker = LabelControlGame.label.playerGoldTracker + 1;
        LabelControlGame.label.enemyGoldTracker = LabelControlGame.label.enemyGoldTracker + 1;
    }

    public void EndTurn()
    {
        playerLocked = 1;
        enemyLocked = 1;
    }

	// Update is called once per frame
	void Update ()
    {
        timer -= Time.deltaTime;
        Timer.text = "Time Left:" + Mathf.Round(timer);
        if (timer < 0 )
        {
            playerLocked = 1;
            enemyLocked = 1;
            NextTurn();
        }

        if (playerLocked == 1 && enemyLocked == 1)
        {
            NextTurn();
        }

        turnCounter.text = "Turn: " + turnNumber.ToString();
    }
}
