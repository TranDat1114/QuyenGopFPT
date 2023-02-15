using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIQuyenGop.Models
{
    [Table("TbToChucDongHanh")]
    public partial class TbToChucDongHanh
    {
        //public TbToChucDongHanh()
        //{
        //    TbChuongTrinhNguyenGops = new HashSet<TbChuongTrinhNguyenGop>();
        //}
        [Key]
        public int IdToChuc { get; set; }
        public string TenToChuc { get; set; } = null!;
        public string HinhAnh { get; set; } = null!;

        //public virtual ICollection<TbChuongTrinhNguyenGop> TbChuongTrinhNguyenGops { get; set; }
    }
}
