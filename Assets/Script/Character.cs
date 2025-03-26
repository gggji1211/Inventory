using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Character 
{
    public List<Item> Inventory { get; private set; }
    public int AttackPower { get; private set; }
    public int Defense { get; private set; }
    public string Name { get; private set; }
    public int Level { get; private set; }
    public int Health { get; private set; }
    public int Critical { get; private set; }

    public Character(string name, int level, int health, int attack, int defense, int critical) // Ω∫≈»
    {
        Name = name;
        Level = level;
        Health = health;
        AttackPower = attack;
        Defense = defense;
        Critical = critical;
        Inventory = new List<Item>(); 
    }

    public void AddItem(Item newItem) 
    {
     
        Inventory.Add(newItem);
    }
    public void EquipItem(Item item) //  Ω∫≈» ¡ı∞°
    {
        AttackPower += item.AttackBonus;
        Defense += item.DefenseBonus;

    }

    public void UnequipItem(Item item) // Ω∫≈» ∞®º“
    {
        AttackPower -= item.AttackBonus;
        Defense -= item.DefenseBonus;

    
    }
}
    

