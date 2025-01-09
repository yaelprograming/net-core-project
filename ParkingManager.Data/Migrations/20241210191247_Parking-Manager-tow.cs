using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkingManager.Data.Migrations
{
    public partial class ParkingManagertow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "ParkingPlaceId",
                table: "Reservations",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "ParkingId",
                table: "Reservations",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "CustomerId",
                table: "Reservations",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "ParkingId",
                table: "Payments",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_CustomerId",
                table: "Reservations",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ParkingId",
                table: "Reservations",
                column: "ParkingId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ParkingPlaceId",
                table: "Reservations",
                column: "ParkingPlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_ParkingId",
                table: "Payments",
                column: "ParkingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_ParkingLots_ParkingId",
                table: "Payments",
                column: "ParkingId",
                principalTable: "ParkingLots",
                principalColumn: "ParkingLotId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Customers_CustomerId",
                table: "Reservations",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_ParkingLots_ParkingId",
                table: "Reservations",
                column: "ParkingId",
                principalTable: "ParkingLots",
                principalColumn: "ParkingLotId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_ParkingSpots_ParkingPlaceId",
                table: "Reservations",
                column: "ParkingPlaceId",
                principalTable: "ParkingSpots",
                principalColumn: "ParkingSpotId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_ParkingLots_ParkingId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Customers_CustomerId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_ParkingLots_ParkingId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_ParkingSpots_ParkingPlaceId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_CustomerId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_ParkingId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_ParkingPlaceId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Payments_ParkingId",
                table: "Payments");

            migrationBuilder.AlterColumn<int>(
                name: "ParkingPlaceId",
                table: "Reservations",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "ParkingId",
                table: "Reservations",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Reservations",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "ParkingId",
                table: "Payments",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");
        }
    }
}
