using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class Actions : MonoBehaviour {

    public static Actions actions;

    public Canvas myCanvas;
    public Text Tooltip;
    public Vector3 offset;
    public Vector3 enemyOffset;
    public Vector3 townTopOffset;
    public Vector3 townBottomOffset;
    public Vector3 hidden;
    public Vector2 mouse;
    public int hovering;
    public int townhovering;
    public Transform selectedCard;
    public GridLayoutGroup Grid;
    public GridLayoutGroup GridHidden;
    public Canvas gridtooltip;
    public Transform currentOccupy;
    public Image cardimage;
    public Transform Card;
    public int cost;
    public int playerGold;
    public int enemyGold;
    public int playerPoints;
    public int enemyPoints;
    public Animator PlayerGoldFlash;
    public Canvas drag;
    public int selecting;
    public int Town1quant = 1;
    public Transform Town1;
    public Transform Town2;
    public Transform Town3;
    public Transform Town4;
    public Transform Town5;
    public Transform Town6;
    public Transform Town7;
    public Transform Town8;
    public Transform Town9;
    public Transform Town10;
    public Transform Town11;
    public Transform Town12;
    public Transform Town13;
    public static List<Transform> ts1 = new List<Transform>();
    public List<Transform> ts2 = new List<Transform>();
    public List<Transform> ts3 = new List<Transform>();
    public List<Transform> ts4 = new List<Transform>();
    public List<Transform> ts5 = new List<Transform>();
    public List<Transform> ts6 = new List<Transform>();
    public List<Transform> ts7 = new List<Transform>();
    public List<Transform> ts8 = new List<Transform>();
    public List<Transform> ts9 = new List<Transform>();
    public List<Transform> ts10 = new List<Transform>();
    public List<Transform> ts11 = new List<Transform>();
    public List<Transform> ts12 = new List<Transform>();
    public List<Transform> ts13 = new List<Transform>();
    public Text Town1count;
    public Text Town2count;
    public Text Town3count;
    public Text Town4count;
    public Text Town5count;
    public Text Town6count;
    public Text Town7count;
    public Text Town8count;
    public Text Town9count;
    public Text Town10count;
    public Text Town11count;
    public Text Town12count;
    public Text Town13count;
    

    public void OnEnable()
    {
        GameControl.control.playerGoldTracker = 1;
        GameControl.control.enemyGoldTracker = 1;
    }

    public void Start()
    {
        Card = Instantiate(Town1);
        ts1.Add(Card.transform);
        Card.transform.position = hidden;

        Card = Instantiate(Town2);
        ts2.Add(Card.transform);
        Card.transform.position = hidden;

        Card = Instantiate(Town3);
        ts3.Add(Card.transform);
        Card.transform.position = hidden;

        Card = Instantiate(Town4);
        ts4.Add(Card.transform);
        Card.transform.position = hidden;

        Card = Instantiate(Town5);
        ts5.Add(Card.transform);
        Card.transform.position = hidden;

        Card = Instantiate(Town6);
        ts6.Add(Card.transform);
        Card.transform.position = hidden;

        Card = Instantiate(Town7);
        ts7.Add(Card.transform);
        Card.transform.position = hidden;

        Card = Instantiate(Town8);
        ts8.Add(Card.transform);
        Card.transform.position = hidden;

        Card = Instantiate(Town9);
        ts9.Add(Card.transform);
        Card.transform.position = hidden;

        Card = Instantiate(Town10);
        ts10.Add(Card.transform);
        Card.transform.position = hidden;

        Card = Instantiate(Town11);
        ts11.Add(Card.transform);
        Card.transform.position = hidden;

        Card = Instantiate(Town12);
        ts12.Add(Card.transform);
        Card.transform.position = hidden;

        Card = Instantiate(Town13);
        ts13.Add(Card.transform);
        Card.transform.position = hidden;
    }

    public void SelectCard(Image cardname)
    {
        selectedCard = cardname.transform;
        selecting = 1;
        cardimage.sprite = Resources.Load(cardname.sprite.name, typeof(Sprite)) as Sprite;
    }

    public void List(string townspace, Transform card)
    {
        if (townspace == "TownSlot1")
        {
            ts1.Add(card);
        }
        if (townspace == "TownSlot2")
        {
            ts2.Add(card);
        }
        if (townspace == "TownSlot3")
        {
            ts3.Add(card);
        }
        if (townspace == "TownSlot4")
        {
            ts4.Add(card);
        }
        if (townspace == "TownSlot5")
        {
            ts5.Add(card);
        }
        if (townspace == "TownSlot6")
        {
            ts6.Add(card);
        }
        if (townspace == "TownSlot7")
        {
            ts7.Add(card);
        }
        if (townspace == "TownSlot8")
        {
            ts8.Add(card);
        }
        if (townspace == "TownSlot9")
        {
            ts9.Add(card);
        }
        if (townspace == "TownSlot10")
        {
            ts10.Add(card);
        }
        if (townspace == "TownSlot11")
        {
            ts11.Add(card);
        }
        if (townspace == "TownSlot12")
        {
            ts12.Add(card);
        }
        if (townspace == "TownSlot13")
        {
            ts13.Add(card);
        }
    }

    public void PlaceCard(Transform townspace)
    {
        if (selecting == 1)
        {
            if (GameControl.control.playerGoldTracker >= cost)
            {
                Card = Instantiate(selectedCard);
                List(townspace.name, Card);
                Card.transform.SetParent(Grid.transform, false);
                drag.transform.position = hidden;
                GameControl.control.playerGoldTracker -= cost;
                GameControl.control.TownSlot1 += 1;
            }
            else
            {
                PlayerGoldFlash.Play("FlashRed");
                drag.transform.position = hidden;
            }
        }
        selecting = 0;
    }

    public void EnemyPlaceCard(Transform townspace)
    {
        if (selecting == 1)
        {
            if (GameControl.control.enemyGoldTracker >= cost)
            {
                Card = Instantiate(selectedCard);
                List(townspace.name, Card);
                Card.transform.SetParent(Grid.transform, false);
                drag.transform.position = hidden;
                GameControl.control.playerGoldTracker -= cost;
                GameControl.control.TownSlot1 -= 1;
            }
            else
            {
                PlayerGoldFlash.Play("FlashRed");
                drag.transform.position = hidden;
            }
        }
        selecting = 0;
    }


    public void Hover(Image cardname)
    {
        hovering = 1;
        if (cardname.sprite.name == "card1")
        {
            Tooltip.text = "Clown:\n Basic Henchmen with no abilities";
            cost = 1;
        }

        if (cardname.sprite.name == "card2")
        {
            Tooltip.text = "Degenerate:\n+1 Power against enemy Henchmen";
            cost = 2;
        }

        if (cardname.sprite.name == "card3")
        {
            Tooltip.text = "Dollface:\n+2 Power if your Super Villain is active";
            cost = 3;
        }

        if (cardname.sprite.name == "card4")
        {
            Tooltip.text = "Poison:\n-1 Power to all enemy Henchmen on target location";
            cost = 1;
        }

        if (cardname.sprite.name == "card5")
        {
            Tooltip.text = "Surge:\n+1 Power all henchmen on target location";
            cost = 2;
        }

        if (cardname.sprite.name == "card6")
        {
            Tooltip.text = "Explode:\nDestroy all henchmen on target location";
            cost = 3;
        }

        if (cardname.sprite.name == "card7")
        {
            Tooltip.text = "Goon: \nBasic Henchmen with no abilities";
            cost = 1;
        }

        if (cardname.sprite.name == "card8")
        {
            Tooltip.text = "Junky: \n +1 Power when attacking, -1 Power when defending";
            cost = 2;
        }

        if (cardname.sprite.name == "card9")
        {
            Tooltip.text = "Ex-Vet:\n+2 Power when attacking, -1 Power when defending";
            cost = 3;
        }

        if (cardname.sprite.name == "card10")
        {
            Tooltip.text = "Revelation:\nReveal all face down henchmen cards";
            cost = 1;
        }

        if (cardname.sprite.name == "card11")
        {
            Tooltip.text = "Curse:\nTarget enemy Henchmen will die at the start of next turn";
            cost = 2;
        }

        if (cardname.sprite.name == "card12")
        {
            Tooltip.text = "Destiny:\nReduce all Henchmen power to 0";
            cost = 3;
        }
    }

    public void UnHover()
    {
        hovering = 0;
        myCanvas.transform.position = hidden;
    }

    public void TownHover(Transform current)
    {
        if (current.name == "TownSlot1")
        {
            foreach (Transform card in ts1)
            {
                card.transform.SetParent(Grid.transform, false);
            }
        }

        if (current.name == "TownSlot2")
        {
            foreach (Transform card in ts2)
            {
                card.transform.SetParent(Grid.transform, false);
            }
        }

        if (current.name == "TownSlot3")
        {
            foreach (Transform card in ts3)
            {
                card.transform.SetParent(Grid.transform, false);
            }
        }

        if (current.name == "TownSlot4")
        {
            foreach (Transform card in ts4)
            {
                card.transform.SetParent(Grid.transform, false);
            }
        }

        if (current.name == "TownSlot5")
        {
            foreach (Transform card in ts5)
            {
                card.transform.SetParent(Grid.transform, false);
            }
        }

        if (current.name == "TownSlot6")
        {
            foreach (Transform card in ts6)
            {
                card.transform.SetParent(Grid.transform, false);
            }
        }

        if (current.name == "TownSlot7")
        {
            foreach (Transform card in ts7)
            {
                card.transform.SetParent(Grid.transform, false);
            }
        }

        if (current.name == "TownSlot8")
        {
            foreach (Transform card in ts8)
            {
                card.transform.SetParent(Grid.transform, false);
            }
        }

        if (current.name == "TownSlot9")
        {
            foreach (Transform card in ts9)
            {
                card.transform.SetParent(Grid.transform, false);
            }
        }

        if (current.name == "TownSlot10")
        {
            foreach (Transform card in ts10)
            {
                card.transform.SetParent(Grid.transform, false);
            }
        }

        if (current.name == "TownSlot11")
        {
            foreach (Transform card in ts11)
            {
                card.transform.SetParent(Grid.transform, false);
            }
        }

        if (current.name == "TownSlot12")
        {
            foreach (Transform card in ts12)
            {
                card.transform.SetParent(Grid.transform, false);
            }
        }

        if (current.name == "TownSlot13")
        {
            foreach (Transform card in ts13)
            {
                card.transform.SetParent(Grid.transform, false);
            }
        }

        townhovering = 1;
    }

    public void TownUnHover(Transform townspace)
    {
        townhovering = 0;
        gridtooltip.transform.position = hidden;
        foreach (var child in Grid.transform.Cast<Transform>().ToList())
        {
            child.transform.SetParent(GridHidden.transform, false);
        }
    }

    public void EndTurn()
    {
        Town1count.text = ts1.Count.ToString();
        Town2count.text = ts2.Count.ToString();
        Town3count.text = ts3.Count.ToString();
        Town4count.text = ts4.Count.ToString();
        Town5count.text = ts5.Count.ToString();
        Town6count.text = ts6.Count.ToString();
        Town7count.text = ts7.Count.ToString();
        Town8count.text = ts8.Count.ToString();
        Town9count.text = ts9.Count.ToString();
        Town10count.text = ts10.Count.ToString();
        Town11count.text = ts11.Count.ToString();
        Town12count.text = ts12.Count.ToString();
        Town13count.text = ts13.Count.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        if (selecting == 1)
        {
            drag.transform.position = Input.mousePosition;
        }

        if (hovering == 1)
        {
            mouse = new Vector2(Input.mousePosition.x, Screen.height - Input.mousePosition.y);
            if (mouse.x < Screen.width / 2)
            {
                myCanvas.transform.position = Input.mousePosition + offset;
            }

            if (mouse.x > Screen.width / 2)
            {
                myCanvas.transform.position = Input.mousePosition + enemyOffset;
            }
        }

        if (townhovering == 1)
        {
            mouse = new Vector2(Input.mousePosition.x, Screen.height - Input.mousePosition.y);
            if (mouse.y < Screen.height / 2)
            {
                gridtooltip.transform.position = Input.mousePosition + townTopOffset;
            }

            if (mouse.y > Screen.height / 2)
            {
                gridtooltip.transform.position = Input.mousePosition + townBottomOffset;
            }
        }
    }
}
