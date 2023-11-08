using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Application.Migrations
{
    /// <inheritdoc />
    public partial class manytomanyrelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Persons_PersonInfoId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_PersonInfoId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "PersonInfoId",
                table: "Cars");

            migrationBuilder.CreateTable(
                name: "PersonCars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonCars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonCars_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonCars_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonCars_CarId",
                table: "PersonCars",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonCars_PersonId",
                table: "PersonCars",
                column: "PersonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonCars");

            migrationBuilder.AddColumn<int>(
                name: "PersonInfoId",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cars_PersonInfoId",
                table: "Cars",
                column: "PersonInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Persons_PersonInfoId",
                table: "Cars",
                column: "PersonInfoId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
