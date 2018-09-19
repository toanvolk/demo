namespace DataAccess.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Permission
    {
        [Key]
        public int PermissionID { get; set; }

        [Required]
        [StringLength(50)]
        public string UserGroupID { get; set; }

        [Required]
        [StringLength(20)]
        public string KeyMenuID { get; set; }

        [Required]
        [StringLength(100)]
        public string PermisName { get; set; }

        [Required]
        [StringLength(50)]
        public string Permis_Type { get; set; }
    }
}
