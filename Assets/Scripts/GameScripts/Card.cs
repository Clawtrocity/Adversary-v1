using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Card {

    public static int cost;
    public static int power;
    public static string tooltip;
    public static int points;
    public static int aff;

    public static int Cost
    {
        get
        {
            return cost;
        }

        set
        {
            cost = value;
        }
    }

    public static int Power
    {
        get
        {
            return Power;
        }

        set
        {
            power = value;
        }
    }

    public static int Aff
    {
        get
        {
            return aff;
        }

        set
        {
            aff = value;
        }
    }

    public static int Points
    {
        get
        {
            return points;
        }

        set
        {
            points = value;
        }
    }

    public static string Tooltip
    {
        get
        {
            return tooltip;
        }

        set
        {
            tooltip = value;
        }
    }
    public static void NewCard(int cost, int power, string tooltip, string name, Sprite card)
    {
        card = Resources.Load(name, typeof(Sprite)) as Sprite;
    }
}
