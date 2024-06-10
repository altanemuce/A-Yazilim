$(document).ready(function () {
    $('#addUser').submit(function (event) {
        event.preventDefault();
        debugger
        var formData = {
            userName: $('#userName').val(),
            email: $('#email').val(),
            password: $('#password').val()
            // Diğer gerekli alanları buraya ekleyin
        };

        $.ajax({
            
            type: 'POST',
            async: true,
            url: 'https://localhost:7164/api/Auths/register',
            data: JSON.stringify(formData),
            contentType: 'application/json',
            success: function (data) {
                // Kullanıcı başarıyla eklendi, tabloyu yeniden oluştur
                updateUserTable(data);
                debugger
                Swal.fire({
                    icon: 'success',
                    title: 'Kullanıcı Başarılı Bir Şekilde Eklenmiştir',
                    text: 'Bu kullanıcı artık sisteme giriş yapabilir',
                    showConfirmButton: false,
                    timer: 3000,
                    timerProgressBar: true
                });
            },
            error: function (xhr, status, error) {
                Swal.fire({
                    icon: 'error',
                    title: 'Kayıt Başarısız',
                    text: 'Kayıt işlemi sırasında bir hata oluştu',
                    confirmButtonText: 'Tamam'
                });
            }
        });
    });
});

function updateUserTable(newUser) {
    var newRow = '<tr>';
    newRow += '<td><span>' + newUser.id + '</span></td>';
    newRow += '<td><div class="products"><div><h6>' + newUser.userName + '</h6><span>' +  '</span></div></div></td>';  
    newRow += '<td><span class="text-primary">' + newUser.email + '</span></td>';
    newRow += '</tr>';

    // Yeni satırı listenin başına ekle
    $('#empoloyees-tblwrapper').prepend(newRow);
}
