/// <reference path="HelperController.js" />

var TinhThanhConfig = {
    searchString: '',
    pageSize: 10,
    pageIndex: 1,
}
var TinhThanhMain = {
    init: function()
    {
        $(document).ready(function () {
            TinhThanhMain.registerEventOnLoaded();
        });
    },
    registerEventOnLoaded: function()
    {
        $("#btnAdd").off('click').on('click', function () {
            $("#modalAddEdit").modal({ backdrop: 'static', keyboard: false });
            $("#title").text("Thêm tỉnh thành");
        });
       
    },
}
TinhThanhMain.init();
