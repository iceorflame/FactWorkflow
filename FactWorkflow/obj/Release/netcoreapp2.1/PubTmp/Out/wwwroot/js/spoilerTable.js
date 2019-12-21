//"use strict";
//document.addEventListener("DOMContentLoaded", function () {
//});
$(document).ready(function () {
    var table = $('#documentTable').DataTable({
        "columnDefs": [{ orderable: false, targets: [0, 6, 7] }],
        "order": [[1, "desc"]],
        "language": {
            "url": "//cdn.datatables.net/plug-ins/1.10.19/i18n/Ukrainian.json"
        }
    });

        $('#documentTable tbody').on('click', 'td.details-control', async function () {
            var tr = $(this).closest('tr');
            console.log(tr);
            var row = table.row(tr);
            let data = await getChildData(tr[0].id);
            console.log(data);

            if (row.child.isShown()) {
                row.child.hide();
                tr.removeClass('shown');
            }
            else {
                row.child(format(data)).show();
                tr.addClass('shown');
            }
        });
});

function getChildData(id) {
    const tableUrl = window.location.origin + `/Home/GetChildData?did=${id}`;
    return fetch(tableUrl)
        .then(response => {
            console.log(response.headers);
            return response.json();
        })
        .then(body => {
            return body;
        })
        .catch(console.error);
};

function format(d) {
    if (d.length) {
        return `<table width="100%" class="table table-bordered">
                 ${tableRows(d)}   
                </table>`;

    }
    else {
        return `<table width="100%" class="table table-bordered">
                    <tr>
                        <td align="center">Резолюція відсутня</td>
                    </tr>
                </table>`;
    }

}

function tableRows(histories) {
    let body = "";
    let type = "";
    let date = "";
    let responsible = "";
    let original = "";
    let button = "";
    histories.forEach(h => {
        if (h.tId == 1) {
            type = "На ознайомлення";
        } else {
            type = "На виконання";
        }

        if (h.hDate != null) {
            date = new Date(h.hDate).toLocaleDateString();
        } else {
            date = "-";
        }

        if (h.hResponsible) {
            responsible = "Відповідальний";
        } else {
            responsible = "Не відповідальний";
        }

        if (h.hOriginal) {
            original = "Має оригінал";
        } else {
            original = "Не має оригінал";
        }

        if (h.aId) {
            button = `<button type="button" data-toggle="modal" class="btn btn-link" value=${h.aId} onclick="openAnswerModal(this)" href="#answerModal">Звіт</button>`;
        } else {
            button = "";
        }

        body += `<tr>
                    <td width="20%">${h.userOut.uName}</td>
                    <td width="13%">${type}</td>
                    <td width="20%">${h.hAddress}</td>
                    <td width="6%">${date}</td>
                    <td width="13%">${responsible}</td>
                    <td width="12%">${original}</td>
                    <td width="12%">${h.status.sName}</td>
                    <td style="text-align: center; width: 4%">${button}</td>
                 </tr>`;
    });
    return body;
}

async function openAnswerModal(element){
    const { value } = element;
    const answerUrl = window.location.origin + `/Home/GetAnswer?aid=${value}`;

    let answer = await fetch(answerUrl)
        .then(response => response.json());
    console.log(answer);
    let modal = document.getElementById("aModal");
    let body = document.getElementById("aBody").append(`${answer.aText}`);
    var btn = document.createElement("a");
    btn.innerHTML = answer.file.fName;
    btn.setAttribute("href", `/Home/Download/${answer.file.fId}`);
    let footer = document.getElementById("aFooter").appendChild(btn);
    modal.style.display ="block";
}