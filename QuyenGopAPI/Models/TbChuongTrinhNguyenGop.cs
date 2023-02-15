using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuyenGopAPI.Models
{
    [Table("TbChuongTrinhNguyenGop")]
    public class TbChuongTrinhNguyenGop
    {
        //public TbChuongTrinhNguyenGop()
        //{
        //    TbBaiVietChuongTrinhNguyenGops = new HashSet<TbBaiVietChuongTrinhNguyenGop>();
        //}
        [Key]
        public int IdCcng { get; set; }
        public string TenChuongTrinh { get; set; } = null!;
        public string SoTienCanNguyenGop { get; set; } = null!;
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public string? DiaDiemNguyenGop { get; set; }
        public string TaiKhoanNguyenGop { get; set; } = null!;
        public string MucDichNguyenGop { get; set; } = null!;
        public int LuotNguyenGop { get; set; }
        public string? HinhThucNguyenGop { get; set; }
        public int? IdToChuc { get; set; }
        public int? IdNng { get; set; }

        //public virtual TbNguoiNguyenGop? IdNngNavigation { get; set; }
        //public virtual TbToChucDongHanh? IdToChucNavigation { get; set; }
        //public virtual ICollection<TbBaiVietChuongTrinhNguyenGop> TbBaiVietChuongTrinhNguyenGops { get; set; }
    }
}
