<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="CardGame.Home" %>

<!DOCTYPE html>
<link href="Styles.css" rel="stylesheet" type="text/css" runat="server" />
<html xmlns="http://www.w3.org/1999/xhtml" style="overflow-x: hidden; overflow-y: hidden">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager EnablePartialRendering="true"
            ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <div id="divPlayButton">
            <asp:UpdatePanel ID="UpdatePanel" runat="server"
                UpdateMode="Conditional">
                <ContentTemplate>
                    <asp:ImageButton ID="playButton" runat="server" ImageUrl="~/Images/playbutton.png" OnClick="playButton_Click" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
        <div id="divStartButton" style="visibility: hidden">
            <asp:UpdatePanel ID="UpdatePanel2" runat="server"
                UpdateMode="Conditional">
                <ContentTemplate>
                    <asp:ImageButton ID="startButton" runat="server" ImageUrl="~/Images/startButton.png" OnClick="startButton_Click" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
        <div class="chooseItems" id="divYesButton" style="visibility: hidden">
            <asp:UpdatePanel ID="UpdatePanel1" runat="server"
                UpdateMode="Conditional">
                <ContentTemplate>
                    <asp:ImageButton ID="yesButton" runat="server" ImageUrl="~/Images/yesButton.png" OnClick="confirmYes_Click" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
        <div class="chooseItems" id="divConfirmText" style="visibility: hidden">
            <asp:Image ID="confirmText" runat="server" ImageUrl="~/Images/confirmText.png" />
        </div>
        <div class="chooseItems" id="divNoButton" style="visibility: hidden">
            <asp:UpdatePanel ID="UpdatePanel3" runat="server"
                UpdateMode="Conditional">
                <ContentTemplate>
                    <asp:ImageButton ID="noButton" runat="server" ImageUrl="~/Images/noButton.png" OnClick="confirmNo_Click" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
        <div class="chooseItems" id="divChoosePanel" style="visibility: hidden">
            <asp:Image ID="cardTemplate" runat="server" ImageUrl="~/Images/cardTemplate.png" Height="520px" Width="340px" />
        </div>
        <div class="chooseItems" id="divCardName" style="visibility: hidden">
            <asp:UpdatePanel ID="UpdatePanel4" runat="server"
                UpdateMode="Conditional">
                <ContentTemplate>
                    <asp:Label class="lblText" ID="lblCardName" runat="server" Text="Label"></asp:Label>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
        <div class="chooseItems" id="divCardStats" style="visibility: hidden">
            <asp:UpdatePanel ID="UpdatePanel6" runat="server"
                UpdateMode="Conditional">
                <ContentTemplate>
                    <asp:Label class="lblText" ID="lblCardStats" runat="server" Text="Label"></asp:Label>
                    <asp:Label class="lblText" ID="lblCardHealth" runat="server" Text="Label"></asp:Label>
                    <asp:Label class="lblText" ID="lblCardAttack" runat="server" Text="Label"></asp:Label>
                    <asp:Label class="lblText" ID="lblCardDefence" runat="server" Text="Label"></asp:Label>
                    <asp:Label class="lblText" ID="lblCardStamina" runat="server" Text="Label"></asp:Label>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
        <div class="chooseItems" id="divCardGif" style="visibility: hidden">
            <asp:UpdatePanel ID="UpdatePanel5" runat="server"
                UpdateMode="Conditional">
                <ContentTemplate>
                    <asp:Image ID="cardGif" runat="server" Height ="150" Width ="150" ImageUrl="~/Images/snoruntBattle.png" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>

        <div class="flex-container" id="pokemonImages" style="visibility: hidden">
            <div id="panelTreecko">
                <asp:Image ID="imgTreecko" runat="server" Height="160px" ImageUrl="~/Images/Treecko.png" Width="130px" />
                <asp:UpdatePanel ID="UpdatePanelTreeckoBtn" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                        <asp:ImageButton class="chooseButton" ID="btnChooseTreecko" runat="server" ImageUrl="~/Images/pokeball.png" OnClick="btnChooseTreecko_Click" />
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
            <div id="panelPonyta">
                <asp:Image ID="imgPonyta" runat="server" Height="170px" ImageUrl="~/Images/Ponyta.png" Width="180px" />
                <asp:UpdatePanel ID="UpdatePanelPonytaBtn" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                        <asp:ImageButton class="chooseButton" ID="btnChoosePonyta" runat="server" ImageUrl="~/Images/pokeball.png" OnClick="btnChoosePonyta_Click" />
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
            <div id="panelSquirtle">
                <asp:Image ID="imgSquirtle" runat="server" Height="160px" ImageUrl="~/Images/Squirtle.png" Width="150px" />
                <asp:UpdatePanel ID="UpdatePanelSquirtleBtn" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="true">
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="btnChooseSquirtle" EventName="Click" />
                    </Triggers>
                    <ContentTemplate>
                        <asp:ImageButton class="chooseButton" ID="btnChooseSquirtle" runat="server" ImageUrl="~/Images/pokeball.png" OnClick="btnChooseSquirtle_Click" />
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
            <div id="panelGeodude">
                <asp:Image ID="imgGeodude" runat="server" Height="190px" ImageUrl="~/Images/Geodude.png" Width="190px" />
                <asp:UpdatePanel ID="UpdatePanelGeodudeBtn" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                        <asp:ImageButton class="chooseButton" ID="btnChooseGeodude" runat="server" ImageUrl="~/Images/pokeball.png" OnClick="btnChooseGeodude_Click" />
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
            <div id="panelPidgey">
                <asp:Image ID="imgPidgey" runat="server" Height="160px" ImageUrl="~/Images/Pidgey.png" Width="180px" />
                <asp:UpdatePanel ID="UpdatePanelPidgeyBtn" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                        <asp:ImageButton class="chooseButton" ID="btnChoosePidgey" runat="server" ImageUrl="~/Images/pokeball.png" OnClick="btnChoosePidgey_Click" />
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
            <div id="panelOddish">
                <asp:Image ID="imgOddish" runat="server" Height="160px" ImageUrl="~/Images/Oddish.png" Width="160px" />
                <asp:UpdatePanel ID="UpdatePanelOddishBtn" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                        <asp:ImageButton class="chooseButton" ID="btnChooseOddish" runat="server" ImageUrl="~/Images/pokeball.png" OnClick="btnChooseOddish_Click" />
                    </ContentTemplate>
                </asp:UpdatePanel>

            </div>
            <div id="panelBagon">
                <asp:Image ID="imgBagon" runat="server" Height="160px" ImageUrl="~/Images/Bagon.png" Width="140px" />
                <asp:UpdatePanel ID="UpdatePanelBagonBtn" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                        <asp:ImageButton class="chooseButton" ID="btnChooseBagon" runat="server" ImageUrl="~/Images/pokeball.png" OnClick="btnChooseBagon_Click" />
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
            <div id="panelDrifloon">
                <asp:Image ID="imgDrifloon" runat="server" Height="160px" ImageUrl="~/Images/Drifloon.png" Width="160px" />
                <asp:UpdatePanel ID="UpdatePanelDrifloonBtn" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                        <asp:ImageButton class="chooseButton" ID="btnChooseDrifloon" runat="server" ImageUrl="~/Images/pokeball.png" OnClick="btnChooseDrifloon_Click" />
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
            <div id="panelTrapinch">
                <asp:Image ID="imgTrapinch" runat="server" Height="160px" ImageUrl="~/Images/Trapinch.png" Width="180px" />
                <asp:UpdatePanel ID="UpdatePanelTrapinchBtn" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                        <asp:ImageButton class="chooseButton" ID="btnChooseTrapinch" runat="server" ImageUrl="~/Images/pokeball.png" OnClick="btnChooseTrapinch_Click" />
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
            <div id="panelSnorunt">
                <asp:Image ID="imgSnorunt" runat="server" Height="160px" ImageUrl="~/Images/Snorunt.png" Width="170px" />
                <asp:UpdatePanel ID="UpdatePanelSnoruntBtn" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                        <asp:ImageButton class="chooseButton" ID="btnChooseSnorunt" runat="server" ImageUrl="~/Images/pokeball.png" OnClick="btnChooseSnorunt_Click" />
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>

        </div>

    </form>

    <script src="jquery-3.4.1.min.js"></script>
    <script src="scripts.js"></script>
</body>
</html>
