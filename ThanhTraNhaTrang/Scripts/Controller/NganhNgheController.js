/// <reference path="HelperController.js" />

var NganhNgheConfig = {
    searchString: '',
    pageSize: 10,
    pageIndex: 1,
}
var NganhNgheMain = {
    init: function()
    {
        $(document).ready(function () {
            NganhNgheMain.registerEventOnLoaded();
        });
    },
    registerEventOnLoaded: function()
    {
        $("#btnAdd").off('click').on('click', function () {
            $("#modalAddEdit").modal({ backdrop: 'static', keyboard: false });
            $("#lblTitle").text("Thêm ngành nghề");
        });
    },
}
NganhNgheMain.init();
