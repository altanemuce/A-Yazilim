

$(document).ready(function () {

    var loader = $('#loader');
    var tableBody = $('#reports-tbl');

    // AJAX isteği başlamadan önce loader'ı göster
    $(document).ajaxStart(function () {
        loader.show();
    });

    // AJAX isteği tamamlandığında loader'ı gizle
    $(document).ajaxStop(function () {
        loader.hide();
    });
    $.ajax({
        url: 'https://localhost:7164/api/Stocks/stok-listesi',
        type: 'GET',
        dataType: 'json',

        success: function (data) {
            debugger
            // Gelen verileri tabloya ekle
            $.each(data, function (index, item) {
                var html = '<tr>';
                html += '<td><span>' + item.id + '</span></td>';
                html += '<td> <h6>' + item.stockCode + '</h6><span>' + '</span></div></div></td>';
                html += '<td><span class="text-primary">' + item.name + '</span></td>';
                html += '<td><span class="text-primary">' + item.type + '</span></td>';
                html += `<td><div class="d-flex"><button class="btn btn-danger shadow btn-xs sharp btn-delete" data-stock-id="${item.id}"><i class="fa fa-trash"></i></button></div></td>`;
                html += '</tr>';

                tableBody.append(html);
            });
        },
        error: function (xhr, status, error) {
            console.error('Hata:', error);
        }
    });
});