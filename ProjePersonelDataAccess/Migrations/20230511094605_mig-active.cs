using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjePersonelDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class migactive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Aktifmi",
                table: "Personnels",
                type: "bit",
                nullable: false,
                computedColumnSql: "(CASE WHEN FinishWorkDate IS NULL THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END)",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComputedColumnSql: "(CASE WHEN FinishWorkDate  IS NULL THEN 1 ELSE 0 END)");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmanID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 5, 11, 12, 46, 5, 201, DateTimeKind.Local).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmanID",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2023, 5, 11, 12, 46, 5, 201, DateTimeKind.Local).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "EducationStatuses",
                keyColumn: "EducationID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 5, 11, 12, 46, 5, 203, DateTimeKind.Local).AddTicks(648));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 5, 11, 12, 46, 5, 202, DateTimeKind.Local).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2023, 5, 11, 12, 46, 5, 202, DateTimeKind.Local).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "PersonnelAddresses",
                keyColumn: "AdressID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 5, 11, 12, 46, 5, 201, DateTimeKind.Local).AddTicks(9745));

            migrationBuilder.UpdateData(
                table: "PersonnelMissions",
                keyColumn: "MissionID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 5, 11, 12, 46, 5, 202, DateTimeKind.Local).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "PersonnelMissions",
                keyColumn: "MissionID",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2023, 5, 11, 12, 46, 5, 202, DateTimeKind.Local).AddTicks(7775));

            migrationBuilder.UpdateData(
                table: "PersonnelPhoneNumbers",
                keyColumn: "PersonnelPhoneNumberID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 5, 11, 12, 46, 5, 201, DateTimeKind.Local).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "Personnels",
                keyColumn: "PersonnelID",
                keyValue: 1,
                columns: new[] { "CreatedDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2023, 5, 11, 12, 46, 5, 202, DateTimeKind.Local).AddTicks(6523), new DateTime(2023, 5, 11, 12, 46, 5, 202, DateTimeKind.Local).AddTicks(6524) });

            migrationBuilder.UpdateData(
                table: "PlaceOfBirths",
                keyColumn: "CityID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 5, 11, 12, 46, 5, 202, DateTimeKind.Local).AddTicks(9467));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Aktifmi",
                table: "Personnels",
                type: "bit",
                nullable: false,
                computedColumnSql: "(CASE WHEN FinishWorkDate  IS NULL THEN 1 ELSE 0 END)",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComputedColumnSql: "(CASE WHEN FinishWorkDate IS NULL THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END)");

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
    }
}
