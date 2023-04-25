using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjePersonelDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmanID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 22, 21, 4, 30, 277, DateTimeKind.Local).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmanID",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 22, 21, 4, 30, 277, DateTimeKind.Local).AddTicks(9872));

            migrationBuilder.UpdateData(
                table: "EducationStatuses",
                keyColumn: "EducationID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 22, 21, 4, 30, 279, DateTimeKind.Local).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 22, 21, 4, 30, 279, DateTimeKind.Local).AddTicks(1637));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 22, 21, 4, 30, 279, DateTimeKind.Local).AddTicks(1640));

            migrationBuilder.UpdateData(
                table: "PersonnelAddresses",
                keyColumn: "AdressID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 22, 21, 4, 30, 278, DateTimeKind.Local).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "PersonnelMissions",
                keyColumn: "MissionID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 22, 21, 4, 30, 279, DateTimeKind.Local).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "PersonnelMissions",
                keyColumn: "MissionID",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 22, 21, 4, 30, 279, DateTimeKind.Local).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "PersonnelPhoneNumbers",
                keyColumn: "PersonnelPhoneNumberID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 22, 21, 4, 30, 278, DateTimeKind.Local).AddTicks(1767));

            migrationBuilder.UpdateData(
                table: "Personnels",
                keyColumn: "PersonnelID",
                keyValue: 1,
                columns: new[] { "CreatedDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2023, 4, 22, 21, 4, 30, 278, DateTimeKind.Local).AddTicks(9792), new DateTime(2023, 4, 22, 21, 4, 30, 278, DateTimeKind.Local).AddTicks(9797) });

            migrationBuilder.UpdateData(
                table: "PlaceOfBirths",
                keyColumn: "CityID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 22, 21, 4, 30, 279, DateTimeKind.Local).AddTicks(2896));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmanID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 22, 21, 1, 48, 548, DateTimeKind.Local).AddTicks(394));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmanID",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 22, 21, 1, 48, 548, DateTimeKind.Local).AddTicks(399));

            migrationBuilder.UpdateData(
                table: "EducationStatuses",
                keyColumn: "EducationID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 22, 21, 1, 48, 549, DateTimeKind.Local).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 22, 21, 1, 48, 549, DateTimeKind.Local).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 22, 21, 1, 48, 549, DateTimeKind.Local).AddTicks(3112));

            migrationBuilder.UpdateData(
                table: "PersonnelAddresses",
                keyColumn: "AdressID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 22, 21, 1, 48, 548, DateTimeKind.Local).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "PersonnelMissions",
                keyColumn: "MissionID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 22, 21, 1, 48, 549, DateTimeKind.Local).AddTicks(2505));

            migrationBuilder.UpdateData(
                table: "PersonnelMissions",
                keyColumn: "MissionID",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 22, 21, 1, 48, 549, DateTimeKind.Local).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "PersonnelPhoneNumbers",
                keyColumn: "PersonnelPhoneNumberID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 22, 21, 1, 48, 548, DateTimeKind.Local).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "Personnels",
                keyColumn: "PersonnelID",
                keyValue: 1,
                columns: new[] { "CreatedDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2023, 4, 22, 21, 1, 48, 549, DateTimeKind.Local).AddTicks(1139), new DateTime(2023, 4, 22, 21, 1, 48, 549, DateTimeKind.Local).AddTicks(1140) });

            migrationBuilder.UpdateData(
                table: "PlaceOfBirths",
                keyColumn: "CityID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 22, 21, 1, 48, 549, DateTimeKind.Local).AddTicks(4477));
        }
    }
}
