$(document).ready(function () {
    var playerTurn = 1;
    var currentSelection = "";
    var currentButton = "";
    $("#playButton").click(function () {
        $("#pokemonImages").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });;
    });
    $(document).on('click', '#btnChooseTreecko', function () {
        currentSelection = "#imgTreecko";
        currentButton = "#btnChooseTreecko";
        $("#divYesButton").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#divConfirmText").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#divNoButton").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#divChoosePanel").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#lblCardName").text("Treecko");
        $("#divCardName").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#cardGif").attr("src", "Images/treeckoBattle.png");
        $("#divCardGif").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#lblCardStats").text("Stats");
        $("#divCardStats").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#lblCardHealth").text("Health : 40" );
        $("#lblCardAttack").text("Attack : 4");
        $("#lblCardDefence").text("Defence :        4");
        $("#lblCardStamina").text("Stamina :        50");
    });
    $("#divNoButton").click(function () {
        $(".chooseItems").fadeTo(400, 0, function () {
            $(".chooseItems").css({ "visibility": "hidden" });
        });

    });
    $("#divYesButton").click(function () {
        $(".chooseItems").fadeTo(400, 0, function () {
            $(".chooseItems").css({ "visibility": "hidden" });
        });
        $(currentButton).fadeTo(400, 0, function () {
            $(currentButton).css({ "visibility": "hidden" });
        });
        $(currentSelection).fadeTo(400, 0, function () {
            $(currentSelection).css({ "visibility": "hidden" });
        });
        if (turnCount == 1)
        {


            turnCount++;
        }
        else
        {

            turnCount--;
        }



    });
    $(document).on('click', '#btnChoosePonyta',function () {
        currentSelection = "#imgPonyta";
        currentButton = "#btnChoosePonyta";
        $("#divYesButton").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#divConfirmText").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#divNoButton").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#divChoosePanel").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#lblCardName").text("Ponyta");
        $("#divCardName").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#cardGif").attr("src", "Images/ponytaBattle.png");
        $("#divCardGif").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#lblCardStats").text("Stats");
        $("#divCardStats").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#lblCardHealth").text("Health : 40");
        $("#lblCardAttack").text("Attack : 5");
        $("#lblCardDefence").text("Defence :        3");
        $("#lblCardStamina").text("Stamina :        50");
    });
    $(document).on('click', '#btnChooseSquirtle',function () {
        currentSelection = "#imgSquirtle";
        currentButton = "#btnChooseSquirtle";
        $("#divYesButton").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#divConfirmText").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#divNoButton").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#divChoosePanel").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#lblCardName").text("Squirtle");
        $("#divCardName").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#cardGif").attr("src", "Images/squirtleBattle.png");
        $("#divCardGif").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#lblCardStats").text("Stats");
        $("#divCardStats").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#lblCardHealth").text("Health : 50");
        $("#lblCardAttack").text("Attack : 4");
        $("#lblCardDefence").text("Defence :        3");
        $("#lblCardStamina").text("Stamina :        50");

    });
    $(document).on('click', '#btnChooseGeodude',function () {
        currentSelection = "#imgGeodude";
        currentButton = "#btnChooseGeodude";
        $("#divYesButton").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#divConfirmText").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#divNoButton").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#divChoosePanel").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#lblCardName").text("Geodude");
        $("#divCardName").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#cardGif").attr("src", "Images/geodudeBattle.png");
        $("#divCardGif").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#lblCardStats").text("Stats");
        $("#divCardStats").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#lblCardHealth").text("Health : 60");
        $("#lblCardAttack").text("Attack : 2");
        $("#lblCardDefence").text("Defence :        6");
        $("#lblCardStamina").text("Stamina :        50");
    });
    $(document).on('click','#btnChoosePidgey',function () {
        currentSelection = "#imgPidgey";
        currentButton = "#btnChoosePidgey";
        $("#divYesButton").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#divConfirmText").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#divNoButton").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#divChoosePanel").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#lblCardName").text("Pidgey");
        $("#divCardName").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#cardGif").attr("src", "Images/pidgeyBattle.png");
        $("#divCardGif").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#lblCardStats").text("Stats");
        $("#divCardStats").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#lblCardHealth").text("Health : 30");
        $("#lblCardAttack").text("Attack : 7");
        $("#lblCardDefence").text("Defence :        1");
        $("#lblCardStamina").text("Stamina :        50");

    });
    $(document).on('click','#btnChooseOddish',function () {
        currentSelection = "#imgOddish";
        currentButton = "#btnChooseOddish";
        $("#divYesButton").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#divConfirmText").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#divNoButton").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#divChoosePanel").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#lblCardName").text("Oddish");
        $("#divCardName").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#cardGif").attr("src", "Images/oddishBattle.png");
        $("#divCardGif").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#lblCardStats").text("Stats");
        $("#divCardStats").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#lblCardHealth").text("Health : 50");
        $("#lblCardAttack").text("Attack : 3");
        $("#lblCardDefence").text("Defence :        5");
        $("#lblCardStamina").text("Stamina :        50");
    });
    $(document).on('click','#btnChooseBagon',function () {
        currentSelection = "#imgBagon";
        currentButton = "#btnChooseBagon";
        $("#divYesButton").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#divConfirmText").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#divNoButton").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#divChoosePanel").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#lblCardName").text("Bagon");
        $("#divCardName").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#cardGif").attr("src", "Images/bagonBattle.png");
        $("#divCardGif").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#lblCardStats").text("Stats");
        $("#divCardStats").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#lblCardHealth").text("Health : 30");
        $("#lblCardAttack").text("Attack : 3");
        $("#lblCardDefence").text("Defence :        6");
        $("#lblCardStamina").text("Stamina :        50");
    });
    $(document).on('click','#btnChooseDrifloon',function () {
        currentSelection = "#imgDrifloon";
        currentButton = "#btnChooseDrifoon";
        $("#divYesButton").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#divConfirmText").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#divNoButton").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#divChoosePanel").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#lblCardName").text("Drifloon");
        $("#divCardName").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#cardGif").attr("src", "Images/drifloonBattle.png");
        $("#divCardGif").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#lblCardStats").text("Stats");
        $("#divCardStats").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#lblCardHealth").text("Health : 30");
        $("#lblCardAttack").text("Attack : 6");
        $("#lblCardDefence").text("Defence :        6");
        $("#lblCardStamina").text("Stamina :        50");
    });
    $(document).on('click','#btnChooseTrapinch',function () {
        currentSelection = "#imgTrapinch";
        currentButton = "#btnChooseTrapinch";
        $("#divYesButton").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#divConfirmText").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#divNoButton").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#divChoosePanel").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#lblCardName").text("Trapinch");
        $("#divCardName").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#cardGif").attr("src", "Images/trapinchBattle.png");
        $("#divCardGif").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#lblCardStats").text("Stats");
        $("#divCardStats").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#lblCardHealth").text("Health : 40");
        $("#lblCardAttack").text("Attack : 3");
        $("#lblCardDefence").text("Defence :        6");
        $("#lblCardStamina").text("Stamina :        50");
    });
    $(document).on('click','#btnChooseSnorunt',function () {
        currentSelection = "#imgSnorunt";
        currentButton = "#btnChooseSnorunt";
        $("#divYesButton").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#divConfirmText").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#divNoButton").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#divChoosePanel").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#lblCardName").text("Snorunt");
        $("#divCardName").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#cardGif").attr("src", "Images/snoruntBattle.png");
        $("#divCardGif").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#lblCardStats").text("Stats");
        $("#divCardStats").css({ opacity: 0.0, visibility: "visible" }).animate({ opacity: 1.0 });
        $("#lblCardHealth").text("Health : 70");
        $("#lblCardAttack").text("Attack : 1");
        $("#lblCardDefence").text("Defence :        8");
        $("#lblCardStamina").text("Stamina :        50");
    });

});


