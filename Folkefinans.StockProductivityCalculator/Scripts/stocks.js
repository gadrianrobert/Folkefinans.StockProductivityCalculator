function DisplayProductivity(stock) {
    $.ajax({
        type: "post",
        url: "/ajaxhandler?action=getproductivity&stock=" + stock,
        dataType: "html",
        success: function (content) {
            $("#productivityContainer").html(content);
        }
    });
};

$(function () {
    $("table tbody tr").click(function () {
        var stock = $(this).closest('tr').children('td:first').text();
        DisplayProductivity(stock);
    });
});