namespace DataAccess.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Dm_NganhNghe
    {
        [Key]
        [StringLength(50)]
        public string MaNganhNghe { get; set; }

        [Required]
        [StringLength(250)]
        public string TenNganhNghe { get; set; }

        [StringLength(20)]
        public string Cap1 { get; set; }

        [StringLength(20)]
        public string Cap2 { get; set; }

        [StringLength(20)]
        public string Cap3 { get; set; }

        [StringLength(20)]
        public string Cap4 { get; set; }

        [StringLength(20)]
        public string Cap5 { get; set; }

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
