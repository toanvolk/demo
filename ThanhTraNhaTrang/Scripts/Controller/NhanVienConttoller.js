/// <reference path="HelperController.js" />

var NhanVienConfig = {
    searchString: '',
    pageSize: 10,
    pageIndex: 1,
}
var NhanVienMain = {
    init: function()
    {
        $(document).ready(function () {
            NhanVienMain.setTitle();
            NhanVienMain.registerEventOnLoaded();
        });
    },

    setTitle: function(){
        //----Popup
        $("#btnRefreshNhom").attr('title', "Làm mới");
        $("#btnAddNhom").attr('title', "Thêm mới nhóm nhân viên");

        $("#btnRefreshChucVu").attr('title', "Làm mới");
        $("#btnAddChucVu").attr('title', "Thêm mới chức vụ");

        $("#btnRefreshBoPhan").attr('title', "Làm mới");
        $("#btnAddBoPhan").attr('title', "Thêm mới bộ phận");

        $("#btnRefreshPhongBan").attr('title', "Làm mới");
        $("#btnAddPhongBan").attr('title', "Thêm mới phòng ban");

        $("#btnSaveForm").attr('title', "Lưu dữ liệu và thoát");
        $("#btnSaveAndNewForm").attr('title', "Lưu dữ liệu và tiếp tục tạo mới");
    },
    registerEventOnLoaded: function()
    {


        $("#btnAdd").off('click').on('click', function () {
            $("#modalAddEdit").modal({ backdrop: 'static', keyboard: false });
            $("#title").text("Thêm nhân viên");
        });
       
    },
}
NhanVienMain.init();
