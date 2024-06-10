

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
        url: 'https://localhost:7164/api/Currents/cari-listesi',
        type: 'GET',
        dataType: 'json',

        success: function (data) {
            debugger
            // Gelen verileri tabloya ekle
            $.each(data, function (index, item) {
                var html = '<tr>';
                html += '<td><span>' + item.id + '</span></td>';
                html += '<td> <h6>' + item.currentCode + '</h6><span>' + '</span></div></div></td>';
                html += '<td><span class="text-primary">' + item.name + '</span></td>';
                html += '<td><span class="text-primary">' + item.taxNo + '</span></td>';
                html += '</tr>';

                tableBody.append(html);
            });
        },
        error: function (xhr, status, error) {
            console.error('Hata:', error);
        }
    });
});