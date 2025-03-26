using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item 
{
    public string itemName { get; private set; }
    public Sprite itemIcon { get; private set; }
    public int AttackBonus { get; private set; }
    public int DefenseBonus { get; private set; }

    public Item(string name, Sprite icon, int attackBonus , int defenseBonus )
    {
        itemName = name;
        itemIcon = icon;
        AttackBonus = attackBonus;    
        DefenseBonus = defenseBonus;  
    }
}