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
    }

    void Update()
    {
        playerPoints.text = "Points: " + playerPointsTracker;
        playerGold.text = "Gold: " + playerGoldTracker;
        enemyPoints.text = "Points: " + enemyPointsTracker;
        enemyGold.text = "Gold: " + enemyGoldTracker;
    }
}
