using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item 
{
    public string itemName { get; private set; }
    public Sprite itemIcon { get; private set; }
    public int AttackBonus;
    public int DefenseBonus;

    // 아이템 생성자
    public Item(string name, Sprite icon, int attackBonus , int defenseBonus )
    {
        itemName = name;
        itemIcon = icon;
        AttackBonus = attackBonus;    
        DefenseBonus = defenseBonus;  
    }
}