namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietThue")]
    public partial class ChiTietThue
    {
        [Key]
        [StringLength(10)]
        public string MaCTThue { get; set; }

        [Required]
        [StringLength(23)]
        public string TenTK { get; set; }

        public DateTime NgayThue { get; set; }

        public DateTime NgayTra { get; set; }

        [Required]
        [StringLength(10)]
        public string MaXe { get; set; }

        [Required]
        [StringLength(10)]
        public string MaKH { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }

        public virtual Xe Xe { get; set; }
    }
}
