$(document).ready(function () {
    $('#addCurrent').submit(function (event) {
        event.preventDefault();
        debugger
        var formData = {
            currentCode: $('#currentCode').val(),
            name: $('#name').val(),
            taxNo: $('#taxNo').val(),
            street: $('#street').val(),
            city: $('#city').val(),
            state: $('#state').val(),
            postalCode: $('#postalCode').val()
           
            // Diğer gerekli alanları buraya ekleyin
        };

        $.ajax({

            type: 'POST',
            async: true,
            url: 'https://localhost:7164/api/Currents/cari-ekle',
            data: JSON.stringify(formData),
            contentType: 'application/json',
            success: function (data) {
                // Kullanıcı başarıyla eklendi, tabloyu yeniden oluştur
                updateUserTable(data);
                debugger
                Swal.fire({
                    icon: 'success',
                    title: 'Cari Başarılı Bir Şekilde Eklenmiştir',
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
    newRow += '<td><div class="products"><div><h6>' + newUser.currentCode + '</h6><span>' + '</span></div></div></td>';
    newRow += '<td><span class="text-primary">' + newUser.name + '</span></td>';
    newRow += '<td><span class="text-primary">' + newUser.taxNo + '</span></td>';
    newRow += '</tr>';

    // Yeni satırı listenin başına ekle
    $('#empoloyees-tblwrapper').prepend(newRow);
}
