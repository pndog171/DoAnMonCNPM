namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TaiKhoan()
        {
            ChiTietThues = new HashSet<ChiTietThue>();
        }

        [Key]
        [StringLength(23)]
        public string TenTK { get; set; }

        [Required]
        [StringLength(23)]
        public string MatKhau { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [Required]
        public string TenNguoiDung { get; set; }

        [Required]
        [StringLength(20)]
        public string SDT { get; set; }

        [Required]
        [StringLength(1)]
        public string MaGioiTinh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietThue> ChiTietThues { get; set; }
    }
}
