var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#myTable').DataTable({
        "ajax": '/admin/product/getall',
        "columns": [
            { data: "title", "width": "20%" },
            { data: "isbn", "width": "10%" },
            { data: "author", "width": "15%" },
            { data: "price", "width": "5%" },
            { data: "category.name", "width": "10%" },
            {
                data: "id",
                "render": function (data) {
                    return `<div class="d-flex gap-2">

                            <a href="/admin/product/upsert/${data}"
                                class="btn btn-sm btn-outline-primary">

                                <i class="bi bi-pencil-square"></i>
                            </a>

                            <a onClick=Delete('/admin/product/deleteEP/${data}')
                                class="btn btn-sm btn-outline-danger">

                                <i class="bi bi-trash"></i>
                            </a>

                            </div>`
                },
                "width": "30%"
            },
        ]
    });
}

function Delete(url) {
    Swal.fire({
        title: "Are you sure?",
        text: "You won't be able to revert this!",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "Yes, delete it!"
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: "DELETE",
                success: function (data) {
                    dataTable.ajax.reload();
                    toastr.success(data.message);
                }
            })

        };
    });
}
