using Microsoft.EntityFrameworkCore.Migrations;

namespace PetShop.Infrastructure.Persistence.Migrations
{
    public partial class UpdateUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Users_UserIdUser",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Addresses_AddressIdAddress",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_AddressIdAddress",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_UserIdUser",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "AddressIdAddress",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserIdUser",
                table: "Addresses");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AddressIdAddress",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserIdUser",
                table: "Addresses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_AddressIdAddress",
                table: "Users",
                column: "AddressIdAddress");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_UserIdUser",
                table: "Addresses",
                column: "UserIdUser");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Users_UserIdUser",
                table: "Addresses",
                column: "UserIdUser",
                principalTable: "Users",
                principalColumn: "IdUser",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Addresses_AddressIdAddress",
                table: "Users",
                column: "AddressIdAddress",
                principalTable: "Addresses",
                principalColumn: "IdAddress",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
