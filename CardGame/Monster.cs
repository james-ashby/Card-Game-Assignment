using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CardGame
{
    public class Monster
    {
        private string name;
        private string pictureFileName;

        Stats stats;


        public Monster(string Name, string FileURL)
        {
            pictureFileName = FileURL;
            name = Name;
            stats = new Stats();
        }
        public Stats GetStats()
        {
            return stats;
        }
        public void SetStats(int Health, int Attack, int Defence)
        {
            stats.SetHealth(Health);
            stats.SetAttack(Attack);
            stats.SetDefence(Defence);
        }
        public string GetPicture()
        {
            return pictureFileName;
        }
        public string GetName()
        {
            return name;
        }
        public void TakeDamage(int damageTaken)
        {
            stats.SetHealth(damageTaken);
        }
        public int GetHealth()
        {
            return stats.GetHealth();
        }
        public int GetAttack()
        {
            return stats.GetAttack();
        }
        public int GetDefence()
        {
            return stats.GetDefence();
        }
        public int GetStamina()
        {
            return stats.GetStamina();
        }
        public void SetStamina(int newStamina)
        {
            stats.SetStamina(newStamina);
        }

    }
    

}