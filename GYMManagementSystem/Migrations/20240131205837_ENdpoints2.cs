using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GYMManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class ENdpoints2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CH_Person_PassWord",
                table: "Person");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "TrainingCourseSubscription",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 31, 23, 58, 36, 975, DateTimeKind.Local).AddTicks(4709),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 31, 22, 53, 24, 393, DateTimeKind.Local).AddTicks(6055));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "TrainingCourse",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 31, 23, 58, 36, 975, DateTimeKind.Local).AddTicks(3722),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 31, 22, 53, 24, 393, DateTimeKind.Local).AddTicks(4015));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "Subscription",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 31, 23, 58, 36, 975, DateTimeKind.Local).AddTicks(2724),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 31, 22, 53, 24, 393, DateTimeKind.Local).AddTicks(2271));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "Person",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 31, 23, 58, 36, 975, DateTimeKind.Local).AddTicks(444),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 31, 22, 53, 24, 392, DateTimeKind.Local).AddTicks(7832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "Department",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 31, 23, 58, 36, 974, DateTimeKind.Local).AddTicks(7729),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 31, 22, 53, 24, 392, DateTimeKind.Local).AddTicks(1824));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "CoachTrainingCourse",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 31, 23, 58, 36, 974, DateTimeKind.Local).AddTicks(6937),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 31, 22, 53, 24, 392, DateTimeKind.Local).AddTicks(302));

            migrationBuilder.AddCheckConstraint(
                name: "CH_Person_PassWord",
                table: "Person",
                sql: "LENGTH(PassWord) >= 8");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CH_Person_PassWord",
                table: "Person");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "TrainingCourseSubscription",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 31, 22, 53, 24, 393, DateTimeKind.Local).AddTicks(6055),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 31, 23, 58, 36, 975, DateTimeKind.Local).AddTicks(4709));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "TrainingCourse",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 31, 22, 53, 24, 393, DateTimeKind.Local).AddTicks(4015),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 31, 23, 58, 36, 975, DateTimeKind.Local).AddTicks(3722));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "Subscription",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 31, 22, 53, 24, 393, DateTimeKind.Local).AddTicks(2271),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 31, 23, 58, 36, 975, DateTimeKind.Local).AddTicks(2724));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "Person",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 31, 22, 53, 24, 392, DateTimeKind.Local).AddTicks(7832),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 31, 23, 58, 36, 975, DateTimeKind.Local).AddTicks(444));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "Department",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 31, 22, 53, 24, 392, DateTimeKind.Local).AddTicks(1824),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 31, 23, 58, 36, 974, DateTimeKind.Local).AddTicks(7729));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "CoachTrainingCourse",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 31, 22, 53, 24, 392, DateTimeKind.Local).AddTicks(302),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 31, 23, 58, 36, 974, DateTimeKind.Local).AddTicks(6937));

            migrationBuilder.AddCheckConstraint(
                name: "CH_Person_PassWord",
                table: "Person",
                sql: "PassWord LIKE '[1-9]'");
        }
    }
}
