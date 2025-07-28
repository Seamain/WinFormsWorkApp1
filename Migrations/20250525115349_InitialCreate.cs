using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WinFormsWorkApp1.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Beds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    BedNumber = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    RoomNumber = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    RoomType = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    MonthlyRate = table.Column<decimal>(type: "DECIMAL(10,2)", nullable: false),
                    Facilities = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Notes = table.Column<string>(type: "longchar", maxLength: 500, nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarePackages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    PackageName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "longchar", maxLength: 500, nullable: false),
                    ServiceItems = table.Column<string>(type: "longchar", maxLength: 1000, nullable: false),
                    MonthlyPrice = table.Column<decimal>(type: "DECIMAL(10,2)", nullable: false),
                    CareLevel = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    IsActive = table.Column<bool>(type: "smallint", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarePackages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Consultants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Gender = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    Address = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    ContactPerson = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    ContactPhone = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Notes = table.Column<string>(type: "longchar", maxLength: 500, nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    IdCard = table.Column<string>(type: "varchar(18)", maxLength: 18, nullable: false),
                    Gender = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Age = table.Column<int>(type: "integer", nullable: true),
                    Phone = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    EmergencyContact = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    EmergencyPhone = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Position = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Department = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    HireDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    TerminationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Notes = table.Column<string>(type: "longchar", maxLength: 500, nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Facilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Category = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Location = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "longchar", maxLength: 500, nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    PurchasePrice = table.Column<decimal>(type: "DECIMAL(10,2)", nullable: false),
                    Manufacturer = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Model = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    LastMaintenanceDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    NextMaintenanceDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    MaintenanceRecord = table.Column<string>(type: "longchar", maxLength: 500, nullable: false),
                    Notes = table.Column<string>(type: "longchar", maxLength: 500, nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facilities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FeeTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    StandardPrice = table.Column<decimal>(type: "DECIMAL(10,2)", nullable: false),
                    BillingCycle = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    IsActive = table.Column<bool>(type: "smallint", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeeTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    MedicationName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    MedicationType = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Specification = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Manufacturer = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Indications = table.Column<string>(type: "longchar", maxLength: 1000, nullable: false),
                    SideEffects = table.Column<string>(type: "longchar", maxLength: 1000, nullable: false),
                    StorageConditions = table.Column<string>(type: "longchar", maxLength: 500, nullable: false),
                    IsActive = table.Column<bool>(type: "smallint", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Location = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Manager = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    ContactPhone = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Category = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "longchar", maxLength: 500, nullable: false),
                    Area = table.Column<decimal>(type: "DECIMAL(8,2)", nullable: false),
                    Capacity = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Notes = table.Column<string>(type: "longchar", maxLength: 500, nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Residents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    IdCard = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Gender = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    Phone = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    EmergencyContact = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    EmergencyPhone = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    MedicalHistory = table.Column<string>(type: "longchar", maxLength: 500, nullable: false),
                    Allergies = table.Column<string>(type: "longchar", maxLength: 500, nullable: false),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    BedId = table.Column<int>(type: "integer", nullable: true),
                    CheckInDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CheckOutDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Notes = table.Column<string>(type: "longchar", maxLength: 500, nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Residents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Residents_Beds_BedId",
                        column: x => x.BedId,
                        principalTable: "Beds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    ConsultantId = table.Column<int>(type: "integer", nullable: false),
                    BedId = table.Column<int>(type: "integer", nullable: true),
                    ReservationDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    PreferredMoveInDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    ServiceType = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    EstimatedCost = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Requirements = table.Column<string>(type: "longchar", maxLength: 500, nullable: false),
                    Notes = table.Column<string>(type: "longchar", maxLength: 500, nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Beds_BedId",
                        column: x => x.BedId,
                        principalTable: "Beds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Reservations_Consultants_ConsultantId",
                        column: x => x.ConsultantId,
                        principalTable: "Consultants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AttendanceRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "integer", nullable: false),
                    AttendanceDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CheckInTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    CheckOutTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Notes = table.Column<string>(type: "longchar", maxLength: 500, nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendanceRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AttendanceRecords_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LeaveRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "integer", nullable: false),
                    LeaveType = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Days = table.Column<decimal>(type: "DECIMAL(4,1)", nullable: false),
                    Reason = table.Column<string>(type: "longchar", maxLength: 500, nullable: false),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    ApprovedBy = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    ApprovalDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Notes = table.Column<string>(type: "longchar", maxLength: 500, nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRecords_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Category = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Specification = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Unit = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Manufacturer = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Supplier = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    SupplierPhone = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    PurchasePrice = table.Column<decimal>(type: "DECIMAL(10,2)", nullable: false),
                    MinimumStock = table.Column<int>(type: "integer", nullable: false),
                    WarningStock = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "longchar", maxLength: 500, nullable: false),
                    Notes = table.Column<string>(type: "longchar", maxLength: 500, nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    WarehouseId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CareRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    ResidentId = table.Column<int>(type: "integer", nullable: false),
                    CarePackageId = table.Column<int>(type: "integer", nullable: true),
                    CareDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CareType = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    CareContent = table.Column<string>(type: "longchar", maxLength: 500, nullable: false),
                    CareResult = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Notes = table.Column<string>(type: "longchar", maxLength: 500, nullable: false),
                    CaregiverName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CareRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CareRecords_CarePackages_CarePackageId",
                        column: x => x.CarePackageId,
                        principalTable: "CarePackages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_CareRecords_Residents_ResidentId",
                        column: x => x.ResidentId,
                        principalTable: "Residents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FeeRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    ResidentId = table.Column<int>(type: "integer", nullable: false),
                    FeeTypeId = table.Column<int>(type: "integer", nullable: false),
                    Amount = table.Column<decimal>(type: "DECIMAL(10,2)", nullable: false),
                    BillingDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Remarks = table.Column<string>(type: "longchar", maxLength: 500, nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeeRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeeRecords_FeeTypes_FeeTypeId",
                        column: x => x.FeeTypeId,
                        principalTable: "FeeTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FeeRecords_Residents_ResidentId",
                        column: x => x.ResidentId,
                        principalTable: "Residents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HealthRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    ResidentId = table.Column<int>(type: "integer", nullable: false),
                    RecordDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    RecordType = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    BloodPressureHigh = table.Column<decimal>(type: "DECIMAL(5,1)", nullable: true),
                    BloodPressureLow = table.Column<decimal>(type: "DECIMAL(5,1)", nullable: true),
                    HeartRate = table.Column<decimal>(type: "DECIMAL(5,1)", nullable: true),
                    Temperature = table.Column<decimal>(type: "DECIMAL(4,1)", nullable: true),
                    BloodSugar = table.Column<decimal>(type: "DECIMAL(5,2)", nullable: true),
                    Weight = table.Column<decimal>(type: "DECIMAL(5,2)", nullable: true),
                    Height = table.Column<decimal>(type: "DECIMAL(5,2)", nullable: true),
                    Symptoms = table.Column<string>(type: "longchar", maxLength: 1000, nullable: false),
                    Diagnosis = table.Column<string>(type: "longchar", maxLength: 1000, nullable: false),
                    Treatment = table.Column<string>(type: "longchar", maxLength: 1000, nullable: false),
                    Notes = table.Column<string>(type: "longchar", maxLength: 500, nullable: false),
                    RecorderName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    RecorderType = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealthRecords_Residents_ResidentId",
                        column: x => x.ResidentId,
                        principalTable: "Residents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MealRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    ResidentId = table.Column<int>(type: "integer", nullable: false),
                    MealDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    MealType = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    MenuItems = table.Column<string>(type: "longchar", maxLength: 500, nullable: false),
                    Appetite = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    SpecialDiet = table.Column<string>(type: "longchar", maxLength: 500, nullable: false),
                    Notes = table.Column<string>(type: "longchar", maxLength: 500, nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MealRecords_Residents_ResidentId",
                        column: x => x.ResidentId,
                        principalTable: "Residents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicalMonitorings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    ResidentId = table.Column<int>(type: "integer", nullable: false),
                    MonitoringDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    MonitoringType = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    MonitoringItem = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Result = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Unit = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    NormalRange = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Recommendations = table.Column<string>(type: "longchar", maxLength: 1000, nullable: false),
                    Notes = table.Column<string>(type: "longchar", maxLength: 500, nullable: false),
                    MonitoredBy = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    MonitoredByType = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalMonitorings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalMonitorings_Residents_ResidentId",
                        column: x => x.ResidentId,
                        principalTable: "Residents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicationRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    ResidentId = table.Column<int>(type: "integer", nullable: false),
                    MedicationId = table.Column<int>(type: "integer", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Dosage = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Frequency = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Usage = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Purpose = table.Column<string>(type: "longchar", maxLength: 500, nullable: false),
                    Notes = table.Column<string>(type: "longchar", maxLength: 500, nullable: false),
                    PrescribedBy = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicationRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicationRecords_Medications_MedicationId",
                        column: x => x.MedicationId,
                        principalTable: "Medications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicationRecords_Residents_ResidentId",
                        column: x => x.ResidentId,
                        principalTable: "Residents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OutingRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    ResidentId = table.Column<int>(type: "integer", nullable: false),
                    Destination = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Purpose = table.Column<string>(type: "longchar", maxLength: 500, nullable: false),
                    OutTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ReturnTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Companion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    CompanionPhone = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Notes = table.Column<string>(type: "longchar", maxLength: 500, nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutingRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OutingRecords_Residents_ResidentId",
                        column: x => x.ResidentId,
                        principalTable: "Residents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    ItemId = table.Column<int>(type: "integer", nullable: false),
                    WarehouseId = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    ProductionDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ExpiryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    BatchNumber = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Location = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Notes = table.Column<string>(type: "longchar", maxLength: 500, nullable: false),
                    LastCheckDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inventories_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inventories_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InventoryTransactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    ItemId = table.Column<int>(type: "integer", nullable: false),
                    WarehouseId = table.Column<int>(type: "integer", nullable: false),
                    TransactionType = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Operator = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Source = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    BatchNumber = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Reason = table.Column<string>(type: "longchar", maxLength: 500, nullable: false),
                    Notes = table.Column<string>(type: "longchar", maxLength: 500, nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InventoryTransactions_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InventoryTransactions_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    FeeRecordId = table.Column<int>(type: "integer", nullable: false),
                    PaymentAmount = table.Column<decimal>(type: "DECIMAL(10,2)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    PaymentMethod = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    ReceiptNumber = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Operator = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Remarks = table.Column<string>(type: "longchar", maxLength: 500, nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentRecords_FeeRecords_FeeRecordId",
                        column: x => x.FeeRecordId,
                        principalTable: "FeeRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Beds",
                columns: new[] { "Id", "BedNumber", "CreateTime", "Facilities", "MonthlyRate", "Notes", "RoomNumber", "RoomType", "Status", "UpdateTime" },
                values: new object[,]
                {
                    { 1, "101-01", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "独立卫生间、空调、电视、衣柜", 3000m, "", "101", "单人间", "空闲", null },
                    { 2, "102-01", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "独立卫生间、空调、电视、衣柜", 3000m, "", "102", "单人间", "空闲", null },
                    { 3, "103-01", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "独立卫生间、空调、电视、衣柜", 3000m, "", "103", "单人间", "空闲", null },
                    { 4, "104-01", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "独立卫生间、空调、电视、衣柜", 3000m, "", "104", "单人间", "空闲", null },
                    { 5, "105-01", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "独立卫生间、空调、电视、衣柜", 3000m, "", "105", "单人间", "空闲", null },
                    { 6, "106-01", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "共用卫生间、空调、电视、衣柜", 2000m, "", "106", "双人间", "空闲", null },
                    { 7, "106-02", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "共用卫生间、空调、电视、衣柜", 2000m, "", "106", "双人间", "空闲", null },
                    { 8, "107-01", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "共用卫生间、空调、电视、衣柜", 2000m, "", "107", "双人间", "空闲", null },
                    { 9, "107-02", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "共用卫生间、空调、电视、衣柜", 2000m, "", "107", "双人间", "空闲", null },
                    { 10, "108-01", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "共用卫生间、空调、电视、衣柜", 2000m, "", "108", "双人间", "空闲", null },
                    { 11, "108-02", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "共用卫生间、空调、电视、衣柜", 2000m, "", "108", "双人间", "空闲", null },
                    { 12, "109-01", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "共用卫生间、空调、电视、衣柜", 2000m, "", "109", "双人间", "空闲", null },
                    { 13, "109-02", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "共用卫生间、空调、电视、衣柜", 2000m, "", "109", "双人间", "空闲", null },
                    { 14, "110-01", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "共用卫生间、空调、电视、衣柜", 2000m, "", "110", "双人间", "空闲", null },
                    { 15, "110-02", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "共用卫生间、空调、电视、衣柜", 2000m, "", "110", "双人间", "空闲", null },
                    { 16, "201-01", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "独立卫生间、空调、电视、衣柜", 3000m, "", "201", "单人间", "空闲", null },
                    { 17, "202-01", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "独立卫生间、空调、电视、衣柜", 3000m, "", "202", "单人间", "空闲", null },
                    { 18, "203-01", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "独立卫生间、空调、电视、衣柜", 3000m, "", "203", "单人间", "空闲", null },
                    { 19, "204-01", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "独立卫生间、空调、电视、衣柜", 3000m, "", "204", "单人间", "空闲", null },
                    { 20, "205-01", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "独立卫生间、空调、电视、衣柜", 3000m, "", "205", "单人间", "空闲", null },
                    { 21, "206-01", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "共用卫生间、空调、电视、衣柜", 2000m, "", "206", "双人间", "空闲", null },
                    { 22, "206-02", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "共用卫生间、空调、电视、衣柜", 2000m, "", "206", "双人间", "空闲", null },
                    { 23, "207-01", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "共用卫生间、空调、电视、衣柜", 2000m, "", "207", "双人间", "空闲", null },
                    { 24, "207-02", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "共用卫生间、空调、电视、衣柜", 2000m, "", "207", "双人间", "空闲", null },
                    { 25, "208-01", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "共用卫生间、空调、电视、衣柜", 2000m, "", "208", "双人间", "空闲", null },
                    { 26, "208-02", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "共用卫生间、空调、电视、衣柜", 2000m, "", "208", "双人间", "空闲", null },
                    { 27, "209-01", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "共用卫生间、空调、电视、衣柜", 2000m, "", "209", "双人间", "空闲", null },
                    { 28, "209-02", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "共用卫生间、空调、电视、衣柜", 2000m, "", "209", "双人间", "空闲", null },
                    { 29, "210-01", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "共用卫生间、空调、电视、衣柜", 2000m, "", "210", "双人间", "空闲", null },
                    { 30, "210-02", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "共用卫生间、空调、电视、衣柜", 2000m, "", "210", "双人间", "空闲", null },
                    { 31, "301-01", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "独立卫生间、空调、电视、衣柜", 3000m, "", "301", "单人间", "空闲", null },
                    { 32, "302-01", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "独立卫生间、空调、电视、衣柜", 3000m, "", "302", "单人间", "空闲", null },
                    { 33, "303-01", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "独立卫生间、空调、电视、衣柜", 3000m, "", "303", "单人间", "空闲", null },
                    { 34, "304-01", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "独立卫生间、空调、电视、衣柜", 3000m, "", "304", "单人间", "空闲", null },
                    { 35, "305-01", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "独立卫生间、空调、电视、衣柜", 3000m, "", "305", "单人间", "空闲", null },
                    { 36, "306-01", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "共用卫生间、空调、电视、衣柜", 2000m, "", "306", "双人间", "空闲", null },
                    { 37, "306-02", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "共用卫生间、空调、电视、衣柜", 2000m, "", "306", "双人间", "空闲", null },
                    { 38, "307-01", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "共用卫生间、空调、电视、衣柜", 2000m, "", "307", "双人间", "空闲", null },
                    { 39, "307-02", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "共用卫生间、空调、电视、衣柜", 2000m, "", "307", "双人间", "空闲", null },
                    { 40, "308-01", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "共用卫生间、空调、电视、衣柜", 2000m, "", "308", "双人间", "空闲", null },
                    { 41, "308-02", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "共用卫生间、空调、电视、衣柜", 2000m, "", "308", "双人间", "空闲", null },
                    { 42, "309-01", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "共用卫生间、空调、电视、衣柜", 2000m, "", "309", "双人间", "空闲", null },
                    { 43, "309-02", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "共用卫生间、空调、电视、衣柜", 2000m, "", "309", "双人间", "空闲", null },
                    { 44, "310-01", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "共用卫生间、空调、电视、衣柜", 2000m, "", "310", "双人间", "空闲", null },
                    { 45, "310-02", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "共用卫生间、空调、电视、衣柜", 2000m, "", "310", "双人间", "空闲", null }
                });

            migrationBuilder.InsertData(
                table: "CarePackages",
                columns: new[] { "Id", "CareLevel", "CreateTime", "Description", "IsActive", "MonthlyPrice", "PackageName", "ServiceItems" },
                values: new object[,]
                {
                    { 1, "自理", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "适合生活能够自理的老人", true, 800m, "基础护理套餐", "日常生活协助、健康监测、定期查房、紧急呼叫" },
                    { 2, "半护理", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "适合部分生活需要协助的老人", true, 1500m, "半护理套餐", "日常生活协助、个人卫生护理、用药提醒、康复训练、健康监测" },
                    { 3, "全护理", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "适合生活完全不能自理的老人", true, 2500m, "全护理套餐", "全面生活护理、医疗护理、康复训练、心理关怀、24小时监护" },
                    { 4, "特护", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "适合有特殊医疗需求的老人", true, 4000m, "特护套餐", "专业医疗护理、特殊设备使用、专人24小时陪护、医生定期巡诊" }
                });

            migrationBuilder.InsertData(
                table: "FeeTypes",
                columns: new[] { "Id", "BillingCycle", "CreateTime", "Description", "IsActive", "StandardPrice", "TypeName" },
                values: new object[,]
                {
                    { 1, "月", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "每月床位租赁费用", true, 0m, "床位费" },
                    { 2, "月", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "护理服务费用", true, 0m, "护理费" },
                    { 3, "月", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "一日三餐费用", true, 0m, "餐饮费" },
                    { 4, "月", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "医疗服务和药品费用", true, 0m, "医疗费" },
                    { 5, "月", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "日常生活用品费用", true, 0m, "生活用品费" },
                    { 6, "月", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "文娱活动参与费用", true, 0m, "娱乐活动费" },
                    { 7, "月", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "其他杂项费用", true, 0m, "其他费用" }
                });

            migrationBuilder.InsertData(
                table: "Medications",
                columns: new[] { "Id", "CreateTime", "Indications", "IsActive", "Manufacturer", "MedicationName", "MedicationType", "SideEffects", "Specification", "StorageConditions" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "预防心脑血管疾病", true, "拜耳", "阿司匹林", "心血管药物", "", "100mg*30片", "" },
                    { 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "高血压治疗", true, "诺华", "降压灵", "降压药", "", "5mg*28片", "" },
                    { 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2型糖尿病治疗", true, "默克", "二甲双胍", "降糖药", "", "500mg*30片", "" },
                    { 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "补充钙质", true, "汤臣倍健", "钙片", "营养补充剂", "", "600mg*60片", "" },
                    { 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "促进钙吸收", true, "善存", "维生素D", "维生素", "", "400IU*90粒", "" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AttendanceRecords_EmployeeId",
                table: "AttendanceRecords",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_CareRecords_CarePackageId",
                table: "CareRecords",
                column: "CarePackageId");

            migrationBuilder.CreateIndex(
                name: "IX_CareRecords_ResidentId",
                table: "CareRecords",
                column: "ResidentId");

            migrationBuilder.CreateIndex(
                name: "IX_FeeRecords_FeeTypeId",
                table: "FeeRecords",
                column: "FeeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_FeeRecords_ResidentId",
                table: "FeeRecords",
                column: "ResidentId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthRecords_ResidentId",
                table: "HealthRecords",
                column: "ResidentId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_ItemId",
                table: "Inventories",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_WarehouseId",
                table: "Inventories",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryTransactions_ItemId",
                table: "InventoryTransactions",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryTransactions_WarehouseId",
                table: "InventoryTransactions",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_WarehouseId",
                table: "Items",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRecords_EmployeeId",
                table: "LeaveRecords",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_MealRecords_ResidentId",
                table: "MealRecords",
                column: "ResidentId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalMonitorings_ResidentId",
                table: "MedicalMonitorings",
                column: "ResidentId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicationRecords_MedicationId",
                table: "MedicationRecords",
                column: "MedicationId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicationRecords_ResidentId",
                table: "MedicationRecords",
                column: "ResidentId");

            migrationBuilder.CreateIndex(
                name: "IX_OutingRecords_ResidentId",
                table: "OutingRecords",
                column: "ResidentId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentRecords_FeeRecordId",
                table: "PaymentRecords",
                column: "FeeRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_BedId",
                table: "Reservations",
                column: "BedId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ConsultantId",
                table: "Reservations",
                column: "ConsultantId");

            migrationBuilder.CreateIndex(
                name: "IX_Residents_BedId",
                table: "Residents",
                column: "BedId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttendanceRecords");

            migrationBuilder.DropTable(
                name: "CareRecords");

            migrationBuilder.DropTable(
                name: "Facilities");

            migrationBuilder.DropTable(
                name: "HealthRecords");

            migrationBuilder.DropTable(
                name: "Inventories");

            migrationBuilder.DropTable(
                name: "InventoryTransactions");

            migrationBuilder.DropTable(
                name: "LeaveRecords");

            migrationBuilder.DropTable(
                name: "MealRecords");

            migrationBuilder.DropTable(
                name: "MedicalMonitorings");

            migrationBuilder.DropTable(
                name: "MedicationRecords");

            migrationBuilder.DropTable(
                name: "OutingRecords");

            migrationBuilder.DropTable(
                name: "PaymentRecords");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "CarePackages");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Medications");

            migrationBuilder.DropTable(
                name: "FeeRecords");

            migrationBuilder.DropTable(
                name: "Consultants");

            migrationBuilder.DropTable(
                name: "Warehouses");

            migrationBuilder.DropTable(
                name: "FeeTypes");

            migrationBuilder.DropTable(
                name: "Residents");

            migrationBuilder.DropTable(
                name: "Beds");
        }
    }
}
