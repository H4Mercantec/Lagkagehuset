window.onload = () => {
    var select = document.getElementById("butik");

    var shops = ["Amager - Strand", "Amager - Amagerbrogade", "Amager - Vermlandsgade", "Bagsværd - Meny", "Billund Lufthavn"];
    shops.forEach(shop => {   
        var option = document.createElement("option"); 
        option.text = shop;        
        select.add(option);
    });
}

var rolls = ['almrundstykker', 'fransk-horn','giffel','handvaerker','kernebidder','majsstykke','sostjerne','trekorns'];
var html = "";

for (i = 0; i < rolls.length; i++)
{
html += "<p>" + rolls[i].toUpperCase() + "</p>"
html += "<div class='rollSection'>";
html +=   "<div class='seperation'>";
html +=     "<img src='img/" + rolls[i] + ".jpg'>";
html +=     "<div>";
html +=       "<div class='countAdjust'> + </div>";
html +=       "<div class='countAdjust'> - </div>";
html +=     "</div>";
html +=   "</div>";
html +=   "<input class='count' type='number' id='" + rolls[i] + "' name='" + rolls[i] +"' value='0'>";
html += "</div>";
}

document.getElementById("oversigt").innerHTML = html;

function switchStore(elm) {
    if (elm.value == "") makeOversigt(undefined);
    var selectedStore = undefined;
    for (i = 0; i < apiArray.length; i++) {
        var combinedName = apiArray[i].city + " - " + apiArray[i].address
        if (combinedName == elm.value) {
            selectedStore = apiArray[i];
            break;
        }
    }
    currentStore = selectedStore;
    makeOversigt(selectedStore);
}