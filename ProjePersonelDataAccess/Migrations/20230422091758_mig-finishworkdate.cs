using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjePersonelDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class migfinishworkdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Personnels",
                type: "bit",
                nullable: false,
                computedColumnSql: "CASE WHEN FinishWorkDate IS NULL THEN 1 ELSE 0 END",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmanID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 22, 12, 17, 58, 135, DateTimeKind.Local).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmanID",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 22, 12, 17, 58, 135, DateTimeKind.Local).AddTicks(4047));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 22, 12, 17, 58, 136, DateTimeKind.Local).AddTicks(2637));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 22, 12, 17, 58, 136, DateTimeKind.Local).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "PersonnelAddresses",
                keyColumn: "AdressID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 22, 12, 17, 58, 135, DateTimeKind.Local).AddTicks(7626));

            migrationBuilder.UpdateData(
                table: "PersonnelMissions",
                keyColumn: "MissionID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 22, 12, 17, 58, 136, DateTimeKind.Local).AddTicks(2138));

            migrationBuilder.UpdateData(
                table: "PersonnelMissions",
                keyColumn: "MissionID",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 22, 12, 17, 58, 136, DateTimeKind.Local).AddTicks(2142));

            migrationBuilder.UpdateData(
                table: "PersonnelPhoneNumbers",
                keyColumn: "PersonnelPhoneNumberID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 22, 12, 17, 58, 135, DateTimeKind.Local).AddTicks(6093));

            migrationBuilder.UpdateData(
                table: "Personnels",
                keyColumn: "PersonnelID",
                keyValue: 1,
                columns: new[] { "CreatedDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2023, 4, 22, 12, 17, 58, 136, DateTimeKind.Local).AddTicks(917), new DateTime(2023, 4, 22, 12, 17, 58, 136, DateTimeKind.Local).AddTicks(918) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Personnels",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComputedColumnSql: "CASE WHEN FinishWorkDate IS NULL THEN 1 ELSE 0 END");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmanID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 18, 21, 45, 40, 14, DateTimeKind.Local).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmanID",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 18, 21, 45, 40, 14, DateTimeKind.Local).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 18, 21, 45, 40, 15, DateTimeKind.Local).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 18, 21, 45, 40, 15, DateTimeKind.Local).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "PersonnelAddresses",
                keyColumn: "AdressID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 18, 21, 45, 40, 14, DateTimeKind.Local).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "PersonnelMissions",
                keyColumn: "MissionID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 18, 21, 45, 40, 15, DateTimeKind.Local).AddTicks(3037));

            migrationBuilder.UpdateData(
                table: "PersonnelMissions",
                keyColumn: "MissionID",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 18, 21, 45, 40, 15, DateTimeKind.Local).AddTicks(3041));

            migrationBuilder.UpdateData(
                table: "PersonnelPhoneNumbers",
                keyColumn: "PersonnelPhoneNumberID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 18, 21, 45, 40, 14, DateTimeKind.Local).AddTicks(6764));

            migrationBuilder.UpdateData(
                table: "Personnels",
                keyColumn: "PersonnelID",
                keyValue: 1,
                columns: new[] { "CreatedDateTime", "IsActive", "UpdateDateTime" },
                values: new object[] { new DateTime(2023, 4, 18, 21, 45, 40, 15, DateTimeKind.Local).AddTicks(1762), true, new DateTime(2023, 4, 18, 21, 45, 40, 15, DateTimeKind.Local).AddTicks(1751) });
        }
    }
}
