using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZombieParty.Migrations
{
    /// <inheritdoc />
    public partial class ZombieForce : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Force",
                table: "Zombies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Force",
                value: 50);

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Force",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Force",
                value: 75);

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Force",
                value: 100);

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Force", "Name" },
                values: new object[] { 80, "Ragamuffin " });

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 6,
                column: "Force",
                value: 60);

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Force", "Name" },
                values: new object[] { 25, "Taxidermy " });

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 8,
                column: "Force",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 9,
                column: "Force",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 10,
                column: "Force",
                value: 75);

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 11,
                column: "Force",
                value: 60);

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 12,
                column: "Force",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 13,
                column: "Force",
                value: 50);

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 14,
                column: "Force",
                value: 40);

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 15,
                column: "Force",
                value: 75);

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 16,
                column: "Force",
                value: 60);

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 17,
                column: "Force",
                value: 40);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Force",
                table: "Zombies");

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Ragamuffin ");

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Taxidermy ");
        }
    }
}
