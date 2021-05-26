$(document).ready(function () {

    $("#TransPresentmentHeader").DataTable({
        ajax: {
            url: "/api/TransactionHeader/",
            method:"GET",
            dataSrc: ""
        },
        columns: [
            {
                data: "transHeadId",
            },
            {
                data: "fileNo"
            },
            {
                data: "date"
            },
            {
                data: "bankName"
            },
            {
                data: "isActive"
            },
            {
                data: "isDeleted"
            },
            {
                data: "createdOn"
            },
            {
                data: "presentmentHeaderNo"
            }
        ] 
    });

    $("#Submit").on("click",null,function () {
        $.ajax({
            url: "/api/TransactionHeader/",
            contentType: "application/json",
            method: "POST",
            data: JSON.stringify({
                date: $("#Date").val(),
                bankName: $("#BankName").val(),
                isActive: $("#IsActive").prop("checked"),
                isDeleted: $("#IsDeleted").prop("checked"),
                presentmentHeaderNo: $("#PresentmentHeaderNo").val()
            }),
            dataType:"json",
            success: function (result) {
                bootbox.alert("Data Saved Successfully");
            },
            error: function (result) {
                bootbox.alert("Data Saved Successfully");
            }
        });
    });

});
