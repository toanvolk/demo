namespace DataAccess.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Function_permission
    {
        [Key]
        [StringLength(20)]
        public string KeyMenuID { get; set; }

        public bool? IsViews { get; set; }

        public bool? IsAdd { get; set; }

        public bool? IsEdit { get; set; }

        public bool? IsDelete { get; set; }

        public bool? IsCopy { get; set; }

        public bool? IsPrint { get; set; }

        public bool? IsExport { get; set; }

        public bool? IsImport { get; set; }
    }
}
