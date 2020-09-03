function addShopToDropdown(butik) {
    select = document.getElementById("butik");
    option = document.createElement("option");
    option.text = (butik == undefined) ? "": butik;
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