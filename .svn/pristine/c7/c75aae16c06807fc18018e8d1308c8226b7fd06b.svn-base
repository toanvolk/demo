namespace DataAccess.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Channge_PassWord
    {
        [Key]
        public int PassID { get; set; }

        [Required]
        [StringLength(50)]
        public string UserID { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(250)]
        public string FullName { get; set; }

        [Required]
        [StringLength(50)]
        public string PassWordOld { get; set; }

        [Required]
        [StringLength(50)]
        public string PassWordNew { get; set; }

        [StringLength(50)]
        public string UserUpdate { get; set; }

        public DateTime? DateUpdate { get; set; }
    }
}
