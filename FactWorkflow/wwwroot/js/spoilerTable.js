$(document).ready(function () {
    var table = $('#documentTable').DataTable({
        "columnDefs": [{ orderable: false, targets: [0, 6, 7] }],
        "order": [[1, "desc"]],
        "language": {
            "url": "//cdn.datatables.net/plug-ins/1.10.19/i18n/Ukrainian.json"
        }
    });
    //getTableData().then(data => {
        //console.log(data);
        //var table = $('#documentTable').DataTable({
        //    "columnDefs": [{ orderable: false, targets: [0, 6, 7] }],
        //    "order": [[1, "desc"]],
        //    "language": {
        //        "url": "//cdn.datatables.net/plug-ins/1.10.19/i18n/Ukrainian.json"
        //    },
        //    "data": data,
        //    "columns": [
        //    {
        //        "className": 'details-control',
        //        "orderable": false,
        //        "data": null,
        //        "defaultContent": '',
        //            "render": function (data, type, row, meta) {

        //            return '<i class="fa fa-chevron-down"></i>';
        //        }
        //    },
        //    { "data": "dId" },
        //    { "data": "dIndex" },
        //        {
        //            "data": "dDate",
        //            "render": function (data, type, row, meta) {
        //                return new Date(data).toLocaleDateString();
        //            }
        //        },
        //    { "data": "dFrom" },
        //    { "data": "dAbout" },
        //        {
        //            "data": "file",
        //            "orderable": false,
        //            "defaultContent": '',
        //            "render": function (data, type, row, meta) {
        //                return '<a href="/Home/Download/' + data.fId + '">' + data.fName+'</a>';
        //            }
        //        },
        //        {
        //            "data": "dId",
        //            "render": function (data, type, row, meta) {
        //                return `<div class="btn-group-vertical">
        //                                        <div class="btn-group">
        //                                            <button type="button" class="btn btn-link dropdown-toggle" data-toggle="dropdown" style="text-decoration: none;">
        //                                                Керування
        //                                            </button>
        //                                            <div class="dropdown-menu">
        //                                                <a class="dropdown-item" href="/Home/SendResolve?did=${data}">Написати резолюцію</a>
        //                                                <a class="dropdown-item" href="/Home/SendResolve?did=${data}">Видалити документ</a>
        //                                                <!-- <a class="dropdown-item">Назва 1</a> -->
        //                                            </div>
        //                                        </div>
        //                                    </div>`;
        //            }
        //        }
        //    ]
        //});

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
    //});
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
    //console.log(d);
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

        body += `<tr>
                    <td>${h.userOut.uName}</td>
                    <td>${type}</td>
                    <td>${h.hAddress}</td>
                    <td>${date}</td>
                    <td>${responsible}</td>
                    <td>${original}</td>
                    <td>${h.status.sName}</td>
                 </tr>`;
    });
    return body;
}

//<tr>
//    <td>${h.userOut.uName}</td>
//    <td>${h.tId}</td>
//    <td>${h.user.uName}</td>
//    <td>${h.hAddress}</td>
//    <td>${h.hDate}</td>
//    <td>${h.hResponsible}</td>
//    <td>${h.hOriginal}</td>
//    <td>${h.sId}</td>
//</tr>