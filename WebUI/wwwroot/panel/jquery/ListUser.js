

$(document).ready(function () {

    var loader = $('#loader');
    var tableBody = $('#empoloyees-tblwrapper');

    // AJAX isteği başlamadan önce loader'ı göster
    $(document).ajaxStart(function () {
        loader.show();
    });

    // AJAX isteği tamamlandığında loader'ı gizle
    $(document).ajaxStop(function () {
        loader.hide();
    });
    $.ajax({
        url: 'https://localhost:7164/api/Users/list-user',
        type: 'GET',
        dataType: 'json',
        
        success: function (data) {
            debugger
            // Gelen verileri tabloya ekle
            $.each(data, function (index, item) {
                var html = '<tr>';
                html += '<td><span>' + item.id + '</span></td>';
                html += '<td><div class="products"> <div><h6>' + item.userName + '</h6><span>' +   '</span></div></div></td>';         
                html += '<td><span class="text-primary">' + item.email + '</span></td>';
                html += '</tr>';

                tableBody.append(html);
            });
        },
        error: function (xhr, status, error) {
            console.error('Hata:', error);
        }
    });
});