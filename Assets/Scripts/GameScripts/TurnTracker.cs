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

    public int playerPower;
    public int enemyPower;
    public int townPower;

	// Use this for initialization
	void Start ()
    {
        turnNumber = 1;
    }
	
    public void NextTurn()
    {
        playerLocked = 0;
        enemyLocked = 0;
        timer = 60.0F;
        turnNumber += 1;
        GameControl.control.playerGoldTracker = GameControl.control.playerGoldTracker + turnNumber;
        GameControl.control.enemyGoldTracker = GameControl.control.enemyGoldTracker + turnNumber;
    }

    public void EndTurn()
    {
        playerLocked = 1;
        enemyLocked = 1;
    }

    public void EndOfTurn()
    {
        Battle();
        NextTurn();
    }

    public void Battle()
    {
        if (Actions.ts1.Count / GameControl.control.TownSlot1 != 1)
        {
            foreach (Transform card in Actions.ts1)
            {
                if (Card.aff == 1)
                {
                    playerPower += 1;
                }

                if (Card.aff == 0)
                {
                    townPower += 1;
                }

                if (Card.aff == -1)
                {
                    enemyPower += 1;
                }
            }

            if (playerPower > enemyPower)
            {
                enemyPower = -1;
                foreach(Transform card in Actions.ts1)
                {
                    if (Card.aff == -1)
                    {
                        Destroy(card);
                    }
                }
            }
            else
            {
                playerPower = -1;
                foreach (Transform card in Actions.ts1)
                {
                    if (Card.aff == 1)
                    {
                        Destroy(card);
                    }
                }
            }

            if (playerPower > townPower)
            {
                foreach (Transform card in Actions.ts1)
                {
                    if (Card.aff == 0)
                    {
                        Destroy(card);
                        LabelControlGame.label.playerPointsTracker += Card.points;
                    }
                }
            }

            if (enemyPower > townPower)
            {
                foreach (Transform card in Actions.ts1)
                {
                    if (Card.aff == 0)
                    {
                        Destroy(card);
                        LabelControlGame.label.enemyPointsTracker += Card.points;
                    }
                }
            }
        }

        playerPower = 0;
        enemyPower = 0;
        townPower = 0;
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
            EndOfTurn();
        }

        if (playerLocked == 1 && enemyLocked == 1)
        {
            EndOfTurn();
        }

        turnCounter.text = "Turn: " + turnNumber.ToString();
    }
}
