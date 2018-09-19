var CapNganhNgheConfig = {
    searchString: '',
    pageSize: 10,
    pageIndex: 1,
}
var CapNganhNgheMain = {

    init: function () {
        $(document).ready(function () {
            CapNganhNgheMain.registerEventOnLoaded();
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
            $("#lblTitle").text("Thêm cấp ngành nghề");
        });

        $("#btnSaveForm").off('click').on('click', function () {
        });
    }
}
CapNganhNgheMain.init();