using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjePersonelDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DriverLicense",
                table: "Personnels");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Personnels",
                newName: "GenderID");

            migrationBuilder.AlterColumn<string>(
                name: "EducationStatus",
                table: "Personnels",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    GenderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.GenderID);
                });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmanID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 18, 19, 10, 20, 253, DateTimeKind.Local).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmanID",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 18, 19, 10, 20, 253, DateTimeKind.Local).AddTicks(6678));

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "GenderID", "CreatedDateTime", "GenderName", "IsActive", "IsDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 18, 19, 10, 20, 254, DateTimeKind.Local).AddTicks(4120), "Kadın", true, false },
                    { 2, new DateTime(2023, 4, 18, 19, 10, 20, 254, DateTimeKind.Local).AddTicks(4122), "Erkek", true, false }
                });

            migrationBuilder.UpdateData(
                table: "PersonnelAddresses",
                keyColumn: "AdressID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 18, 19, 10, 20, 253, DateTimeKind.Local).AddTicks(9849));

            migrationBuilder.UpdateData(
                table: "PersonnelMissions",
                keyColumn: "MissionID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 18, 19, 10, 20, 254, DateTimeKind.Local).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "PersonnelMissions",
                keyColumn: "MissionID",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 18, 19, 10, 20, 254, DateTimeKind.Local).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "PersonnelPhoneNumbers",
                keyColumn: "PersonnelPhoneNumberID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 18, 19, 10, 20, 253, DateTimeKind.Local).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "Personnels",
                keyColumn: "PersonnelID",
                keyValue: 1,
                columns: new[] { "CreatedDateTime", "EducationStatus", "GenderID" },
                values: new object[] { new DateTime(2023, 4, 18, 19, 10, 20, 254, DateTimeKind.Local).AddTicks(2615), "Lisans", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Personnels_GenderID",
                table: "Personnels",
                column: "GenderID");

            migrationBuilder.AddForeignKey(
                name: "FK_Personnels_Genders_GenderID",
                table: "Personnels",
                column: "GenderID",
                principalTable: "Genders",
                principalColumn: "GenderID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personnels_Genders_GenderID",
                table: "Personnels");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropIndex(
                name: "IX_Personnels_GenderID",
                table: "Personnels");

            migrationBuilder.RenameColumn(
                name: "GenderID",
                table: "Personnels",
                newName: "Gender");

            migrationBuilder.AlterColumn<int>(
                name: "EducationStatus",
                table: "Personnels",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "DriverLicense",
                table: "Personnels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmanID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 18, 4, 10, 55, 54, DateTimeKind.Local).AddTicks(3487));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmanID",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 18, 4, 10, 55, 54, DateTimeKind.Local).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "PersonnelAddresses",
                keyColumn: "AdressID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 18, 4, 10, 55, 54, DateTimeKind.Local).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "PersonnelMissions",
                keyColumn: "MissionID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 18, 4, 10, 55, 55, DateTimeKind.Local).AddTicks(1454));

            migrationBuilder.UpdateData(
                table: "PersonnelMissions",
                keyColumn: "MissionID",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 18, 4, 10, 55, 55, DateTimeKind.Local).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "PersonnelPhoneNumbers",
                keyColumn: "PersonnelPhoneNumberID",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2023, 4, 18, 4, 10, 55, 54, DateTimeKind.Local).AddTicks(5294));

            migrationBuilder.UpdateData(
                table: "Personnels",
                keyColumn: "PersonnelID",
                keyValue: 1,
                columns: new[] { "CreatedDateTime", "DriverLicense", "EducationStatus", "Gender" },
                values: new object[] { new DateTime(2023, 4, 18, 4, 10, 55, 54, DateTimeKind.Local).AddTicks(9377), 3, 4, 2 });
        }
    }
}
