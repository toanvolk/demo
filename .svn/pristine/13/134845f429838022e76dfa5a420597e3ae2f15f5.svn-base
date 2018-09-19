var LoaiHinhDoanhNghiepConfig = {
    searchString: '',
    pageSize: 10,
    pageIndex: 1,
}
var LoaiHinhDoanhNghiepMain = {

    init: function () {
        $(document).ready(function () {
            LoaiHinhDoanhNghiepMain.registerEventOnLoaded();
        });
    },
    registerEventOnLoaded: function () {
        //Set title 
        //----Page index
        $("#btnAdd").attr('title', "Tạo mới");
        $("#btnDelete").attr('title', "Xóa các mục đã chọn bên dưới");        

        $("#btnSaveForm").attr('title', "Lưu dữ liệu và thoát");
        $("#btnSaveAndNewForm").attr('title', "Lưu dữ liệu và tiếp tục tạo mới");


        $("#btnAdd").off('click').on('click', function () {
            $("#modalAddEdit").modal({ backdrop: 'static', keyboard: false });
            $("#lblTitle").text("Thêm loại hình doanh nghiệp");
        });

        $("#btnSaveForm").off('click').on('click', function () {
        });
    }
}
LoaiHinhDoanhNghiepMain.init();