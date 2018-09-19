namespace DataAccess.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NV_KeHoachThanhTra_CT
    {
        [Key]
        public int KeHoach_CT { get; set; }

        [Required]
        [StringLength(50)]
        public string MaKeHoach { get; set; }

        [Required]
        [StringLength(50)]
        public string MaDoiTuong { get; set; }

        [Required]
        [StringLength(250)]
        public string TenDoiTuong { get; set; }

        [StringLength(350)]
        public string DiaChi { get; set; }

        public string KiemTra { get; set; }
    }
}
