using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace webapi.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IdentityUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Chemist",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TimeAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserAddedId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IPAdded = table.Column<string>(type: "nvarchar(45)", nullable: false),
                    TimeModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserModifiedId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IPModified = table.Column<string>(type: "nvarchar(45)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chemist", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chemist_IdentityUser_UserAddedId",
                        column: x => x.UserAddedId,
                        principalTable: "IdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Chemist_IdentityUser_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "IdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CrystalStructure",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Acronym = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TimeAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserAddedId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IPAdded = table.Column<string>(type: "nvarchar(45)", nullable: false),
                    TimeModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserModifiedId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IPModified = table.Column<string>(type: "nvarchar(45)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrystalStructure", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CrystalStructure_IdentityUser_UserAddedId",
                        column: x => x.UserAddedId,
                        principalTable: "IdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CrystalStructure_IdentityUser_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "IdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ElementDiscoveryGroup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TimeAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserAddedId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IPAdded = table.Column<string>(type: "nvarchar(45)", nullable: false),
                    TimeModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserModifiedId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IPModified = table.Column<string>(type: "nvarchar(45)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElementDiscoveryGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElementDiscoveryGroup_IdentityUser_UserAddedId",
                        column: x => x.UserAddedId,
                        principalTable: "IdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ElementDiscoveryGroup_IdentityUser_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "IdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Phase",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Acronym = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TimeAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserAddedId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IPAdded = table.Column<string>(type: "nvarchar(45)", nullable: false),
                    TimeModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserModifiedId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IPModified = table.Column<string>(type: "nvarchar(45)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Phase_IdentityUser_UserAddedId",
                        column: x => x.UserAddedId,
                        principalTable: "IdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Phase_IdentityUser_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "IdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WebColor",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TimeAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserAddedId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IPAdded = table.Column<string>(type: "nvarchar(45)", nullable: false),
                    TimeModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserModifiedId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IPModified = table.Column<string>(type: "nvarchar(45)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebColor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WebColor_IdentityUser_UserAddedId",
                        column: x => x.UserAddedId,
                        principalTable: "IdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WebColor_IdentityUser_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "IdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Element",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AtomicNumber = table.Column<long>(type: "bigint", nullable: false),
                    ElementName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AtomicWeight = table.Column<double>(type: "float", nullable: false),
                    Period = table.Column<long>(type: "bigint", nullable: false),
                    Group = table.Column<long>(type: "bigint", nullable: false),
                    PhaseId = table.Column<long>(type: "bigint", nullable: false),
                    ConfigId = table.Column<long>(type: "bigint", nullable: false),
                    IonicRadius = table.Column<float>(type: "real", nullable: true),
                    AtomicRadius = table.Column<double>(type: "float", nullable: true),
                    Electronegativity = table.Column<double>(type: "float", nullable: true),
                    FirstIonizationPotential = table.Column<double>(type: "float", nullable: true),
                    Density = table.Column<double>(type: "float", nullable: true),
                    MeltingPoint = table.Column<double>(type: "float", nullable: true),
                    BoilingPoint = table.Column<double>(type: "float", nullable: true),
                    Isotopes = table.Column<long>(type: "bigint", nullable: true),
                    SpecificHeatCapacity = table.Column<float>(type: "real", nullable: true),
                    ElectronConfiguration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayRow = table.Column<long>(type: "bigint", nullable: false),
                    DisplayColumn = table.Column<long>(type: "bigint", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TimeAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserAddedId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IPAdded = table.Column<string>(type: "nvarchar(45)", nullable: false),
                    TimeModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserModifiedId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IPModified = table.Column<string>(type: "nvarchar(45)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Element", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Element_CrystalStructure_ConfigId",
                        column: x => x.ConfigId,
                        principalTable: "CrystalStructure",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Element_IdentityUser_UserAddedId",
                        column: x => x.UserAddedId,
                        principalTable: "IdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Element_IdentityUser_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "IdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Element_Phase_PhaseId",
                        column: x => x.PhaseId,
                        principalTable: "Phase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ElementType",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Acronym = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TimeAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserAddedId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IPAdded = table.Column<string>(type: "nvarchar(45)", nullable: false),
                    TimeModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserModifiedId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IPModified = table.Column<string>(type: "nvarchar(45)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColorId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElementType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElementType_IdentityUser_UserAddedId",
                        column: x => x.UserAddedId,
                        principalTable: "IdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ElementType_IdentityUser_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "IdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ElementType_WebColor_ColorId",
                        column: x => x.ColorId,
                        principalTable: "WebColor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ElementDiscovery",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiscoverersId = table.Column<long>(type: "bigint", nullable: false),
                    Biography = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TimeAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserAddedId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IPAdded = table.Column<string>(type: "nvarchar(45)", nullable: false),
                    TimeModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserModifiedId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IPModified = table.Column<string>(type: "nvarchar(45)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ElementId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElementDiscovery", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElementDiscovery_ElementDiscoveryGroup_DiscoverersId",
                        column: x => x.DiscoverersId,
                        principalTable: "ElementDiscoveryGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ElementDiscovery_Element_ElementId",
                        column: x => x.ElementId,
                        principalTable: "Element",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ElementDiscovery_IdentityUser_UserAddedId",
                        column: x => x.UserAddedId,
                        principalTable: "IdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ElementDiscovery_IdentityUser_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "IdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ElementClassification",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeId = table.Column<long>(type: "bigint", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TimeAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserAddedId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IPAdded = table.Column<string>(type: "nvarchar(45)", nullable: false),
                    TimeModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserModifiedId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IPModified = table.Column<string>(type: "nvarchar(45)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ElementId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElementClassification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElementClassification_ElementType_TypeId",
                        column: x => x.TypeId,
                        principalTable: "ElementType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ElementClassification_Element_ElementId",
                        column: x => x.ElementId,
                        principalTable: "Element",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ElementClassification_IdentityUser_UserAddedId",
                        column: x => x.UserAddedId,
                        principalTable: "IdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ElementClassification_IdentityUser_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "IdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "IdentityUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1", 2147483647, "a44e371a-6840-4cef-80a2-e113068694d1", "", true, true, null, "", "COGNITAREXNIHILO", "", "", true, "51433c62-7a19-44a4-b0e4-ce1d0383a585", false, "CognitarExNihilo" });

            migrationBuilder.InsertData(
                table: "CrystalStructure",
                columns: new[] { "Id", "Acronym", "Guid", "IPAdded", "IPModified", "ImagePath", "IsActive", "Name", "TimeAdded", "TimeModified", "UserAddedId", "UserModifiedId" },
                values: new object[,]
                {
                    { 1L, "N/A", new Guid("040627c5-e1bd-4da0-b248-7ec23c10e84c"), "127.0.0.1", "127.0.0.1", "common_icons/axe.png", true, "Not Applicable", new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 2L, "bcc", new Guid("c5c4bb23-a965-4550-a75d-b1138fe1cae5"), "127.0.0.1", "127.0.0.1", "crystal_icons/bcc.svg", true, "Body-Centered Cubic", new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 3L, "hex", new Guid("b5bd3be7-3669-42c9-890f-5e6586c041da"), "127.0.0.1", "127.0.0.1", "crystal_icons/hex.svg", true, "Hexagonal", new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 4L, "rho", new Guid("eeb2cea1-9b84-451a-ab38-d968c4373ad4"), "127.0.0.1", "127.0.0.1", "crystal_icons/rho.svg", true, "Rhombohedral", new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 5L, "fcc", new Guid("9ebc048e-63c3-4a9d-b219-c63742d317fc"), "127.0.0.1", "127.0.0.1", "crystal_icons/fcc.svg", true, "Face-Centered Cubic", new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 6L, "sc", new Guid("a7126788-59ca-4527-9e81-503fabcba4c8"), "127.0.0.1", "127.0.0.1", "crystal_icons/sc.svg", true, "Cubic", new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 7L, "orth", new Guid("c7c7e003-9a9e-4643-8389-8ebe9f18c00e"), "127.0.0.1", "127.0.0.1", "crystal_icons/orth.svg", true, "Orthorhombic", new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 8L, "tet", new Guid("7df8cf23-963c-4867-ae0e-49b9f02b0f56"), "127.0.0.1", "127.0.0.1", "crystal_icons/tetr.svg", true, "Tetragonal", new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 9L, "mon", new Guid("5f170852-d220-4cb1-a750-80c4f2704212"), "127.0.0.1", "127.0.0.1", "crystal_icons/mon.svg", true, "Monoclinic", new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), "1", "1" }
                });

            migrationBuilder.InsertData(
                table: "ElementDiscoveryGroup",
                columns: new[] { "Id", "Guid", "IPAdded", "IPModified", "ImagePath", "IsActive", "Name", "TimeAdded", "TimeModified", "UserAddedId", "UserModifiedId", "Year" },
                values: new object[,]
                {
                    { 1L, new Guid("6a528ed7-7104-4bfb-9328-8a0f107501fe"), "127.0.0.1", "127.0.0.1", null, true, "Cavendish", new DateTime(2023, 9, 24, 22, 22, 39, 247, DateTimeKind.Local).AddTicks(9110), new DateTime(2023, 9, 24, 22, 22, 39, 247, DateTimeKind.Local).AddTicks(9110), "1", "1", "1766" },
                    { 2L, new Guid("1b1837f0-55ac-4c85-8abc-ccfe8ec7b15f"), "127.0.0.1", "127.0.0.1", null, true, "Janssen", new DateTime(2023, 9, 24, 22, 22, 39, 247, DateTimeKind.Local).AddTicks(9110), new DateTime(2023, 9, 24, 22, 22, 39, 247, DateTimeKind.Local).AddTicks(9110), "1", "1", "1868" },
                    { 3L, new Guid("fb13fb5a-e075-471e-81f0-60ca0d3f22fa"), "127.0.0.1", "127.0.0.1", null, true, "Arfvedson", new DateTime(2023, 9, 24, 22, 22, 39, 247, DateTimeKind.Local).AddTicks(9110), new DateTime(2023, 9, 24, 22, 22, 39, 247, DateTimeKind.Local).AddTicks(9110), "1", "1", "1817" },
                    { 4L, new Guid("6a8e8e1c-6757-4419-817d-e4d397f91a68"), "127.0.0.1", "127.0.0.1", null, true, "Vaulquelin", new DateTime(2023, 9, 24, 22, 22, 39, 247, DateTimeKind.Local).AddTicks(9110), new DateTime(2023, 9, 24, 22, 22, 39, 247, DateTimeKind.Local).AddTicks(9110), "1", "1", "1798" },
                    { 5L, new Guid("abc93986-88bc-4f08-a0ef-777141cdbfe5"), "127.0.0.1", "127.0.0.1", null, true, "Gay-Lussac", new DateTime(2023, 9, 24, 22, 22, 39, 247, DateTimeKind.Local).AddTicks(9110), new DateTime(2023, 9, 24, 22, 22, 39, 247, DateTimeKind.Local).AddTicks(9110), "1", "1", "1808" },
                    { 6L, new Guid("3a8a06e6-6a9a-433b-9bc6-8107b9336cca"), "127.0.0.1", "127.0.0.1", null, true, "Prehistoric", new DateTime(2023, 9, 24, 22, 22, 39, 247, DateTimeKind.Local).AddTicks(9110), new DateTime(2023, 9, 24, 22, 22, 39, 247, DateTimeKind.Local).AddTicks(9110), "1", "1", "" },
                    { 7L, new Guid("7306147e-d923-426b-ba42-ebece7825108"), "127.0.0.1", "127.0.0.1", null, true, "Rutherford", new DateTime(2023, 9, 24, 22, 22, 39, 247, DateTimeKind.Local).AddTicks(9110), new DateTime(2023, 9, 24, 22, 22, 39, 247, DateTimeKind.Local).AddTicks(9110), "1", "1", "1772" },
                    { 8L, new Guid("1eca28ea-1b4f-482a-b797-9036532236a9"), "127.0.0.1", "127.0.0.1", null, true, "Priestley/Scheele", new DateTime(2023, 9, 24, 22, 22, 39, 247, DateTimeKind.Local).AddTicks(9110), new DateTime(2023, 9, 24, 22, 22, 39, 247, DateTimeKind.Local).AddTicks(9110), "1", "1", "1774" },
                    { 9L, new Guid("bbb7980f-c216-4d5b-9e07-15c58d3c9ea1"), "127.0.0.1", "127.0.0.1", null, true, "Moissan", new DateTime(2023, 9, 24, 22, 22, 39, 247, DateTimeKind.Local).AddTicks(9110), new DateTime(2023, 9, 24, 22, 22, 39, 247, DateTimeKind.Local).AddTicks(9110), "1", "1", "1886" },
                    { 10L, new Guid("4423dcdf-f462-4908-80b1-d8dfce4b0f37"), "127.0.0.1", "127.0.0.1", null, true, "Ramsay and Travers", new DateTime(2023, 9, 24, 22, 22, 39, 247, DateTimeKind.Local).AddTicks(9110), new DateTime(2023, 9, 24, 22, 22, 39, 247, DateTimeKind.Local).AddTicks(9110), "1", "1", "1898" },
                    { 11L, new Guid("bbb114a6-4db5-489e-94dc-a92aaebc82d7"), "127.0.0.1", "127.0.0.1", null, true, "Davy", new DateTime(2023, 9, 24, 22, 22, 39, 247, DateTimeKind.Local).AddTicks(9110), new DateTime(2023, 9, 24, 22, 22, 39, 247, DateTimeKind.Local).AddTicks(9110), "1", "1", "1807" },
                    { 12L, new Guid("694a0d51-4a10-4935-a1f8-91dfb6ebc2e5"), "127.0.0.1", "127.0.0.1", null, true, "Black", new DateTime(2023, 9, 24, 22, 22, 39, 247, DateTimeKind.Local).AddTicks(9110), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), "1", "1", "1755" },
                    { 13L, new Guid("daaa210e-94bd-48b9-a90f-f8ddbbba02a9"), "127.0.0.1", "127.0.0.1", null, true, "Wšhler", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), "1", "1", "1827" },
                    { 14L, new Guid("584361df-bd2a-47ed-82b8-f7ed0985ac5b"), "127.0.0.1", "127.0.0.1", null, true, "Berzelius", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), "1", "1", "1824" },
                    { 15L, new Guid("aa852307-8e25-4aec-9368-a468fccce0c6"), "127.0.0.1", "127.0.0.1", null, true, "BranBrand", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), "1", "1", "1669" },
                    { 16L, new Guid("5c0e4a47-4817-4dfb-8365-76e801c002cf"), "127.0.0.1", "127.0.0.1", null, true, "Scheele", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), "1", "1", "1774" },
                    { 17L, new Guid("ad5d7058-95ff-4f96-aef7-52b7721e8e1b"), "127.0.0.1", "127.0.0.1", null, true, "Rayleigh and Ramsay", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), "1", "1", "1894" },
                    { 18L, new Guid("aa7974e5-9291-4dbd-8ecc-53772063294a"), "127.0.0.1", "127.0.0.1", null, true, "Davy", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), "1", "1", "1808" },
                    { 19L, new Guid("c454b989-c1ba-4ec0-b51f-d8d98c1198a7"), "127.0.0.1", "127.0.0.1", null, true, "Nilson", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), "1", "1", "1878" },
                    { 20L, new Guid("7bec820d-f7ba-4382-ad08-e2d271f13899"), "127.0.0.1", "127.0.0.1", null, true, "Gregor", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), "1", "1", "1791" },
                    { 21L, new Guid("ea0b8425-8f18-480f-8131-a4041769ad8e"), "127.0.0.1", "127.0.0.1", null, true, "   del Rio", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), "1", "1", "1801" },
                    { 22L, new Guid("947c96eb-119b-4434-ab5f-d5bc9d595224"), "127.0.0.1", "127.0.0.1", null, true, "Vauquelin", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), "1", "1", "1797" },
                    { 23L, new Guid("4f49af13-d688-4d91-84cf-81ea214a791e"), "127.0.0.1", "127.0.0.1", null, true, "Gahn, Scheele", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), "1", "1", "1774" },
                    { 24L, new Guid("565d9d8a-86ed-4180-9d2b-666152da9330"), "127.0.0.1", "127.0.0.1", null, true, "Brandt", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), "1", "1", "1735" },
                    { 25L, new Guid("f673741c-13a4-4e84-b322-f4c156d08bd7"), "127.0.0.1", "127.0.0.1", null, true, "Cronstedt", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), "1", "1", "1751" },
                    { 26L, new Guid("d228d85e-1638-4ad4-9937-e3894096b67c"), "127.0.0.1", "127.0.0.1", null, true, "de Boisbaudran", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), "1", "1", "1875" },
                    { 27L, new Guid("9df92043-fba6-42b0-9591-b8872202bb05"), "127.0.0.1", "127.0.0.1", null, true, "Winkler", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), "1", "1", "1886" },
                    { 28L, new Guid("04864e00-61d4-4f4c-baa3-f3cacf1e5cd8"), "127.0.0.1", "127.0.0.1", null, true, "Albertus Magnus", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), "1", "1", "1250" },
                    { 29L, new Guid("7c22b2d6-b0aa-476b-9921-44b061182d00"), "127.0.0.1", "127.0.0.1", null, true, "Berzelius", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), "1", "1", "1817" },
                    { 30L, new Guid("c898d5e0-caba-4174-a698-64ce47a1ea1e"), "127.0.0.1", "127.0.0.1", null, true, "Balard", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), "1", "1", "1826" },
                    { 31L, new Guid("fe6ad13b-c2de-4249-8c8e-89c5277369b7"), "127.0.0.1", "127.0.0.1", null, true, "Bunsen and Kirchoff", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), "1", "1", "1861" },
                    { 32L, new Guid("e4fa8868-f318-41f9-ba98-dcb1a1551c77"), "127.0.0.1", "127.0.0.1", null, true, "Gadolin", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), "1", "1", "1794" },
                    { 33L, new Guid("31e0f292-507d-487d-9a97-2b47d802f45c"), "127.0.0.1", "127.0.0.1", null, true, "Klaproth", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), "1", "1", "1789" },
                    { 34L, new Guid("d864494f-34bc-44d0-b845-325fe07ddb89"), "127.0.0.1", "127.0.0.1", null, true, "Hatchett", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), "1", "1", "1801" },
                    { 35L, new Guid("2c4eb607-b75a-442b-b9d1-19e67cebb539"), "127.0.0.1", "127.0.0.1", null, true, "Scheele", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), "1", "1", "1778" },
                    { 36L, new Guid("77e57014-226f-49a6-a9b3-59a789323a36"), "127.0.0.1", "127.0.0.1", null, true, "Perrier and SegrŽ", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), "1", "1", "1937" },
                    { 37L, new Guid("3a80bdc5-b9dc-4ad4-ba7f-94a7d9086487"), "127.0.0.1", "127.0.0.1", null, true, "Klaus", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), "1", "1", "1844" },
                    { 38L, new Guid("f6cc29a3-6a7d-4811-b60b-8b7fab617dee"), "127.0.0.1", "127.0.0.1", null, true, "Wollaston", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), "1", "1", "1803" },
                    { 39L, new Guid("a64b29ef-1b2e-46f6-b5bd-8b7bd09043a3"), "127.0.0.1", "127.0.0.1", null, true, "Stromeyer", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), "1", "1", "1817" },
                    { 40L, new Guid("773c97dc-b7fd-4726-b486-80800f54bf25"), "127.0.0.1", "127.0.0.1", null, true, "Reich and Richter", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), "1", "1", "1863" },
                    { 41L, new Guid("5db1ce62-8a2a-447b-b616-2026cefb24f6"), "127.0.0.1", "127.0.0.1", null, true, "Early historic times", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), "1", "1", "" },
                    { 42L, new Guid("476ad459-89c5-4f9c-a035-04ac6c630156"), "127.0.0.1", "127.0.0.1", null, true, "von Reichenstein", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), "1", "1", "1782" },
                    { 43L, new Guid("d654d74f-cd59-4f09-a73d-dd34463c6cde"), "127.0.0.1", "127.0.0.1", null, true, "Courtois", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), "1", "1", "1811" },
                    { 44L, new Guid("688c934f-55c4-4517-9688-7717e12ab898"), "127.0.0.1", "127.0.0.1", null, true, "Bunsen and Kirchoff", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(1600), "1", "1", "1860" },
                    { 45L, new Guid("5a878c07-9f34-44c8-9d63-a9247019ea9e"), "127.0.0.1", "127.0.0.1", null, true, "Mosander", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1839" },
                    { 46L, new Guid("2d4d3276-0919-46d6-9b8f-af6d16e4af2d"), "127.0.0.1", "127.0.0.1", null, true, "Berzelius", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1803" },
                    { 47L, new Guid("e3a717c8-c0f2-43ac-a2fe-9337212945c8"), "127.0.0.1", "127.0.0.1", null, true, "von Welsbach", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1885" },
                    { 48L, new Guid("6339d1d5-9506-455d-a3ff-905ba824c68c"), "127.0.0.1", "127.0.0.1", null, true, "Marinsky et al.", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1945" },
                    { 49L, new Guid("c0c542db-ff5c-4769-8dde-88ae9719469a"), "127.0.0.1", "127.0.0.1", null, true, "Boisbaudran", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1879" },
                    { 50L, new Guid("69b4cfd1-c922-4cb3-97a6-83cbbced2bc0"), "127.0.0.1", "127.0.0.1", null, true, "Demarcay", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1901" },
                    { 51L, new Guid("3efbcc98-2c02-4afa-82cd-5ec0c831e624"), "127.0.0.1", "127.0.0.1", null, true, "de Marignac", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1880" },
                    { 52L, new Guid("6b5dc1d4-bd97-462a-9b0e-f686e794c6e8"), "127.0.0.1", "127.0.0.1", null, true, "Mosander", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1843" },
                    { 53L, new Guid("89f7ce20-51b9-44a7-9ee2-43bd94092d0b"), "127.0.0.1", "127.0.0.1", null, true, "de Boisbaudran", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1886" },
                    { 54L, new Guid("7481e66d-802b-42ef-9df8-7c2e6bed329a"), "127.0.0.1", "127.0.0.1", null, true, "Delafontaine and Soret", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1878" },
                    { 55L, new Guid("c3839325-652a-4795-ac77-0ac3352818b6"), "127.0.0.1", "127.0.0.1", null, true, "Cleve", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1879" },
                    { 56L, new Guid("f5bdda85-b8c2-4a44-aeb7-81623a690949"), "127.0.0.1", "127.0.0.1", null, true, "Marignac", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1878" },
                    { 57L, new Guid("0535a9e7-f10c-4f94-9e5f-7bbb10305a60"), "127.0.0.1", "127.0.0.1", null, true, "Urbain/ von Welsbach", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1907" },
                    { 58L, new Guid("b68e633a-6c9b-40ac-90ba-0165fa3c3ac7"), "127.0.0.1", "127.0.0.1", null, true, "Coster and von Hevesy", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1923" },
                    { 59L, new Guid("3fb1dc00-f98a-45d6-be92-21a20dae1a1e"), "127.0.0.1", "127.0.0.1", null, true, "Ekeberg", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1801" },
                    { 60L, new Guid("314704f1-a1f9-468d-a1cc-d1815be92e5a"), "127.0.0.1", "127.0.0.1", null, true, "J. and F. d'Elhuyar", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1783" },
                    { 61L, new Guid("6cc48bf6-302b-41a9-b64e-15dc1300f495"), "127.0.0.1", "127.0.0.1", null, true, "Noddack, Berg, and Tacke", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1925" },
                    { 62L, new Guid("a4311405-92b1-452e-8d0c-c6a5e5110981"), "127.0.0.1", "127.0.0.1", null, true, "Tennant", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1803" },
                    { 63L, new Guid("1317735c-bcf7-4af5-a3e1-d95d6fcffc19"), "127.0.0.1", "127.0.0.1", null, true, "Tennant", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1804" },
                    { 64L, new Guid("cf17df02-793a-459a-b7cc-e3b11ffe99f1"), "127.0.0.1", "127.0.0.1", null, true, "Ulloa/Wood", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1735" },
                    { 65L, new Guid("a48aa08d-22c6-44ca-8e84-576248a9a047"), "127.0.0.1", "127.0.0.1", null, true, "Crookes", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1861" },
                    { 66L, new Guid("897d1925-37d2-4b87-a9f7-6bb5555f504a"), "127.0.0.1", "127.0.0.1", null, true, "Geoffroy the Younger", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1753" },
                    { 67L, new Guid("1fc423b8-4aa1-4f64-830c-1a6b89ce6c64"), "127.0.0.1", "127.0.0.1", null, true, "Curie", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1898" },
                    { 68L, new Guid("cd0498ea-556e-4b01-b8af-4c7377d236d2"), "127.0.0.1", "127.0.0.1", null, true, "Corson et al.", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1940" },
                    { 69L, new Guid("65a6ca76-9533-4ad8-862f-d08942199f85"), "127.0.0.1", "127.0.0.1", null, true, "Dorn", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1900" },
                    { 70L, new Guid("3f5c6fd9-a40d-4aa3-9ad4-ca27d1a407e7"), "127.0.0.1", "127.0.0.1", null, true, "Perey", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1939" },
                    { 71L, new Guid("621473f0-60b3-4a3b-80cf-c572f4f9c797"), "127.0.0.1", "127.0.0.1", null, true, "Pierre and Marie Curie", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1898" },
                    { 72L, new Guid("efa11dcc-0249-452a-ac8b-ba197ccc08e7"), "127.0.0.1", "127.0.0.1", null, true, "Debierne/Giesel", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1899" },
                    { 73L, new Guid("4e2b75d8-8227-4960-b2fa-a0b979fd4782"), "127.0.0.1", "127.0.0.1", null, true, "Berzelius", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1828" },
                    { 74L, new Guid("bd3bfe2f-980b-4589-b1b5-304242f9381b"), "127.0.0.1", "127.0.0.1", null, true, "Hahn and Meitner", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1917" },
                    { 75L, new Guid("f2fcfda0-8792-4181-a551-f3b607f1041e"), "127.0.0.1", "127.0.0.1", null, true, "Peligot", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1841" },
                    { 76L, new Guid("711d2b25-7860-47c2-ac9d-55c9d5517630"), "127.0.0.1", "127.0.0.1", null, true, "McMillan and Abelson", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1940" },
                    { 77L, new Guid("cbf1e81a-f1c7-46ae-8b31-b358be00a598"), "127.0.0.1", "127.0.0.1", null, true, "Seaborg et al.", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1940" },
                    { 78L, new Guid("0a6ff849-f061-49be-9940-5695308461eb"), "127.0.0.1", "127.0.0.1", null, true, "Seaborg et al.", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1944" },
                    { 79L, new Guid("e0dcb33a-d1e9-4e2d-a7c6-0e5290a6bdbd"), "127.0.0.1", "127.0.0.1", null, true, "Seaborg et al.", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1949" },
                    { 80L, new Guid("b1047ef9-24ee-4a90-ae87-4af646ff9a17"), "127.0.0.1", "127.0.0.1", null, true, "Seaborg et al.", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1950" },
                    { 81L, new Guid("90f1a167-b40a-484f-8701-211b536669cf"), "127.0.0.1", "127.0.0.1", null, true, "Ghiorso et al.", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1952" },
                    { 82L, new Guid("0525d2d7-4804-4ff0-a7d1-36f5dea5c555"), "127.0.0.1", "127.0.0.1", null, true, "Ghiorso et al.", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1953" },
                    { 83L, new Guid("905ea138-20f5-4ab5-b66a-a6e641ca745e"), "127.0.0.1", "127.0.0.1", null, true, "Ghiorso et al.", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1955" },
                    { 84L, new Guid("efe30fc7-0589-45d3-b2e3-7563255006c4"), "127.0.0.1", "127.0.0.1", null, true, "Ghiorso et al.", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1958" },
                    { 85L, new Guid("98f9e935-44cb-4f44-b773-e09bd6cb7646"), "127.0.0.1", "127.0.0.1", null, true, "Ghiorso et al.", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1961" },
                    { 86L, new Guid("9ea4913d-0cfc-4b46-b218-7f29e4c7afaf"), "127.0.0.1", "127.0.0.1", null, true, "Ghiorso et al.", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1969" },
                    { 87L, new Guid("4a31a7e0-ceeb-47cc-827b-81579ff6e051"), "127.0.0.1", "127.0.0.1", null, true, "Ghiorso et al.", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1970" },
                    { 88L, new Guid("1c9e2c2b-a696-4335-9f2e-516c92ee59d1"), "127.0.0.1", "127.0.0.1", null, true, "Ghiorso et al.", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1974" },
                    { 89L, new Guid("3cca10cf-5dbe-4b83-bd23-f5e6bc89926d"), "127.0.0.1", "127.0.0.1", null, true, "Armbruster and MŸnzenberg", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1981" },
                    { 90L, new Guid("14e5bfae-28c5-409f-85a5-4ebe2e6178ee"), "127.0.0.1", "127.0.0.1", null, true, "Armbruster and MŸnzenberg", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1983" },
                    { 91L, new Guid("102eb2c2-acae-43e3-86c5-f0bc72b5cead"), "127.0.0.1", "127.0.0.1", null, true, "GSI, Darmstadt, West Germany", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "1982" },
                    { 92L, new Guid("f90d7bcc-32ba-4c5b-96f9-abad1aa0bf63"), "127.0.0.1", "127.0.0.1", null, true, "", new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1", "" }
                });

            migrationBuilder.InsertData(
                table: "Phase",
                columns: new[] { "Id", "Acronym", "Guid", "IPAdded", "IPModified", "ImagePath", "IsActive", "Name", "TimeAdded", "TimeModified", "UserAddedId", "UserModifiedId" },
                values: new object[,]
                {
                    { 1L, "gas", new Guid("be51fa4e-2b63-4fcb-a010-e0f3c5104bf1"), "127.0.0.1", "127.0.0.1", null, true, "gas", new DateTime(2023, 9, 21, 1, 1, 38, 278, DateTimeKind.Local).AddTicks(6350), new DateTime(2023, 9, 21, 1, 1, 38, 279, DateTimeKind.Local).AddTicks(5170), "1", "1" },
                    { 2L, "sol", new Guid("719d5b25-fb2d-4d4a-8242-9be505b408fe"), "127.0.0.1", "127.0.0.1", null, true, "solid", new DateTime(2023, 9, 21, 1, 1, 38, 279, DateTimeKind.Local).AddTicks(5170), new DateTime(2023, 9, 21, 1, 1, 38, 279, DateTimeKind.Local).AddTicks(5170), "1", "1" },
                    { 3L, "liq", new Guid("a0eed403-6037-484f-a285-430e64fd4edd"), "127.0.0.1", "127.0.0.1", null, true, "liquid", new DateTime(2023, 9, 21, 1, 1, 38, 279, DateTimeKind.Local).AddTicks(5170), new DateTime(2023, 9, 21, 1, 1, 38, 279, DateTimeKind.Local).AddTicks(5170), "1", "1" },
                    { 4L, "atl", new Guid("05db4a57-6adc-4ff9-a05e-d1ec951c7789"), "127.0.0.1", "127.0.0.1", null, true, "artificial", new DateTime(2023, 9, 21, 1, 1, 38, 279, DateTimeKind.Local).AddTicks(5170), new DateTime(2023, 9, 21, 1, 1, 38, 279, DateTimeKind.Local).AddTicks(5170), "1", "1" }
                });

            migrationBuilder.InsertData(
                table: "WebColor",
                columns: new[] { "Id", "Code", "Guid", "IPAdded", "IPModified", "IsActive", "Name", "TimeAdded", "TimeModified", "UserAddedId", "UserModifiedId" },
                values: new object[,]
                {
                    { 1L, "1dd513", new Guid("b5c030b8-e1f1-4d0a-b4c5-63c07df15623"), "127.0.0.1", "127.0.0.1", true, "actinides", new DateTime(2023, 9, 30, 20, 57, 55, 160, DateTimeKind.Local).AddTicks(7420), new DateTime(2023, 9, 30, 20, 57, 55, 160, DateTimeKind.Local).AddTicks(7420), "1", "1" },
                    { 2L, "8d0c63", new Guid("ec0dbe34-b7a7-4ec1-aa46-047f342fc1e4"), "127.0.0.1", "127.0.0.1", true, "alkali metals", new DateTime(2023, 9, 30, 20, 57, 55, 160, DateTimeKind.Local).AddTicks(7420), new DateTime(2023, 9, 30, 20, 57, 55, 160, DateTimeKind.Local).AddTicks(7420), "1", "1" },
                    { 3L, "dc00fe", new Guid("926e7993-a144-4d4e-aa31-691335baa088"), "127.0.0.1", "127.0.0.1", true, "alkaline metals", new DateTime(2023, 9, 30, 20, 57, 55, 160, DateTimeKind.Local).AddTicks(7420), new DateTime(2023, 9, 30, 20, 57, 55, 160, DateTimeKind.Local).AddTicks(7420), "1", "1" },
                    { 4L, "1cb8ae", new Guid("9ddcd865-b3c9-4d4e-8965-768dde67b4fe"), "127.0.0.1", "127.0.0.1", true, "halogens", new DateTime(2023, 9, 30, 20, 57, 55, 160, DateTimeKind.Local).AddTicks(7420), new DateTime(2023, 9, 30, 20, 57, 55, 160, DateTimeKind.Local).AddTicks(7420), "1", "1" },
                    { 5L, "f4ff00", new Guid("f8653a34-b124-45c0-b183-d64885c02207"), "127.0.0.1", "127.0.0.1", true, "lanthanides", new DateTime(2023, 9, 30, 20, 57, 55, 160, DateTimeKind.Local).AddTicks(7420), new DateTime(2023, 9, 30, 20, 57, 55, 160, DateTimeKind.Local).AddTicks(7420), "1", "1" },
                    { 6L, "24ff05", new Guid("35488d3c-4c20-41b2-a65c-f0ed6fd63ceb"), "127.0.0.1", "127.0.0.1", true, "metalloids", new DateTime(2023, 9, 30, 20, 57, 55, 160, DateTimeKind.Local).AddTicks(7420), new DateTime(2023, 9, 30, 20, 57, 55, 160, DateTimeKind.Local).AddTicks(7420), "1", "1" },
                    { 7L, "098cdd", new Guid("c53e0b32-1846-4573-88f4-27283f424138"), "127.0.0.1", "127.0.0.1", true, "metals", new DateTime(2023, 9, 30, 20, 57, 55, 160, DateTimeKind.Local).AddTicks(7420), new DateTime(2023, 9, 30, 20, 57, 55, 160, DateTimeKind.Local).AddTicks(7420), "1", "1" },
                    { 8L, "ff3838", new Guid("73779ee7-17d6-4a81-ae96-f6a8d95b24aa"), "127.0.0.1", "127.0.0.1", true, "noble gases", new DateTime(2023, 9, 30, 20, 57, 55, 160, DateTimeKind.Local).AddTicks(7420), new DateTime(2023, 9, 30, 20, 57, 55, 160, DateTimeKind.Local).AddTicks(7420), "1", "1" },
                    { 9L, "ff9e00", new Guid("102103d5-e65a-4ce0-8c6d-6fc426d242a2"), "127.0.0.1", "127.0.0.1", true, "nonmetals", new DateTime(2023, 9, 30, 20, 57, 55, 160, DateTimeKind.Local).AddTicks(7420), new DateTime(2023, 9, 30, 20, 57, 55, 160, DateTimeKind.Local).AddTicks(7420), "1", "1" },
                    { 10L, "048b28", new Guid("6a4e27e3-c2b1-4cb6-95af-71c434f99f01"), "127.0.0.1", "127.0.0.1", true, "transactinides", new DateTime(2023, 9, 30, 20, 57, 55, 160, DateTimeKind.Local).AddTicks(7420), new DateTime(2023, 9, 30, 20, 57, 55, 160, DateTimeKind.Local).AddTicks(7420), "1", "1" },
                    { 11L, "35f7b4", new Guid("792c91c1-9510-455e-8e14-0744232725b2"), "127.0.0.1", "127.0.0.1", true, "transition metals", new DateTime(2023, 9, 30, 20, 57, 55, 160, DateTimeKind.Local).AddTicks(7420), new DateTime(2023, 9, 30, 20, 57, 55, 160, DateTimeKind.Local).AddTicks(7420), "1", "1" },
                    { 12L, "ffffff", new Guid("18377929-a588-4001-a53f-249312029da7"), "127.0.0.1", "127.0.0.1", true, "white", new DateTime(2023, 9, 30, 20, 57, 55, 160, DateTimeKind.Local).AddTicks(7420), new DateTime(2023, 9, 30, 20, 57, 55, 160, DateTimeKind.Local).AddTicks(7420), "1", "1" }
                });

            migrationBuilder.InsertData(
                table: "Element",
                columns: new[] { "Id", "AtomicNumber", "AtomicRadius", "AtomicWeight", "BoilingPoint", "ConfigId", "Density", "DisplayColumn", "DisplayRow", "ElectronConfiguration", "Electronegativity", "ElementName", "FirstIonizationPotential", "Group", "Guid", "IPAdded", "IPModified", "IonicRadius", "IsActive", "Isotopes", "MeltingPoint", "Period", "PhaseId", "SpecificHeatCapacity", "Symbol", "TimeAdded", "TimeModified", "UserAddedId", "UserModifiedId" },
                values: new object[,]
                {
                    { 1L, 1L, 0.79000000000000004, 1.0079400000000001, 20.280000000000001, 1L, 8.988E-05, 1L, 1L, "1s1", 2.2000000000000002, "Hydrogen", 13.5984, 1L, new Guid("8b9e6898-bf66-459b-8ded-e557cf0799b4"), "127.0.0.1", "127.0.0.1", 0.012f, true, 3L, 14.175000000000001, 1L, 1L, 14.304f, "H", new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), "1", "1" },
                    { 2L, 2L, 0.48999999999999999, 4.0026020000000004, 4.2199999999999998, 1L, 0.0001785, 18L, 1L, "1s2", null, "Helium", 24.587399999999999, 18L, new Guid("41e0a85d-d50f-462a-9de9-a287713589d9"), "127.0.0.1", "127.0.0.1", null, true, 5L, null, 1L, 1L, 5.193f, "He", new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), "1", "1" },
                    { 3L, 3L, 2.1000000000000001, 6.9409999999999998, 1615.0, 2L, 0.53400000000000003, 1L, 2L, "[He] 2s1", 0.97999999999999998, "Lithium", 5.3917000000000002, 1L, new Guid("5535557f-44bd-42d4-96b9-950fa81864a6"), "127.0.0.1", "127.0.0.1", 0.76f, true, 5L, 453.85000000000002, 2L, 2L, 3.582f, "Li", new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), "1", "1" },
                    { 4L, 4L, 1.3999999999999999, 9.0121819999999992, 2742.0, 3L, 1.8500000000000001, 2L, 2L, "[He] 2s2", 1.5700000000000001, "Beryllium", 9.3226999999999993, 2L, new Guid("43becbd9-857d-4e46-b3ea-4e8c9fe13e7e"), "127.0.0.1", "127.0.0.1", 0.35f, true, 6L, 1560.1500000000001, 2L, 2L, 1.825f, "Be", new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), "1", "1" },
                    { 5L, 5L, 1.2, 10.811, 4200.0, 4L, 2.3399999999999999, 13L, 2L, "[He] 2s2 2p1", 2.04, "Boron", 8.298, 13L, new Guid("cfe0d3e1-f509-4b5e-ad81-d11ed8772517"), "127.0.0.1", "127.0.0.1", 0.23f, true, 6L, 2573.1500000000001, 2L, 2L, 1.026f, "B", new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), "1", "1" },
                    { 6L, 6L, 0.91000000000000003, 12.0107, 4300.0, 3L, 2.2669999999999999, 14L, 2L, "[He] 2s2 2p2", 2.5499999999999998, "Carbon", 11.260300000000001, 14L, new Guid("e44e9d56-918c-4094-a5e6-ea00bd099fc1"), "127.0.0.1", "127.0.0.1", null, true, 7L, 3948.1500000000001, 2L, 2L, 0.709f, "C", new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), "1", "1" },
                    { 7L, 7L, 0.75, 14.0067, 77.359999999999999, 1L, 0.0012505999999999999, 15L, 2L, "[He] 2s2 2p3", 3.04, "Nitrogen", 14.5341, 15L, new Guid("e78c981e-0adc-43ca-9a66-938cad7a8690"), "127.0.0.1", "127.0.0.1", 0.13f, true, 8L, 63.289999999999999, 2L, 1L, 1.04f, "N", new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), "1", "1" },
                    { 8L, 8L, 0.65000000000000002, 15.9994, 90.200000000000003, 1L, 0.0014289999999999999, 16L, 2L, "[He] 2s2 2p4", 3.4399999999999999, "Oxygen", 13.6181, 16L, new Guid("5b59cfcb-0d7d-486b-b13a-d007ecb4778c"), "127.0.0.1", "127.0.0.1", 1.4f, true, 8L, 50.5, 2L, 1L, 0.918f, "O", new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), "1", "1" },
                    { 9L, 9L, 0.56999999999999995, 18.998403199999998, 85.030000000000001, 1L, 0.001696, 17L, 2L, "[He] 2s2 2p5", 3.98, "Fluorine", 17.422799999999999, 17L, new Guid("24150b80-68c9-4f6f-b6d1-7ff9e764ac4d"), "127.0.0.1", "127.0.0.1", 1.3f, true, 6L, 53.630000000000003, 2L, 1L, 0.824f, "F", new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), "1", "1" },
                    { 10L, 10L, 0.51000000000000001, 20.1797, 27.07, 1L, 0.00089990000000000003, 18L, 2L, "[He] 2s2 2p6", null, "Neon", 21.564499999999999, 18L, new Guid("7a74c249-ceba-4158-a718-b462ee343b38"), "127.0.0.1", "127.0.0.1", null, true, 8L, 24.702999999999999, 2L, 1L, 1.03f, "Ne", new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), "1", "1" },
                    { 11L, 11L, 2.2000000000000002, 22.989769280000001, 1156.0, 2L, 0.97099999999999997, 1L, 3L, "[Ne] 3s1", 0.93000000000000005, "Sodium", 5.1391, 1L, new Guid("011fb1b4-ce71-4dd2-9f48-039f9fe84286"), "127.0.0.1", "127.0.0.1", 1f, true, 7L, 371.14999999999998, 3L, 2L, 1.228f, "Na", new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), "1", "1" },
                    { 12L, 12L, 1.7, 24.305, 1363.0, 3L, 1.738, 2L, 3L, "[Ne] 3s2", 1.3100000000000001, "Magnesium", 7.6462000000000003, 2L, new Guid("a1235df2-2e58-48c5-a37c-83e689a14776"), "127.0.0.1", "127.0.0.1", 0.72f, true, 8L, 923.14999999999998, 3L, 2L, 1.023f, "Mg", new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), "1", "1" },
                    { 13L, 13L, 1.8, 26.9815386, 2792.0, 5L, 2.698, 13L, 3L, "[Ne] 3s2 3p1", 1.6100000000000001, "Aluminum", 5.9858000000000002, 13L, new Guid("4d15b180-51e9-44f5-8b9a-0e1b947be456"), "127.0.0.1", "127.0.0.1", 0.54f, true, 8L, 933.39999999999998, 3L, 2L, 0.897f, "Al", new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), "1", "1" },
                    { 14L, 14L, 1.5, 28.0855, 3538.0, 5L, 2.3296000000000001, 14L, 3L, "[Ne] 3s2 3p2", 1.8999999999999999, "Silicon", 8.1516999999999999, 14L, new Guid("b815b23e-8cb3-4bcf-9e54-2ba8cbad731e"), "127.0.0.1", "127.0.0.1", 0.4f, true, 8L, 1683.1500000000001, 3L, 2L, 0.705f, "Si", new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), "1", "1" },
                    { 15L, 15L, 1.2, 30.973762000000001, 553.0, 6L, 1.8200000000000001, 15L, 3L, "[Ne] 3s2 3p3", 2.1899999999999999, "Phosphorus", 10.486700000000001, 15L, new Guid("fdf47fe4-bed0-438b-870f-0be2b7b8384f"), "127.0.0.1", "127.0.0.1", 0.38f, true, 7L, 317.25, 3L, 2L, 0.769f, "P", new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), "1", "1" },
                    { 16L, 16L, 1.1000000000000001, 32.064999999999998, 717.79999999999995, 7L, 2.0670000000000002, 16L, 3L, "[Ne] 3s2 3p4", 2.5800000000000001, "Sulfur", 10.359999999999999, 16L, new Guid("49cfc85f-b4cd-4406-a9ec-10969e8a43c6"), "127.0.0.1", "127.0.0.1", 0.37f, true, 10L, 388.50999999999999, 3L, 2L, 0.71f, "S", new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), "1", "1" },
                    { 17L, 17L, 0.96999999999999997, 35.453000000000003, 239.11000000000001, 1L, 0.0032139999999999998, 17L, 3L, "[Ne] 3s2 3p5", 3.1600000000000001, "Chlorine", 12.967599999999999, 17L, new Guid("21198bf4-e881-4048-b15e-4392addca50d"), "127.0.0.1", "127.0.0.1", 1.8f, true, 11L, 172.31, 3L, 1L, 0.479f, "Cl", new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), "1", "1" },
                    { 18L, 18L, 0.88, 39.948, 87.299999999999997, 1L, 0.0017837, 18L, 3L, "[Ne] 3s2 3p6", null, "Argon", 15.759600000000001, 18L, new Guid("c8754f73-7680-45ba-b6e7-7c7502b80a7f"), "127.0.0.1", "127.0.0.1", null, true, 8L, 83.959999999999994, 3L, 1L, 0.52f, "Ar", new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), "1", "1" },
                    { 19L, 19L, 2.7999999999999998, 39.098300000000002, 1032.0, 2L, 0.86199999999999999, 1L, 4L, "[Ar] 4s1", 0.81999999999999995, "Potassium", 4.3407, 1L, new Guid("3d7c5aaa-4862-4da2-8ed5-798842d39ecf"), "127.0.0.1", "127.0.0.1", 1.4f, true, 10L, 336.5, 4L, 2L, 0.757f, "K", new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), "1", "1" },
                    { 20L, 20L, 2.2000000000000002, 40.078000000000003, 1757.0, 5L, 1.54, 2L, 4L, "[Ar] 4s2", 1.0, "Calcium", 6.1132, 2L, new Guid("f48b0a94-57c2-4c82-8754-b1f82de20f54"), "127.0.0.1", "127.0.0.1", 0.99f, true, 14L, 1112.1500000000001, 4L, 2L, 0.647f, "Ca", new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), "1", "1" },
                    { 21L, 21L, 2.1000000000000001, 44.955911999999998, 3109.0, 3L, 2.9889999999999999, 3L, 4L, "[Ar] 3d1 4s2", 1.3600000000000001, "Scandium", 6.5614999999999997, 3L, new Guid("7de0c9f4-f155-45bd-891d-e8e54dd8160c"), "127.0.0.1", "127.0.0.1", 0.75f, true, 15L, 1812.1500000000001, 4L, 2L, 0.568f, "Sc", new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), "1", "1" },
                    { 22L, 22L, 2.0, 47.866999999999997, 3560.0, 3L, 4.54, 4L, 4L, "[Ar] 3d2 4s2", 1.54, "Titanium", 6.8281000000000001, 4L, new Guid("e5284f84-4cd8-449e-ad73-9ed4719944f9"), "127.0.0.1", "127.0.0.1", 0.61f, true, 9L, 1933.1500000000001, 4L, 2L, 0.523f, "Ti", new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), "1", "1" },
                    { 23L, 23L, 1.8999999999999999, 50.941499999999998, 3680.0, 2L, 6.1100000000000003, 5L, 4L, "[Ar] 3d3 4s2", 1.6299999999999999, "Vanadium", 6.7462, 5L, new Guid("490ed6e9-d6d0-4d7d-9535-dd1a6b1447c0"), "127.0.0.1", "127.0.0.1", 0.59f, true, 9L, 2175.1500000000001, 4L, 2L, 0.489f, "V", new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), "1", "1" },
                    { 24L, 24L, 1.8999999999999999, 51.996099999999998, 2944.0, 2L, 7.1500000000000004, 6L, 4L, "[Ar] 3d5 4s1", 1.6599999999999999, "Chromium", 6.7664999999999997, 6L, new Guid("8c9d5a16-73ec-4369-9d18-dd00cd403444"), "127.0.0.1", "127.0.0.1", 0.52f, true, 9L, 2130.1500000000001, 4L, 2L, 0.449f, "Cr", new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), "1", "1" },
                    { 25L, 25L, 1.8, 54.938045000000002, 2334.0, 2L, 7.4400000000000004, 7L, 4L, "[Ar] 3d5 4s2", 1.55, "Manganese", 7.4340000000000002, 7L, new Guid("bfeeb4a2-57f6-43f6-9799-59ce69a75d97"), "127.0.0.1", "127.0.0.1", 0.46f, true, 11L, 1519.1500000000001, 4L, 2L, 0.479f, "Mn", new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), "1", "1" },
                    { 26L, 26L, 1.7, 55.844999999999999, 3134.0, 2L, 7.8739999999999997, 8L, 4L, "[Ar] 3d6 4s2", 1.8300000000000001, "Iron", 7.9024000000000001, 8L, new Guid("06c550dd-37be-4253-b64f-335c8d0dcbee"), "127.0.0.1", "127.0.0.1", 0.65f, true, 10L, 1808.1500000000001, 4L, 2L, 0.449f, "Fe", new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), "1", "1" },
                    { 27L, 27L, 1.7, 58.933194999999998, 3200.0, 3L, 8.8599999999999994, 9L, 4L, "[Ar] 3d7 4s2", 1.8799999999999999, "Cobalt", 7.8810000000000002, 9L, new Guid("66f2eb11-9002-4d2e-999a-a3ea5ec7893e"), "127.0.0.1", "127.0.0.1", 0.75f, true, 14L, 1768.1500000000001, 4L, 2L, 0.421f, "Co", new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), "1", "1" },
                    { 28L, 28L, 1.6000000000000001, 58.693399999999997, 3186.0, 5L, 8.9120000000000008, 10L, 4L, "[Ar] 3d8 4s2", 1.9099999999999999, "Nickel", 7.6398000000000001, 10L, new Guid("688b338e-084d-4640-a9cb-2bd727910528"), "127.0.0.1", "127.0.0.1", 0.69f, true, 11L, 1726.1500000000001, 4L, 2L, 0.444f, "Ni", new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), "1", "1" },
                    { 29L, 29L, 1.6000000000000001, 63.545999999999999, 2835.0, 5L, 8.9600000000000009, 11L, 4L, "[Ar] 3d10 4s1", 1.8999999999999999, "Copper", 7.7263999999999999, 11L, new Guid("8f9fa04d-3b73-4be5-b1a5-f7f9517329e7"), "127.0.0.1", "127.0.0.1", 0.73f, true, 11L, 1357.75, 4L, 2L, 0.385f, "Cu", new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), "1", "1" },
                    { 30L, 30L, 1.5, 65.379999999999995, 1180.0, 3L, 7.1340000000000003, 12L, 4L, "[Ar] 3d10 4s2", 1.6499999999999999, "Zinc", 9.3941999999999997, 12L, new Guid("3db926ba-bda0-4ee1-9a61-78cb5ccc007b"), "127.0.0.1", "127.0.0.1", 0.74f, true, 15L, 692.88, 4L, 2L, 0.388f, "Zn", new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), "1", "1" },
                    { 31L, 31L, 1.8, 69.722999999999999, 2477.0, 7L, 5.907, 13L, 4L, "[Ar] 3d10 4s2 4p1", 1.8100000000000001, "Gallium", 5.9992999999999999, 13L, new Guid("3f7f16e1-2335-4008-9826-464a54de0735"), "127.0.0.1", "127.0.0.1", 0.62f, true, 14L, 302.91000000000003, 4L, 2L, 0.371f, "Ga", new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), new DateTime(2023, 9, 21, 0, 51, 35, 566, DateTimeKind.Local).AddTicks(7830), "1", "1" },
                    { 32L, 32L, 1.5, 72.640000000000001, 3106.0, 5L, 5.3230000000000004, 14L, 4L, "[Ar] 3d10 4s2 4p2", 2.0099999999999998, "Germanium", 7.8994, 14L, new Guid("58463c08-f261-4d0c-b12f-20878f8d69b1"), "127.0.0.1", "127.0.0.1", 0.53f, true, 17L, 1211.45, 4L, 2L, 0.32f, "Ge", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 33L, 33L, 1.3, 74.921599999999998, 887.0, 4L, 5.7759999999999998, 15L, 4L, "[Ar] 3d10 4s2 4p3", 2.1800000000000002, "Arsenic", 9.7886000000000006, 15L, new Guid("0bc7c0f8-fb7b-43ba-98c7-b241188f9697"), "127.0.0.1", "127.0.0.1", 0.58f, true, 14L, 1090.1500000000001, 4L, 2L, 0.329f, "As", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 34L, 34L, 1.2, 78.959999999999994, 958.0, 3L, 4.8090000000000002, 16L, 4L, "[Ar] 3d10 4s2 4p4", 2.5499999999999998, "Selenium", 9.7523999999999997, 16L, new Guid("762e94fb-5a37-4555-8a7d-0a56e0c6d42f"), "127.0.0.1", "127.0.0.1", 0.5f, true, 20L, 494.14999999999998, 4L, 2L, 0.321f, "Se", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 35L, 35L, 1.1000000000000001, 79.903999999999996, 332.0, 1L, 3.1219999999999999, 17L, 4L, "[Ar] 3d10 4s2 4p5", 2.96, "Bromine", 11.813800000000001, 17L, new Guid("9a775c11-425f-49f9-bb24-65386dfcca8f"), "127.0.0.1", "127.0.0.1", 2f, true, 19L, 266.05000000000001, 4L, 3L, 0.474f, "Br", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 36L, 36L, 1.0, 83.798000000000002, 119.93000000000001, 1L, 0.0037330000000000002, 18L, 4L, "[Ar] 3d10 4s2 4p6", null, "Krypton", 13.999599999999999, 18L, new Guid("c4740240-a9c8-4f75-b69f-fa95558a5f43"), "127.0.0.1", "127.0.0.1", null, true, 23L, 115.93000000000001, 4L, 1L, 0.248f, "Kr", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 37L, 37L, 3.0, 85.467799999999997, 961.0, 2L, 1.532, 1L, 5L, "[Kr] 5s1", 0.81999999999999995, "Rubidium", 4.1771000000000003, 1L, new Guid("8714ae4c-a49b-40d0-84d0-468d08027722"), "127.0.0.1", "127.0.0.1", 1.5f, true, 20L, 312.79000000000002, 5L, 2L, 0.363f, "Rb", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 38L, 38L, 2.5, 87.620000000000005, 1655.0, 5L, 2.6400000000000001, 2L, 5L, "[Kr] 5s2", 0.94999999999999996, "Strontium", 5.6948999999999996, 2L, new Guid("a65933b6-d7a6-4c08-ac91-105397a0d537"), "127.0.0.1", "127.0.0.1", 1.1f, true, 18L, 1042.1500000000001, 5L, 2L, 0.301f, "Sr", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 39L, 39L, 2.2999999999999998, 88.905850000000001, 3609.0, 3L, 4.4690000000000003, 3L, 5L, "[Kr] 4d1 5s2", 1.22, "Yttrium", 6.2172999999999998, 3L, new Guid("27c0ab53-d1c7-46ef-9d0b-02c2d4b74991"), "127.0.0.1", "127.0.0.1", 0.9f, true, 21L, 1799.1500000000001, 5L, 2L, 0.298f, "Y", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 40L, 40L, 2.2000000000000002, 91.224000000000004, 4682.0, 3L, 6.5060000000000002, 4L, 5L, "[Kr] 4d2 5s2", 1.3300000000000001, "Zirconium", 6.6338999999999997, 4L, new Guid("814459bb-e6a5-43b6-b59a-2b8c04b50d33"), "127.0.0.1", "127.0.0.1", 0.72f, true, 20L, 2125.1500000000001, 5L, 2L, 0.278f, "Zr", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 41L, 41L, 2.1000000000000001, 92.906379999999999, 5017.0, 2L, 8.5700000000000003, 5L, 5L, "[Kr] 4d4 5s1", 1.6000000000000001, "Niobium", 6.7588999999999997, 5L, new Guid("67d4a9ff-2889-4813-8c3e-46166e6f95a3"), "127.0.0.1", "127.0.0.1", 0.69f, true, 24L, 2741.1500000000001, 5L, 2L, 0.265f, "Nb", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 42L, 42L, 2.0, 95.959999999999994, 4912.0, 2L, 10.220000000000001, 6L, 5L, "[Kr] 4d5 5s1", 2.1600000000000001, "Molybdenum", 7.0923999999999996, 6L, new Guid("5d156707-f910-40a9-acea-230c3d49ec38"), "127.0.0.1", "127.0.0.1", 0.65f, true, 20L, 2890.1500000000001, 5L, 2L, 0.251f, "Mo", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 43L, 43L, 2.0, 98.0, 5150.0, 3L, 11.5, 7L, 5L, "[Kr] 4d5 5s2", 1.8999999999999999, "Technetium", 7.2800000000000002, 7L, new Guid("fe135b66-fd63-4e1e-bed0-01a1f2eda801"), "127.0.0.1", "127.0.0.1", 0.56f, true, 23L, 2473.1500000000001, 5L, 4L, null, "Tc", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 44L, 44L, 1.8999999999999999, 101.06999999999999, 4423.0, 3L, 12.369999999999999, 8L, 5L, "[Kr] 4d7 5s1", 2.2000000000000002, "Ruthenium", 7.3605, 8L, new Guid("ac69c66a-e0ab-4a8e-aff1-795f8fb440e8"), "127.0.0.1", "127.0.0.1", 0.68f, true, 16L, 2523.1500000000001, 5L, 2L, 0.238f, "Ru", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 45L, 45L, 1.8, 102.9055, 3968.0, 5L, 12.41, 9L, 5L, "[Kr] 4d8 5s1", 2.2799999999999998, "Rhodium", 7.4588999999999999, 9L, new Guid("af950e10-93b7-4050-bb31-41ebaefdaff6"), "127.0.0.1", "127.0.0.1", 0.68f, true, 20L, 2239.1500000000001, 5L, 2L, 0.243f, "Rh", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 46L, 46L, 1.8, 106.42, 3236.0, 5L, 12.02, 10L, 5L, "[Kr] 4d10", 2.2000000000000002, "Palladium", 8.3369, 10L, new Guid("51e75951-c6f7-4766-834f-58707a54c915"), "127.0.0.1", "127.0.0.1", 0.86f, true, 21L, 1825.1500000000001, 5L, 2L, 0.244f, "Pd", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 47L, 47L, 1.8, 107.8682, 2435.0, 5L, 10.500999999999999, 11L, 5L, "[Kr] 4d10 5s1", 1.9299999999999999, "Silver", 7.5762, 11L, new Guid("07f87993-bdae-4887-826e-918f2432c630"), "127.0.0.1", "127.0.0.1", 1.3f, true, 27L, 1234.1500000000001, 5L, 2L, 0.235f, "Ag", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 48L, 48L, 1.7, 112.411, 1040.0, 3L, 8.6899999999999995, 12L, 5L, "[Kr] 4d10 5s2", 1.6899999999999999, "Cadmium", 8.9938000000000002, 12L, new Guid("b50e3437-29c4-4e06-b1c9-dfb71c009af1"), "127.0.0.1", "127.0.0.1", 0.97f, true, 22L, 594.33000000000004, 5L, 2L, 0.232f, "Cd", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 49L, 49L, 2.0, 114.818, 2345.0, 8L, 7.3099999999999996, 13L, 5L, "[Kr] 4d10 5s2 5p1", 1.78, "Indium", 5.7864000000000004, 13L, new Guid("499f9a9d-2b5a-4d53-893b-20193e77d0fc"), "127.0.0.1", "127.0.0.1", 0.8f, true, 34L, 429.91000000000003, 5L, 2L, 0.233f, "In", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 50L, 50L, 1.7, 118.70999999999999, 2875.0, 8L, 7.2869999999999999, 14L, 5L, "[Kr] 4d10 5s2 5p2", 1.96, "Tin", 7.3438999999999997, 14L, new Guid("f172d5b0-c333-44c0-a0d2-fe337525361e"), "127.0.0.1", "127.0.0.1", 0.69f, true, 28L, 505.20999999999998, 5L, 2L, 0.228f, "Sn", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 51L, 51L, 1.5, 121.76000000000001, 1860.0, 4L, 6.6849999999999996, 15L, 5L, "[Kr] 4d10 5s2 5p3", 2.0499999999999998, "Antimony", 8.6083999999999996, 15L, new Guid("aa652f93-b45a-45fc-9802-4651709f99f5"), "127.0.0.1", "127.0.0.1", 0.76f, true, 29L, 904.04999999999995, 5L, 2L, 0.207f, "Sb", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 52L, 52L, 1.3999999999999999, 127.59999999999999, 1261.0, 3L, 6.2320000000000002, 16L, 5L, "[Kr] 4d10 5s2 5p4", 2.1000000000000001, "Tellurium", 9.0096000000000007, 16L, new Guid("7a668a8f-44a7-4ab9-a253-9875ff70a434"), "127.0.0.1", "127.0.0.1", 0.97f, true, 29L, 722.79999999999995, 5L, 2L, 0.202f, "Te", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 53L, 53L, 1.3, 126.90447, 457.39999999999998, 7L, 4.9299999999999997, 17L, 5L, "[Kr] 4d10 5s2 5p5", 2.6600000000000001, "Iodine", 10.4513, 17L, new Guid("3109a713-478e-4005-9d03-74f779473c69"), "127.0.0.1", "127.0.0.1", 2.2f, true, 24L, 386.64999999999998, 5L, 2L, 0.214f, "I", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 54L, 54L, 1.2, 131.29300000000001, 165.03, 1L, 0.0058869999999999999, 18L, 5L, "[Kr] 4d10 5s2 5p6", null, "Xenon", 12.129799999999999, 18L, new Guid("791d363f-e3a7-492f-8bf4-a2637d4e10c1"), "127.0.0.1", "127.0.0.1", null, true, 31L, 161.44999999999999, 5L, 1L, 0.158f, "Xe", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 55L, 55L, 3.2999999999999998, 132.9054519, 944.0, 1L, 1.873, 1L, 6L, "[Xe] 6s1", 0.79000000000000004, "Cesium", 3.8938999999999999, 1L, new Guid("5f548beb-d531-43f4-b30d-11bd70d093de"), "127.0.0.1", "127.0.0.1", 1.7f, true, 22L, 301.69999999999999, 6L, 2L, 0.242f, "Cs", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 56L, 56L, 2.7999999999999998, 137.327, 2170.0, 2L, 3.5939999999999999, 2L, 6L, "[Xe] 6s2", 0.89000000000000001, "Barium", 5.2117000000000004, 2L, new Guid("f114eaea-b26b-47a1-ae25-a91705e11f44"), "127.0.0.1", "127.0.0.1", 1.4f, true, 25L, 1002.15, 6L, 2L, 0.204f, "Ba", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 57L, 57L, 2.7000000000000002, 138.90547000000001, 3737.0, 3L, 6.1449999999999996, 3L, 8L, "[Xe] 5d1 6s2", 1.1000000000000001, "Lanthanum", 5.5769000000000002, 3L, new Guid("358942b4-01be-4146-ae57-7c6e985ef738"), "127.0.0.1", "127.0.0.1", 1.1f, true, 19L, 1193.1500000000001, 6L, 2L, 0.195f, "La", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 58L, 58L, 2.7000000000000002, 140.11600000000001, 3716.0, 5L, 6.7699999999999996, 4L, 8L, "[Xe] 4f1 5d1 6s2", 1.1200000000000001, "Cerium", 5.5387000000000004, 19L, new Guid("516ee167-52e1-464f-8e00-34635aa12359"), "127.0.0.1", "127.0.0.1", 1f, true, 19L, 1071.1500000000001, 6L, 2L, 0.192f, "Ce", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 59L, 59L, 2.7000000000000002, 140.90764999999999, 3793.0, 3L, 6.7729999999999997, 5L, 8L, "[Xe] 4f3 6s2", 1.1299999999999999, "Praseodymium", 5.4729999999999999, 20L, new Guid("b668ff0a-46e6-46e0-bb7d-e3972ec503e4"), "127.0.0.1", "127.0.0.1", 1f, true, 15L, 1204.1500000000001, 6L, 2L, 0.193f, "Pr", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 60L, 60L, 2.6000000000000001, 144.24199999999999, 3347.0, 3L, 7.0069999999999997, 6L, 8L, "[Xe] 4f4 6s2", 1.1399999999999999, "Neodymium", 5.5250000000000004, 21L, new Guid("aad752c4-510c-4341-82b2-44a6c5736c1c"), "127.0.0.1", "127.0.0.1", 1f, true, 16L, 1289.1500000000001, 6L, 2L, 0.19f, "Nd", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 61L, 61L, 2.6000000000000001, 145.0, 3273.0, 3L, 7.2599999999999998, 7L, 8L, "[Xe] 4f5 6s2", 1.1299999999999999, "Promethium", 5.5819999999999999, 22L, new Guid("8857aa47-10ca-4098-8309-ae2620c2f612"), "127.0.0.1", "127.0.0.1", 0.98f, true, 14L, 1204.1500000000001, 6L, 4L, null, "Pm", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 62L, 62L, 2.6000000000000001, 150.36000000000001, 2067.0, 3L, 7.5199999999999996, 8L, 8L, "[Xe] 4f6 6s2", 1.1699999999999999, "Samarium", 5.6436999999999999, 23L, new Guid("cc63809d-c358-4e9d-a342-bf4b49d4b5e9"), "127.0.0.1", "127.0.0.1", 0.96f, true, 17L, 1345.1500000000001, 6L, 2L, 0.197f, "Sm", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 63L, 63L, 2.6000000000000001, 151.964, 1802.0, 2L, 5.2430000000000003, 9L, 8L, "[Xe] 4f7 6s2", 1.2, "Europium", 5.6703999999999999, 24L, new Guid("17b4906d-b165-4aaa-b7cc-50eb22bb831f"), "127.0.0.1", "127.0.0.1", 0.95f, true, 21L, 1095.1500000000001, 6L, 2L, 0.182f, "Eu", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 64L, 64L, 2.5, 157.25, 3546.0, 3L, 7.8949999999999996, 10L, 8L, "[Xe] 4f7 5d1 6s2", 1.2, "Gadolinium", 6.1501000000000001, 25L, new Guid("da5b7dfd-5c3a-4938-a836-a383bc1fab60"), "127.0.0.1", "127.0.0.1", 0.94f, true, 17L, 1585.1500000000001, 6L, 2L, 0.236f, "Gd", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 65L, 65L, 2.5, 158.92535000000001, 3503.0, 3L, 8.2289999999999992, 11L, 8L, "[Xe] 4f9 6s2", 1.2, "Terbium", 5.8638000000000003, 26L, new Guid("c8d0274d-c9f9-49d6-a59c-20731d92c3b7"), "127.0.0.1", "127.0.0.1", 0.92f, true, 24L, 1630.1500000000001, 6L, 2L, 0.182f, "Tb", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 66L, 66L, 2.5, 162.5, 2840.0, 3L, 8.5500000000000007, 12L, 8L, "[Xe] 4f10 6s2", 1.22, "Dysprosium", 5.9389000000000003, 27L, new Guid("dbdd5c5f-de92-4705-b5b7-73ed9b75192f"), "127.0.0.1", "127.0.0.1", 0.91f, true, 21L, 1680.1500000000001, 6L, 2L, 0.17f, "Dy", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 67L, 67L, 2.5, 164.93031999999999, 2993.0, 3L, 8.7949999999999999, 13L, 8L, "[Xe] 4f11 6s2", 1.23, "Holmium", 6.0214999999999996, 28L, new Guid("5ca50ae8-08f2-40c5-8615-4ac518f10026"), "127.0.0.1", "127.0.0.1", 0.9f, true, 29L, 1743.1500000000001, 6L, 2L, 0.165f, "Ho", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 68L, 68L, 2.5, 167.25899999999999, 3503.0, 3L, 9.0660000000000007, 14L, 8L, "[Xe] 4f12 6s2", 1.24, "Erbium", 6.1077000000000004, 29L, new Guid("280f74c0-aee4-4041-9ccf-543acbc58c4b"), "127.0.0.1", "127.0.0.1", 0.88f, true, 16L, 1795.1500000000001, 6L, 2L, 0.168f, "Er", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 69L, 69L, 2.3999999999999999, 168.93421000000001, 2223.0, 3L, 9.3209999999999997, 15L, 8L, "[Xe] 4f13 6s2", 1.25, "Thulium", 6.1843000000000004, 30L, new Guid("46a4042c-ab29-4138-8823-0e1af9d45efc"), "127.0.0.1", "127.0.0.1", 0.87f, true, 18L, 1818.1500000000001, 6L, 2L, 0.16f, "Tm", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 70L, 70L, 2.3999999999999999, 173.054, 1469.0, 5L, 6.9649999999999999, 16L, 8L, "[Xe] 4f14 6s2", 1.1000000000000001, "Ytterbium", 6.2542, 31L, new Guid("b39d069a-bf94-4de5-a1ca-ba75359a9d51"), "127.0.0.1", "127.0.0.1", 0.86f, true, 16L, 1097.1500000000001, 6L, 2L, 0.155f, "Yb", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 71L, 71L, 2.2999999999999998, 174.96680000000001, 3675.0, 3L, 9.8399999999999999, 17L, 8L, "[Xe] 4f14 5d1 6s2", 1.27, "Lutetium", 5.4259000000000004, 32L, new Guid("19481025-cdc9-427e-8a83-921528abdf19"), "127.0.0.1", "127.0.0.1", 0.85f, true, 22L, 1936.1500000000001, 6L, 2L, 0.154f, "Lu", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 72L, 72L, 2.2000000000000002, 178.49000000000001, 4876.0, 3L, 13.31, 4L, 6L, "[Xe] 4f14 5d2 6s2", 1.3, "Hafnium", 6.8250999999999999, 4L, new Guid("23320800-3078-4050-9b84-83b025a114c5"), "127.0.0.1", "127.0.0.1", 0.71f, true, 17L, 2500.1500000000001, 6L, 2L, 0.144f, "Hf", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 73L, 73L, 2.1000000000000001, 180.94788, 5731.0, 2L, 16.654, 5L, 6L, "[Xe] 4f14 5d3 6s2", 1.5, "Tantalum", 7.5495999999999999, 5L, new Guid("9e965f9b-2b91-4b27-9a73-4b1a5da7f872"), "127.0.0.1", "127.0.0.1", 0.64f, true, 19L, 3269.1500000000001, 6L, 2L, 0.14f, "Ta", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 74L, 74L, 2.0, 183.84, 5828.0, 2L, 19.25, 6L, 6L, "[Xe] 4f14 5d4 6s2", 2.3599999999999999, "Wolfram", 7.8639999999999999, 6L, new Guid("1100ca21-26cf-4d45-bd4c-a356defd31ac"), "127.0.0.1", "127.0.0.1", 0.62f, true, 22L, 3680.1500000000001, 6L, 2L, 0.132f, "W", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 75L, 75L, 2.0, 186.20699999999999, 5869.0, 3L, 21.02, 7L, 6L, "[Xe] 4f14 5d5 6s2", 1.8999999999999999, "Rhenium", 7.8334999999999999, 7L, new Guid("5b0527ac-96d4-4f94-a436-773ce9b15aeb"), "127.0.0.1", "127.0.0.1", 0.56f, true, 21L, 3453.1500000000001, 6L, 2L, 0.137f, "Re", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 76L, 76L, 1.8999999999999999, 190.22999999999999, 5285.0, 3L, 22.609999999999999, 8L, 6L, "[Xe] 4f14 5d6 6s2", 2.2000000000000002, "Osmium", 8.4382000000000001, 8L, new Guid("7648d00f-68dc-4a10-b543-6a45c4b5c38a"), "127.0.0.1", "127.0.0.1", 0.63f, true, 19L, 3300.1500000000001, 6L, 2L, 0.13f, "Os", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 77L, 77L, 1.8999999999999999, 192.21700000000001, 4701.0, 5L, 22.559999999999999, 9L, 6L, "[Xe] 4f14 5d7 6s2", 2.2000000000000002, "Iridium", 8.9670000000000005, 9L, new Guid("476fc6fc-881f-4c03-a955-33b89056f5fb"), "127.0.0.1", "127.0.0.1", 0.63f, true, 25L, 2716.1500000000001, 6L, 2L, 0.131f, "Ir", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 78L, 78L, 1.8, 195.084, 4098.0, 5L, 21.460000000000001, 10L, 6L, "[Xe] 4f14 5d9 6s1", 2.2799999999999998, "Platinum", 8.9587000000000003, 10L, new Guid("25308ed5-1a14-46c0-bf0d-0b387c0a3f29"), "127.0.0.1", "127.0.0.1", 0.63f, true, 32L, 2045.1500000000001, 6L, 2L, 0.133f, "Pt", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 79L, 79L, 1.8, 196.96656899999999, 3129.0, 5L, 19.282, 11L, 6L, "[Xe] 4f14 5d10 6s1", 2.54, "Gold", 9.2255000000000003, 11L, new Guid("9c94d0c0-d00a-40a7-8e4c-a80ae4d3693d"), "127.0.0.1", "127.0.0.1", 0.85f, true, 21L, 1337.73, 6L, 2L, 0.129f, "Au", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 80L, 80L, 1.8, 200.59, 630.0, 1L, 13.5336, 12L, 6L, "[Xe] 4f14 5d10 6s2", 2.0, "Mercury", 10.4375, 12L, new Guid("ee770938-8950-4c58-be5f-2561a49e7f68"), "127.0.0.1", "127.0.0.1", 1f, true, 26L, 234.43000000000001, 6L, 3L, 0.14f, "Hg", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 81L, 81L, 2.1000000000000001, 204.38329999999999, 1746.0, 3L, 11.85, 13L, 6L, "[Xe] 4f14 5d10 6s2 6p1", 2.04, "Thallium", 6.1082000000000001, 13L, new Guid("a2ced02c-2ddb-4e73-b152-03126cffb987"), "127.0.0.1", "127.0.0.1", 1.5f, true, 28L, 577.14999999999998, 6L, 2L, 0.129f, "Tl", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 82L, 82L, 1.8, 207.19999999999999, 2022.0, 5L, 11.342000000000001, 14L, 6L, "[Xe] 4f14 5d10 6s2 6p2", 2.3300000000000001, "Lead", 7.4166999999999996, 14L, new Guid("a9376b7c-96f4-4ae4-bffd-a39217ef37b3"), "127.0.0.1", "127.0.0.1", 1.2f, true, 29L, 600.75, 6L, 2L, 0.129f, "Pb", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 83L, 83L, 1.6000000000000001, 208.9804, 1837.0, 4L, 9.8070000000000004, 15L, 6L, "[Xe] 4f14 5d10 6s2 6p3", 2.02, "Bismuth", 7.2855999999999996, 15L, new Guid("ed8c8852-77c0-4678-a9e9-8702a9ecf070"), "127.0.0.1", "127.0.0.1", 1f, true, 19L, 544.66999999999996, 6L, 2L, 0.122f, "Bi", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 84L, 84L, 1.5, 210.0, 1235.0, 6L, 9.3200000000000003, 16L, 6L, "[Xe] 4f14 5d10 6s2 6p4", 2.0, "Polonium", 8.4169999999999998, 16L, new Guid("ded5ade1-9e6e-4fec-97a5-8cfbb80c092f"), "127.0.0.1", "127.0.0.1", 2.3f, true, 34L, 527.14999999999998, 6L, 2L, null, "Po", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 85L, 85L, 1.3999999999999999, 210.0, 610.0, 1L, 7.0, 17L, 6L, "[Xe] 4f14 5d10 6s2 6p5", 2.2000000000000002, "Astatine", 9.3000000000000007, 17L, new Guid("fd2535a7-1cee-4a22-a65f-6531add08d2d"), "127.0.0.1", "127.0.0.1", null, true, 21L, 575.14999999999998, 6L, 2L, null, "At", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 86L, 86L, 1.3, 222.0, 211.30000000000001, 1L, 0.0097300000000000008, 18L, 6L, "[Xe] 4f14 5d10 6s2 6p6", null, "Radon", 10.7485, 18L, new Guid("397f50cc-e295-4cee-95b3-65d81f31c1df"), "127.0.0.1", "127.0.0.1", null, true, 20L, 202.15000000000001, 6L, 1L, 0.094f, "Rn", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 87L, 87L, null, 223.0, 950.0, 2L, 1.8700000000000001, 1L, 7L, "[Rn] 7s1", 0.69999999999999996, "Francium", 4.0727000000000002, 1L, new Guid("e6a6541e-28f7-4a32-8b0d-0b6001863306"), "127.0.0.1", "127.0.0.1", 1.8f, true, 21L, 300.14999999999998, 7L, 2L, null, "Fr", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 88L, 88L, null, 226.0, 2010.0, 2L, 5.5, 2L, 7L, "[Rn] 7s2", 0.90000000000000002, "Radium", 5.2784000000000004, 2L, new Guid("6ff8a279-4968-42cf-b67d-457e8101b3da"), "127.0.0.1", "127.0.0.1", 1.4f, true, 15L, 973.14999999999998, 7L, 2L, null, "Ra", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 89L, 89L, null, 227.0, 3471.0, 5L, 10.07, 3L, 9L, "[Rn] 6d1 7s2", 1.1000000000000001, "Actinium", 5.1699999999999999, 3L, new Guid("f05dba6d-3b90-4e12-a511-5c35745ea873"), "127.0.0.1", "127.0.0.1", 1.1f, true, 11L, 1323.1500000000001, 7L, 2L, 0.12f, "Ac", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 90L, 90L, null, 232.03806, 5061.0, 5L, 11.720000000000001, 4L, 9L, "[Rn] 6d2 7s2", 1.3, "Thorium", 6.3067000000000002, 19L, new Guid("caba3b54-5e7d-4b6e-b5d9-9dc93b80e0ef"), "127.0.0.1", "127.0.0.1", 0.97f, true, 12L, 2028.1500000000001, 7L, 2L, 0.113f, "Th", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 91L, 91L, null, 231.03587999999999, 4300.0, 7L, 15.369999999999999, 5L, 9L, "[Rn] 5f2 6d1 7s2", 1.5, "Protactinium", 5.8899999999999997, 20L, new Guid("9926ac39-537e-4ae3-92ea-e416bd2cf617"), "127.0.0.1", "127.0.0.1", 0.78f, true, 14L, 1873.1500000000001, 7L, 2L, null, "Pa", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 92L, 92L, null, 238.02891, 4404.0, 7L, 18.949999999999999, 6L, 9L, "[Rn] 5f3 6d1 7s2", 1.3799999999999999, "Uranium", 6.1940999999999997, 21L, new Guid("5ae5369b-f844-4eb5-813a-f5efb6b1bb2d"), "127.0.0.1", "127.0.0.1", 0.52f, true, 15L, 1405.1500000000001, 7L, 2L, 0.116f, "U", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 93L, 93L, null, 237.0, 4273.0, 7L, 20.449999999999999, 7L, 9L, "[Rn] 5f4 6d1 7s2", 1.3600000000000001, "Neptunium", 6.2656999999999998, 22L, new Guid("f9598d5c-8e86-40f9-9ea1-c00d82fb14af"), "127.0.0.1", "127.0.0.1", 0.75f, true, 153L, 913.14999999999998, 7L, 4L, null, "Np", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 94L, 94L, null, 244.0, 3501.0, 9L, 19.84, 8L, 9L, "[Rn] 5f6 7s2", 1.28, "Plutonium", 6.0262000000000002, 23L, new Guid("0378b555-21a1-44b0-80c5-580cff7a63ed"), "127.0.0.1", "127.0.0.1", 0.89f, true, 163L, 913.14999999999998, 7L, 4L, null, "Pu", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 95L, 95L, null, 243.0, 2880.0, 3L, 13.69, 9L, 9L, "[Rn] 5f7 7s2", 1.3, "Americium", 5.9737999999999998, 24L, new Guid("60bd22ed-fad6-4840-bd3f-48023ccab687"), "127.0.0.1", "127.0.0.1", 0.98f, true, 133L, 1267.1500000000001, 7L, 4L, null, "Am", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 96L, 96L, null, 247.0, 3383.0, 3L, 13.51, 10L, 9L, "", 1.3, "Curium", 5.9915000000000003, 25L, new Guid("2e311298-5af2-4845-8d56-098e9dc13f8d"), "127.0.0.1", "127.0.0.1", 0.97f, true, 133L, 1340.1500000000001, 7L, 4L, null, "Cm", new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 567, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 97L, 97L, null, 247.0, 983.0, 3L, 14.789999999999999, 11L, 9L, "", 1.3, "Berkelium", 6.1978999999999997, 26L, new Guid("1d826c9c-870c-4cd1-bbc6-3492968d05d6"), "127.0.0.1", "127.0.0.1", 0.95f, true, 83L, 1259.1500000000001, 7L, 4L, null, "Bk", new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 98L, 98L, null, 251.0, 1173.0, 3L, 15.1, 12L, 9L, "", 1.3, "Californium", 6.2816999999999998, 27L, new Guid("c8454eba-1177-42dc-b60c-5b252df6e1c3"), "127.0.0.1", "127.0.0.1", 0.93f, true, 123L, 1925.1500000000001, 7L, 4L, null, "Cf", new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 99L, 99L, null, 252.0, null, 3L, 13.5, 13L, 9L, "", 1.3, "Einsteinium", 6.4199999999999999, 28L, new Guid("9a6fde62-2410-4ea4-ac13-58ec045dcde7"), "127.0.0.1", "127.0.0.1", null, true, 123L, 1133.1500000000001, 7L, 4L, null, "Es", new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 100L, 100L, null, 257.0, null, 1L, null, 14L, 9L, "", 1.3, "Fermium", 6.5, 29L, new Guid("16da9cfe-afa1-4c7f-ad76-b06106d7d583"), "127.0.0.1", "127.0.0.1", null, true, 103L, null, 7L, 4L, null, "Fm", new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 101L, 101L, null, 258.0, null, 1L, null, 15L, 9L, "", 1.3, "Mendelevium", 6.5800000000000001, 30L, new Guid("13250812-5d25-41bc-8378-1aa5963bc3aa"), "127.0.0.1", "127.0.0.1", null, true, 33L, null, 7L, 4L, null, "Md", new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 102L, 102L, null, 259.0, null, 1L, null, 16L, 9L, "", 1.3, "Nobelium", 6.6500000000000004, 31L, new Guid("b327d96d-b8bb-4427-be9e-630fdf7b9483"), "127.0.0.1", "127.0.0.1", null, true, 73L, null, 7L, 4L, null, "No", new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 103L, 103L, null, 262.0, null, 1L, null, 17L, 9L, "", null, "Lawrencium", null, 32L, new Guid("726e5be3-baf2-4209-a1c7-0e02a11a4a37"), "127.0.0.1", "127.0.0.1", null, true, 203L, null, 7L, 4L, null, "Lr", new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 104L, 104L, null, 261.0, null, 1L, 18.100000000000001, 4L, 7L, "", null, "Rutherfordium", null, 4L, new Guid("0df6b946-aa14-487c-b2c2-8eb54accc380"), "127.0.0.1", "127.0.0.1", null, true, null, null, 7L, 4L, null, "Rf", new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 105L, 105L, null, 262.0, null, 1L, 39.0, 5L, 7L, "", null, "Dubnium", null, 5L, new Guid("57a6b44e-1ddb-4d14-9788-77dccf9b28b9"), "127.0.0.1", "127.0.0.1", null, true, null, null, 7L, 4L, null, "Db", new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 106L, 106L, null, 266.0, null, 1L, 35.0, 6L, 7L, "", null, "Seaborgium", null, 6L, new Guid("a3d7e3fa-249d-408f-9ba2-804295fa10bf"), "127.0.0.1", "127.0.0.1", null, true, null, null, 7L, 4L, null, "Sg", new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 107L, 107L, null, 264.0, null, 1L, 37.0, 7L, 7L, "", null, "Bohrium", null, 7L, new Guid("d792cbdd-fdc3-47bd-8104-4901e36cc0ce"), "127.0.0.1", "127.0.0.1", null, true, null, null, 7L, 4L, null, "Bh", new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 108L, 108L, null, 267.0, null, 1L, 41.0, 8L, 7L, "", null, "Hassium", null, 8L, new Guid("d1667855-b3c7-48bd-96fb-0b5df6aef46e"), "127.0.0.1", "127.0.0.1", null, true, null, null, 7L, 4L, null, "Hs", new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 109L, 109L, null, 268.0, null, 1L, 35.0, 9L, 7L, "", null, "Meitnerium", null, 9L, new Guid("6c57e866-04bf-420d-b0e0-c177f668c1d3"), "127.0.0.1", "127.0.0.1", null, true, null, null, 7L, 4L, null, "Mt", new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 110L, 110L, null, 271.0, null, 1L, null, 10L, 7L, "", null, "Darmstadtium ", null, 10L, new Guid("1c380d26-c44b-45f8-8de3-4d9acf0f1a4b"), "127.0.0.1", "127.0.0.1", null, true, null, null, 7L, 4L, null, "Ds ", new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 111L, 111L, null, 272.0, null, 1L, null, 11L, 7L, "", null, "Roentgenium ", null, 11L, new Guid("9b859158-1823-4a19-a13a-448ba026749c"), "127.0.0.1", "127.0.0.1", null, true, null, null, 7L, 4L, null, "Rg ", new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 112L, 112L, null, 285.0, null, 1L, null, 12L, 7L, "", null, "Copernicium ", null, 12L, new Guid("94c7e92f-331f-4b6c-b4e7-56a6009cfa32"), "127.0.0.1", "127.0.0.1", null, true, null, null, 7L, 4L, null, "Cn ", new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 113L, 113L, null, 284.0, null, 1L, null, 13L, 7L, "", null, "Ununtrium ", null, 13L, new Guid("670715e8-3304-4b0a-8d53-8d81e9379e4c"), "127.0.0.1", "127.0.0.1", null, true, null, null, 7L, 4L, null, "Uut ", new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 114L, 114L, null, 289.0, null, 1L, null, 14L, 7L, "", null, "Ununquadium ", null, 14L, new Guid("10a32c2c-5249-4b2e-8215-ab7dd67806c9"), "127.0.0.1", "127.0.0.1", null, true, null, null, 7L, 4L, null, "Uuq ", new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 115L, 115L, null, 288.0, null, 1L, null, 15L, 7L, "", null, "Ununpentium ", null, 15L, new Guid("a2c9f235-535d-4e0e-b541-90495830f6c3"), "127.0.0.1", "127.0.0.1", null, true, null, null, 7L, 4L, null, "Uup ", new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 116L, 116L, null, 292.0, null, 1L, null, 16L, 7L, "", null, "Ununhexium ", null, 16L, new Guid("22864dfc-de1c-47a1-9748-363f0a258c63"), "127.0.0.1", "127.0.0.1", null, true, null, null, 7L, 4L, null, "Uuh ", new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 117L, 117L, null, 295.0, null, 1L, null, 17L, 7L, "", null, "Ununseptium ", null, 17L, new Guid("35d733a2-fe07-485a-8e2a-467d29d1a4f0"), "127.0.0.1", "127.0.0.1", null, true, null, null, 7L, 4L, null, "Uus ", new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), "1", "1" },
                    { 118L, 118L, null, 294.0, null, 1L, null, 18L, 7L, "", null, "Ununoctium ", null, 18L, new Guid("07c47364-4cc4-4d38-9c9d-b78bd259100c"), "127.0.0.1", "127.0.0.1", null, true, null, null, 7L, 4L, null, "Uuo ", new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 9, 21, 0, 51, 35, 568, DateTimeKind.Local).AddTicks(7820), "1", "1" }
                });

            migrationBuilder.InsertData(
                table: "ElementType",
                columns: new[] { "Id", "Acronym", "ColorId", "Guid", "IPAdded", "IPModified", "ImagePath", "IsActive", "Name", "TimeAdded", "TimeModified", "UserAddedId", "UserModifiedId" },
                values: new object[,]
                {
                    { 1L, "nmn", 9L, new Guid("af89504d-ac3f-4ee3-8594-a92b5cb7a646"), "127.0.0.1", "127.0.0.1", "classification_icons/nonmetals.png", true, "Nonmetal", new DateTime(2023, 9, 21, 1, 9, 18, 10, DateTimeKind.Local).AddTicks(7010), new DateTime(2023, 9, 21, 1, 9, 18, 10, DateTimeKind.Local).AddTicks(7010), "1", "1" },
                    { 2L, "nbl", 8L, new Guid("06c587fe-f5fa-4022-a42e-bbbe8319fc8b"), "127.0.0.1", "127.0.0.1", "classification_icons/noble_gases.png", true, "Noble Gas", new DateTime(2023, 9, 21, 1, 9, 18, 10, DateTimeKind.Local).AddTicks(7010), new DateTime(2023, 9, 21, 1, 9, 18, 10, DateTimeKind.Local).AddTicks(7010), "1", "1" },
                    { 3L, "mlk", 2L, new Guid("17565823-480c-4815-a8ab-5ae311dc26b1"), "127.0.0.1", "127.0.0.1", "classification_icons/alkali_metals.png", true, "Alkali Metal", new DateTime(2023, 9, 21, 1, 9, 18, 10, DateTimeKind.Local).AddTicks(7010), new DateTime(2023, 9, 21, 1, 9, 18, 10, DateTimeKind.Local).AddTicks(7010), "1", "1" },
                    { 4L, "mea", 3L, new Guid("475b66ae-cc17-4e7f-93fd-2e7a75a0c01d"), "127.0.0.1", "127.0.0.1", "classification_icons/alkaline_metals.png", true, "Alkaline Earth Metal", new DateTime(2023, 9, 21, 1, 9, 18, 10, DateTimeKind.Local).AddTicks(7010), new DateTime(2023, 9, 21, 1, 9, 18, 10, DateTimeKind.Local).AddTicks(7010), "1", "1" },
                    { 5L, "mld", 6L, new Guid("67b76bd1-97f9-4d5b-81cd-defa8f13f981"), "127.0.0.1", "127.0.0.1", "classification_icons/alkali_metals.png", true, "Metalloid", new DateTime(2023, 9, 21, 1, 9, 18, 10, DateTimeKind.Local).AddTicks(7010), new DateTime(2023, 9, 21, 1, 9, 18, 10, DateTimeKind.Local).AddTicks(7010), "1", "1" },
                    { 6L, "hgn", 4L, new Guid("b5bc3a77-d9db-40a1-9a5a-be57704c4990"), "127.0.0.1", "127.0.0.1", "classification_icons/halogens.png", true, "Halogen", new DateTime(2023, 9, 21, 1, 9, 18, 10, DateTimeKind.Local).AddTicks(7010), new DateTime(2023, 9, 21, 1, 9, 18, 10, DateTimeKind.Local).AddTicks(7010), "1", "1" },
                    { 7L, "mtl", 7L, new Guid("d03c6b63-858f-4933-bbee-415832e17fea"), "127.0.0.1", "127.0.0.1", "classification_icons/metals.png", true, "Metal", new DateTime(2023, 9, 21, 1, 9, 18, 10, DateTimeKind.Local).AddTicks(7010), new DateTime(2023, 9, 21, 1, 9, 18, 10, DateTimeKind.Local).AddTicks(7010), "1", "1" },
                    { 8L, "mtt", 11L, new Guid("7e52eea6-1435-4603-9aa8-1197f61e3582"), "127.0.0.1", "127.0.0.1", "classification_icons/transition_metals.png", true, "Transition Metal", new DateTime(2023, 9, 21, 1, 9, 18, 10, DateTimeKind.Local).AddTicks(7010), new DateTime(2023, 9, 21, 1, 9, 18, 10, DateTimeKind.Local).AddTicks(7010), "1", "1" },
                    { 9L, "lan", 5L, new Guid("238fd4ad-2978-442a-8c4c-e047533af97b"), "127.0.0.1", "127.0.0.1", "classification_icons/lanthanides.png", true, "Lanthanide", new DateTime(2023, 9, 21, 1, 9, 18, 10, DateTimeKind.Local).AddTicks(7010), new DateTime(2023, 9, 21, 1, 9, 18, 10, DateTimeKind.Local).AddTicks(7010), "1", "1" },
                    { 10L, "act", 1L, new Guid("c47f95d2-fab5-4b32-9277-e2cf4412a5c5"), "127.0.0.1", "127.0.0.1", "classification_icons/actinides.png", true, "Actinide", new DateTime(2023, 9, 21, 1, 9, 18, 10, DateTimeKind.Local).AddTicks(7010), new DateTime(2023, 9, 21, 1, 9, 18, 10, DateTimeKind.Local).AddTicks(7010), "1", "1" },
                    { 11L, "txa", 10L, new Guid("0eeb6f30-9539-4e6d-a8f7-89d52d77ee5c"), "127.0.0.1", "127.0.0.1", "classification_icons/transactinides.png", true, "Transactinide", new DateTime(2023, 9, 21, 1, 9, 18, 10, DateTimeKind.Local).AddTicks(7010), new DateTime(2023, 9, 21, 1, 9, 18, 10, DateTimeKind.Local).AddTicks(7010), "1", "1" },
                    { 12L, "N/A", 12L, new Guid("a113012d-35bb-4049-a7b4-2e47f20b479c"), "127.0.0.1", "127.0.0.1", "common_icons/axe.png", true, "Not In Any Classification", new DateTime(2023, 9, 21, 1, 9, 18, 10, DateTimeKind.Local).AddTicks(7010), new DateTime(2023, 9, 21, 1, 9, 18, 10, DateTimeKind.Local).AddTicks(7010), "1", "1" },
                    { 13L, "coe", 12L, new Guid("403c98f2-95c7-45e8-bfaa-f934f2e24583"), "127.0.0.1", "127.0.0.1", "classification_icons/alembic.png", true, "Common Organic Element", new DateTime(2023, 9, 21, 1, 9, 18, 10, DateTimeKind.Local).AddTicks(7010), new DateTime(2023, 9, 21, 1, 9, 18, 10, DateTimeKind.Local).AddTicks(7010), "1", "1" },
                    { 14L, "uoe", 12L, new Guid("a2c960ae-e1fc-454a-adb7-ffc392d63967"), "127.0.0.1", "127.0.0.1", "classification_icons/test_tube.png", true, "Uncommon Organic Element", new DateTime(2023, 9, 21, 1, 9, 18, 10, DateTimeKind.Local).AddTicks(7010), new DateTime(2023, 9, 21, 1, 9, 18, 10, DateTimeKind.Local).AddTicks(7010), "1", "1" }
                });

            migrationBuilder.InsertData(
                table: "ElementClassification",
                columns: new[] { "Id", "ElementId", "Guid", "IPAdded", "IPModified", "IsActive", "TimeAdded", "TimeModified", "TypeId", "UserAddedId", "UserModifiedId" },
                values: new object[,]
                {
                    { 1L, 1L, new Guid("924127cd-c990-46a5-8c82-e68509665819"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 1L, "1", "1" },
                    { 2L, 6L, new Guid("b4ee574f-295a-410b-a613-059c44a7f0d6"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 1L, "1", "1" },
                    { 3L, 7L, new Guid("7a5dc691-d7b9-4617-a9c4-3a6d034bd104"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 1L, "1", "1" },
                    { 4L, 8L, new Guid("23ae37da-d2c2-4c6c-bf3b-4b1f8088568d"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 1L, "1", "1" },
                    { 5L, 15L, new Guid("ffeb83ec-e507-4459-b0c5-400c67ab253f"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 1L, "1", "1" },
                    { 6L, 16L, new Guid("0d32e17c-a381-42d3-8538-e06c3a5920f3"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 1L, "1", "1" },
                    { 7L, 34L, new Guid("ffcb9ae5-a0eb-43a9-9be0-6362a3e4a114"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 1L, "1", "1" },
                    { 8L, 2L, new Guid("cdc3a2bc-94cc-4f96-8138-a51b1597ae1b"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 2L, "1", "1" },
                    { 9L, 10L, new Guid("21d1924f-d7e1-4136-bd7c-de62534261d3"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 2L, "1", "1" },
                    { 10L, 18L, new Guid("e5854092-3236-4e68-b157-c2117f896a22"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 2L, "1", "1" },
                    { 11L, 36L, new Guid("c8d296ee-c3af-418e-9de7-1ffa8bb6d51c"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 2L, "1", "1" },
                    { 12L, 54L, new Guid("84d603d5-adc8-458f-9ef2-dd84df102d88"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 2L, "1", "1" },
                    { 13L, 85L, new Guid("37746000-ed7b-4a3c-9e04-dbc55b9e5440"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 2L, "1", "1" },
                    { 14L, 118L, new Guid("6578c669-861c-479e-985f-e556fe265156"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 2L, "1", "1" },
                    { 15L, 3L, new Guid("1afe3e60-5566-4c3d-a3a9-7d68d54cc8b8"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 3L, "1", "1" },
                    { 16L, 11L, new Guid("79240680-be7d-4cd1-a445-3d708724c6ad"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 3L, "1", "1" },
                    { 17L, 19L, new Guid("1d6bc386-7620-47bb-ac2d-5bb2d921a351"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 3L, "1", "1" },
                    { 18L, 37L, new Guid("3a46efab-e035-42bb-8a93-f527b4cb0947"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 3L, "1", "1" },
                    { 19L, 55L, new Guid("5534f30b-e1dd-4f9a-b0fa-087938ec5d86"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 3L, "1", "1" },
                    { 20L, 86L, new Guid("d82e94ed-f672-4131-8f6c-6c1825aa939b"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 3L, "1", "1" },
                    { 21L, 4L, new Guid("50369d50-75e2-44c6-8051-80d5cd16e6cf"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 4L, "1", "1" },
                    { 22L, 12L, new Guid("fda2824e-fa32-40ba-9c05-68c7a3a097af"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 4L, "1", "1" },
                    { 23L, 20L, new Guid("fa989dd8-d703-4f45-a297-507190a43c93"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 4L, "1", "1" },
                    { 24L, 38L, new Guid("c7168189-04ea-4dce-a610-2dbced5fbd7c"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 4L, "1", "1" },
                    { 25L, 56L, new Guid("86c903a4-87f2-4fc9-b34a-6f983a4986c9"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 4L, "1", "1" },
                    { 26L, 87L, new Guid("7aac7030-7342-46cb-b1b0-0f6b92846fad"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 4L, "1", "1" },
                    { 27L, 5L, new Guid("d088b2a8-6562-474a-8d19-bbb73ef2b358"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 5L, "1", "1" },
                    { 28L, 14L, new Guid("923404e9-6e28-4e25-9feb-42fcadba8d56"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 5L, "1", "1" },
                    { 29L, 32L, new Guid("82fed428-1f4d-453e-8c18-c203e6199d8b"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 5L, "1", "1" },
                    { 30L, 33L, new Guid("0c307ac2-58d5-4abb-83ad-7c4d3882b713"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 5L, "1", "1" },
                    { 31L, 51L, new Guid("eacf9746-68e4-4164-ad0b-27ff0d843561"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 5L, "1", "1" },
                    { 32L, 52L, new Guid("a56a7c3b-24ba-4199-b114-6d567a37005c"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 5L, "1", "1" },
                    { 33L, 84L, new Guid("2f5a905a-21b3-43f4-b839-ea5f13177ae5"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 5L, "1", "1" },
                    { 34L, 9L, new Guid("7c758ead-5e21-4972-b6b5-dda2c904b3ea"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 6L, "1", "1" },
                    { 35L, 17L, new Guid("86c8560b-bec1-4b3e-8722-9787fc0e20f9"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 6L, "1", "1" },
                    { 36L, 35L, new Guid("166286ec-ed97-4202-8438-1fe958ca5824"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 6L, "1", "1" },
                    { 37L, 53L, new Guid("e16c0397-f643-4907-b0c1-201da9fbfd01"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 6L, "1", "1" },
                    { 38L, 13L, new Guid("5d6ef05d-c61b-44c7-bebf-a981b33e63f0"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 7L, "1", "1" },
                    { 39L, 31L, new Guid("3ff86abc-7d0f-462a-b860-9d5572939fb9"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 7L, "1", "1" },
                    { 40L, 49L, new Guid("2a26a62a-1cbf-4306-8069-1ab65108c809"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 7L, "1", "1" },
                    { 41L, 50L, new Guid("e950667f-8e46-4443-9da8-09173bff71a3"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 7L, "1", "1" },
                    { 42L, 81L, new Guid("1c530347-8eed-489a-9d65-2df2817e013d"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 7L, "1", "1" },
                    { 43L, 82L, new Guid("04df7beb-dd8c-42c8-bc17-c6762b9bd14f"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 7L, "1", "1" },
                    { 44L, 83L, new Guid("83c42b08-d0ea-4a42-b1a0-ab185023477c"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 7L, "1", "1" },
                    { 45L, 21L, new Guid("ae05a7dc-faf0-4b1a-87f5-155e96112669"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 8L, "1", "1" },
                    { 46L, 22L, new Guid("8d3937dc-a712-485b-b988-111403ba18c9"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 8L, "1", "1" },
                    { 47L, 23L, new Guid("316b4c17-151d-4d8b-8665-bdc24a90ed9b"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 8L, "1", "1" },
                    { 48L, 24L, new Guid("38d85bf5-7bbc-4980-86a1-d4daf9b38f57"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 8L, "1", "1" },
                    { 49L, 25L, new Guid("fb31c286-61f8-4d96-949a-a8b9319325c0"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 8L, "1", "1" },
                    { 50L, 26L, new Guid("1021442a-8cdf-420b-8e84-8bddce462451"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 8L, "1", "1" },
                    { 51L, 27L, new Guid("fb8a0338-d2bf-4222-9a59-9462daede834"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 8L, "1", "1" },
                    { 52L, 28L, new Guid("3c4138e0-9654-432a-9aef-f7c131ccb15b"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 8L, "1", "1" },
                    { 53L, 29L, new Guid("99c6eb1e-27b6-4503-9550-ad9858c3511d"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 8L, "1", "1" },
                    { 54L, 30L, new Guid("bf801ea1-d1da-4d3e-b4c3-9a032947b36b"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 8L, "1", "1" },
                    { 55L, 39L, new Guid("c2ccac41-6d3b-4e39-af50-c58750a0124f"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 8L, "1", "1" },
                    { 56L, 40L, new Guid("f1cf0cea-0eac-4ac2-86a5-fc8122e2dd58"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 8L, "1", "1" },
                    { 57L, 41L, new Guid("bbe4dd5c-0852-47ae-98e4-4b50a93a2ef7"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 8L, "1", "1" },
                    { 58L, 42L, new Guid("153888b3-0bdb-4079-921d-aa5c36bc5e78"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 8L, "1", "1" },
                    { 59L, 43L, new Guid("6db8b591-0931-477c-a3c1-3701ab212812"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 8L, "1", "1" },
                    { 60L, 44L, new Guid("46e59f34-bead-4f3d-a18e-db042f35edfb"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 8L, "1", "1" },
                    { 61L, 45L, new Guid("38aed077-6b8a-4164-ac8c-3ff816ae52e4"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 8L, "1", "1" },
                    { 62L, 46L, new Guid("dad86d61-8093-41a0-bfe9-e39aa162de13"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 8L, "1", "1" },
                    { 63L, 47L, new Guid("f61cacd2-d646-4b4a-aadd-26d73c62ed76"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 8L, "1", "1" },
                    { 64L, 48L, new Guid("49a612fa-45c7-4fb7-9cc1-f0ebadb53a7f"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 8L, "1", "1" },
                    { 65L, 72L, new Guid("3c4dc57e-e4a5-45aa-b9de-a2edd3c8713e"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 8L, "1", "1" },
                    { 66L, 73L, new Guid("0dd0eb68-2c23-48e5-9bd0-1e78fe2ffe57"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 8L, "1", "1" },
                    { 67L, 74L, new Guid("466d4f0f-9a0a-4ea4-9d42-4f69988b9cc5"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 8L, "1", "1" },
                    { 68L, 75L, new Guid("560d0a93-ff3d-4e22-b5a4-75a72333b658"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 8L, "1", "1" },
                    { 69L, 76L, new Guid("d73ac17c-7ccd-46da-839b-a4f834b449e0"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 8L, "1", "1" },
                    { 70L, 77L, new Guid("3425f1aa-996f-405c-99ef-5dcb33559141"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 8L, "1", "1" },
                    { 71L, 78L, new Guid("4f5e605a-21ca-465f-a6de-f3bce37caadb"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 8L, "1", "1" },
                    { 72L, 79L, new Guid("31066a5e-fcd0-4df4-bbf8-10c17930bd6f"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 8L, "1", "1" },
                    { 73L, 80L, new Guid("91491d04-5494-40f2-9134-6322755fccb0"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 8L, "1", "1" },
                    { 74L, 57L, new Guid("bae3c238-83af-4d97-b618-c4c6ec0b3afa"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 9L, "1", "1" },
                    { 75L, 58L, new Guid("a2e8a957-714c-48e4-9298-720f6ab579ec"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 9L, "1", "1" },
                    { 76L, 59L, new Guid("0e9c3395-c08c-43d2-acbe-2efa6d99c1bc"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 9L, "1", "1" },
                    { 77L, 60L, new Guid("402259eb-5d4e-4bcb-8811-d9368dcc7333"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 9L, "1", "1" },
                    { 78L, 61L, new Guid("9ed9edeb-a15c-4fe1-a93b-305b16f4f3e9"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 9L, "1", "1" },
                    { 79L, 62L, new Guid("df2c8200-95a8-4331-a4fc-d5b668b97517"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 9L, "1", "1" },
                    { 80L, 63L, new Guid("895cfff0-ee04-4533-bc0f-ba36c2094868"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 9L, "1", "1" },
                    { 81L, 64L, new Guid("da680fe8-0e04-4441-813e-e2b2a0e21864"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 9L, "1", "1" },
                    { 82L, 65L, new Guid("e835b8b5-ec80-451c-9ec5-169d09bc22c3"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 9L, "1", "1" },
                    { 83L, 66L, new Guid("dfb67a97-c802-4258-9f05-2afedfab11b9"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 9L, "1", "1" },
                    { 84L, 67L, new Guid("29f12590-d6a0-41d7-a5ce-40585ccc530a"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 9L, "1", "1" },
                    { 85L, 68L, new Guid("7943df99-3744-4ce8-af05-964b25680a58"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 9L, "1", "1" },
                    { 86L, 69L, new Guid("c3655738-8499-4c55-b76d-75c16f94a2ec"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 9L, "1", "1" },
                    { 87L, 70L, new Guid("07e2aa94-a10a-4078-b14b-69932b5f7f7b"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 9L, "1", "1" },
                    { 88L, 71L, new Guid("9e5cd0f7-614b-433f-870c-4401b5499863"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 9L, "1", "1" },
                    { 89L, 88L, new Guid("e3552f1b-a397-4b76-b551-26b94c1b7bd3"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 10L, "1", "1" },
                    { 90L, 89L, new Guid("19a84f54-3fd2-4053-8f2a-2bbb229e45bc"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 10L, "1", "1" },
                    { 91L, 90L, new Guid("df7322a1-e891-4a59-9b80-17c006505520"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 10L, "1", "1" },
                    { 92L, 91L, new Guid("f12a82f2-a5c8-438a-9325-1dbd54485a8b"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 10L, "1", "1" },
                    { 93L, 92L, new Guid("9318b363-635c-4c9c-979c-0ecf75c467e6"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 10L, "1", "1" },
                    { 94L, 93L, new Guid("d19c68e2-ab97-4ca5-a585-7518b15c2c9f"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 10L, "1", "1" },
                    { 95L, 94L, new Guid("590744a8-9416-4708-aa57-1b856e1a32f0"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 10L, "1", "1" },
                    { 96L, 95L, new Guid("afa419ab-e1a1-40cb-b484-63ce3b6e1bc0"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 10L, "1", "1" },
                    { 97L, 96L, new Guid("c3e3da90-fdaa-4ad0-b309-d08c1497efeb"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 10L, "1", "1" },
                    { 98L, 97L, new Guid("ac630b65-01e3-4ced-9e06-e9ceb7308bdf"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 10L, "1", "1" },
                    { 99L, 98L, new Guid("cbe48a0b-fc95-4b90-b68e-c187d5fe3544"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 10L, "1", "1" },
                    { 100L, 99L, new Guid("ee95fa3e-d73d-47fd-8e91-80c87530a420"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 10L, "1", "1" },
                    { 101L, 100L, new Guid("e135811b-598f-4161-a98d-e7d47579dfcd"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 10L, "1", "1" },
                    { 102L, 101L, new Guid("65fe9aae-abb9-4f28-b65b-690038e6fa4c"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 10L, "1", "1" },
                    { 103L, 102L, new Guid("20114c94-b128-487a-9e36-db71a4e6d14e"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 10L, "1", "1" },
                    { 104L, 103L, new Guid("fb2ffdbb-c05a-4c10-b7a4-97f95532c2f1"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 10L, "1", "1" },
                    { 105L, 104L, new Guid("c4ee9505-8622-4bc4-ac44-8300c359ee36"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 11L, "1", "1" },
                    { 106L, 105L, new Guid("452b71fc-13ea-494f-8fef-d93fd3ab8029"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 11L, "1", "1" },
                    { 107L, 106L, new Guid("6ee22327-5c87-447c-80da-877421bd993f"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 11L, "1", "1" },
                    { 108L, 107L, new Guid("52d1ed5f-d89d-4ef5-a2b7-f7449a2914ec"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 11L, "1", "1" },
                    { 109L, 108L, new Guid("7011656d-9f56-4a6c-a98d-21a7701c631e"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 11L, "1", "1" },
                    { 110L, 109L, new Guid("e68234b3-9942-419e-a8e9-c8764b02b3b9"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 11L, "1", "1" },
                    { 111L, 110L, new Guid("cecb6af2-90ae-4f57-859d-654c785404ba"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 11L, "1", "1" },
                    { 112L, 111L, new Guid("b5ca9fcd-e77d-454e-b7dc-5a9085f0df47"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 11L, "1", "1" },
                    { 113L, 112L, new Guid("feea3493-3a0a-483c-b8e1-fbb8ebda028f"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 11L, "1", "1" },
                    { 114L, 114L, new Guid("d2cc0196-ccd8-46c1-aab3-cc27e0f3e5bc"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 11L, "1", "1" },
                    { 115L, 116L, new Guid("0a3fdd65-f237-4918-8bb8-b65712496f81"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 11L, "1", "1" },
                    { 116L, 113L, new Guid("2147c7c4-b100-4bf5-9f27-06bd82e215d8"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 12L, "1", "1" },
                    { 117L, 115L, new Guid("021ae608-53fe-44e7-a6f8-59617ea5a69f"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 12L, "1", "1" },
                    { 118L, 117L, new Guid("886b2e0b-c8af-413d-a564-f7f46ca6c391"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 12L, "1", "1" },
                    { 119L, 1L, new Guid("00000000-0000-0000-0000-000000000000"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 13L, "1", "1" },
                    { 120L, 6L, new Guid("00000000-0000-0000-0000-000000000000"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 13L, "1", "1" },
                    { 121L, 7L, new Guid("00000000-0000-0000-0000-000000000000"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 13L, "1", "1" },
                    { 122L, 8L, new Guid("00000000-0000-0000-0000-000000000000"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 13L, "1", "1" },
                    { 123L, 9L, new Guid("00000000-0000-0000-0000-000000000000"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 14L, "1", "1" },
                    { 124L, 15L, new Guid("00000000-0000-0000-0000-000000000000"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 14L, "1", "1" },
                    { 125L, 16L, new Guid("00000000-0000-0000-0000-000000000000"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 14L, "1", "1" },
                    { 126L, 17L, new Guid("00000000-0000-0000-0000-000000000000"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 14L, "1", "1" },
                    { 127L, 35L, new Guid("00000000-0000-0000-0000-000000000000"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 14L, "1", "1" },
                    { 128L, 53L, new Guid("00000000-0000-0000-0000-000000000000"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 14L, "1", "1" },
                    { 129L, 3L, new Guid("00000000-0000-0000-0000-000000000000"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 14L, "1", "1" },
                    { 130L, 11L, new Guid("00000000-0000-0000-0000-000000000000"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 14L, "1", "1" },
                    { 131L, 19L, new Guid("00000000-0000-0000-0000-000000000000"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 14L, "1", "1" },
                    { 132L, 4L, new Guid("00000000-0000-0000-0000-000000000000"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 14L, "1", "1" },
                    { 133L, 12L, new Guid("00000000-0000-0000-0000-000000000000"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 14L, "1", "1" },
                    { 134L, 20L, new Guid("00000000-0000-0000-0000-000000000000"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 14L, "1", "1" },
                    { 135L, 5L, new Guid("00000000-0000-0000-0000-000000000000"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 14L, "1", "1" },
                    { 136L, 13L, new Guid("00000000-0000-0000-0000-000000000000"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 14L, "1", "1" },
                    { 137L, 14L, new Guid("00000000-0000-0000-0000-000000000000"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 14L, "1", "1" },
                    { 138L, 2L, new Guid("00000000-0000-0000-0000-000000000000"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 14L, "1", "1" },
                    { 139L, 10L, new Guid("00000000-0000-0000-0000-000000000000"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 14L, "1", "1" },
                    { 140L, 18L, new Guid("00000000-0000-0000-0000-000000000000"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 9, 25, 13, 15, 22, 320, DateTimeKind.Local).AddTicks(1180), 14L, "1", "1" }
                });

            migrationBuilder.InsertData(
                table: "ElementDiscovery",
                columns: new[] { "Id", "Biography", "DiscoverersId", "ElementId", "Guid", "IPAdded", "IPModified", "IsActive", "TimeAdded", "TimeModified", "UserAddedId", "UserModifiedId" },
                values: new object[,]
                {
                    { 1L, null, 1L, 1L, new Guid("855b2cc1-7dc9-4253-bdc7-1ec642823d07"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1" },
                    { 2L, null, 2L, 2L, new Guid("a5a5f35f-cbe0-4d63-a16c-70ca233c27fc"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1" },
                    { 3L, null, 3L, 3L, new Guid("7491e90b-7c82-41f3-aae8-52e665877931"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1" },
                    { 4L, null, 4L, 4L, new Guid("a20e816c-dc2d-43ac-9866-d90f1b88e9d0"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1" },
                    { 5L, null, 5L, 5L, new Guid("7f0d441b-b8f8-4cd3-b29f-f49cd8e67887"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1" },
                    { 6L, null, 6L, 6L, new Guid("90d2e01a-4224-4510-b839-fac954f7c57d"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1" },
                    { 7L, null, 6L, 16L, new Guid("83a77d3c-86b8-4f15-9b39-a87387f8d82a"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1" },
                    { 8L, null, 6L, 26L, new Guid("4bded2a3-4071-42c0-bc5e-9aa6d93932ef"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1" },
                    { 9L, null, 6L, 29L, new Guid("311de6cd-645d-4706-ad19-f4cbecd39776"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1" },
                    { 10L, null, 6L, 30L, new Guid("1889f33a-f23c-4eff-92fe-31fc761834be"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1" },
                    { 11L, null, 6L, 47L, new Guid("3404980b-16e6-4ea1-ac1b-6fce8bca2b43"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1" },
                    { 12L, null, 6L, 50L, new Guid("aed3074c-2117-4407-b56c-673b743f7d0d"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1" },
                    { 13L, null, 6L, 79L, new Guid("2d6f9d83-6dc9-4119-9580-d7777619ff96"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1" },
                    { 14L, null, 6L, 80L, new Guid("e0ae176d-8ac5-442a-8c93-a65bc4179a9e"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1" },
                    { 15L, null, 6L, 82L, new Guid("2ec3fbc5-a371-4929-b9e5-6a3b1653c835"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1" },
                    { 16L, null, 7L, 7L, new Guid("8ed7d779-de92-4b4d-a3d7-61d60dc3e64e"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1" },
                    { 17L, null, 8L, 8L, new Guid("71eea791-e205-40a0-a239-6fcf24019dd5"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1" },
                    { 18L, null, 9L, 9L, new Guid("fdb49ea0-1928-4043-9915-c40a7002ac5c"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), "1", "1" },
                    { 19L, null, 10L, 10L, new Guid("c3301a63-7dcf-4c12-9506-fdd040756866"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 20L, null, 10L, 36L, new Guid("bed5d7e1-6474-49ae-bd25-af50d3f131d9"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 21L, null, 10L, 54L, new Guid("58ef3e5d-722b-4ef3-9850-2a40beb5b407"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 22L, null, 11L, 11L, new Guid("048a4b2e-6f38-40d8-bb83-6c8866543e7a"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 23L, null, 11L, 19L, new Guid("855666fd-80c4-4558-bd76-32b1a0dc1e4f"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 24L, null, 12L, 12L, new Guid("044f6596-d678-46b2-b504-9d5fbc2dda11"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 25L, null, 13L, 13L, new Guid("c2a23946-c532-4460-b334-2fe164283f42"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 26L, null, 14L, 14L, new Guid("8b4e952c-05d6-4c94-92a4-cea46780a381"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 27L, null, 15L, 15L, new Guid("d4cf26bf-dfc2-418e-b9a7-0e54aa2f11ce"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 28L, null, 16L, 17L, new Guid("0ab17bd4-d61c-4e70-bd20-0d1cfb10fb89"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 29L, null, 17L, 18L, new Guid("b212470b-4ca2-4495-81c0-ac837ce06a17"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 30L, null, 18L, 20L, new Guid("067da3fe-c52b-4463-9927-8d94402bc4bd"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 31L, null, 18L, 38L, new Guid("6f930927-3246-48c4-802c-341e882e21d0"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 32L, null, 18L, 56L, new Guid("120755d6-c578-4570-8fbb-5b65b62b3188"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 33L, null, 19L, 21L, new Guid("c66d9afc-df34-4178-b513-beafceaa7a5f"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 34L, null, 20L, 22L, new Guid("fc8b82ef-a853-4063-85b9-2fbf60753e5d"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 35L, null, 21L, 23L, new Guid("2dbf9107-434c-4f09-a3e0-bbeb93485d1c"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 36L, null, 22L, 24L, new Guid("435f63e0-eee2-4caa-9c3f-ea012370f211"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 37L, null, 23L, 25L, new Guid("4fae35e1-3fa5-4edc-b06f-b7cb0c201174"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 38L, null, 24L, 27L, new Guid("033c0cd1-9ea9-47c2-8672-a53e0d1d8b71"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 39L, null, 25L, 28L, new Guid("134e661a-0f70-421d-b66a-0b4b7c2e67c6"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 40L, null, 26L, 31L, new Guid("70c6bd0b-f593-438c-9f8f-966c24c03159"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 41L, null, 27L, 32L, new Guid("230f09ee-ecb8-4feb-b809-711d49c37f1d"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 42L, null, 28L, 33L, new Guid("c44739a4-0ee7-4ce2-b4c9-778379baf863"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 43L, null, 29L, 34L, new Guid("c1150c16-6e53-42af-9a65-78adab285ea8"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 44L, null, 30L, 35L, new Guid("61a4cd5f-bef1-4806-9928-2bd43de6f5af"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 45L, null, 31L, 37L, new Guid("d6ec1bf5-e079-4431-9c6e-31486c71db03"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 46L, null, 32L, 39L, new Guid("e59d54b8-a725-4006-aa82-0b46701f3b18"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 47L, null, 33L, 40L, new Guid("4ab42bbe-b453-45a0-a193-f0dd190bea53"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 48L, null, 34L, 41L, new Guid("d6474e0a-4818-4da7-8424-cc0be76afe8b"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 49L, null, 35L, 42L, new Guid("d3b9e10e-a638-4039-b868-00a3e144296d"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 50L, null, 36L, 43L, new Guid("fde3f681-9a56-411a-b06c-6ab7331fee9b"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 51L, null, 37L, 44L, new Guid("23ade3e3-5162-42ec-9b5e-fd62b0c49460"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 52L, null, 38L, 45L, new Guid("db26cfcd-b2f5-45ec-918f-ac51d295d838"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 53L, null, 38L, 46L, new Guid("e1db620f-16f5-4751-a95a-c8083ec3ad5b"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 54L, null, 39L, 48L, new Guid("f51942ef-e301-45cf-b881-9daafecf5e6a"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 55L, null, 40L, 49L, new Guid("2bc5372f-fb8f-4126-8667-c10f5b057fdc"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 56L, null, 41L, 51L, new Guid("e9e5496d-77e8-4ad3-a33a-9a2aae808592"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 57L, null, 42L, 52L, new Guid("1654c725-e736-4ede-be63-73e77ad97398"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 58L, null, 43L, 53L, new Guid("af52c8c1-8bce-44c0-ac17-9ef821827d2e"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 59L, null, 44L, 55L, new Guid("1af4d10d-880d-4581-ab6c-6b8404b2814b"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 60L, null, 45L, 57L, new Guid("baea751b-d5e8-42e1-b37f-5c7f92fb9187"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 61L, null, 46L, 58L, new Guid("5dbadb59-10c7-4375-a936-88c18b45077f"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 62L, null, 47L, 59L, new Guid("8074ee55-d10d-4c6c-83b8-532dd6f8e4d5"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 63L, null, 47L, 60L, new Guid("d25b99d5-280a-416d-b338-75884bfb99ee"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 64L, null, 48L, 61L, new Guid("e6eca3f9-844c-415d-858a-49d71d573e36"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 65L, null, 49L, 62L, new Guid("abea4b4c-c7e5-4cb9-8cf7-69f0e8ad4542"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 66L, null, 50L, 63L, new Guid("d3076e5b-6ba4-4de6-b4bb-9c11e54ebc66"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 67L, null, 51L, 64L, new Guid("1f37efb2-ea8d-4b84-8e89-9843dddcdb3d"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 68L, null, 52L, 65L, new Guid("27beefda-da17-4111-ad1c-71036e68bf83"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 69L, null, 52L, 68L, new Guid("25ca673c-595b-489b-aca1-b471eb1c6f9d"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 70L, null, 53L, 66L, new Guid("e3ea4c10-179a-4251-92f9-d0481e6a5987"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 71L, null, 54L, 67L, new Guid("86e9adea-7bfd-4b71-a550-9a684d7a8a72"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 72L, null, 55L, 69L, new Guid("d8a7a6ce-85ac-4608-87f4-b258ae6d176f"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 73L, null, 56L, 70L, new Guid("86bb5c33-a762-452d-bf3d-213e3665c00b"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 74L, null, 57L, 71L, new Guid("7c129fa4-54da-48f8-b62f-113e2bd70668"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 75L, null, 58L, 72L, new Guid("1f17e8ee-12d7-4eca-a7d0-1c93fb03fbe3"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 76L, null, 59L, 73L, new Guid("8b90db2a-d171-4d20-9cf1-06e0e6a55842"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 77L, null, 60L, 74L, new Guid("bb15341a-d7dd-46b5-a603-6f23acd743a2"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 78L, null, 61L, 75L, new Guid("e54e7b99-1ca2-41ed-9514-18af79942fa9"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 79L, null, 62L, 76L, new Guid("10896fd7-17cf-44a6-b8f7-3e5bd7721ee6"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 80L, null, 63L, 77L, new Guid("051d4023-fe9b-432f-a993-cef61d9436cf"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 81L, null, 64L, 78L, new Guid("31cbe25d-87c3-4fab-aab9-d59691f2ea7f"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 82L, null, 65L, 81L, new Guid("57a10168-d39d-431e-b393-7e413c5a0fa5"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 83L, null, 66L, 83L, new Guid("502b909d-0db6-4183-86bf-eb421bed9671"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 84L, null, 67L, 84L, new Guid("d5f9e6a8-8e4c-476a-96df-dd79d6ed4d96"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 85L, null, 68L, 85L, new Guid("80164688-35de-4dad-8c39-e25d25072f87"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 86L, null, 69L, 86L, new Guid("a1187c22-b1dd-4bd2-8aa3-f41887cbb747"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 87L, null, 70L, 87L, new Guid("233f2fcc-c5b8-48bb-8784-af3a3e9cee61"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 88L, null, 71L, 88L, new Guid("da31453c-d5b7-4703-ae8e-8dee3d4241af"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 89L, null, 72L, 89L, new Guid("960f73f1-a09f-47c8-b3d8-66283bfcbdff"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 90L, null, 73L, 90L, new Guid("fa08b2b1-b29c-4289-81b2-0a1f4c58d65e"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 91L, null, 74L, 91L, new Guid("9f438eba-7e81-443f-8dbd-3814ba7ee39f"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 92L, null, 75L, 92L, new Guid("38a29ed1-3751-4107-b8f2-d9b3e0735117"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 93L, null, 76L, 93L, new Guid("604add8e-a0fe-4810-a510-7d51b4c626a7"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 94L, null, 77L, 94L, new Guid("e9275e40-08a1-492f-9c98-ecc45447c66a"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 95L, null, 78L, 95L, new Guid("818867c4-7822-49be-858d-d8d27ba60dcc"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 96L, null, 78L, 96L, new Guid("ec1d4804-fbad-4882-8d02-31b487fee9bb"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 97L, null, 79L, 97L, new Guid("fdb94e2a-9956-4985-83f8-dadebc311830"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 98L, null, 80L, 98L, new Guid("0d35b0bf-1d10-492c-bfce-5467a9999a2d"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 99L, null, 81L, 99L, new Guid("0b37efc0-9ecb-4331-96fd-662b1d98cbde"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 9, 24, 22, 22, 39, 248, DateTimeKind.Local).AddTicks(9090), "1", "1" },
                    { 100L, null, 82L, 100L, new Guid("d60a42e1-f873-4000-933f-d4e6a1af84bb"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 249, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 249, DateTimeKind.Local).AddTicks(4090), "1", "1" },
                    { 101L, null, 83L, 101L, new Guid("499f21c0-6bd7-4971-b752-d8728b0a5d8b"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 249, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 249, DateTimeKind.Local).AddTicks(4090), "1", "1" },
                    { 102L, null, 84L, 102L, new Guid("cb0d916a-a185-4e72-b909-9405dda48339"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 249, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 249, DateTimeKind.Local).AddTicks(4090), "1", "1" },
                    { 103L, null, 85L, 103L, new Guid("b3075536-741e-4d2a-80e4-5df9cc8a36ce"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 249, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 249, DateTimeKind.Local).AddTicks(4090), "1", "1" },
                    { 104L, null, 86L, 104L, new Guid("0054e17c-5188-44b7-9d73-f76d6347e51f"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 249, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 249, DateTimeKind.Local).AddTicks(4090), "1", "1" },
                    { 105L, null, 87L, 105L, new Guid("423a6731-3a39-4ce5-b498-033548962828"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 249, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 249, DateTimeKind.Local).AddTicks(4090), "1", "1" },
                    { 106L, null, 88L, 106L, new Guid("a97de8f8-1874-406a-9604-edaa5469e2f3"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 249, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 249, DateTimeKind.Local).AddTicks(4090), "1", "1" },
                    { 107L, null, 89L, 107L, new Guid("76024136-404c-4610-9c45-e9c67a2f0fee"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 249, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 249, DateTimeKind.Local).AddTicks(4090), "1", "1" },
                    { 108L, null, 90L, 108L, new Guid("5b379a40-719e-405f-841d-d8cb13cd52bd"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 249, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 249, DateTimeKind.Local).AddTicks(4090), "1", "1" },
                    { 109L, null, 91L, 109L, new Guid("d0b3314a-ad29-495b-8bef-377f8c6c5fc7"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 249, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 249, DateTimeKind.Local).AddTicks(4090), "1", "1" },
                    { 110L, null, 92L, 110L, new Guid("ba46d1dd-6ffa-4d18-98fa-16e78757af19"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 249, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 249, DateTimeKind.Local).AddTicks(4090), "1", "1" },
                    { 111L, null, 92L, 111L, new Guid("e75436af-5d6e-4840-b5ed-805def81385c"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 249, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 249, DateTimeKind.Local).AddTicks(4090), "1", "1" },
                    { 112L, null, 92L, 112L, new Guid("b9ff7409-8b2f-48f7-99c2-b09f7e9c8355"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 249, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 249, DateTimeKind.Local).AddTicks(4090), "1", "1" },
                    { 113L, null, 92L, 113L, new Guid("232f4b47-882e-4e04-a998-434e899de279"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 249, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 249, DateTimeKind.Local).AddTicks(4090), "1", "1" },
                    { 114L, null, 92L, 114L, new Guid("cb2d25a4-045f-477b-a3df-ddef1bb21623"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 249, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 249, DateTimeKind.Local).AddTicks(4090), "1", "1" },
                    { 115L, null, 92L, 115L, new Guid("e2cdea4e-378c-49b7-960a-6cd518981f36"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 249, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 249, DateTimeKind.Local).AddTicks(4090), "1", "1" },
                    { 116L, null, 92L, 116L, new Guid("ee907e05-441b-42ca-b888-025fd1664927"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 249, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 249, DateTimeKind.Local).AddTicks(4090), "1", "1" },
                    { 117L, null, 92L, 117L, new Guid("e479d034-c05d-42ce-a069-2862e4479477"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 249, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 249, DateTimeKind.Local).AddTicks(4090), "1", "1" },
                    { 118L, null, 92L, 118L, new Guid("e665b64c-9a49-4202-b8d2-48f37aea74b5"), "127.0.0.1", "127.0.0.1", true, new DateTime(2023, 9, 24, 22, 22, 39, 249, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 9, 24, 22, 22, 39, 249, DateTimeKind.Local).AddTicks(4090), "1", "1" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chemist_UserAddedId",
                table: "Chemist",
                column: "UserAddedId");

            migrationBuilder.CreateIndex(
                name: "IX_Chemist_UserModifiedId",
                table: "Chemist",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_CrystalStructure_UserAddedId",
                table: "CrystalStructure",
                column: "UserAddedId");

            migrationBuilder.CreateIndex(
                name: "IX_CrystalStructure_UserModifiedId",
                table: "CrystalStructure",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_Element_ConfigId",
                table: "Element",
                column: "ConfigId");

            migrationBuilder.CreateIndex(
                name: "IX_Element_PhaseId",
                table: "Element",
                column: "PhaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Element_UserAddedId",
                table: "Element",
                column: "UserAddedId");

            migrationBuilder.CreateIndex(
                name: "IX_Element_UserModifiedId",
                table: "Element",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_ElementClassification_ElementId",
                table: "ElementClassification",
                column: "ElementId");

            migrationBuilder.CreateIndex(
                name: "IX_ElementClassification_TypeId",
                table: "ElementClassification",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ElementClassification_UserAddedId",
                table: "ElementClassification",
                column: "UserAddedId");

            migrationBuilder.CreateIndex(
                name: "IX_ElementClassification_UserModifiedId",
                table: "ElementClassification",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_ElementDiscovery_DiscoverersId",
                table: "ElementDiscovery",
                column: "DiscoverersId");

            migrationBuilder.CreateIndex(
                name: "IX_ElementDiscovery_ElementId",
                table: "ElementDiscovery",
                column: "ElementId");

            migrationBuilder.CreateIndex(
                name: "IX_ElementDiscovery_UserAddedId",
                table: "ElementDiscovery",
                column: "UserAddedId");

            migrationBuilder.CreateIndex(
                name: "IX_ElementDiscovery_UserModifiedId",
                table: "ElementDiscovery",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_ElementDiscoveryGroup_UserAddedId",
                table: "ElementDiscoveryGroup",
                column: "UserAddedId");

            migrationBuilder.CreateIndex(
                name: "IX_ElementDiscoveryGroup_UserModifiedId",
                table: "ElementDiscoveryGroup",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_ElementType_ColorId",
                table: "ElementType",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_ElementType_UserAddedId",
                table: "ElementType",
                column: "UserAddedId");

            migrationBuilder.CreateIndex(
                name: "IX_ElementType_UserModifiedId",
                table: "ElementType",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_Phase_UserAddedId",
                table: "Phase",
                column: "UserAddedId");

            migrationBuilder.CreateIndex(
                name: "IX_Phase_UserModifiedId",
                table: "Phase",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_WebColor_UserAddedId",
                table: "WebColor",
                column: "UserAddedId");

            migrationBuilder.CreateIndex(
                name: "IX_WebColor_UserModifiedId",
                table: "WebColor",
                column: "UserModifiedId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chemist");

            migrationBuilder.DropTable(
                name: "ElementClassification");

            migrationBuilder.DropTable(
                name: "ElementDiscovery");

            migrationBuilder.DropTable(
                name: "ElementType");

            migrationBuilder.DropTable(
                name: "ElementDiscoveryGroup");

            migrationBuilder.DropTable(
                name: "Element");

            migrationBuilder.DropTable(
                name: "WebColor");

            migrationBuilder.DropTable(
                name: "CrystalStructure");

            migrationBuilder.DropTable(
                name: "Phase");

            migrationBuilder.DropTable(
                name: "IdentityUser");
        }
    }
}
