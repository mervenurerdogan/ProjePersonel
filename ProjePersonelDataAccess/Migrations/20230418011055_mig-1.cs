using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjePersonelDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmanName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmanID);
                });

            migrationBuilder.CreateTable(
                name: "PersonnelMissions",
                columns: table => new
                {
                    MissionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MissionName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    DepartmanID = table.Column<int>(type: "int", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonnelMissions", x => x.MissionID);
                    table.ForeignKey(
                        name: "FK_PersonnelMissions_Departments_DepartmanID",
                        column: x => x.DepartmanID,
                        principalTable: "Departments",
                        principalColumn: "DepartmanID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Personnels",
                columns: table => new
                {
                    PersonnelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentityNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlaceOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EducationStatus = table.Column<int>(type: "int", nullable: false),
                    StartWorkDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FinishWorkDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    DriverLicense = table.Column<int>(type: "int", nullable: false),
                    SummaryInfoPersonnel = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MissionID = table.Column<int>(type: "int", nullable: false),
                    DepartmanID = table.Column<int>(type: "int", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personnels", x => x.PersonnelID);
                    table.ForeignKey(
                        name: "FK_Personnels_Departments_DepartmanID",
                        column: x => x.DepartmanID,
                        principalTable: "Departments",
                        principalColumn: "DepartmanID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Personnels_PersonnelMissions_MissionID",
                        column: x => x.MissionID,
                        principalTable: "PersonnelMissions",
                        principalColumn: "MissionID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "PersonnelAddresses",
                columns: table => new
                {
                    AdressID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    AddressDescription = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    PersonnelID = table.Column<int>(type: "int", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonnelAddresses", x => x.AdressID);
                    table.ForeignKey(
                        name: "FK_PersonnelAddresses_Personnels_PersonnelID",
                        column: x => x.PersonnelID,
                        principalTable: "Personnels",
                        principalColumn: "PersonnelID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonnelPhoneNumbers",
                columns: table => new
                {
                    PersonnelPhoneNumberID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    NumberDescription = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    PersonnelID = table.Column<int>(type: "int", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonnelPhoneNumbers", x => x.PersonnelPhoneNumberID);
                    table.ForeignKey(
                        name: "FK_PersonnelPhoneNumbers_Personnels_PersonnelID",
                        column: x => x.PersonnelID,
                        principalTable: "Personnels",
                        principalColumn: "PersonnelID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmanID", "CreatedDateTime", "DepartmanName", "Description", "IsActive", "IsDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 18, 4, 10, 55, 54, DateTimeKind.Local).AddTicks(3487), "Yazılım", "A şirketinin    Yazılım Bölümü ", true, false },
                    { 2, new DateTime(2023, 4, 18, 4, 10, 55, 54, DateTimeKind.Local).AddTicks(3490), "Muhasebe", "A şirketinin    Muhasebe Bölümü ", true, false }
                });

            migrationBuilder.InsertData(
                table: "PersonnelMissions",
                columns: new[] { "MissionID", "CreatedDateTime", "DepartmanID", "Description", "IsActive", "IsDeleted", "MissionName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 18, 4, 10, 55, 55, DateTimeKind.Local).AddTicks(1454), 1, "A şirketi  yazılım bölümünde çalışan görevi mühendis olan kişi", true, false, "Mühendis" },
                    { 2, new DateTime(2023, 4, 18, 4, 10, 55, 55, DateTimeKind.Local).AddTicks(1461), 2, "A şirketi  muhasebe bölümünde çalışan görevi muhasebeci olan kişi", true, false, "Muhasebeci" }
                });

            migrationBuilder.InsertData(
                table: "Personnels",
                columns: new[] { "PersonnelID", "BirthDate", "CreatedDateTime", "DepartmanID", "DriverLicense", "EducationStatus", "Email", "FinishWorkDate", "Gender", "IdentityNumber", "IsActive", "IsDeleted", "MissionID", "Name", "PlaceOfBirth", "StartWorkDate", "SummaryInfoPersonnel", "Surname" },
                values: new object[] { 1, new DateTime(1985, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 18, 4, 10, 55, 54, DateTimeKind.Local).AddTicks(9377), 1, 3, 4, "user@gmail.com", new DateTime(2022, 2, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "98765432122", true, false, 1, "Ayşe", "Ankara", new DateTime(2022, 2, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), "Personel Açıklama hakkında ", "Yılmaz" });

            migrationBuilder.InsertData(
                table: "PersonnelAddresses",
                columns: new[] { "AdressID", "Address", "AddressDescription", "CreatedDateTime", "IsActive", "IsDeleted", "PersonnelID" },
                values: new object[] { 1, "Çiçek sokak gül apartmanı No10", "Ev Adresi", new DateTime(2023, 4, 18, 4, 10, 55, 54, DateTimeKind.Local).AddTicks(6713), true, false, 1 });

            migrationBuilder.InsertData(
                table: "PersonnelPhoneNumbers",
                columns: new[] { "PersonnelPhoneNumberID", "CreatedDateTime", "IsActive", "IsDeleted", "NumberDescription", "PersonnelID", "PhoneNumber" },
                values: new object[] { 1, new DateTime(2023, 4, 18, 4, 10, 55, 54, DateTimeKind.Local).AddTicks(5294), true, false, "Cep Telefon Numarası", 1, "98763215472" });

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelAddresses_PersonnelID",
                table: "PersonnelAddresses",
                column: "PersonnelID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelMissions_DepartmanID",
                table: "PersonnelMissions",
                column: "DepartmanID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelPhoneNumbers_PersonnelID",
                table: "PersonnelPhoneNumbers",
                column: "PersonnelID");

            migrationBuilder.CreateIndex(
                name: "IX_Personnels_DepartmanID",
                table: "Personnels",
                column: "DepartmanID");

            migrationBuilder.CreateIndex(
                name: "IX_Personnels_MissionID",
                table: "Personnels",
                column: "MissionID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonnelAddresses");

            migrationBuilder.DropTable(
                name: "PersonnelPhoneNumbers");

            migrationBuilder.DropTable(
                name: "Personnels");

            migrationBuilder.DropTable(
                name: "PersonnelMissions");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
