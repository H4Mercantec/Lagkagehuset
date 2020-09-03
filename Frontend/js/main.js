function addShopToDropdown(butik) {
    select = document.getElementById("butik");
    option = document.createElement("option");
    option.text = (butik == undefined) ? "": butik;
    select.add(option);
}

function switchStore(e, elm) {
    console.log(e);
    console.log(elm);
}