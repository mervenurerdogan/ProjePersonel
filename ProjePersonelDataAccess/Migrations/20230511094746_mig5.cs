using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjePersonelDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmanID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 5, 11, 12, 47, 46, 66, DateTimeKind.Local).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmanID",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2023, 5, 11, 12, 47, 46, 66, DateTimeKind.Local).AddTicks(5562));

            migrationBuilder.UpdateData(
                table: "EducationStatuses",
                keyColumn: "EducationID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 5, 11, 12, 47, 46, 67, DateTimeKind.Local).AddTicks(9315));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 5, 11, 12, 47, 46, 67, DateTimeKind.Local).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2023, 5, 11, 12, 47, 46, 67, DateTimeKind.Local).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "PersonnelAddresses",
                keyColumn: "AdressID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 5, 11, 12, 47, 46, 66, DateTimeKind.Local).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "PersonnelMissions",
                keyColumn: "MissionID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 5, 11, 12, 47, 46, 67, DateTimeKind.Local).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "PersonnelMissions",
                keyColumn: "MissionID",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2023, 5, 11, 12, 47, 46, 67, DateTimeKind.Local).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "PersonnelPhoneNumbers",
                keyColumn: "PersonnelPhoneNumberID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 5, 11, 12, 47, 46, 66, DateTimeKind.Local).AddTicks(7214));

            migrationBuilder.UpdateData(
                table: "Personnels",
                keyColumn: "PersonnelID",
                keyValue: 1,
                columns: new[] { "CreatedDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2023, 5, 11, 12, 47, 46, 67, DateTimeKind.Local).AddTicks(5319), new DateTime(2023, 5, 11, 12, 47, 46, 67, DateTimeKind.Local).AddTicks(5319) });

            migrationBuilder.InsertData(
                table: "Personnels",
                columns: new[] { "PersonnelID", "BirthDate", "CreatedDateTime", "DepartmanID", "EducationID", "Email", "FinishWorkDate", "GenderID", "IdentityNumber", "IsActive", "IsDeleted", "MissionID", "Name", "PlaceOfBirthID", "StartWorkDate", "SummaryInfoPersonnel", "Surname", "UpdateDateTime" },
                values: new object[] { 2, new DateTime(1991, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 11, 12, 47, 46, 67, DateTimeKind.Local).AddTicks(5323), 1, 1, "user@gmail.com", null, 1, "58715432129", true, false, 1, "Ali", 1, new DateTime(2020, 2, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), "Personel Açıklama hakkında ", "Er", new DateTime(2023, 5, 11, 12, 47, 46, 67, DateTimeKind.Local).AddTicks(5324) });

            migrationBuilder.UpdateData(
                table: "PlaceOfBirths",
                keyColumn: "CityID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 5, 11, 12, 47, 46, 67, DateTimeKind.Local).AddTicks(8170));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Personnels",
                keyColumn: "PersonnelID",
                keyValue: 2);

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
    }
}
