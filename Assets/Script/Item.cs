using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item 
{
    public string itemName { get; private set; }
    public Sprite itemIcon { get; private set; }

    public Item(string name, Sprite icon)
    {
        itemName = name;
        itemIcon = icon;
    }
}