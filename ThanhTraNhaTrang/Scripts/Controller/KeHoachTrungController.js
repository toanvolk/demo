/// <reference path="HelperController.js" />

var KeHoachTrungConfig = {
    searchString: '',
    pageSize: 10,
    pageIndex: 1,

    ObjList: [
        {
            Stt: 0,
            NoiDung: 'Công tác tuyển sinh và quản lý tài chính',
            LinhVuc: 'Công thanh tra chuyên ngành',
            DoiTuong: 'Sở GD&DT',
            PhamVi: 'Từ năm 2014 - 2015',
            DonVi: 'Phòng NV',
            ThoiGian: '	Quý 1 năm 2015'
        },
        {
            Stt: 0,
            NoiDung: 'Công tác tuyển sinh và quản lý tài chính',
            LinhVuc: 'Công thanh tra chuyên ngành',
            DoiTuong: 'Sở GD&DT',
            PhamVi: 'Từ năm 2015 - 2016',
            DonVi: 'Phòng NV',
            ThoiGian: '	Quý 1 năm 2016'
        },
        {
            Stt: 0,
            NoiDung: 'Công tác tuyển sinh và quản lý tài chính',
            LinhVuc: 'Công thanh tra chuyên ngành',
            DoiTuong: 'Sở GD&DT',
            PhamVi: 'Từ năm 2016 - 2017',
            DonVi: 'Phòng NV',
            ThoiGian: '	Quý 1 năm 2017'
        },
    ]
}
var KeHoachTrungConfig = {
    init: function()
    {
        $(document).ready(function () {
            KeHoachTrungConfig.setTitle();
            KeHoachTrungConfig.registerEventOnLoaded();
        });
    },
    setTitle: function () {
        //----Form
        $("#btnAdd").attr('title', "Thêm mới dữ liệu");
        //$("#btnDelete").attr('title', "Xóa dữ liệu đã chọn");

        $("#btnSaveForm").attr('title', "Lưu dữ liệu và thoát");
        $("#btnSaveAndNewForm").attr('title', "Lưu dữ liệu và tiếp tục tạo mới");

    },
    registerEventOnLoaded: function()
    {
        $("#btnAdd").off('click').on('click', function () {
            $("#modalAddEdit").modal({ backdrop: 'static', keyboard: false });
            $("#title").text("Thêm");
        });

        $("#btnSaveForm").off('click').on('click', function () {
            alert("Save");
        });
        
        
    },
}
KeHoachTrungConfig.init();
