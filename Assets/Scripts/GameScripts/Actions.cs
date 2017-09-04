using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Actions : MonoBehaviour {

    public Canvas myCanvas;
    public Canvas drag;
    public Text Tooltip;
    public Image card;
    public Vector3 offset;
    public Vector3 enemyOffset;
    public Vector3 hidden;
    public Vector2 mouse;
    public int hovering;
    public string selectedCard;
    public Vector3 startingPosition;

    public RectTransform Town1;

    public void Start()
    {
        startingPosition = drag.transform.position;
    }

    public void Hover(Image cardname)
    {
        cardname.name = selectedCard;
        hovering = 1;
        if (cardname.sprite.name == "card1")
        {
            Tooltip.text = "Clown:\n Basic Henchmen with no abilities";
        }

        if (cardname.sprite.name == "card2")
        {
            Tooltip.text = "Degenerate:\n+1 Power against enemy Henchmen";
        }

        if (cardname.sprite.name == "card3")
        {
            Tooltip.text = "Dollface:\n+2 Power if your Super Villain is active";
        }

        if (cardname.sprite.name == "card4")
        {
            Tooltip.text = "Poison:\n-1 Power to all enemy Henchmen on target location";
        }

        if (cardname.sprite.name == "card5")
        {
            Tooltip.text = "Surge:\n+1 Power all henchmen on target location";
        }

        if (cardname.sprite.name == "card6")
        {
            Tooltip.text = "Explode:\nDestroy all henchmen on target location";
        }

        if (cardname.sprite.name == "card7")
        {
            Tooltip.text = "Goon: \nBasic Henchmen with no abilities";
        }

        if (cardname.sprite.name == "card8")
        {
            Tooltip.text = "Junky: \n +1 Power when attacking, -1 Power when defending";
        }

        if (cardname.sprite.name == "card9")
        {
            Tooltip.text = "Ex-Vet:\n+2 Power when attacking, -1 Power when defending";
        }

        if (cardname.sprite.name == "card10")
        {
            Tooltip.text = "Revelation:\nReveal all face down henchmen cards";
        }

        if (cardname.sprite.name == "card11")
        {
            Tooltip.text = "Curse:\nTarget enemy Henchmen will die at the start of next turn";
        }

        if (cardname.sprite.name == "card12")
        {
            Tooltip.text = "Destiny:\nReduce all Henchmen power to 0";
        }
    }

    public void UnHover()
    {
        hovering = 0;
        myCanvas.transform.position = hidden;
    }
    
    public void Drag()
    {
        card.sprite = Resources.Load(selectedCard, typeof(Sprite)) as Sprite;
        drag.transform.position = Input.mousePosition;
    }

    public void LetGo()
    {
        drag.transform.position = startingPosition;
    }

    // Update is called once per frame
    void Update()
    {
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
    }
}
