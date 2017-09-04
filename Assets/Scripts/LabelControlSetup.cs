using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LabelControlSetup : MonoBehaviour {

    public Text gold;
    public Text wins;
    public Text losses;
    public Text totalpoints;

    void Update()
    {
        wins.text = "Wins: " + GameControl.control.wins.ToString();
        losses.text = "Losses: " + GameControl.control.losses.ToString();
        totalpoints.text = "Total Points: " + GameControl.control.totalpoints.ToString();
        gold.text = "Gold: " + GameControl.control.gold.ToString();
    }
}
