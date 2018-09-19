namespace DataAccess.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NV_KeHoachThanhTra
    {
        [Key]
        [StringLength(50)]
        public string MaKeHoach { get; set; }

        [Required]
        [StringLength(250)]
        public string TenKeHoach { get; set; }

        [Required]
        [StringLength(50)]
        public string NamKeHoach { get; set; }

        [Required]
        [StringLength(50)]
        public string MaDonVi { get; set; }

        [Required]
        [StringLength(250)]
        public string TenDonVi { get; set; }

        [Required]
        [StringLength(50)]
        public string MaKieuTT { get; set; }

        [StringLength(250)]
        public string TenKieuTT { get; set; }

        [Required]
        [StringLength(50)]
        public string MaLoaiTT { get; set; }

        [StringLength(250)]
        public string TenLoaiTT { get; set; }

        [Required]
        public string NoiDung { get; set; }

        [StringLength(500)]
        public string PhamViTT { get; set; }

        public int? ThoiHanTT { get; set; }

        [StringLength(50)]
        public string ThơiGianTH { get; set; }

        [StringLength(250)]
        public string DonViPhoiHop { get; set; }

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
