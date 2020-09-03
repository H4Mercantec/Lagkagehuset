function addShopToDropdown(butik) {
    select = document.getElementById("butik");
    option = document.createElement("option");
    option.text = butik;
    select.add(option);
}