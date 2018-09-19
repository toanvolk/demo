namespace DataAccess.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_LogDetail
    {
        [Key]
        public int LogDetailID { get; set; }

        public int LogMasterID { get; set; }

        [StringLength(100)]
        public string TableName { get; set; }

        [StringLength(250)]
        public string ObjectEdit { get; set; }

        [StringLength(350)]
        public string Descriptions { get; set; }

        public DateTime? DateEdit { get; set; }
    }
}
