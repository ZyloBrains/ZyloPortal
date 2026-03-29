using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZyloApp.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Batches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colleges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colleges", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FinAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeeAmount = table.Column<float>(type: "real", nullable: false),
                    Discount = table.Column<float>(type: "real", nullable: false),
                    PaidAmount = table.Column<float>(type: "real", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinAccounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Resume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Publish = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Requirements = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RepoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoardUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColorCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TechPrograms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Affliation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechPrograms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
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
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Widgets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HtmlContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Widgets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BatchId = table.Column<int>(type: "int", nullable: true),
                    ProjectId = table.Column<int>(type: "int", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teams_Batches_BatchId",
                        column: x => x.BatchId,
                        principalTable: "Batches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Teams_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InstructorTag",
                columns: table => new
                {
                    InstructorId = table.Column<int>(type: "int", nullable: false),
                    TagsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstructorTag", x => new { x.InstructorId, x.TagsId });
                    table.ForeignKey(
                        name: "FK_InstructorTag_Instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InstructorTag_Tags_TagsId",
                        column: x => x.TagsId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRole_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRole_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TagWidget",
                columns: table => new
                {
                    TagsId = table.Column<int>(type: "int", nullable: false),
                    WidgetsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagWidget", x => new { x.TagsId, x.WidgetsId });
                    table.ForeignKey(
                        name: "FK_TagWidget_Tags_TagsId",
                        column: x => x.TagsId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TagWidget_Widgets_WidgetsId",
                        column: x => x.WidgetsId,
                        principalTable: "Widgets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GeneralProgramming = table.Column<int>(type: "int", nullable: false),
                    WebExperience = table.Column<int>(type: "int", nullable: false),
                    DbExperience = table.Column<int>(type: "int", nullable: false),
                    FormSubmitted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ProfileImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CollegeId = table.Column<int>(type: "int", nullable: false),
                    TechProgramId = table.Column<int>(type: "int", nullable: false),
                    FinAccountId = table.Column<int>(type: "int", nullable: true),
                    TeamId = table.Column<int>(type: "int", nullable: true),
                    BatchId = table.Column<int>(type: "int", nullable: true),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Batches_BatchId",
                        column: x => x.BatchId,
                        principalTable: "Batches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Students_Colleges_CollegeId",
                        column: x => x.CollegeId,
                        principalTable: "Colleges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_FinAccounts_FinAccountId",
                        column: x => x.FinAccountId,
                        principalTable: "FinAccounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Students_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Students_TechPrograms_TechProgramId",
                        column: x => x.TechProgramId,
                        principalTable: "TechPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_Users_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Attendances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    PunchIn = table.Column<TimeOnly>(type: "time", nullable: true),
                    PunchOut = table.Column<TimeOnly>(type: "time", nullable: true),
                    WorkLog = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attendances_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Colleges",
                columns: new[] { "Id", "Created", "CreatedBy", "LastUpdated", "LastUpdatedBy", "Location", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2488), null, null, null, "Bhadrapur, Jhapa", "Mechi Multiple Campus" },
                    { 2, new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2510), null, null, null, "Dhankuta", "Dhankuta Multiple Campus" },
                    { 3, new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2511), null, null, null, "Dharan", "Central Campus of Technology" },
                    { 4, new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2512), null, null, null, "Biratnagar", "Mahendra Morang Adarsha Multiple Campus" },
                    { 5, new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2513), null, null, null, "Rajbiraj", "Mahendra Bindeshwori Multiple Campus" },
                    { 6, new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2515), null, null, null, "Siraha", "Surya Narayan Satya Na. Mo. Yadav Campus" },
                    { 7, new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2516), null, null, null, "Janakpur", "Ramsorup Ramsagar Multiple Campus" },
                    { 8, new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2517), null, null, null, "Birgunj", "Thakur Ram Multiple Campus" },
                    { 9, new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2518), null, null, null, "Bharatpur", "Birendra Multiple Campus" },
                    { 10, new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2519), null, null, null, "Pokhara", "Prithivi Narayan Multiple Campus" },
                    { 11, new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2520), null, null, null, "Mahendranagar", "SidhaNath Science Campus" },
                    { 12, new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2521), null, null, null, "Nepalgunj", "Mahendra Multiple Campus" },
                    { 13, new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2522), null, null, null, "Butwal", "Butwal Multiple Campus" },
                    { 14, new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2523), null, null, null, "Palpa", "Tribhuvan Multiple Campus" },
                    { 15, new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2524), null, null, null, "Ghantaghar", "Tri-Chandra Multiple Campus" },
                    { 16, new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2525), null, null, null, "Lainchour", "Amrit Science Campus" },
                    { 17, new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2526), null, null, null, "Patan", "Patan Multiple Campus" },
                    { 18, new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2527), null, null, null, "Bhaktapur", "Bhaktapur Multiple Campus" },
                    { 19, new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2528), null, null, null, "Bagbazar", "Padma Kanya Multiple Campus" },
                    { 20, new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2529), null, null, null, "Ghorahi, Dang", "Mahendra Multiple Campus" },
                    { 21, new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2530), null, null, null, "Baglung", "Dhaulagiri Campus" },
                    { 22, new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2531), null, null, null, "Gorkha", "Gorkha Campus" },
                    { 23, new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2532), null, null, null, "Bhairahawa", "Bhairahawa Multiple Campus" },
                    { 24, new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2533), null, null, null, "Biratnagar", "Degree Campus" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "32fd450f-ab5e-4b63-a7dc-38f5e30e502c", "32fd450f-ab5e-4b63-a7dc-38f5e30e502c", "Trainee", "TRAINEE" },
                    { "3d7bc476-9cdd-4eb8-899f-2c313ec71e73", "3d7bc476-9cdd-4eb8-899f-2c313ec71e73", "SuperAdmin", "SUPERADMIN" },
                    { "9fa4ba00-c6a1-487b-a6c4-f56fb276bd67", "9fa4ba00-c6a1-487b-a6c4-f56fb276bd67", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "TechPrograms",
                columns: new[] { "Id", "Affliation", "Created", "CreatedBy", "LastUpdated", "LastUpdatedBy", "Name" },
                values: new object[,]
                {
                    { 1, "TU", new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2913), null, null, null, "BCA" },
                    { 2, "PU", new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2918), null, null, null, "BCA" },
                    { 3, "TU", new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2919), null, null, null, "BIT" },
                    { 4, "PU", new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2920), null, null, null, "BIT" },
                    { 5, "TU", new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2921), null, null, null, "BIM" },
                    { 6, "TU", new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2922), null, null, null, "BScIT" },
                    { 7, "PU", new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2923), null, null, null, "BScIT" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "08e4ff02-9df1-415c-ab49-892c539a689b", 0, "4d6c5e2a-3981-4764-af81-07e4e6b1d0f6", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAEMXZQToP7v66Y+cWWQGENKbKu2mcOvH4kemxkuFg97K4ms2RfWmrqOtgi2lYFxgkTQ==", null, false, "09e416de-8a5d-46a4-aa2b-1b79bed5c8db", false, "rawal.bishnu@live.com" });

            migrationBuilder.InsertData(
                table: "Widgets",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "HtmlContent", "LastUpdated", "LastUpdatedBy", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2975), "Seed", "An display item in home page", "Welcome to AppTechnoSoft! An initiative for students and freshers.", null, null, "CarouselItem" },
                    { 2, new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2979), "Seed", "An display item in home page", "Bridging the gap between academia and industry!", null, null, "CarouselItem" },
                    { 3, new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2981), "Seed", "An display item in home page", "We guide you on software R&D and SDLC to kickstart your career!", null, null, "CarouselItem" },
                    { 4, new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2983), "Seed", "An display item in home page", "Replacement Opportunities!", null, null, "CarouselItem" },
                    { 5, new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2985), "Seed", "An display item in home page", "From basics to professional touches!", null, null, "CarouselItem" },
                    { 6, new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2988), "Seed", "GIT and GitHub Essentials", "todo", null, null, "Module" },
                    { 7, new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2990), "Seed", "Training + Internship Combo", "todo", null, null, "HomeIntro" }
                });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3d7bc476-9cdd-4eb8-899f-2c313ec71e73", "08e4ff02-9df1-415c-ab49-892c539a689b" });

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_StudentId",
                table: "Attendances",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_InstructorTag_TagsId",
                table: "InstructorTag",
                column: "TagsId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ApplicationUserId",
                table: "Students",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_BatchId",
                table: "Students",
                column: "BatchId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_CollegeId",
                table: "Students",
                column: "CollegeId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_FinAccountId",
                table: "Students",
                column: "FinAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_TeamId",
                table: "Students",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_TechProgramId",
                table: "Students",
                column: "TechProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_TagWidget_WidgetsId",
                table: "TagWidget",
                column: "WidgetsId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_BatchId",
                table: "Teams",
                column: "BatchId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_ProjectId",
                table: "Teams",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_RoleId",
                table: "UserRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attendances");

            migrationBuilder.DropTable(
                name: "InstructorTag");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "TagWidget");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Widgets");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Colleges");

            migrationBuilder.DropTable(
                name: "FinAccounts");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "TechPrograms");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Batches");

            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
