using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Parcial2_Emely.Data.Migrations
{
    public partial class IncluyentoDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vitaminas",
                columns: table => new
                {
                    VitaminaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vitaminas", x => x.VitaminaId);
                });

            migrationBuilder.InsertData(
                table: "Vitaminas",
                columns: new[] { "VitaminaId", "Nombre" },
                values: new object[] { 1, "Vitamina C" });

            migrationBuilder.InsertData(
                table: "Vitaminas",
                columns: new[] { "VitaminaId", "Nombre" },
                values: new object[] { 2, "Betaina" });

            migrationBuilder.InsertData(
                table: "Vitaminas",
                columns: new[] { "VitaminaId", "Nombre" },
                values: new object[] { 3, "Vitamina K" });

            migrationBuilder.InsertData(
                table: "Vitaminas",
                columns: new[] { "VitaminaId", "Nombre" },
                values: new object[] { 4, "Vitamina B12" });

            migrationBuilder.InsertData(
                table: "Vitaminas",
                columns: new[] { "VitaminaId", "Nombre" },
                values: new object[] { 5, "Vitamina A" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vitaminas");
        }
    }
}
