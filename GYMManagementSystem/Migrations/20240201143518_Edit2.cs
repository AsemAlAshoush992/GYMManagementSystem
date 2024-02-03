using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GYMManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class Edit2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "TrainingCourseSubscription",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 1, 17, 35, 18, 501, DateTimeKind.Local).AddTicks(199),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 31, 23, 58, 36, 975, DateTimeKind.Local).AddTicks(4709));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "TrainingCourse",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 1, 17, 35, 18, 500, DateTimeKind.Local).AddTicks(8733),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 31, 23, 58, 36, 975, DateTimeKind.Local).AddTicks(3722));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "Subscription",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 1, 17, 35, 18, 500, DateTimeKind.Local).AddTicks(7419),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 31, 23, 58, 36, 975, DateTimeKind.Local).AddTicks(2724));

            migrationBuilder.AlterColumn<byte>(
                name: "Weight",
                table: "Person",
                type: "tinyint unsigned",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Person",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<string>(
                name: "Specialization",
                table: "Person",
                type: "varchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Person",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<byte>(
                name: "Height",
                table: "Person",
                type: "tinyint unsigned",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "HealthStatus",
                table: "Person",
                type: "varchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValue: "Uninfected",
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20,
                oldDefaultValue: "Uninfected");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Person",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "Person",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 1, 17, 35, 18, 500, DateTimeKind.Local).AddTicks(3893),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 31, 23, 58, 36, 975, DateTimeKind.Local).AddTicks(444));

            migrationBuilder.AlterColumn<string>(
                name: "Certifications",
                table: "Person",
                type: "varchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "Department",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 1, 17, 35, 18, 499, DateTimeKind.Local).AddTicks(9391),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 31, 23, 58, 36, 974, DateTimeKind.Local).AddTicks(7729));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "CoachTrainingCourse",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 1, 17, 35, 18, 499, DateTimeKind.Local).AddTicks(8487),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 31, 23, 58, 36, 974, DateTimeKind.Local).AddTicks(6937));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "TrainingCourseSubscription",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 31, 23, 58, 36, 975, DateTimeKind.Local).AddTicks(4709),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 2, 1, 17, 35, 18, 501, DateTimeKind.Local).AddTicks(199));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "TrainingCourse",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 31, 23, 58, 36, 975, DateTimeKind.Local).AddTicks(3722),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 2, 1, 17, 35, 18, 500, DateTimeKind.Local).AddTicks(8733));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "Subscription",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 31, 23, 58, 36, 975, DateTimeKind.Local).AddTicks(2724),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 2, 1, 17, 35, 18, 500, DateTimeKind.Local).AddTicks(7419));

            migrationBuilder.AlterColumn<int>(
                name: "Weight",
                table: "Person",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(byte),
                oldType: "tinyint unsigned",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Person",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Specialization",
                table: "Person",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Person",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Height",
                table: "Person",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(byte),
                oldType: "tinyint unsigned",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HealthStatus",
                table: "Person",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "Uninfected",
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValue: "Uninfected");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Person",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "Person",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 31, 23, 58, 36, 975, DateTimeKind.Local).AddTicks(444),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 2, 1, 17, 35, 18, 500, DateTimeKind.Local).AddTicks(3893));

            migrationBuilder.AlterColumn<string>(
                name: "Certifications",
                table: "Person",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "Department",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 31, 23, 58, 36, 974, DateTimeKind.Local).AddTicks(7729),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 2, 1, 17, 35, 18, 499, DateTimeKind.Local).AddTicks(9391));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "CoachTrainingCourse",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 31, 23, 58, 36, 974, DateTimeKind.Local).AddTicks(6937),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 2, 1, 17, 35, 18, 499, DateTimeKind.Local).AddTicks(8487));
        }
    }
}
