$(document).ready(function () {
    $('#addStock').submit(function (event) {
        event.preventDefault();
        debugger
        var formData = {
            stockCode: $('#stockCode').val(),
            name: $('#name').val(),
            type: $('#type').val(),
            price: $('#price').val()
          

            // Diğer gerekli alanları buraya ekleyin
        };

        $.ajax({

            type: 'POST',
            async: true,
            url: 'https://localhost:7164/api/Stocks/stok-ekle',
            data: JSON.stringify(formData),
            contentType: 'application/json',
            success: function (data) {
                // Kullanıcı başarıyla eklendi, tabloyu yeniden oluştur
                updateUserTable(data);
                debugger
                Swal.fire({
                    icon: 'success',
                    title: 'Stok Başarılı Bir Şekilde Eklenmiştir',
                    showConfirmButton: false,
                    timer: 3000,
                    timerProgressBar: true
                });
            },
            error: function (xhr, status, error) {
                Swal.fire({
                    icon: 'error',
                    title: 'Ekleme Başarısız',
                    text: 'Ekleme işlemi sırasında bir hata oluştu',
                    confirmButtonText: 'Tamam'
                });
            }
        });
    });
});

function updateUserTable(newUser) {
    var newRow = '<tr>';
    newRow += '<td><span>' + newUser.id + '</span></td>';
    newRow += '<td><div><h6>' + newUser.stockCode + '</h6><span>' + '</span></div></td>';
    newRow += '<td><span class="text-primary">' + newUser.name + '</span></td>';
    newRow += '<td><span class="text-primary">' + newUser.type + '</span></td>';
    newRow += `<td><div class="d-flex"><button class="btn btn-danger shadow btn-xs sharp btn-delete" data-about-id="${newUser.id}"><i class="fa fa-trash"></i></button></div></td>`;
    newRow += '</tr>';

    // Yeni satırı listenin başına ekle
    $('#addStock').prepend(newRow);
}
