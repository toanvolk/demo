namespace DataAccess.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_MenuList
    {
        [Key]
        [StringLength(20)]
        public string KeyMenuID { get; set; }

        [StringLength(250)]
        public string MenuName { get; set; }

        [StringLength(250)]
        public string MenuNameAlias { get; set; }

        [StringLength(250)]
        public string MenuNameContent { get; set; }

        [StringLength(150)]
        public string PageKey { get; set; }

        [StringLength(2)]
        public string Alignment { get; set; }

        public int? MenuType { get; set; }

        public int? IsGroup { get; set; }

        [StringLength(10)]
        public string Module { get; set; }

        [StringLength(150)]
        public string PathIcon { get; set; }

        public bool? IsVisible { get; set; }

        public bool? IsBold { get; set; }

        [StringLength(50)]
        public string KeyWork { get; set; }

        public int? SorOrder { get; set; }
    }
}
