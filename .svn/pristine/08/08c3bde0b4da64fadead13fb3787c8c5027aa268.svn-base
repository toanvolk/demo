/// <reference path="HelperController.js" />

var DonViConfig = {
    searchString: '',
    pageSize: 10,
    pageIndex: 1,
}
var DonViMain = {
    init: function()
    {
        $(document).ready(function () {
            DonViMain.setTitle();
            DonViMain.registerEventOnLoaded();

        });
    },

    setTitle: function()
    {
        //----Popup
        $("#btnRefreshTinhThanh").attr('title', "Làm mới");
        $("#btnAddTinhThanh").attr('title', "Thêm mới tỉnh thành");

        $("#btnRefreshQuanHuyen").attr('title', "Làm mới");
        $("#btnAddQuanHuyen").attr('title', "Thêm mới quận huyện");

        $("#btnSaveForm").attr('title', "Lưu dữ liệu và thoát");
        $("#btnSaveAndNewForm").attr('title', "Lưu dữ liệu và tiếp tục tạo mới");
    },

    registerEventOnLoaded: function()
    {
        

        $("#btnAdd").off('click').on('click', function () {
            $("#modalAddEdit").modal({ backdrop: 'static', keyboard: false });
            $("#lblTitle").text("Thêm đơn vị");

           
            var now = new Date();
            var day = ("0" + now.getDate()).slice(-2);
            var month = ("0" + (now.getMonth() + 1)).slice(-2);
            var today = now.getFullYear() + "-" + (month) + "-" + (day);

            $('#dtNgayCap').val(today);
            $("#dtNgayDoi").val(today);
        });
        
        $("#btnSaveForm").off('click').on('click', function () {
            alert("btnSaveForm");
        });
    },
}
DonViMain.init();
