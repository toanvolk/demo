/// <reference path="HelperController.js" />

var UserGroupConfig = {
    searchString: '',
    pageSize: 10,
    pageIndex: 1,
}
var UserGroupMain = {
    init: function()
    {
        $(document).ready(function () {
            UserGroupMain.registerEventOnLoaded();
        });
    },
    registerEventOnLoaded: function()
    {
        $("#btnAdd").off('click').on('click', function () {
            $("#modalAddEdit").modal({ backdrop: 'static', keyboard: false });
            $("#title").text("Thêm nhóm");
        });
    },
}
UserGroupMain.init();
