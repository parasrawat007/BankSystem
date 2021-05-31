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
                data: "presentmentHeaderNo",
                render: function (data) {
                    return "<a href='#'>" + data + " </a>";
                }
            }
        ]
    });

    $("#Submit").click(function(){
        var data = {
            date: $("#Date").val(),
            bankName: $("#BankName").val(),
            isActive: $("#IsActive").prop("checked"),
            isDeleted: $("#IsDeleted").prop("checked"),
            presentmentHeaderNo: $("#PresentmentHeaderNo").val()
        };

        $.ajax({
            url: "/api/TransactionHeader/",
            method: "POST",
            data: JSON.stringify(data),
            contentType: "application/json",
            success: function () {
                bootbox.alert("Working", function () {
                    window.location.assign("/WebForm1.aspx");
                });
            },
            error: function () {
                bootbox.alert("Error Ocurred");
            }
        });
    });

});
