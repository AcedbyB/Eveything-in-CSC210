let theme_choice = 1;

$("#theme-kitchen").click(function() {
    if (theme_choice == 1) return;
    theme_choice = 1;
    $("#censor-kitchen").attr("hidden", true);
    $("#censor-space").removeAttr("hidden");
    $("#theme-kitchen").addClass("choosed");
    $("#theme-space").removeClass("choosed");
});

$("#theme-space").click(function() {
    if (theme_choice == 2) return;
    theme_choice = 2;
    $("#censor-kitchen").removeAttr("hidden");
    $("#censor-space").attr("hidden", true);
    console.log("lol");
    $("#theme-kitchen").removeClass("choosed");
    $("#theme-space").addClass("choosed");
});