﻿var ShareConfig = {

}

var ShareMain = {
    init: function () {
        $(document).ready(function () {
            
            ShareMain.registerEventOnLoaded();
        });
    },
    registerEventOnLoaded: function () {
        //Business
        $("#btnKeHoachThanhTra").off('click').on('click', function () {
            window.location.replace("/KeHoachThanhTra/Index");
        });
        $("#btnKeHoachTrung").off('click').on('click', function () {
            window.location.replace("/KeHoachTrung/Index");
        });
        $("#btnKetQuaThanhTra").off('click').on('click', function () {
            window.location.replace("/KetQuaThanhTra/Index");
        });
        //System ---------------------------
        $("#btnSystemConfig").off('click').on('click', function () {
            window.location.replace("/SystemConfig/Index");
        });
        $("#btnAutoBackupData").off('click').on('click', function () {
            window.location.replace("/AutoBackupData/Index");
        });
        $("#btnLogOut").off('click').on('click', function () {
            window.location.replace("/Account/Login");
        });
        $("#btnUser").off('click').on('click', function () {
            window.location.replace("/User/Index");
        });
        $(".btn-Change-Password").off('click').on('click', function () {
            $("#modalChangePassword").modal({ backdrop: 'static', keyboard: false });
            $("#title").text("Thay đổi mật khẩu");
        });
        $("#btnPhanQuyen").off('click').on('click', function () {
            window.location.replace("/PhanQuyen/Index");
        });        
        $("#btnUserGroup").off('click').on('click', function () {
            window.location.replace("/UserGroup/Index");
        });
        //Catalog ------------------------------
        $("#btnNganhNgheKinhDoanh").off('click').on('click', function () {
            window.location.replace("/NganhNghe/Index");
        });
        
        $("#btnDonVi").off('click').on('click', function () {
            window.location.replace("/DonVi/Index");
            //$.ajax(
            //    {
            //        url: "/DonVi/Index",
            //        type: "GET",
            //        datatype: "html",
                    
            //        success : function(response)
            //        {
            //            $("#page-wrapper").html(response);
            //        }
            //    });

        });

        $("#btnDoiTuong").off('click').on('click', function () {
            window.location.replace("/DoiTuong/Index");
        });

        
        $("#btnTinhThanh").off('click').on('click', function () {
            window.location.replace("/TinhThanh/Index");
        });        
       
        $("#btnQuanHuyen").off('click').on('click', function () {
            window.location.replace("/QuanHuyen/Index");
        });
        
        $("#btnNhanVien").off('click').on('click', function () {
            window.location.replace("/NhanVien/Index");
        });
        
        $("#btnNhomNhanVien").off('click').on('click', function () {
            window.location.replace("/NhomNhanVien/Index");
        });
        
        $("#btnBoPhan").off('click').on('click', function () {
            window.location.replace("/BoPhan/Index");
        });
        
        $("#btnPhongBan").off('click').on('click', function () {
            window.location.replace("/PhongBan/Index");
        });
        $("#btnChucVu").off('click').on('click', function () {
            window.location.replace("/ChucVu/Index");
        });
        $("#btnPhamViThanhTra").off('click').on('click', function () {
            window.location.replace("/PhamViThanhTra/Index");
        });
        $("#btnLoaiThanhTra").off('click').on('click', function () {
            window.location.replace("/LoaiThanhTra/Index");
        });
        
        $("#btnHanhViViPham").off('click').on('click', function () {
            window.location.replace("/HanhViViPham/Index");
        });
        
        $("#btnCapNganhNghe").off('click').on('click', function () {
            window.location.replace("/CapNganhNghe/Index");
        });
        
        $("#btnLoaiHinhDoanhNghiep").off('click').on('click', function () {
            window.location.replace("/LoaiHinhDoanhNghiep/Index");
        });
        
        $("#btnThoiGianTienHanh").off('click').on('click', function () {
            window.location.replace("/ThoiGianTienHanh/Index");
        });

        //$("#btnThoiGianTienHanh").off('click').on('click', function () {
        //    //window.location.replace("/ThoiGianTienHanh/Index");
        //    $("#page-wrapper").load("/ThoiGianTienHanh/Index");
        //});
    },
}
ShareMain.init();