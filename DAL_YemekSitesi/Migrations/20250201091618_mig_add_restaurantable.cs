using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL_YemekSitesi.Migrations
{
    public partial class mig_add_restaurantable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RestaurantTables",
                columns: table => new
                {
                    RestaurantTableID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantTables", x => x.RestaurantTableID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RestaurantTables");
        }
    }
}
