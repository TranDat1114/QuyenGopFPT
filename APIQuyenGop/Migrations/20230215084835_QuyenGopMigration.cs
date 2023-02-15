using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIQuyenGop.Migrations
{
    public partial class QuyenGopMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TbBaiVietChuongTrinhNguyenGop",
                columns: table => new
                {
                    IdBaiViet = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoanCanh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CauChuyen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThoiGianDangBaiViet = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TacGia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdChuDe = table.Column<int>(type: "int", nullable: true),
                    IdCcng = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbBaiVietChuongTrinhNguyenGop", x => x.IdBaiViet);
                });

            migrationBuilder.CreateTable(
                name: "TbChuDe",
                columns: table => new
                {
                    IdChuDe = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenChuDe = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbChuDe", x => x.IdChuDe);
                });

            migrationBuilder.CreateTable(
                name: "TbChuongTrinhNguyenGop",
                columns: table => new
                {
                    IdCcng = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenChuongTrinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoTienCanNguyenGop = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiaDiemNguyenGop = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaiKhoanNguyenGop = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MucDichNguyenGop = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LuotNguyenGop = table.Column<int>(type: "int", nullable: false),
                    HinhThucNguyenGop = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdToChuc = table.Column<int>(type: "int", nullable: true),
                    IdNng = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbChuongTrinhNguyenGop", x => x.IdCcng);
                });

            migrationBuilder.CreateTable(
                name: "TbNguoiNguyenGop",
                columns: table => new
                {
                    IdNng = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoVaTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LienHe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoTienNguyenGop = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayNguyenGop = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HinhThucNguyenGop = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MucDichNguyenGop = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbNguoiNguyenGop", x => x.IdNng);
                });

            migrationBuilder.CreateTable(
                name: "TbToChucDongHanh",
                columns: table => new
                {
                    IdToChuc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenToChuc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbToChucDongHanh", x => x.IdToChuc);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TbBaiVietChuongTrinhNguyenGop");

            migrationBuilder.DropTable(
                name: "TbChuDe");

            migrationBuilder.DropTable(
                name: "TbChuongTrinhNguyenGop");

            migrationBuilder.DropTable(
                name: "TbNguoiNguyenGop");

            migrationBuilder.DropTable(
                name: "TbToChucDongHanh");
        }
    }
}
