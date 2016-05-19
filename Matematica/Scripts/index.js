
$("#btnMath").click(function () {
    $.ajax({
        url: 'api/operation',
        type: 'GET',
        data: {
            v1: Number($('#v1').val()),
            v2: Number($('#v2').val()),
            op: $('#op').val() || 'p'
        },
        dataType: 'json',
        success: function (res) {
            alert(res.result)
        }
    });
});