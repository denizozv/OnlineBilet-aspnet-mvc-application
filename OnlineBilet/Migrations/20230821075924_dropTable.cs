using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineBilet.Migrations
{
    /// <inheritdoc />
    public partial class dropTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Halls_HallNumber",
                table: "Movies");

            migrationBuilder.DropTable(
                name: "Halls");

            migrationBuilder.DropIndex(
                name: "IX_Movies_HallNumber",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "HallNumber",
                table: "Movies");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HallNumber",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Halls",
                columns: table => new
                {
                    HallNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Halls", x => x.HallNumber);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_HallNumber",
                table: "Movies",
                column: "HallNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Halls_HallNumber",
                table: "Movies",
                column: "HallNumber",
                principalTable: "Halls",
                principalColumn: "HallNumber",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
