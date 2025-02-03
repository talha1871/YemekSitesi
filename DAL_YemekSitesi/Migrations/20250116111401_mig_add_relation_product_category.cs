using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL_YemekSitesi.Migrations
{
    public partial class mig_add_relation_product_category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Testimonials",
                table: "Testimonials");

            migrationBuilder.RenameTable(
                name: "Testimonials",
                newName: "Testimonial");

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Testimonial",
                table: "Testimonial",
                column: "TestimonialID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categorys_CategoryID",
                table: "Products",
                column: "CategoryID",
                principalTable: "Categorys",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categorys_CategoryID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryID",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Testimonial",
                table: "Testimonial");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Testimonial",
                newName: "Testimonials");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Testimonials",
                table: "Testimonials",
                column: "TestimonialID");
        }
    }
}
