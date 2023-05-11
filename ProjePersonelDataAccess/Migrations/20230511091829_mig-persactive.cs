using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjePersonelDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class migpersactive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Aktifmi",
                table: "Personnels",
                type: "bit",
                nullable: false,
                computedColumnSql: "(CASE WHEN FinishWorkDate  IS NULL THEN 1 ELSE 0 END)");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmanID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 5, 11, 12, 18, 29, 120, DateTimeKind.Local).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmanID",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2023, 5, 11, 12, 18, 29, 120, DateTimeKind.Local).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "EducationStatuses",
                keyColumn: "EducationID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 5, 11, 12, 18, 29, 122, DateTimeKind.Local).AddTicks(774));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 5, 11, 12, 18, 29, 121, DateTimeKind.Local).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2023, 5, 11, 12, 18, 29, 121, DateTimeKind.Local).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "PersonnelAddresses",
                keyColumn: "AdressID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 5, 11, 12, 18, 29, 120, DateTimeKind.Local).AddTicks(9197));

            migrationBuilder.UpdateData(
                table: "PersonnelMissions",
                keyColumn: "MissionID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 5, 11, 12, 18, 29, 121, DateTimeKind.Local).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "PersonnelMissions",
                keyColumn: "MissionID",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2023, 5, 11, 12, 18, 29, 121, DateTimeKind.Local).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "PersonnelPhoneNumbers",
                keyColumn: "PersonnelPhoneNumberID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 5, 11, 12, 18, 29, 120, DateTimeKind.Local).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "Personnels",
                keyColumn: "PersonnelID",
                keyValue: 1,
                columns: new[] { "CreatedDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2023, 5, 11, 12, 18, 29, 121, DateTimeKind.Local).AddTicks(6294), new DateTime(2023, 5, 11, 12, 18, 29, 121, DateTimeKind.Local).AddTicks(6295) });

            migrationBuilder.UpdateData(
                table: "PlaceOfBirths",
                keyColumn: "CityID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 5, 11, 12, 18, 29, 121, DateTimeKind.Local).AddTicks(9513));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Aktifmi",
                table: "Personnels");

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
    }
}
