using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task.Migrations
{
    /// <inheritdoc />
    public partial class updateDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Specialties_SpecialtyId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Specialtyİd",
                table: "Teachers");

            migrationBuilder.AlterColumn<int>(
                name: "SpecialtyId",
                table: "Teachers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Specialties_SpecialtyId",
                table: "Teachers",
                column: "SpecialtyId",
                principalTable: "Specialties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Specialties_SpecialtyId",
                table: "Teachers");

            migrationBuilder.AlterColumn<int>(
                name: "SpecialtyId",
                table: "Teachers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Specialtyİd",
                table: "Teachers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Specialties_SpecialtyId",
                table: "Teachers",
                column: "SpecialtyId",
                principalTable: "Specialties",
                principalColumn: "Id");
        }
    }
}
