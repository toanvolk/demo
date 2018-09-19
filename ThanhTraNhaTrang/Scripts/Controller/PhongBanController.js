/// <reference path="HelperController.js" />

var PhongBanConfig = {
    searchString: '',
    pageSize: 10,
    pageIndex: 1,
}
var PhongBanMain = {
    init: function()
    {
        $(document).ready(function () {
            PhongBanMain.registerEventOnLoaded();
        });
    },
    registerEventOnLoaded: function()
    {
        $("#btnAdd").off('click').on('click', function () {
            $("#modalAddEdit").modal({ backdrop: 'static', keyboard: false });
            $("#lblTitle").text("Thêm phòng ban");
        });
    },
}
PhongBanMain.init();
