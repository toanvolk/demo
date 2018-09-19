namespace DataAccess.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Dm_NhanVien
    {
        [Key]
        [StringLength(50)]
        public string MaNhanVien { get; set; }

        [Required]
        [StringLength(250)]
        public string TenNhanVien { get; set; }

        [StringLength(250)]
        public string TenKhac { get; set; }

        [Required]
        [StringLength(50)]
        public string MaNhom { get; set; }

        [Required]
        [StringLength(250)]
        public string TenNhom { get; set; }

        [Required]
        [StringLength(50)]
        public string MaChucVu { get; set; }

        [Required]
        [StringLength(250)]
        public string TenChucVu { get; set; }

        [Required]
        [StringLength(50)]
        public string MaBoPhan { get; set; }

        [Required]
        [StringLength(250)]
        public string TenBoPhan { get; set; }

        [Required]
        [StringLength(50)]
        public string MaPhongBan { get; set; }

        [Required]
        [StringLength(250)]
        public string TenPhongBan { get; set; }

        [StringLength(5)]
        public string GioiTinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayLamViec { get; set; }

        [StringLength(250)]
        public string DiaChi { get; set; }

        [StringLength(15)]
        public string Phone { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(50)]
        public string CMND { get; set; }

        [StringLength(300)]
        public string GhiChu { get; set; }

        public bool? IsActivate { get; set; }

        [StringLength(50)]
        public string UserCreate { get; set; }

        public DateTime? DateCreate { get; set; }

        [StringLength(50)]
        public string UserUpdate { get; set; }

        public DateTime? DateUpdate { get; set; }
    }
}
