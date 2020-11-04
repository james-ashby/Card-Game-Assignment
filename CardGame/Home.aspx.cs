using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Configuration;


namespace CardGame
{

    public partial class Home : System.Web.UI.Page
    {
        Player player1;
        Player player2;
        int playerTurn;
        int turnCount;
        string currentSelection;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                player1 = new Player();
                player2 = new Player();
                playerTurn = 1;
                turnCount = 0;
                SaveState();
                hoverButton();
            }
            if (IsPostBack)
            {
                player1 = Session["player1"] as Player;
                player2 = Session["player2"] as Player;
                turnCount = Convert.ToInt32(Session["turnCount"]);
                playerTurn = Convert.ToInt32(Session["playerTurn"]);
                currentSelection = Convert.ToString(Session["currentSelection"]);
            }
        }
        // ******** Void functions for homepage ******** \\ 
        #region Void Functions    
        public void SaveState()
        {
            Session["player1"] = player1;
            Session["player2"] = player2;
            Session["turnCount"] = turnCount;
            Session["playerTurn"] = playerTurn;
            Session["currentSelection"] = currentSelection;
        }
        public void hoverButton() // Any on hover elements
        {
            btnChooseTreecko.Attributes.Add("onmouseover", "this.src = 'Images/pokeballHighlight.png'");
            btnChooseTreecko.Attributes.Add("onmouseout", "this.src = 'Images/pokeball.png'");
            btnChoosePonyta.Attributes.Add("onmouseover", "this.src = 'Images/pokeballHighlight.png'");
            btnChoosePonyta.Attributes.Add("onmouseout", "this.src = 'Images/pokeball.png'");
            btnChooseSquirtle.Attributes.Add("onmouseover", "this.src = 'Images/pokeballHighlight.png'");
            btnChooseSquirtle.Attributes.Add("onmouseout", "this.src = 'Images/pokeball.png'");
            btnChooseGeodude.Attributes.Add("onmouseover", "this.src = 'Images/pokeballHighlight.png'");
            btnChooseGeodude.Attributes.Add("onmouseout", "this.src = 'Images/pokeball.png'");
            btnChoosePidgey.Attributes.Add("onmouseover", "this.src = 'Images/pokeballHighlight.png'");
            btnChoosePidgey.Attributes.Add("onmouseout", "this.src = 'Images/pokeball.png'");
            btnChooseOddish.Attributes.Add("onmouseover", "this.src = 'Images/pokeballHighlight.png'");
            btnChooseOddish.Attributes.Add("onmouseout", "this.src = 'Images/pokeball.png'");
            btnChooseBagon.Attributes.Add("onmouseover", "this.src = 'Images/pokeballHighlight.png'");
            btnChooseBagon.Attributes.Add("onmouseout", "this.src = 'Images/pokeball.png'");
            btnChooseDrifloon.Attributes.Add("onmouseover", "this.src = 'Images/pokeballHighlight.png'");
            btnChooseDrifloon.Attributes.Add("onmouseout", "this.src = 'Images/pokeball.png'");
            btnChooseTrapinch.Attributes.Add("onmouseover", "this.src = 'Images/pokeballHighlight.png'");
            btnChooseTrapinch.Attributes.Add("onmouseout", "this.src = 'Images/pokeball.png'");
            btnChooseSnorunt.Attributes.Add("onmouseover", "this.src = 'Images/pokeballHighlight.png'");
            btnChooseSnorunt.Attributes.Add("onmouseout", "this.src = 'Images/pokeball.png'");
            playButton.Attributes.Add("onmouseover", "this.src = 'Images/playbuttonHighlight.png'");
            playButton.Attributes.Add("onmouseout", "this.src = 'Images/playbutton.png'");
            yesButton.Attributes.Add("onmouseover", "this.src = 'Images/yesButtonHighlight.png'");
            yesButton.Attributes.Add("onmouseout", "this.src = 'Images/yesButton.png'");
            noButton.Attributes.Add("onmouseover", "this.src = 'Images/noButtonHighlight.png'");
            noButton.Attributes.Add("onmouseout", "this.src = 'Images/noButton.png'");
            startButton.Attributes.Add("onmouseover", "this.src = 'Images/startButtonHighlight.png'");
            startButton.Attributes.Add("onmouseout", "this.src = 'Images/startButton.png'");
        }

        public void changeGif()
        {

        }
        public void endTurn()
        {
            if (playerTurn == 1)
            {
                playerTurn++;
            }
            else
            {
                playerTurn--;
            }
            SaveState();
        }
        public void startGame()
        {
            Response.Redirect("Game.aspx");
        }
        #endregion
        // ******************** Click event handlers ***************** \\
        #region Click Handlers
        protected void playButton_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            playButton.Visible = false;
        }

        protected void btnChooseTreecko_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            currentSelection = "Treecko";
            SaveState();
        }

        protected void btnChoosePidgey_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            currentSelection = "Pidgey";
            SaveState();
        }
        protected void btnChooseSquirtle_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            currentSelection = "Squirtle";
            SaveState();
        }

        protected void btnChoosePonyta_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            currentSelection = "Ponyta";
            SaveState();
        }

        protected void btnChooseGeodude_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            currentSelection = "Geodude";
            SaveState();
        }

        protected void btnChooseOddish_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            currentSelection = "Oddish";
            SaveState();
        }

        protected void btnChooseBagon_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            currentSelection = "Bagon";
            SaveState();
        }

        protected void btnChooseDrifloon_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            currentSelection = "Drifloon";
            SaveState();
        }

        protected void btnChooseTrapinch_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            currentSelection = "Trapinch";
            SaveState();
        }

        protected void btnChooseSnorunt_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            currentSelection = "Snorunt";
            SaveState();
        }
        #endregion

        public void AddMonsterToTeam(int playerTurn)
        {
            if (playerTurn == 1)
            {
                player1.AddMonsterToTeam(currentSelection);
            }
            else if (playerTurn == 2)
            {
                player2.AddMonsterToTeam(currentSelection);
            }
        }
        
       

        protected void confirmYes_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            turnCount++;
            AddMonsterToTeam(playerTurn);
            if (turnCount == 3)
            {
                startGame();
            }
            SaveState();
            //endTurn();
        }

        protected void confirmNo_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            
        }

        protected void startButton_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {

        }
    }
}