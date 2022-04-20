using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopSiteApp.Migrations
{
    public partial class addPayment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CartName",
                table: "orderHeaders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CartNumber",
                table: "orderHeaders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cvc",
                table: "orderHeaders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ExpirationMonth",
                table: "orderHeaders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ExpirationYear",
                table: "orderHeaders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CartName",
                table: "orderHeaders");

            migrationBuilder.DropColumn(
                name: "CartNumber",
                table: "orderHeaders");

            migrationBuilder.DropColumn(
                name: "Cvc",
                table: "orderHeaders");

            migrationBuilder.DropColumn(
                name: "ExpirationMonth",
                table: "orderHeaders");

            migrationBuilder.DropColumn(
                name: "ExpirationYear",
                table: "orderHeaders");
        }
    }
}
