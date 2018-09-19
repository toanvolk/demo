namespace DataAccess.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_UserList
    {
        [Key]
        [StringLength(50)]
        public string UserID { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(250)]
        public string FullName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Dirthday { get; set; }

        [StringLength(2)]
        public string Sex { get; set; }

        [Required]
        [StringLength(50)]
        public string UserGroupID { get; set; }

        [Required]
        [StringLength(250)]
        public string UserGroupName { get; set; }

        [Required]
        [StringLength(50)]
        public string PassWord { get; set; }

        public bool? IsAdmin { get; set; }

        [StringLength(300)]
        public string Note { get; set; }

        public bool? IsActivate { get; set; }

        [StringLength(50)]
        public string UserCreate { get; set; }

        public DateTime? DateCreate { get; set; }

        [StringLength(50)]
        public string UserUpdate { get; set; }

        public DateTime? DateUpdate { get; set; }
    }
}
