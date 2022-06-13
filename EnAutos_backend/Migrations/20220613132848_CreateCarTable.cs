using Microsoft.EntityFrameworkCore.Migrations;

namespace EnAutos_backend.Migrations
{
    public partial class CreateCarTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Dours = table.Column<int>(nullable: false),
                    Seats = table.Column<int>(nullable: false),
                    Luggage = table.Column<string>(nullable: true),
                    Transmission = table.Column<bool>(nullable: false),
                    AirConditioning = table.Column<bool>(nullable: false),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "catecoris",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CarId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_catecoris", x => x.Id);
                    table.ForeignKey(
                        name: "FK_catecoris_cars_CarId",
                        column: x => x.CarId,
                        principalTable: "cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_catecoris_CarId",
                table: "catecoris",
                column: "CarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "catecoris");

            migrationBuilder.DropTable(
                name: "cars");
        }
    }
}
