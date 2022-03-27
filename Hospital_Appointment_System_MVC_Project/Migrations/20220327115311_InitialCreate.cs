using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital_Appointment_System_MVC_Project.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Specialty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedMachineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateMachineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedMachineName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Identity_No = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Age = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedMachineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateMachineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedMachineName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Patient_Id = table.Column<int>(type: "int", nullable: false),
                    Doctor_Id = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedMachineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateMachineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedMachineName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_Doctors_Doctor_Id",
                        column: x => x.Doctor_Id,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointments_Patients_Patient_Id",
                        column: x => x.Patient_Id,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Address", "Age", "CreateDate", "CreatedIpAddress", "CreatedMachineName", "DeletedDate", "DeletedIpAddress", "DeletedMachineName", "FirstName", "LastName", "Phone", "Specialty", "UpdateDate", "UpdateIpAddress", "UpdateMachineName" },
                values: new object[,]
                {
                    { 1, "Galata Mah.Beyoğlu/İstanbul", "41", null, null, null, null, null, null, "Bülent", "GÜNEŞ", "05417415252", "Nutritionist", null, null, null },
                    { 2, "CELALİYE  Mah.Büyükçekmece/İstanbul", "33", null, null, null, null, null, null, "Barış", "YİĞİT", "05366325412", "internal Medicine Specialist", null, null, null },
                    { 3, "Ayazağa Mah.Sarıyer/İstanbul", "51", null, null, null, null, null, null, "Okan", "AYDIN", "05232143609", "Gynecologist", null, null, null },
                    { 4, "Atatürk  Mah.Arnavutköy/İstanbul", "43", null, null, null, null, null, null, "Levent", "CAYMAZ", "05328979878", "Plastic Surgery", null, null, null },
                    { 5, "Şirinevler Mah.Bahçelievler/İstanbul", "36", null, null, null, null, null, null, "Büşra", "BERK", "05366478543", "Pediatric Surgery", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "Age", "CreateDate", "CreatedIpAddress", "CreatedMachineName", "DeletedDate", "DeletedIpAddress", "DeletedMachineName", "FirstName", "Identity_No", "LastName", "Phone", "UpdateDate", "UpdateIpAddress", "UpdateMachineName" },
                values: new object[,]
                {
                    { 1, "İnönü Mah.Küçükçekmece/İstanbul", "26", null, null, null, null, null, null, "Oğuzhan", "68795435210", "KÖMCÜ", "05356548789", null, null, null },
                    { 2, "Çukur Mah.Fatih/İstanbul", "35", null, null, null, null, null, null, "Ozan", "55523698745", "SAĞLAM", "05321463625", null, null, null },
                    { 3, "Çobançeşme Mah.Bağcılar/İstanbul", "75", null, null, null, null, null, null, "Gamze", "25478965412", "KURT", "05312145326", null, null, null },
                    { 4, "Kartaltepe  Mah.Bakırköy/İstanbul", "22", null, null, null, null, null, null, "Elif", "21032547801", "DUMAN", "05326898587", null, null, null },
                    { 5, "Cumhuriyet Mah.Bahçelievler/İstanbul", "10", null, null, null, null, null, null, "Mertcan", "21304156987", "TUNA", "05365532284", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "CreateDate", "CreatedIpAddress", "CreatedMachineName", "Date", "DeletedDate", "DeletedIpAddress", "DeletedMachineName", "Doctor_Id", "Patient_Id", "Prescription", "Reason", "Time", "UpdateDate", "UpdateIpAddress", "UpdateMachineName" },
                values: new object[,]
                {
                    { 1, null, null, null, "10.02.2022", null, null, null, 2, 1, "Ağrı kesici ilacı", "Karın ağrısı", "14:00", null, null, null },
                    { 2, null, null, null, "10.02.2022", null, null, null, 2, 2, "Mide bulantısı ilacı", "Mide bulantısı", "14:30", null, null, null },
                    { 3, null, null, null, "12.02.2022", null, null, null, 3, 3, "Cinsiyeti belirlendi", "Doğum için bebek kontrolü", "10:00", null, null, null },
                    { 4, null, null, null, "13.02.2022", null, null, null, 1, 4, "Kilo vermesi için yeni bir diyet oluşturuldu.", "Fazla kilo", "13:00", null, null, null },
                    { 5, null, null, null, "14.02.2022", null, null, null, 5, 5, "Kol alçıya alındı", "Kırık kol", "15:00", null, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_Doctor_Id",
                table: "Appointments",
                column: "Doctor_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_Patient_Id",
                table: "Appointments",
                column: "Patient_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
