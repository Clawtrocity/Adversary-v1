using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LabelControlGame : MonoBehaviour
{
    public static LabelControlGame label;

    public Text profileName;
    public Text enemyName;
    public Text playerGold;
    public Text playerPoints;
    public int playerPointsTracker;
    public int playerGoldTracker;
    public Text enemyGold;
    public Text enemyPoints;
    public int enemyPointsTracker;
    public int enemyGoldTracker;

    void Start()
    {
        profileName.text = GameControl.control.profileName.ToString();
        enemyName.text = GameControl.control.enemyName.ToString();
        playerGoldTracker = 1;
        enemyGoldTracker = 1;
        playerPointsTracker = 1;
        enemyPointsTracker = 1;
    }

    void Update()
    {
        playerPoints.text = GameControl.control.playerPoints;
        playerGold.text = GameControl.control.playerGold;
        enemyPoints.text = GameControl.control.enemyPoints;
        enemyGold.text = GameControl.control.enemyGold;
    }

    public int PlayerGoldTracker
    {
        get
        {
            return playerGoldTracker;
        }

        set
        {
            playerGoldTracker = value;
        }
    }
}
