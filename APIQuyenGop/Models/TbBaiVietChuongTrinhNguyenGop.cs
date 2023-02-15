using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIQuyenGop.Models
{
    [Table("TbBaiVietChuongTrinhNguyenGop")]
    public partial class TbBaiVietChuongTrinhNguyenGop
    {
        [Key]
        public int IdBaiViet { get; set; }
        public string HoanCanh { get; set; } = null!;
        public string CauChuyen { get; set; } = null!;
        public DateTime? ThoiGianDangBaiViet { get; set; }
        public string TacGia { get; set; } = null!;
        public string? Url { get; set; }
        public string? HinhAnh { get; set; }
        public int? IdChuDe { get; set; }
        public int? IdCcng { get; set; }

        //public virtual TbChuongTrinhNguyenGop? IdCcngNavigation { get; set; }
        //public virtual TbChuDe? IdChuDeNavigation { get; set; }
    }
}
