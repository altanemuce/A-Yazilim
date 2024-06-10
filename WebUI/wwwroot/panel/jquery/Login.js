$(document).ready(function () {
    $('#login').submit(function (event) {
        event.preventDefault();

        var formData = {
            email: $('#email').val(),
            password: $('#password').val()
            // Diğer gerekli alanları buraya ekleyin

        };

        $.ajax({
            type: 'POST',
            async: true,
            url: 'https://localhost:7164/api/Auths/login',
            data: JSON.stringify(formData),
            contentType: 'application/json',
            success: function (data) {

                Swal.fire({
                    icon: 'success',
                    title: 'Giriş Başarılı',
                    text: 'Lütfen Bekleyiniz Panele Yönlendiriliyorsunuz',
                    showConfirmButton: false,
                    timer: 3000,
                    timerProgressBar: true,
                    didClose: () => {
                        window.location.href = '/login';
                    }
                });

            },
            error: function (xhr, status, error) {
                Swal.fire({
                    icon: 'error',
                    title: 'Giriş başarısız',
                    text: 'Giriş işlemi sırasında bir hata oluştu',
                    confirmButtonText: 'Tamam'
                })
            }
        });
    });
});