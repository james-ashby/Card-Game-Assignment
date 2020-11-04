using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace CardGame
{
    public partial class Game : System.Web.UI.Page
    {
        Player player1;
        Player player2;
        protected void Page_Load(object sender, EventArgs e)
        {
            player1 = Session["player1"] as Player;
            player2 = Session["player2"] as Player;
            Label2.Text = player1.teamMonster(0).GetName();
            Image1.ImageUrl = "Images/" + player1.teamMonster(0).GetPicture();
            Image1.Width = 200; Image1.Height = 200;
            Label3.Text = player1.teamMonster(1).GetName();
            Image2.ImageUrl = "Images/" + player1.teamMonster(1).GetPicture();
            Image2.Width = 200; Image2.Height = 200;
            Label4.Text = player1.teamMonster(2).GetName();
            Image3.ImageUrl = "Images/" + player1.teamMonster(2).GetPicture();
            Image3.Width = 200; Image2.Height = 200;
        }
        public void SaveState()
        {
            Session["player1"] = player1;
            Session["player2"] = player2;
        }
    }
}