using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CardGame
{
    public class Stats
    {
        private int health;
        private int attack;
        private int defence;
        private int stamina = 50;
        public Stats()
        {
            
        }
        public int GetHealth()
        {
            return health;
        }

        public int GetAttack()
        {
            return attack;
        }

        public int GetDefence()
        {
            return defence;
        }
        public int GetStamina()
        {
            return stamina;
        }
        public void SetStamina(int newStamina)
        {
            stamina = newStamina;
        }
        public void SetHealth(int newHealth)
        {
            health = newHealth;
        }
        public void SetAttack(int newAttack)
        {
            attack = newAttack;
        }
        public void SetDefence(int newDefence)
        {
            defence = newDefence;
        }
    }
}