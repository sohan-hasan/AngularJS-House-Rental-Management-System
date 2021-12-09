using Microsoft.EntityFrameworkCore.Migrations;

namespace HouseRentalManagementSystem.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RefBookingStatuses",
                keyColumn: "BookingStatusCode",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RefBookingStatuses",
                keyColumn: "BookingStatusCode",
                keyValue: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RefBookingStatuses",
                columns: new[] { "BookingStatusCode", "BookingStatusDescription" },
                values: new object[] { 1, "Confirmed" });

            migrationBuilder.InsertData(
                table: "RefBookingStatuses",
                columns: new[] { "BookingStatusCode", "BookingStatusDescription" },
                values: new object[] { 2, "Provisional" });
        }
    }
}
