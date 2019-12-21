"use strict";
document.addEventListener("DOMContentLoaded", function () {
});
function openModal(element) {
    let wrapper = document.getElementById("modalWrapper");
    let button = document.getElementById("deleteButton");

    button.setAttribute("href", button.href.substring(0, button.href.lastIndexOf("/") + 1) + element.id);
    wrapper.style.display = "block";
}
