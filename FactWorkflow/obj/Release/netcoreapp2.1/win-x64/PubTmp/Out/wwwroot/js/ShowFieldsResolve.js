"use strict";

document.addEventListener("DOMContentLoaded", function () {
    setRoles();
});

function showAdditionalFields() {
    let radioButton = document.getElementById("toDo");
    let date = document.getElementById("endDate");
    let responsible = document.getElementById("responsible");
    let text = document.getElementById("resolveText");

    if (radioButton.checked === true) {
        date.hidden = false;
        responsible.hidden = false;
        text.hidden = false;
    } else {
        date.hidden = true;
        responsible.hidden = true;
        text.hidden = true;
    }
}

function setRoles() {
    const rolesUrl = window.location.origin + "/Home/GetRoles";
    fetch(rolesUrl)
        .then(response => {
            return response.json();
        })
        .then(roles => {
            let roleSelect = document.getElementById("roleSelect");
            roles.forEach(role =>
                roleSelect.append(new Option(role.rAlterName, role.rId, false, false))
            );
            setUsers();
        })
        .catch(console.log);
}

function setUsers() {
    let selectedOption = getSelectedOption("roleSelect").value;
    const usersUrl = `${window.location.origin}/Home/GetUsers?id=${selectedOption}`;
    let cathedraUser = document.getElementById("cathedraUser");
    if (selectedOption == 7) {
        cathedraUser.hidden = false;
    }
    else {
        cathedraUser.hidden = true;
    }
    let userSelect = document.getElementById("userSelect");
    userSelect.innerHTML = "";
    fetch(usersUrl)
        .then(response => {
            return response.json();
        })
        .then(users => users.forEach(user => {
            userSelect.append(new Option(user.uName, user.uId, false, false));
        }
        ))
        .catch(console.log);
}

function getSelectedOption(selectId) {
    let selectedRole = document.getElementById(selectId);
    let selectedOption = selectedRole.options[selectedRole.selectedIndex];
    return selectedOption;
}
