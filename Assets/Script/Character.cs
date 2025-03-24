using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    
        public string Name { get; private set; }
        public int Level { get; private set; }
        public int Health { get; private set; }
        public int MaxHealth { get; private set; }

        public Character(string name, int level, int maxHealth)
        {
            Name = name;
            Level = level;
            MaxHealth = maxHealth;
            Health = maxHealth;
        }
    }


