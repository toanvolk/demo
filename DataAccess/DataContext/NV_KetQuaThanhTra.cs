namespace DataAccess.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NV_KetQuaThanhTra
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KeHoach_CT { get; set; }

        [Required]
        public string NoiDung { get; set; }

        [Column(TypeName = "date")]
        public DateTime TuNgay { get; set; }

        [Column(TypeName = "date")]
        public DateTime DenNgay { get; set; }

        [Column(TypeName = "money")]
        public decimal? ThuHoiTien { get; set; }

        [Column(TypeName = "money")]
        public decimal? ThuHoiDat { get; set; }

        [Column(TypeName = "money")]
        public decimal? PhatTien { get; set; }

        [Column(TypeName = "money")]
        public decimal? TichThuTien { get; set; }

        [StringLength(300)]
        public string GhiChuTTT { get; set; }

        [Column(TypeName = "money")]
        public decimal? TieuHuyTien { get; set; }

        [StringLength(300)]
        public string GhiChuTieuHuy { get; set; }

        [Column(TypeName = "money")]
        public decimal? SuLyKhac { get; set; }

        [StringLength(300)]
        public string GhiChuSuLy { get; set; }

        public bool? DinhChi { get; set; }

        public bool? TuocQuyen { get; set; }

        [StringLength(300)]
        public string GhiChuTuocQuyen { get; set; }

        public string TomTatSaiPham { get; set; }

        [StringLength(50)]
        public string UserCreate { get; set; }

        public DateTime? DateCreate { get; set; }

        [StringLength(50)]
        public string UserUpdate { get; set; }

        public DateTime? DateUpdate { get; set; }
    }
}
