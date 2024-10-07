using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hotel_manager.Migrations
{
    /// <inheritdoc />
    public partial class CreationOfSeedersForRoomV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "rooms",
                columns: new[] { "id", "availability", "max_occupancy_persons", "price_per_night", "room_number", "room_type_id" },
                values: new object[,]
                {
                    { 5, true, (byte)1, 50.0, "105", 1 },
                    { 6, true, (byte)2, 80.0, "106", 2 },
                    { 7, true, (byte)2, 150.0, "107", 3 },
                    { 8, true, (byte)4, 200.0, "108", 4 },
                    { 9, true, (byte)1, 50.0, "109", 1 },
                    { 10, true, (byte)2, 80.0, "110", 2 },
                    { 11, true, (byte)1, 50.0, "201", 1 },
                    { 12, true, (byte)2, 80.0, "202", 2 },
                    { 13, true, (byte)2, 150.0, "203", 3 },
                    { 14, true, (byte)4, 200.0, "204", 4 },
                    { 15, true, (byte)1, 50.0, "205", 1 },
                    { 16, true, (byte)2, 80.0, "206", 2 },
                    { 17, true, (byte)2, 150.0, "207", 3 },
                    { 18, true, (byte)4, 200.0, "208", 4 },
                    { 19, true, (byte)1, 50.0, "209", 1 },
                    { 20, true, (byte)2, 80.0, "210", 2 },
                    { 21, true, (byte)1, 50.0, "301", 1 },
                    { 22, true, (byte)2, 80.0, "302", 2 },
                    { 23, true, (byte)2, 150.0, "303", 3 },
                    { 24, true, (byte)4, 200.0, "304", 4 },
                    { 25, true, (byte)1, 50.0, "305", 1 },
                    { 26, true, (byte)2, 80.0, "306", 2 },
                    { 27, true, (byte)2, 150.0, "307", 3 },
                    { 28, true, (byte)4, 200.0, "308", 4 },
                    { 29, true, (byte)1, 50.0, "309", 1 },
                    { 30, true, (byte)2, 80.0, "310", 2 },
                    { 31, true, (byte)1, 50.0, "401", 1 },
                    { 32, true, (byte)2, 80.0, "402", 2 },
                    { 33, true, (byte)2, 150.0, "403", 3 },
                    { 34, true, (byte)4, 200.0, "404", 4 },
                    { 35, true, (byte)1, 50.0, "405", 1 },
                    { 36, true, (byte)2, 80.0, "406", 2 },
                    { 37, true, (byte)2, 150.0, "407", 3 },
                    { 38, true, (byte)4, 200.0, "408", 4 },
                    { 39, true, (byte)1, 50.0, "409", 1 },
                    { 40, true, (byte)2, 80.0, "410", 2 },
                    { 41, true, (byte)1, 50.0, "501", 1 },
                    { 42, true, (byte)2, 80.0, "502", 2 },
                    { 43, true, (byte)2, 150.0, "503", 3 },
                    { 44, true, (byte)4, 200.0, "504", 4 },
                    { 45, true, (byte)1, 50.0, "505", 1 },
                    { 46, true, (byte)2, 80.0, "506", 2 },
                    { 47, true, (byte)2, 150.0, "507", 3 },
                    { 48, true, (byte)4, 200.0, "508", 4 },
                    { 49, true, (byte)1, 50.0, "509", 1 },
                    { 50, true, (byte)2, 80.0, "510", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 50);
        }
    }
}
