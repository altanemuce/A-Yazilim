$(document).ready(function () {
    // Kullanıcı ekleme formu gönderildiğinde
   

    // Dinamik olarak oluşturulan butonlar için silme işlemi
    $('#reports-tbl').on('click', '.btn-delete', function () {
        var userId = $(this).data('stock-id');

        // Silme işlemi öncesi kullanıcıdan onay alma
        Swal.fire({
            title: 'Emin misiniz?',
            text: 'Bu stoku silmek istediğinizden emin misiniz?',
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Evet, sil!',
            cancelButtonText: 'Hayır, iptal!'
        }).then((result) => {
            if (result.isConfirmed) {
                $.ajax({
                    type: 'POST',
                    url: `https://localhost:7164/api/Stocks/stok-sil/${userId}`,
                    success: function () {
                        // Silme işlemi başarılı olursa, satırı tablodan kaldır
                        $(`button[data-stock-id="${userId}"]`).closest('tr').remove();

                        Swal.fire(
                            'Silindi!',
                            'Kullanıcı başarıyla silindi.',
                            'success'
                        );
                    },
                    error: function (xhr, status, error) {
                        Swal.fire({
                            icon: 'error',
                            title: 'Silme Başarısız',
                            text: 'Silme işlemi sırasında bir hata oluştu',
                            confirmButtonText: 'Tamam'
                        });
                    }
                });
            }
        });
    });
});

//function updateUserTable(newUser) {
//    var newRow = '<tr>';
//    newRow += `<td><span>${newUser.id}</span></td>`;
//    newRow += `<td><div class="products"><img src="images/contacts/pic2.jpg" class="avatar avatar-md" alt=""><div><h6>${newUser.userName}</h6><span>${newUser.role}</span></div></div></td>`;
//    newRow += `<td><span>${newUser.department}</span></td>`;
//    newRow += `<td><span class="text-primary">${newUser.email}</span></td>`;
//    newRow += `<td><span>${newUser.phone}</span></td>`;
//    newRow += `<td><span>${newUser.gender}</span></td>`;
//    newRow += `<td><span>${newUser.location}</span></td>`;
//    newRow += `<td><span class="badge badge-success light border-0">${newUser.status}</span></td>`;
//    newRow += `<td><div class="d-flex"><button class="btn btn-danger shadow btn-xs sharp btn-delete" data-user-id="${newUser.id}"><i class="fa fa-trash"></i></button></div></td>`;
//    newRow += '</tr>';

//    // Yeni satırı listenin başına ekle
//    $('#userTable tbody').prepend(newRow);
//}
