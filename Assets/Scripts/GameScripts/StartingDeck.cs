using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartingDeck : MonoBehaviour {

    public static StartingDeck startingDeck;

    public int playerDeck;
    public int enemyDeck;
    public Image playerToken1;
    public Image playerToken2;
    public Image playerToken3;
    public Image playerToken4;
    public Image playerToken5;
    public Image playerToken6;
    public Image enemyToken1;
    public Image enemyToken2;
    public Image enemyToken3;
    public Image enemyToken4;
    public Image enemyToken5;
    public Image enemyToken6;
    public Image Town1;
    public Image Town2;
    public Image Town3;
    public Image Town4;
    public Image Town5;
    public Image Town6;
    public Image Town7;
    public Image Town8;
    public Image Town9;
    public Image Town10;
    public Image Town11;
    public Image Town12;
    public Image Town13;


    // Use this for initialization
    public void Start ()
    {
        playerDeck = GameControl.control.currentDeck;
        enemyDeck = GameControl.control.enemyDeck;

        if (playerDeck == 1)
        {
            playerToken1.sprite = Resources.Load("card1", typeof(Sprite)) as Sprite;
            playerToken2.sprite = Resources.Load("card2", typeof(Sprite)) as Sprite;
            playerToken3.sprite = Resources.Load("card3", typeof(Sprite)) as Sprite;
            playerToken4.sprite = Resources.Load("card4", typeof(Sprite)) as Sprite;
            playerToken5.sprite = Resources.Load("card5", typeof(Sprite)) as Sprite;
            playerToken6.sprite = Resources.Load("card6", typeof(Sprite)) as Sprite;
        }

        if (playerDeck == 2)
        {
            playerToken1.sprite = Resources.Load("card7", typeof(Sprite)) as Sprite;
            playerToken2.sprite = Resources.Load("card8", typeof(Sprite)) as Sprite;
            playerToken3.sprite = Resources.Load("card9", typeof(Sprite)) as Sprite;
            playerToken4.sprite = Resources.Load("card10", typeof(Sprite)) as Sprite;
            playerToken5.sprite = Resources.Load("card11", typeof(Sprite)) as Sprite;
            playerToken6.sprite = Resources.Load("card12", typeof(Sprite)) as Sprite;
        }

        if (enemyDeck == 1)
        {
            enemyToken1.sprite = Resources.Load("card1", typeof(Sprite)) as Sprite;
            enemyToken2.sprite = Resources.Load("card2", typeof(Sprite)) as Sprite;
            enemyToken3.sprite = Resources.Load("card3", typeof(Sprite)) as Sprite;
            enemyToken4.sprite = Resources.Load("card4", typeof(Sprite)) as Sprite;
            enemyToken5.sprite = Resources.Load("card5", typeof(Sprite)) as Sprite;
            enemyToken6.sprite = Resources.Load("card6", typeof(Sprite)) as Sprite;
        }

        if (enemyDeck == 2)
        {
            enemyToken1.sprite = Resources.Load("card7", typeof(Sprite)) as Sprite;
            enemyToken2.sprite = Resources.Load("card8", typeof(Sprite)) as Sprite;
            enemyToken3.sprite = Resources.Load("card9", typeof(Sprite)) as Sprite;
            enemyToken4.sprite = Resources.Load("card10", typeof(Sprite)) as Sprite;
            enemyToken5.sprite = Resources.Load("card11", typeof(Sprite)) as Sprite;
            enemyToken6.sprite = Resources.Load("card12", typeof(Sprite)) as Sprite;
        }

        Town1.sprite = Resources.Load("T1Civ", typeof(Sprite)) as Sprite;
        Town2.sprite = Resources.Load("T1Civ", typeof(Sprite)) as Sprite;
        Town3.sprite = Resources.Load("T1Civ", typeof(Sprite)) as Sprite;
        Town4.sprite = Resources.Load("T2Police", typeof(Sprite)) as Sprite;
        Town5.sprite = Resources.Load("T2Police", typeof(Sprite)) as Sprite;
        Town6.sprite = Resources.Load("T1Civ", typeof(Sprite)) as Sprite;
        Town7.sprite = Resources.Load("T3Mayor", typeof(Sprite)) as Sprite;
        Town8.sprite = Resources.Load("T1Civ", typeof(Sprite)) as Sprite;
        Town9.sprite = Resources.Load("T2Police", typeof(Sprite)) as Sprite;
        Town10.sprite = Resources.Load("T2Police", typeof(Sprite)) as Sprite;
        Town11.sprite = Resources.Load("T1Civ", typeof(Sprite)) as Sprite;
        Town12.sprite = Resources.Load("T1Civ", typeof(Sprite)) as Sprite;
        Town13.sprite = Resources.Load("T1Civ", typeof(Sprite)) as Sprite;
    }
}
