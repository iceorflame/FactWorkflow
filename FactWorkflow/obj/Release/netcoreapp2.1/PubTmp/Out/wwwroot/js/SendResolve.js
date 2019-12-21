"use strict";

var array = [];
var docId;
var rad;

document.addEventListener("DOMContentLoaded", function () {
    //docId = document.getElementById("DId").val;
    rad = $("#raddress").val();
    $("#cathedraUser").hide();
    $.ajax({
        type: "get",
        url: "/Home/GetRoles",
        success: function (data) {
            for (var i = 0; i < data.length; i++) {
                $("#roleSelect").append(new Option(data[i].rAlterName, data[i].rId, false, false));
            }
            getUsers();
        },
        error: function (data) { alert("ALERT") },
    });
});

function getUsers() {
    $("#userSelect").empty();
    var selectedRole = $("#roleSelect option:selected").val();
    if (selectedRole == 7) {
        $("#cathedraUser").show();
    }
    else {
        $("#cathedraUser").hide();
    }
    $.ajax({
        type: "get",
        data: {
            "id": selectedRole
        },
        url: "/Home/GetUsers",
        success: function (data) {
            for (var i = 0; i < data.length; i++) {
                $("#userSelect").append(new Option(data[i].uName, data[i].uId, false, false));
            }
        },
        error: function (data) { alert("ALERT") },
    });
}

function addResolution() {
    var selectedRole = $("#roleSelect option:selected").val();
    var id = $("#userSelect option:selected").val();
    var name;
    if (selectedRole == 7) {
        name = $("#uzver").val();
    }
    else {
        name = $("#userSelect option:selected").text();
    }
    var user = {
        "UId": id,
        "UName": name
    };
    var exists = false;
    for (var i = 0; i < array.length; i++) {
        if (array[i].name == name)
            exists = true;
    }
    if (!exists) {
        $("#arrUsers").find("> tbody:last-child").append("<tr><td>" + name + "</td><td><button id=" + name + " class=deleteButton type=button>Видалити</button></td></tr>");
        array.push(user);
    }
}

$("#arrUsers").on("click", ".deleteButton", function () {
    var deleteid = $(this).attr("id");
    $(this).closest("tr").remove();
    for (var i = 0; i < array.length; i++) {
        if (array[i].name === deleteid) {
            var dno = array.splice(i, 1);
            if (dno.length > 0)
                i--;
        }
    }
    console.log(array);
});

function getQueryVariable(variable) {
    var query = window.location.search.substring(1);
    var vars = query.split('&');
    for (var i = 0; i < vars.length; i++) {
        var pair = vars[i].split('=');
        if (decodeURIComponent(pair[0]) == variable) {
            return decodeURIComponent(pair[1]);
        }
    }
    console.log('Query variable %s not found', variable);
}

function submit() {

    $.ajax({
        type: "POST",
        url: "/Home/SendResolve",
        data: {
            "docid": document.getElementById("DId").value,
            "ra": rad,
            "users": array
        },
        success: function () {
            window.location = "DocumentTable";
        },
        error: function () {

        },
    });

    //let data = {
    //    "docid": document.getElementById("DId").value,
    //    "ra": rad,
    //    "users": array
    //};

    //let options = {
    //    method: "POST",
    //    headers: {
    //        "Content-Type": "application/json"
    //    },
    //    credentials: "same-origin",
    //    body: JSON.stringify(data) 
    //};
    //fetch("/Home/SendResolve", options)
    //    .then(response => {
    //        if (response.status === 200) {
    //            window.location = "DocumentTable";
    //        }
    //        else {
    //            console.log(response);
    //        }
    //    })
    //    .catch(error => console.log(error));
}