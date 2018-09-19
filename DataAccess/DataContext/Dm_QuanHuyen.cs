namespace DataAccess.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Dm_QuanHuyen
    {
        [Key]
        [StringLength(50)]
        public string MaQuan { get; set; }

        [Required]
        [StringLength(250)]
        public string TenQuan { get; set; }

        [StringLength(250)]
        public string TenKhac { get; set; }

        [Required]
        [StringLength(50)]
        public string MaTinhThanh { get; set; }

        [Required]
        [StringLength(250)]
        public string TenTinhThanh { get; set; }

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
