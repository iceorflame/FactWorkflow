"use strict";

function showAdditionalFields() {
    // Get the checkbox
    var radioButton = document.getElementById("toDo");
    // Get the output text
    var date = document.getElementById("endDate");

    var responsible = document.getElementById("responsible");

    // If the checkbox is checked, display the output text
    if (radioButton.checked == true) {
        date.hidden = false;
        responsible.hidden = false;
    } else {
        date.hidden = true;
        responsible.hidden = true;
    }
}