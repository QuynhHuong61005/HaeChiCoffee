namespace HaeChiCoffee.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TAIKHOAN")]
    public partial class TAIKHOAN
    {
        [Key]
        public int MaTK { get; set; }

        [Required]
        [StringLength(50)]
        public string TenDangNhap { get; set; }

        [StringLength(100)]
        public string HoTen { get; set; }

        [Required]
        [StringLength(100)]
        public string MatKhau { get; set; }

        [Required]
        [StringLength(20)]
        public string Quyen { get; set; }

        [StringLength(20)]
        public string TrangThai { get; set; }
    }
}
