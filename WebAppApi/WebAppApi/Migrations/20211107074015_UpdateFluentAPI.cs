using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppApi.Migrations
{
    public partial class UpdateFluentAPI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_chiTietDonHangs_donHangs_maDonHang",
                table: "chiTietDonHangs");

            migrationBuilder.DropForeignKey(
                name: "FK_chiTietDonHangs_HangHoa_maHangHoa",
                table: "chiTietDonHangs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_donHangs",
                table: "donHangs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_chiTietDonHangs",
                table: "chiTietDonHangs");

            migrationBuilder.DropColumn(
                name: "giaTien",
                table: "donHangs");

            migrationBuilder.DropColumn(
                name: "giamGia",
                table: "donHangs");

            migrationBuilder.RenameTable(
                name: "donHangs",
                newName: "DonHang");

            migrationBuilder.RenameTable(
                name: "chiTietDonHangs",
                newName: "ChiTietDonHang");

            migrationBuilder.RenameColumn(
                name: "tenDonHang",
                table: "DonHang",
                newName: "soDienThoai");

            migrationBuilder.RenameColumn(
                name: "maDonHang",
                table: "ChiTietDonHang",
                newName: "maDonhang");

            migrationBuilder.RenameIndex(
                name: "IX_chiTietDonHangs_maHangHoa",
                table: "ChiTietDonHang",
                newName: "IX_ChiTietDonHang_maHangHoa");

            migrationBuilder.AlterColumn<string>(
                name: "tenHangHoa",
                table: "HangHoa",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<string>(
                name: "diaChiGiaoHang",
                table: "DonHang",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ngayDatHang",
                table: "DonHang",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getutcdate()");

            migrationBuilder.AddColumn<DateTime>(
                name: "ngayGiaoHang",
                table: "DonHang",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nguoiNhan",
                table: "DonHang",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tinhTrangDonHang",
                table: "DonHang",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<byte>(
                name: "giamGia",
                table: "ChiTietDonHang",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<double>(
                name: "donGia",
                table: "ChiTietDonHang",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "soLuong",
                table: "ChiTietDonHang",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DonHang",
                table: "DonHang",
                column: "maDonhang");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChiTietDonHang",
                table: "ChiTietDonHang",
                columns: new[] { "maDonhang", "maHangHoa" });

            migrationBuilder.CreateIndex(
                name: "IX_DonHang_maDonhang",
                table: "DonHang",
                column: "maDonhang",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CTDH_DonHang",
                table: "ChiTietDonHang",
                column: "maDonhang",
                principalTable: "DonHang",
                principalColumn: "maDonhang",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CTDH_HangHoa",
                table: "ChiTietDonHang",
                column: "maHangHoa",
                principalTable: "HangHoa",
                principalColumn: "maHangHoa",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CTDH_DonHang",
                table: "ChiTietDonHang");

            migrationBuilder.DropForeignKey(
                name: "FK_CTDH_HangHoa",
                table: "ChiTietDonHang");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DonHang",
                table: "DonHang");

            migrationBuilder.DropIndex(
                name: "IX_DonHang_maDonhang",
                table: "DonHang");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChiTietDonHang",
                table: "ChiTietDonHang");

            migrationBuilder.DropColumn(
                name: "diaChiGiaoHang",
                table: "DonHang");

            migrationBuilder.DropColumn(
                name: "ngayDatHang",
                table: "DonHang");

            migrationBuilder.DropColumn(
                name: "ngayGiaoHang",
                table: "DonHang");

            migrationBuilder.DropColumn(
                name: "nguoiNhan",
                table: "DonHang");

            migrationBuilder.DropColumn(
                name: "tinhTrangDonHang",
                table: "DonHang");

            migrationBuilder.DropColumn(
                name: "donGia",
                table: "ChiTietDonHang");

            migrationBuilder.DropColumn(
                name: "soLuong",
                table: "ChiTietDonHang");

            migrationBuilder.RenameTable(
                name: "DonHang",
                newName: "donHangs");

            migrationBuilder.RenameTable(
                name: "ChiTietDonHang",
                newName: "chiTietDonHangs");

            migrationBuilder.RenameColumn(
                name: "soDienThoai",
                table: "donHangs",
                newName: "tenDonHang");

            migrationBuilder.RenameColumn(
                name: "maDonhang",
                table: "chiTietDonHangs",
                newName: "maDonHang");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietDonHang_maHangHoa",
                table: "chiTietDonHangs",
                newName: "IX_chiTietDonHangs_maHangHoa");

            migrationBuilder.AlterColumn<string>(
                name: "tenHangHoa",
                table: "HangHoa",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<double>(
                name: "giaTien",
                table: "donHangs",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "giamGia",
                table: "donHangs",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AlterColumn<double>(
                name: "giamGia",
                table: "chiTietDonHangs",
                type: "float",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AddPrimaryKey(
                name: "PK_donHangs",
                table: "donHangs",
                column: "maDonhang");

            migrationBuilder.AddPrimaryKey(
                name: "PK_chiTietDonHangs",
                table: "chiTietDonHangs",
                columns: new[] { "maDonHang", "maHangHoa" });

            migrationBuilder.AddForeignKey(
                name: "FK_chiTietDonHangs_donHangs_maDonHang",
                table: "chiTietDonHangs",
                column: "maDonHang",
                principalTable: "donHangs",
                principalColumn: "maDonhang",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_chiTietDonHangs_HangHoa_maHangHoa",
                table: "chiTietDonHangs",
                column: "maHangHoa",
                principalTable: "HangHoa",
                principalColumn: "maHangHoa",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
