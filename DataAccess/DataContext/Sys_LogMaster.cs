namespace DataAccess.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_LogMaster
    {
        [Key]
        public int LogMasterID { get; set; }

        [StringLength(50)]
        public string UserID { get; set; }

        [StringLength(50)]
        public string UserGroupID { get; set; }

        public DateTime? StartDateLog { get; set; }

        public DateTime? EndDateLog { get; set; }
    }
}
