namespace DataAccess.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Dm_DoiTuong
    {
        [Key]
        [StringLength(50)]
        public string MaDoiTuong { get; set; }

        [Required]
        [StringLength(250)]
        public string TenDoiTuong { get; set; }

        [StringLength(250)]
        public string TenKhac { get; set; }

        [StringLength(50)]
        public string MaLoaiHinhDN { get; set; }

        [Required]
        [StringLength(50)]
        public string MaTinhThanh { get; set; }

        [Required]
        [StringLength(250)]
        public string TenTinhThanh { get; set; }

        [Required]
        [StringLength(50)]
        public string MaQuan { get; set; }

        [Required]
        [StringLength(250)]
        public string TenQuan { get; set; }

        [StringLength(250)]
        public string DiaChi { get; set; }

        [StringLength(15)]
        public string DienThoai { get; set; }

        [StringLength(20)]
        public string Fax { get; set; }

        [StringLength(150)]
        public string NgươiDaiDien { get; set; }

        [StringLength(150)]
        public string ChuSohuu { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayCapGP { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDoiGP { get; set; }

        [StringLength(50)]
        public string MaNganhNghe { get; set; }

        [StringLength(250)]
        public string TenNganhNghe { get; set; }

        public bool? ViPhamNhieu { get; set; }

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
