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

function resetBasket() {
    for (var i = 0; i < rundstykkerImg.length; i++) {
        var optElm = document.getElementById(rundstykkerImg[i]);
        if (optElm == undefined) continue;
        optElm.value = 0;
    }
}




function placeOrder() {
    var order = generateOrder();
    var api = new XMLHttpRequest();
    api.open("POST", "/order", true);

    api.onload = () => {
        showOrderResponse(api.response);
    }
    api.send();
}

function generateOrder() {
    var rolls = [];
    var order = {
        "name": undefined,
        "address": undefined,
        "phone": undefined,
        "rolls": []
    };

    for (var i = 0; i < rundstykkerImg.length; i++) {
        var optRoll = document.getElementById(rundstykkerImg[i]);
        if (optRoll == undefined) continue;
        var amount = optRoll.value;
        if (amount > 0) {
            order.rolls.push({ "productID": i, "amount": amount });
        }
    }

    return order;
}


function showOrderResponse(data) {

    orderDiv = document.getElementById("orderDiv");
    var div = document.createElement("div");
    var divText = document.createTextNode(data);
    div.appendChild(divText);
    orderDiv.innerHTML = "";
    orderDiv.appendChild(div);


    var button = document.createElement("button");
    var buttonText = document.createTextNode("Click to reload");
    button.appendChild(buttonText);
    button.onclick = () => window.location.reload();
    orderDiv.appendChild(button);
}