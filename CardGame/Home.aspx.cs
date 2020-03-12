using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CardGame
{
    public partial class Home : System.Web.UI.Page
    {
        Player player1;
        Player player2;
        int playerTurn = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            player1 = new Player();
            player2 = new Player();
            
        }
       
        public void AddTreeckoToTeam(int playerTurn)
        {
            if (playerTurn == 1)
            {
                player1.AddMonsterToTeam("Treecko");
            }
            else if (playerTurn == 2)
            {
                player2.AddMonsterToTeam("Treecko");
            }
        }


        public void UpdateDisplay()
        {
            Label1.Text = player1.teamMonster(0).GetName();
        }
    }
}