/// <reference path="HelperController.js" />

var BoPhanConfig = {
    searchString: '',
    pageSize: 10,
    pageIndex: 1,
}
var BoPhanMain = {
    init: function()
    {
        $(document).ready(function () {
            BoPhanMain.registerEventOnLoaded();
        });
    },
    registerEventOnLoaded: function()
    {
        $("#btnAdd").off('click').on('click', function () {
            $("#modalAddEdit").modal({ backdrop: 'static', keyboard: false });
            $("#title").text("Thêm bộ phận");
        });
    },
}
BoPhanMain.init();
