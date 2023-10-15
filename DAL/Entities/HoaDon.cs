namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [Key]
        [StringLength(10)]
        public string MaHD { get; set; }

        [Required]
        [StringLength(10)]
        public string MaXe { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TongTien { get; set; }

        [Required]
        [StringLength(23)]
        public string TenTK { get; set; }

        public DateTime NgayThanhToan { get; set; }

        [Required]
        [StringLength(10)]
        public string MaKH { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual Xe Xe { get; set; }
    }
}
