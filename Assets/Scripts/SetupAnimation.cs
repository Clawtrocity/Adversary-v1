using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SetupAnimation : MonoBehaviour {

    public Animator Vil;
    public Animator Inv;
    public Animator Bat;
    public Animator Stat;
    public Animator Shop;
    public Animator Event;
    public Text profileName;
    public int ScreenControlInt;
    public Transform target;
    public Vector3 destination;
    public float speed;

    public void Awake()
    {
        Vil.enabled = true;
        Inv.enabled = true;
        Bat.enabled = true;
        Stat.enabled = true;
        Shop.enabled = true;
        Vil.Play("Shrink");
        Inv.Play("Shrink");
        Bat.Play("Shrink");
        Stat.Play("Shrink");
        Shop.Play("Shrink");

        if (String.IsNullOrEmpty(GameControl.control.profileName))
        {
            Event.enabled = true;
            Event.Play("EventIn");
        }
        else
        {
            Event.enabled = false;
        }
    }

    public void Villain()
    {
        Vil.Play("Grow");
        Inv.Play("Shrink");
        Bat.Play("Shrink");
        Stat.Play("Shrink");
        Shop.Play("Shrink");
        destination.x = 3708;
        destination.y = 94;
        destination.z = 0;
}

    public void Inventory()
    {
        Inv.Play("Grow");
        Vil.Play("Shrink");
        Bat.Play("Shrink");
        Stat.Play("Shrink");
        Shop.Play("Shrink");
        destination.x = 1843;
        destination.y = 94;
        destination.z = 0;
}

    public void Battle()
    {
        Bat.Play("Grow");
        Vil.Play("Shrink");
        Inv.Play("Shrink");
        Stat.Play("Shrink");
        Shop.Play("Shrink");
        destination.x = -25;
        destination.y = 94;
        destination.z = 0;
}

    public void Stats()
    {
        Stat.Play("Grow");
        Vil.Play("Shrink");
        Inv.Play("Shrink");
        Bat.Play("Shrink");
        Shop.Play("Shrink");
        destination.x = -1890;
        destination.y = 94;
        destination.z = 0;
    }

    public void TheShop()
    {
        Shop.Play("Grow");
        Vil.Play("Shrink");
        Inv.Play("Shrink");
        Bat.Play("Shrink");
        Stat.Play("Shrink");
        destination.x = -3758;
        destination.y = 94;
        destination.z = 0;
    }

    public void LockProfile()
    {
        GameControl.control.profileName = profileName.text;
        Event.Play("EventOut");
    }

    public void Update()
    {
        Vector3 targetPosition = target.TransformPoint(new Vector3 (destination.x,destination.y,destination.z));
        target.transform.position = Vector3.Lerp(transform.position, targetPosition, speed);
    }
}
