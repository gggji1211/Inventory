using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
        public int AttackPower { get; private set; }
        public int Defense { get; private set; }
         public string Name { get; private set; }
        public int Level { get; private set; }
        public int Health { get; private set; }
    public int Critical { get; private set; }

    public Character(string name, int level, int health, int attack ,int defense,int critical)
        {
            Name = name;
            Level = level;
            Health = health;
             AttackPower = attack;
             Defense = defense;
        Critical = critical;
        }
    }


