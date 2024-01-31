using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace GYMManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class Intial1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    NameInArabic = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    NameInEnglish = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false, defaultValue: "Training and Observing"),
                    Description = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    CreateionDate = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2024, 1, 31, 18, 17, 4, 685, DateTimeKind.Local).AddTicks(4460))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentID);
                    table.CheckConstraint("CH_Department_NameInArabic", "LENGTH(NameInArabic) >= 4");
                    table.CheckConstraint("CH_Department_NameInEnglish", "LENGTH(NameInEnglish) >= 4");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Subscription",
                columns: table => new
                {
                    SubscriptionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    StartDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Description = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<float>(type: "float", nullable: false, defaultValue: 15f),
                    SubscriptionStatus = table.Column<int>(type: "int", nullable: false),
                    DurationInDays = table.Column<int>(type: "int", nullable: false),
                    TrainingHoursInDay = table.Column<int>(type: "int", nullable: false),
                    MaxNumberOfVisits = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    CreateionDate = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2024, 1, 31, 18, 17, 4, 685, DateTimeKind.Local).AddTicks(9028))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscription", x => x.SubscriptionID);
                    table.CheckConstraint("CH_Subscription_StartDate", "EndDate > StartDate AND StartDate > sysdate() AND EndDate > sysdate()");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TrainingCourse",
                columns: table => new
                {
                    TrainingCourseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Image = table.Column<string>(type: "longtext", nullable: false),
                    Description = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    intensityLevel = table.Column<int>(type: "int", nullable: false),
                    Schedule = table.Column<string>(type: "longtext", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    CreateionDate = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2024, 1, 31, 18, 17, 4, 686, DateTimeKind.Local).AddTicks(88)),
                    DepartmentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingCourse", x => x.TrainingCourseID);
                    table.ForeignKey(
                        name: "FK_TrainingCourse_Department_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Department",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    PersonID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(type: "varchar(14)", maxLength: 14, nullable: false),
                    Email = table.Column<string>(type: "varchar(255)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "varchar(255)", nullable: false),
                    PassWord = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    HealthStatus = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false, defaultValue: "Uninfected"),
                    Image = table.Column<string>(type: "longtext", nullable: false),
                    genderType = table.Column<int>(type: "int", nullable: false),
                    Specialization = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Certifications = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    DepartmentID = table.Column<int>(type: "int", nullable: false),
                    SubscriptionID = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    CreateionDate = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2024, 1, 31, 18, 17, 4, 685, DateTimeKind.Local).AddTicks(7046)),
                    Salary = table.Column<float>(type: "float", nullable: false, defaultValue: 260f)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.PersonID);
                    table.CheckConstraint("CH_Person_Email", " Email LIKE '%@%.com'");
                    table.CheckConstraint("CH_Person_FullName", "LENGTH(FullName) >= 3");
                    table.CheckConstraint("CH_Person_PassWord", "PassWord LIKE '[1-9]'");
                    table.CheckConstraint("CH_Person_PhoneNumber", "PhoneNumber LIKE '009627________'");
                    table.ForeignKey(
                        name: "FK_Person_Department_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Department",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Person_Subscription_SubscriptionID",
                        column: x => x.SubscriptionID,
                        principalTable: "Subscription",
                        principalColumn: "SubscriptionID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TrainingCourseSubscription",
                columns: table => new
                {
                    TrainingCourseSubscriptionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    CreateionDate = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2024, 1, 31, 18, 17, 4, 686, DateTimeKind.Local).AddTicks(1070)),
                    SubscriptionID = table.Column<int>(type: "int", nullable: false),
                    TrainingCourseID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingCourseSubscription", x => x.TrainingCourseSubscriptionID);
                    table.ForeignKey(
                        name: "FK_TrainingCourseSubscription_Subscription_SubscriptionID",
                        column: x => x.SubscriptionID,
                        principalTable: "Subscription",
                        principalColumn: "SubscriptionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingCourseSubscription_TrainingCourse_TrainingCourseID",
                        column: x => x.TrainingCourseID,
                        principalTable: "TrainingCourse",
                        principalColumn: "TrainingCourseID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CoachTrainingCourse",
                columns: table => new
                {
                    CoachTrainingCourseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    CreateionDate = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2024, 1, 31, 18, 17, 4, 685, DateTimeKind.Local).AddTicks(3691)),
                    TrainingCourseID = table.Column<int>(type: "int", nullable: false),
                    CoachPersonID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoachTrainingCourse", x => x.CoachTrainingCourseID);
                    table.ForeignKey(
                        name: "FK_CoachTrainingCourse_Person_CoachPersonID",
                        column: x => x.CoachPersonID,
                        principalTable: "Person",
                        principalColumn: "PersonID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoachTrainingCourse_TrainingCourse_TrainingCourseID",
                        column: x => x.TrainingCourseID,
                        principalTable: "TrainingCourse",
                        principalColumn: "TrainingCourseID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_CoachTrainingCourse_CoachPersonID",
                table: "CoachTrainingCourse",
                column: "CoachPersonID");

            migrationBuilder.CreateIndex(
                name: "IX_CoachTrainingCourse_TrainingCourseID",
                table: "CoachTrainingCourse",
                column: "TrainingCourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Person_DepartmentID",
                table: "Person",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Person_Email",
                table: "Person",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Person_PhoneNumber",
                table: "Person",
                column: "PhoneNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Person_SubscriptionID",
                table: "Person",
                column: "SubscriptionID");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingCourse_DepartmentID",
                table: "TrainingCourse",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingCourseSubscription_SubscriptionID",
                table: "TrainingCourseSubscription",
                column: "SubscriptionID");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingCourseSubscription_TrainingCourseID",
                table: "TrainingCourseSubscription",
                column: "TrainingCourseID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoachTrainingCourse");

            migrationBuilder.DropTable(
                name: "TrainingCourseSubscription");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "TrainingCourse");

            migrationBuilder.DropTable(
                name: "Subscription");

            migrationBuilder.DropTable(
                name: "Department");
        }
    }
}
