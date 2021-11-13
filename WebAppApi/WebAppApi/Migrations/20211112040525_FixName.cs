using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppApi.Migrations
{
    public partial class FixName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "tenLoai",
                table: "Loai",
                newName: "TenLoai");

            migrationBuilder.RenameColumn(
                name: "maLoai",
                table: "Loai",
                newName: "MaLoai");

            migrationBuilder.RenameColumn(
                name: "tenHangHoa",
                table: "HangHoa",
                newName: "TenHangHoa");

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
                name: "maHangHoa",
                table: "HangHoa",
                newName: "MaHangHoa");

            migrationBuilder.RenameColumn(
                name: "tinhTrangDonHang",
                table: "DonHang",
                newName: "TinhTrangDonHang");

            migrationBuilder.RenameColumn(
                name: "soDienThoai",
                table: "DonHang",
                newName: "SoDienThoai");

            migrationBuilder.RenameColumn(
                name: "nguoiNhan",
                table: "DonHang",
                newName: "NguoiNhan");

            migrationBuilder.RenameColumn(
                name: "ngayGiaoHang",
                table: "DonHang",
                newName: "NgayGiaoHang");

            migrationBuilder.RenameColumn(
                name: "ngayDatHang",
                table: "DonHang",
                newName: "NgayDatHang");

            migrationBuilder.RenameColumn(
                name: "diaChiGiaoHang",
                table: "DonHang",
                newName: "DiaChiGiaoHang");

            migrationBuilder.RenameColumn(
                name: "maDonhang",
                table: "DonHang",
                newName: "MaDonhang");

            migrationBuilder.RenameIndex(
                name: "IX_DonHang_maDonhang",
                table: "DonHang",
                newName: "IX_DonHang_MaDonhang");

            migrationBuilder.RenameColumn(
                name: "thanhTien",
                table: "ChiTietDonHang",
                newName: "ThanhTien");

            migrationBuilder.RenameColumn(
                name: "soLuong",
                table: "ChiTietDonHang",
                newName: "SoLuong");

            migrationBuilder.RenameColumn(
                name: "mieuTa",
                table: "ChiTietDonHang",
                newName: "MieuTa");

            migrationBuilder.RenameColumn(
                name: "giamGia",
                table: "ChiTietDonHang",
                newName: "GiamGia");

            migrationBuilder.RenameColumn(
                name: "donGia",
                table: "ChiTietDonHang",
                newName: "DonGia");

            migrationBuilder.RenameColumn(
                name: "maHangHoa",
                table: "ChiTietDonHang",
                newName: "MaHangHoa");

            migrationBuilder.RenameColumn(
                name: "maDonhang",
                table: "ChiTietDonHang",
                newName: "MaDonhang");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietDonHang_maHangHoa",
                table: "ChiTietDonHang",
                newName: "IX_ChiTietDonHang_MaHangHoa");

            migrationBuilder.AlterColumn<int>(
                name: "MaLoai",
                table: "Loai",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "maLoai",
                table: "HangHoa",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaHangHoa",
                table: "HangHoa",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "MaLoai",
                table: "HangHoa",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaDonhang",
                table: "DonHang",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "MaHangHoa",
                table: "ChiTietDonHang",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<int>(
                name: "MaDonhang",
                table: "ChiTietDonHang",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaLoai",
                table: "HangHoa");

            migrationBuilder.RenameColumn(
                name: "TenLoai",
                table: "Loai",
                newName: "tenLoai");

            migrationBuilder.RenameColumn(
                name: "MaLoai",
                table: "Loai",
                newName: "maLoai");

            migrationBuilder.RenameColumn(
                name: "TenHangHoa",
                table: "HangHoa",
                newName: "tenHangHoa");

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
                name: "MaHangHoa",
                table: "HangHoa",
                newName: "maHangHoa");

            migrationBuilder.RenameColumn(
                name: "TinhTrangDonHang",
                table: "DonHang",
                newName: "tinhTrangDonHang");

            migrationBuilder.RenameColumn(
                name: "SoDienThoai",
                table: "DonHang",
                newName: "soDienThoai");

            migrationBuilder.RenameColumn(
                name: "NguoiNhan",
                table: "DonHang",
                newName: "nguoiNhan");

            migrationBuilder.RenameColumn(
                name: "NgayGiaoHang",
                table: "DonHang",
                newName: "ngayGiaoHang");

            migrationBuilder.RenameColumn(
                name: "NgayDatHang",
                table: "DonHang",
                newName: "ngayDatHang");

            migrationBuilder.RenameColumn(
                name: "DiaChiGiaoHang",
                table: "DonHang",
                newName: "diaChiGiaoHang");

            migrationBuilder.RenameColumn(
                name: "MaDonhang",
                table: "DonHang",
                newName: "maDonhang");

            migrationBuilder.RenameIndex(
                name: "IX_DonHang_MaDonhang",
                table: "DonHang",
                newName: "IX_DonHang_maDonhang");

            migrationBuilder.RenameColumn(
                name: "ThanhTien",
                table: "ChiTietDonHang",
                newName: "thanhTien");

            migrationBuilder.RenameColumn(
                name: "SoLuong",
                table: "ChiTietDonHang",
                newName: "soLuong");

            migrationBuilder.RenameColumn(
                name: "MieuTa",
                table: "ChiTietDonHang",
                newName: "mieuTa");

            migrationBuilder.RenameColumn(
                name: "GiamGia",
                table: "ChiTietDonHang",
                newName: "giamGia");

            migrationBuilder.RenameColumn(
                name: "DonGia",
                table: "ChiTietDonHang",
                newName: "donGia");

            migrationBuilder.RenameColumn(
                name: "MaHangHoa",
                table: "ChiTietDonHang",
                newName: "maHangHoa");

            migrationBuilder.RenameColumn(
                name: "MaDonhang",
                table: "ChiTietDonHang",
                newName: "maDonhang");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietDonHang_MaHangHoa",
                table: "ChiTietDonHang",
                newName: "IX_ChiTietDonHang_maHangHoa");

            migrationBuilder.AlterColumn<Guid>(
                name: "maLoai",
                table: "Loai",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<Guid>(
                name: "maLoai",
                table: "HangHoa",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "maHangHoa",
                table: "HangHoa",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<Guid>(
                name: "maDonhang",
                table: "DonHang",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<Guid>(
                name: "maHangHoa",
                table: "ChiTietDonHang",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "maDonhang",
                table: "ChiTietDonHang",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
