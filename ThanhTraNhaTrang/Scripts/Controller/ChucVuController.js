/// <reference path="HelperController.js" />

var ChucVuConfig = {
    searchString: '',
    pageSize: 10,
    pageIndex: 1,
}
var ChucVuMain = {
    init: function()
    {
        $(document).ready(function () {
            ChucVuMain.registerEventOnLoaded();
        });
    },
    registerEventOnLoaded: function()
    {
        $("#btnAdd").off('click').on('click', function () {
            $("#modalAddEdit").modal({ backdrop: 'static', keyboard: false });
            $("#lblTitle").text("Thêm chức vụ");
        });
    },
}
ChucVuMain.init();
