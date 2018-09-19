/// <reference path="HelperController.js" />

var DoiTuongConfig = {
    searchString: '',
    pageSize: 10,
    pageIndex: 1,
}
var DoiTuongMain = {
    init: function()
    {
        $(document).ready(function () {
            DoiTuongMain.registerEventOnLoaded();
            DoiTuongMain.setTitle();
        });
    },
    setTitle: function(){
        //----Page index
        $("#btnAdd").attr('title', "Tạo mới");
        $("#btnDelete").attr('title', "Xóa các mục đã chọn bên dưới");

        //----Popup
        $("#btnRefreshLoaiDoanhNghiep").attr('title', "Làm mới");
        $("#btnAddLoaiDoanhNghiep").attr('title', "Thêm loại hình doanh nghiệp");

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
            $("#lblTitle").text("Thêm đối tượng");

           
            var now = new Date();
            var day = ("0" + now.getDate()).slice(-2);
            var month = ("0" + (now.getMonth() + 1)).slice(-2);
            var today = now.getFullYear() + "-" + (month) + "-" + (day);

            $('#dtNgayCap').val(today);
            $("#dtNgayDoi").val(today);
        });

        $("#btnSaveForm").off('click').on('click', function () {
        });
    },
}
DoiTuongMain.init();
