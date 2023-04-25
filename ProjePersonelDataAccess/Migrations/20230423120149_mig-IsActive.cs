using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjePersonelDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class migIsActive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FinishWorkDate",
                table: "Personnels",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmanID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 23, 15, 1, 49, 13, DateTimeKind.Local).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmanID",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 23, 15, 1, 49, 13, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "EducationStatuses",
                keyColumn: "EducationID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 23, 15, 1, 49, 14, DateTimeKind.Local).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 23, 15, 1, 49, 14, DateTimeKind.Local).AddTicks(6551));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 23, 15, 1, 49, 14, DateTimeKind.Local).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "PersonnelAddresses",
                keyColumn: "AdressID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 23, 15, 1, 49, 13, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "PersonnelMissions",
                keyColumn: "MissionID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 23, 15, 1, 49, 14, DateTimeKind.Local).AddTicks(6167));

            migrationBuilder.UpdateData(
                table: "PersonnelMissions",
                keyColumn: "MissionID",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 23, 15, 1, 49, 14, DateTimeKind.Local).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "PersonnelPhoneNumbers",
                keyColumn: "PersonnelPhoneNumberID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 23, 15, 1, 49, 13, DateTimeKind.Local).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "Personnels",
                keyColumn: "PersonnelID",
                keyValue: 1,
                columns: new[] { "CreatedDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2023, 4, 23, 15, 1, 49, 14, DateTimeKind.Local).AddTicks(4960), new DateTime(2023, 4, 23, 15, 1, 49, 14, DateTimeKind.Local).AddTicks(4960) });

            migrationBuilder.UpdateData(
                table: "PlaceOfBirths",
                keyColumn: "CityID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 23, 15, 1, 49, 14, DateTimeKind.Local).AddTicks(7680));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FinishWorkDate",
                table: "Personnels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmanID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 22, 22, 19, 12, 210, DateTimeKind.Local).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmanID",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 22, 22, 19, 12, 210, DateTimeKind.Local).AddTicks(343));

            migrationBuilder.UpdateData(
                table: "EducationStatuses",
                keyColumn: "EducationID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 22, 22, 19, 12, 211, DateTimeKind.Local).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 22, 22, 19, 12, 211, DateTimeKind.Local).AddTicks(3018));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 22, 22, 19, 12, 211, DateTimeKind.Local).AddTicks(3019));

            migrationBuilder.UpdateData(
                table: "PersonnelAddresses",
                keyColumn: "AdressID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 22, 22, 19, 12, 210, DateTimeKind.Local).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "PersonnelMissions",
                keyColumn: "MissionID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 22, 22, 19, 12, 211, DateTimeKind.Local).AddTicks(2417));

            migrationBuilder.UpdateData(
                table: "PersonnelMissions",
                keyColumn: "MissionID",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 22, 22, 19, 12, 211, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "PersonnelPhoneNumbers",
                keyColumn: "PersonnelPhoneNumberID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 22, 22, 19, 12, 210, DateTimeKind.Local).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "Personnels",
                keyColumn: "PersonnelID",
                keyValue: 1,
                columns: new[] { "CreatedDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2023, 4, 22, 22, 19, 12, 211, DateTimeKind.Local).AddTicks(1064), new DateTime(2023, 4, 22, 22, 19, 12, 211, DateTimeKind.Local).AddTicks(1064) });

            migrationBuilder.UpdateData(
                table: "PlaceOfBirths",
                keyColumn: "CityID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 22, 22, 19, 12, 211, DateTimeKind.Local).AddTicks(4292));
        }
    }
}
