using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CardGame
{
    public class Monsters
    {
        private List<Monster> monsterList = new List<Monster>();

        Monster Treecko;
        Monster Squirtle;
        Monster Geodude; 
        Monster Ponyta; 
        Monster Pidgey; 
        public Monsters()
        {
            SetCharacters();
            SetCharacterStats();
            AddMonstersToList();
        }

        public void SetCharacters() // Instatiate the monsters with a Name and image url
        {
            Treecko = new Monster("Treecko", "test.png");
            Squirtle = new Monster("Squirtle", "test.png");
            Geodude = new Monster("Geodude", "test.png");
            Ponyta = new Monster("Ponyta", "test.png");
            Pidgey = new Monster("Pidgey", "test.png");
        }
        public void SetCharacterStats() // (Health, Attack, Defence) (Stamina for all is 50)
        {
            Treecko.SetStats(40, 4, 4);
            Squirtle.SetStats(50, 4, 3);
            Geodude.SetStats(65, 2, 6);
            Ponyta.SetStats(40, 5, 3);
            Pidgey.SetStats(30, 7, 1);

        }
        public void AddMonstersToList() // Add each of the monsters to the main monster list
        {
            monsterList.Add(Treecko);
            monsterList.Add(Squirtle);
            monsterList.Add(Geodude);
            monsterList.Add(Ponyta);
            monsterList.Add(Pidgey);
        }
        public Monster GetMonsterFromList(string monsterName) // Retrieve a monster from the monster list and remove it after
        {
            Monster tempMonster = new Monster("","");
            for (int i = monsterList.Count - 1; i >= 0; i--)
            {
                if (monsterName == monsterList[i].GetName())
                {
                    tempMonster = monsterList[i];
                    monsterList.RemoveAt(i);
                }
            }
            return tempMonster;
        }
    }
}