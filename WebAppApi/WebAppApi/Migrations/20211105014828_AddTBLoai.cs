using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppApi.Migrations
{
    public partial class AddTBLoai : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "maLoai",
                table: "HangHoa",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Loai",
                columns: table => new
                {
                    maLoai = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tenLoai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loai", x => x.maLoai);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HangHoa_maLoai",
                table: "HangHoa",
                column: "maLoai");

            migrationBuilder.AddForeignKey(
                name: "FK_HangHoa_Loai_maLoai",
                table: "HangHoa",
                column: "maLoai",
                principalTable: "Loai",
                principalColumn: "maLoai",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HangHoa_Loai_maLoai",
                table: "HangHoa");

            migrationBuilder.DropTable(
                name: "Loai");

            migrationBuilder.DropIndex(
                name: "IX_HangHoa_maLoai",
                table: "HangHoa");

            migrationBuilder.DropColumn(
                name: "maLoai",
                table: "HangHoa");
        }
    }
}
