using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CardGame
{
    public class Monsters
    {
        private List<Monster> monsterList = new List<Monster>();
        private List<Monster> catchableMonsters = new List<Monster>();

        // Declaring monsters for the starting monsters that players can choose
        Monster Treecko;
        Monster Squirtle;
        Monster Geodude; 
        Monster Ponyta; 
        Monster Pidgey;
        Monster Oddish;
        Monster Snorunt;
        Monster Bagon;
        Monster Trapinch;
        Monster Drifloon;
        // Declaring monsters that players can catch throughout the game


        public Monsters()
        {
            SetCharacters();
            SetCharacterStats();
            AddMonstersToList();
        }

        public void SetCharacters() // Instatiate the monsters with a Name and image url
        {
            Treecko = new Monster("Treecko", "treeckoBattle.png");
            Squirtle = new Monster("Squirtle", "squirtleBattle.png");
            Geodude = new Monster("Geodude", "geodudeBattle.png");
            Ponyta = new Monster("Ponyta", "ponytaBattle.png");
            Pidgey = new Monster("Pidgey", "pidgeyBattle.png");
            Oddish = new Monster("Oddish", "oddishBattle.png");
            Snorunt = new Monster("Snorunt", "snoruntBattle.png");
            Bagon = new Monster("Bagon", "bagonBattle.png");
            Trapinch = new Monster("Trapinch", "trapinchBattle.png");
            Drifloon = new Monster("Drifloon", "drifloonBattle.png");
            
        }
        public void SetCharacterStats() // (Health, Attack, Defence) (Stamina for all is 50)
        {
            Treecko.SetStats(40, 4, 4);
            Squirtle.SetStats(50, 4, 3);
            Geodude.SetStats(60, 2, 6);
            Ponyta.SetStats(40, 5, 3);
            Pidgey.SetStats(30, 7, 1);
            Oddish.SetStats(50, 3, 5);
            Snorunt.SetStats(70, 1, 8);
            Bagon.SetStats(30, 5, 5);
            Trapinch.SetStats(40, 3, 6);
            Drifloon.SetStats(30, 6, 6);
        }
        public void AddMonstersToList() // Add each of the monsters to the main monster list
        {
            monsterList.Add(Treecko);
            monsterList.Add(Squirtle);
            monsterList.Add(Geodude);
            monsterList.Add(Ponyta);
            monsterList.Add(Pidgey);
            monsterList.Add(Oddish);
            monsterList.Add(Snorunt);
            monsterList.Add(Bagon);
            monsterList.Add(Trapinch);
            monsterList.Add(Drifloon);
        }
        public Monster GetMonsterFromList(string monsterName) // Retrieve a monster from the monster list and remove it after (for choosing specific)
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
        public Monster RandomMonsterFromList(int randMaxValue)
        {
            Monster tempMonster = new Monster("", "");
            tempMonster = catchableMonsters[randMaxValue];
            catchableMonsters.RemoveAt(randMaxValue);
            return tempMonster;
        }
    }
}