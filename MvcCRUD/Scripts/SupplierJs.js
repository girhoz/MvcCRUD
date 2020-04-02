$(document).ready(function () {
    $('#suppTable').dataTable({
        "ajax": LoadDataSupplier(),
        "responsive": true,
    });
    $('[data-toggle="tooltip"]').tooltip();
});

function LoadDataSupplier() {
    $.ajax({
        url: "/Supplier/List",
        type: "GET",
        contentType: "application/json;charset=utf-8",
        datatype: "json",
        success: function (result) {
            var html = '';
            $.each(resut, function (key, Supplier) {
                debugger;
                html += '<tr>';
                html += '<td>' + Supplier.Name + '</td>';
                html += '<td>' + Supplier.Address + '</td>';
                html += '<td>' + Supplier.Email + '</td>';
                html += '<td><button type ="button" class="btn btn warning" id="Update" onclick="return GetById(' + Supplier.Id + ')"Edit</button> ';
                html += '<td><button type ="button" class="btn btn danger" id="Update" onclick="return GetById(' + Supplier.Id + ')"Delete</button> ';
                html += '<tr>';
                html += '<tr>';
                html += '<tr>';
            });
            $('.suppbody').html(html);
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });

}