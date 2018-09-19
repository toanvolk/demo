namespace DataAccess.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Dm_PhongBan
    {
        [Key]
        [StringLength(50)]
        public string MaPhongBan { get; set; }

        [Required]
        [StringLength(250)]
        public string TenPhongBan { get; set; }

        [StringLength(250)]
        public string TenKhac { get; set; }

        [Required]
        [StringLength(50)]
        public string MaBoPhan { get; set; }

        [Required]
        [StringLength(250)]
        public string TenBoPhan { get; set; }

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
