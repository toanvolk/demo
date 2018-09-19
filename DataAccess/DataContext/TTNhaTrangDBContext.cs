namespace DataAccess.DataContext
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TTNhaTrangDBContext : DbContext
    {
        private static TTNhaTrangDBContext instance = null;
        private static readonly object padlock = new object();
        public static TTNhaTrangDBContext Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new TTNhaTrangDBContext();
                        }
                    }
                }
                return instance;
            }
        }
        private TTNhaTrangDBContext()
            : base("name=TTNhaTrangDBContext")
        {
        }

        public virtual DbSet<Dm_BoPhan> Dm_BoPhan { get; set; }
        public virtual DbSet<Dm_CapNganhNghe> Dm_CapNganhNghe { get; set; }
        public virtual DbSet<Dm_ChucVu> Dm_ChucVu { get; set; }
        public virtual DbSet<Dm_DoiTuong> Dm_DoiTuong { get; set; }
        public virtual DbSet<Dm_DonViThucHien> Dm_DonViThucHien { get; set; }
        public virtual DbSet<Dm_HanhViViPham> Dm_HanhViViPham { get; set; }
        public virtual DbSet<Dm_LoaiHinhDoanhNghiep> Dm_LoaiHinhDoanhNghiep { get; set; }
        public virtual DbSet<Dm_LoaiThanhTra> Dm_LoaiThanhTra { get; set; }
        public virtual DbSet<Dm_NganhNghe> Dm_NganhNghe { get; set; }
        public virtual DbSet<Dm_NhanVien> Dm_NhanVien { get; set; }
        public virtual DbSet<Dm_NhomNhanVen> Dm_NhomNhanVen { get; set; }
        public virtual DbSet<Dm_PhamViThanhTra> Dm_PhamViThanhTra { get; set; }
        public virtual DbSet<Dm_PhongBan> Dm_PhongBan { get; set; }
        public virtual DbSet<Dm_QuanHuyen> Dm_QuanHuyen { get; set; }
        public virtual DbSet<Dm_TinhThanh> Dm_TinhThanh { get; set; }
        public virtual DbSet<NV_KeHoachThanhTra> NV_KeHoachThanhTra { get; set; }
        public virtual DbSet<NV_KeHoachThanhTra_CT> NV_KeHoachThanhTra_CT { get; set; }
        public virtual DbSet<NV_KetQuaThanhTra> NV_KetQuaThanhTra { get; set; }
        public virtual DbSet<Sys_Channge_PassWord> Sys_Channge_PassWord { get; set; }
        public virtual DbSet<Sys_Function_permission> Sys_Function_permission { get; set; }
        public virtual DbSet<Sys_LogDetail> Sys_LogDetail { get; set; }
        public virtual DbSet<Sys_MenuList> Sys_MenuList { get; set; }
        public virtual DbSet<Sys_Permission> Sys_Permission { get; set; }
        public virtual DbSet<Sys_UserGroup> Sys_UserGroup { get; set; }
        public virtual DbSet<Sys_UserList> Sys_UserList { get; set; }
        public virtual DbSet<Sys_LogMaster> Sys_LogMaster { get; set; }
        public virtual DbSet<Sys_MessageList> Sys_MessageList { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dm_BoPhan>()
                .Property(e => e.MaBoPhan)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_BoPhan>()
                .Property(e => e.UserCreate)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_BoPhan>()
                .Property(e => e.UserUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_CapNganhNghe>()
                .Property(e => e.MaCap)
                .IsFixedLength();

            modelBuilder.Entity<Dm_CapNganhNghe>()
                .Property(e => e.UserCreate)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_CapNganhNghe>()
                .Property(e => e.UserUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_ChucVu>()
                .Property(e => e.MaChucVu)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_ChucVu>()
                .Property(e => e.UserCreate)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_ChucVu>()
                .Property(e => e.UserUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_DoiTuong>()
                .Property(e => e.MaDoiTuong)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_DoiTuong>()
                .Property(e => e.MaLoaiHinhDN)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_DoiTuong>()
                .Property(e => e.MaTinhThanh)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_DoiTuong>()
                .Property(e => e.MaQuan)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_DoiTuong>()
                .Property(e => e.MaNganhNghe)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_DoiTuong>()
                .Property(e => e.UserCreate)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_DoiTuong>()
                .Property(e => e.UserUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_DonViThucHien>()
                .Property(e => e.MaDonVi)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_DonViThucHien>()
                .Property(e => e.MaTinhThanh)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_DonViThucHien>()
                .Property(e => e.MaQuan)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_DonViThucHien>()
                .Property(e => e.UserCreate)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_DonViThucHien>()
                .Property(e => e.UserUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_HanhViViPham>()
                .Property(e => e.MaHanhVi)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_HanhViViPham>()
                .Property(e => e.UserCreate)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_HanhViViPham>()
                .Property(e => e.UserUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_LoaiHinhDoanhNghiep>()
                .Property(e => e.MaLoaiHinhDN)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_LoaiHinhDoanhNghiep>()
                .Property(e => e.UserCreate)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_LoaiHinhDoanhNghiep>()
                .Property(e => e.UserUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_LoaiThanhTra>()
                .Property(e => e.MaKieuTT)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_LoaiThanhTra>()
                .Property(e => e.UserCreate)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_LoaiThanhTra>()
                .Property(e => e.UserUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_NganhNghe>()
                .Property(e => e.MaNganhNghe)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_NganhNghe>()
                .Property(e => e.Cap1)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_NganhNghe>()
                .Property(e => e.Cap2)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_NganhNghe>()
                .Property(e => e.Cap3)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_NganhNghe>()
                .Property(e => e.Cap4)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_NganhNghe>()
                .Property(e => e.Cap5)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_NganhNghe>()
                .Property(e => e.UserCreate)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_NganhNghe>()
                .Property(e => e.UserUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_NhanVien>()
                .Property(e => e.MaNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_NhanVien>()
                .Property(e => e.MaNhom)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_NhanVien>()
                .Property(e => e.MaChucVu)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_NhanVien>()
                .Property(e => e.MaBoPhan)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_NhanVien>()
                .Property(e => e.MaPhongBan)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_NhanVien>()
                .Property(e => e.GioiTinh)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_NhanVien>()
                .Property(e => e.UserCreate)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_NhanVien>()
                .Property(e => e.UserUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_NhomNhanVen>()
                .Property(e => e.MaNhom)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_NhomNhanVen>()
                .Property(e => e.UserCreate)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_NhomNhanVen>()
                .Property(e => e.UserUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_PhamViThanhTra>()
                .Property(e => e.MaPV)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_PhamViThanhTra>()
                .Property(e => e.UserCreate)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_PhamViThanhTra>()
                .Property(e => e.UserUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_PhongBan>()
                .Property(e => e.MaPhongBan)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_PhongBan>()
                .Property(e => e.MaBoPhan)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_PhongBan>()
                .Property(e => e.UserCreate)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_PhongBan>()
                .Property(e => e.UserUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_QuanHuyen>()
                .Property(e => e.MaQuan)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_QuanHuyen>()
                .Property(e => e.MaTinhThanh)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_QuanHuyen>()
                .Property(e => e.UserCreate)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_QuanHuyen>()
                .Property(e => e.UserUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_TinhThanh>()
                .Property(e => e.MaTinhThanh)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_TinhThanh>()
                .Property(e => e.UserCreate)
                .IsUnicode(false);

            modelBuilder.Entity<Dm_TinhThanh>()
                .Property(e => e.UserUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<NV_KeHoachThanhTra>()
                .Property(e => e.MaKeHoach)
                .IsUnicode(false);

            modelBuilder.Entity<NV_KeHoachThanhTra>()
                .Property(e => e.NamKeHoach)
                .IsUnicode(false);

            modelBuilder.Entity<NV_KeHoachThanhTra>()
                .Property(e => e.MaDonVi)
                .IsUnicode(false);

            modelBuilder.Entity<NV_KeHoachThanhTra>()
                .Property(e => e.MaKieuTT)
                .IsUnicode(false);

            modelBuilder.Entity<NV_KeHoachThanhTra>()
                .Property(e => e.MaLoaiTT)
                .IsUnicode(false);

            modelBuilder.Entity<NV_KeHoachThanhTra>()
                .Property(e => e.ThơiGianTH)
                .IsUnicode(false);

            modelBuilder.Entity<NV_KeHoachThanhTra>()
                .Property(e => e.UserCreate)
                .IsUnicode(false);

            modelBuilder.Entity<NV_KeHoachThanhTra>()
                .Property(e => e.UserUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<NV_KeHoachThanhTra_CT>()
                .Property(e => e.MaKeHoach)
                .IsUnicode(false);

            modelBuilder.Entity<NV_KeHoachThanhTra_CT>()
                .Property(e => e.MaDoiTuong)
                .IsUnicode(false);

            modelBuilder.Entity<NV_KetQuaThanhTra>()
                .Property(e => e.ThuHoiTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NV_KetQuaThanhTra>()
                .Property(e => e.ThuHoiDat)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NV_KetQuaThanhTra>()
                .Property(e => e.PhatTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NV_KetQuaThanhTra>()
                .Property(e => e.TichThuTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NV_KetQuaThanhTra>()
                .Property(e => e.TieuHuyTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NV_KetQuaThanhTra>()
                .Property(e => e.SuLyKhac)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NV_KetQuaThanhTra>()
                .Property(e => e.UserCreate)
                .IsUnicode(false);

            modelBuilder.Entity<NV_KetQuaThanhTra>()
                .Property(e => e.UserUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Channge_PassWord>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Channge_PassWord>()
                .Property(e => e.PassWordOld)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Channge_PassWord>()
                .Property(e => e.PassWordNew)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Channge_PassWord>()
                .Property(e => e.UserUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Function_permission>()
                .Property(e => e.KeyMenuID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_MenuList>()
                .Property(e => e.KeyMenuID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_MenuList>()
                .Property(e => e.Alignment)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_MenuList>()
                .Property(e => e.Module)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Permission>()
                .Property(e => e.UserGroupID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Permission>()
                .Property(e => e.KeyMenuID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Permission>()
                .Property(e => e.Permis_Type)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_UserGroup>()
                .Property(e => e.UserGroupID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_UserGroup>()
                .Property(e => e.UserCreate)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_UserGroup>()
                .Property(e => e.UserUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_UserList>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_UserList>()
                .Property(e => e.Sex)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_UserList>()
                .Property(e => e.UserGroupID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_UserList>()
                .Property(e => e.PassWord)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_UserList>()
                .Property(e => e.UserCreate)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_UserList>()
                .Property(e => e.UserUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_LogMaster>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_LogMaster>()
                .Property(e => e.UserGroupID)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_MessageList>()
               .Property(e => e.MessageKey)
               .IsUnicode(false);
        }
    }
}
