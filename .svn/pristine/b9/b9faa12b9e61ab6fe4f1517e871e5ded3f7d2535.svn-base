/// <reference path="HelperController.js" />

var SystemConfig = {
    searchString: '',
    pageSize: 10,
    pageIndex: 1,
}
var SystemConfigMain = {
    init: function()
    {
        $(document).ready(function () {
            SystemConfigMain.registerEventOnLoaded();
            SystemConfigMain.setTitle();
        });
    },
    setTitle: function () {

        //----Page index
        $("#btnAdd").attr('title', "Tạo mới");
        $("#btnDelete").attr('title', "Xóa các mục đã chọn bên dưới");

        //----Popup
        $("#btnSaveForm").attr('title', "Lưu dữ liệu và thoát");
        $("#btnSaveAndNewForm").attr('title', "Lưu dữ liệu và tiếp tục tạo mới");
    },
    registerEventOnLoaded: function()
    {
        $("#btnAdd").off('click').on('click', function () {
            $("#modalAddEdit").modal({ backdrop: 'static', keyboard: false });
            $("#lblTitle").text("Thêm cấu hình");
        });
    },
}
SystemConfigMain.init();
