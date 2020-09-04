function addShopToDropdown(butik) {
    select = document.getElementById("butik");
    option = document.createElement("option");
    option.text = (butik == undefined) ? "" : butik;
    select.add(option);
}

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
    for (var i = 0; i < rolls.length; i++) {
        var optElm = document.getElementById(rolls[i]);
        if (optElm == undefined) continue;
        optElm.value = 0;
    }
} 

function loadApi()
{
    //url = "http://jsonplaceholder.typicode.com/users"; 
    url = "/shops?includeRollData=true";// todoo tilføj url til api
  var api = new XMLHttpRequest();
  api.open("GET", url, true);
      
  api.onerror = () => { addAllShops(); }
  api.onabort = () => { addAllShops(); }
  api.ontimeout = () => { addAllShops(); }
  api.onload = () => {
      try {
          apiArray = JSON.parse(api.response);
          window.apiArray = apiArray;
          addAllShops();
      } catch
      {addAllShops();}
  }
  api.send();
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