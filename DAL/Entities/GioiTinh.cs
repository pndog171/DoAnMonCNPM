namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GioiTinh")]
    public partial class GioiTinh
    {
        [Key]
        [StringLength(1)]
        public string MaGioiTinh { get; set; }

        [Column("GioiTinh")]
        [Required]
        [StringLength(4)]
        public string GioiTinh1 { get; set; }
    }
}
