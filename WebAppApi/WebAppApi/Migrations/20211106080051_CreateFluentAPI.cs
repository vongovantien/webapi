using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppApi.Migrations
{
    public partial class CreateFluentAPI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MoTa",
                table: "HangHoa",
                newName: "moTa");

            migrationBuilder.RenameColumn(
                name: "GiamGia",
                table: "HangHoa",
                newName: "giamGia");

            migrationBuilder.RenameColumn(
                name: "DonGia",
                table: "HangHoa",
                newName: "donGia");

            migrationBuilder.RenameColumn(
                name: "Tenh",
                table: "HangHoa",
                newName: "tenHangHoa");

            migrationBuilder.RenameColumn(
                name: "Mahh",
                table: "HangHoa",
                newName: "maHangHoa");

            migrationBuilder.CreateTable(
                name: "donHangs",
                columns: table => new
                {
                    maDonhang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tenDonHang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    giamGia = table.Column<double>(type: "float", nullable: false),
                    giaTien = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_donHangs", x => x.maDonhang);
                });

            migrationBuilder.CreateTable(
                name: "chiTietDonHangs",
                columns: table => new
                {
                    maHangHoa = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    maDonHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    mieuTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    giamGia = table.Column<double>(type: "float", nullable: false),
                    thanhTien = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chiTietDonHangs", x => new { x.maDonHang, x.maHangHoa });
                    table.ForeignKey(
                        name: "FK_chiTietDonHangs_donHangs_maDonHang",
                        column: x => x.maDonHang,
                        principalTable: "donHangs",
                        principalColumn: "maDonhang",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_chiTietDonHangs_HangHoa_maHangHoa",
                        column: x => x.maHangHoa,
                        principalTable: "HangHoa",
                        principalColumn: "maHangHoa",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_chiTietDonHangs_maHangHoa",
                table: "chiTietDonHangs",
                column: "maHangHoa");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "chiTietDonHangs");

            migrationBuilder.DropTable(
                name: "donHangs");

            migrationBuilder.RenameColumn(
                name: "moTa",
                table: "HangHoa",
                newName: "MoTa");

            migrationBuilder.RenameColumn(
                name: "giamGia",
                table: "HangHoa",
                newName: "GiamGia");

            migrationBuilder.RenameColumn(
                name: "donGia",
                table: "HangHoa",
                newName: "DonGia");

            migrationBuilder.RenameColumn(
                name: "tenHangHoa",
                table: "HangHoa",
                newName: "Tenh");

            migrationBuilder.RenameColumn(
                name: "maHangHoa",
                table: "HangHoa",
                newName: "Mahh");
        }
    }
}
