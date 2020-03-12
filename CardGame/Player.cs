using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CardGame
{
    public class Player
    {
        List<Monster> Team = new List<Monster>();
        Monsters monsters = new Monsters();

        public Player()
        {
            
        }
        public void AddMonsterToTeam(string monsterChoice)
        {
            Team.Add(monsters.GetMonsterFromList(monsterChoice));
        }
        public void CheckTeamHealth()
        {
            for (int i = 0; i < Team.Count; i++)
            {
                if (Team[i].GetHealth() < 0)
                {
                    Team.RemoveAt(i);
                }
            }
        }
        public Monster teamMonster(int indexValue)
        {
            return Team[indexValue];
        }
        

    }
}