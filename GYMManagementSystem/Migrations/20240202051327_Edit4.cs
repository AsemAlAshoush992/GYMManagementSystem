using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GYMManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class Edit4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_Department_DepartmentID",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "SubscriptionStatus",
                table: "Subscription");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "TrainingCourseSubscription",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 2, 8, 13, 27, 628, DateTimeKind.Local).AddTicks(9663),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 2, 1, 17, 42, 47, 833, DateTimeKind.Local).AddTicks(5531));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "TrainingCourse",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 2, 8, 13, 27, 628, DateTimeKind.Local).AddTicks(8117),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 2, 1, 17, 42, 47, 833, DateTimeKind.Local).AddTicks(4331));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "Subscription",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 2, 8, 13, 27, 628, DateTimeKind.Local).AddTicks(6522),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 2, 1, 17, 42, 47, 833, DateTimeKind.Local).AddTicks(3172));

            migrationBuilder.AlterColumn<float>(
                name: "Salary",
                table: "Person",
                type: "float",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "float",
                oldDefaultValue: 260f);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Image",
                table: "Person",
                type: "longblob",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentID",
                table: "Person",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "Person",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 2, 8, 13, 27, 628, DateTimeKind.Local).AddTicks(4074),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 2, 1, 17, 42, 47, 833, DateTimeKind.Local).AddTicks(512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "Department",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 2, 8, 13, 27, 627, DateTimeKind.Local).AddTicks(9832),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 2, 1, 17, 42, 47, 832, DateTimeKind.Local).AddTicks(6986));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "CoachTrainingCourse",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 2, 8, 13, 27, 627, DateTimeKind.Local).AddTicks(8867),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 2, 1, 17, 42, 47, 832, DateTimeKind.Local).AddTicks(6075));

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Department_DepartmentID",
                table: "Person",
                column: "DepartmentID",
                principalTable: "Department",
                principalColumn: "DepartmentID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_Department_DepartmentID",
                table: "Person");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "TrainingCourseSubscription",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 1, 17, 42, 47, 833, DateTimeKind.Local).AddTicks(5531),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 2, 2, 8, 13, 27, 628, DateTimeKind.Local).AddTicks(9663));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "TrainingCourse",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 1, 17, 42, 47, 833, DateTimeKind.Local).AddTicks(4331),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 2, 2, 8, 13, 27, 628, DateTimeKind.Local).AddTicks(8117));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "Subscription",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 1, 17, 42, 47, 833, DateTimeKind.Local).AddTicks(3172),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 2, 2, 8, 13, 27, 628, DateTimeKind.Local).AddTicks(6522));

            migrationBuilder.AddColumn<int>(
                name: "SubscriptionStatus",
                table: "Subscription",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<float>(
                name: "Salary",
                table: "Person",
                type: "float",
                nullable: false,
                defaultValue: 260f,
                oldClrType: typeof(float),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Person",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "longblob",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentID",
                table: "Person",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "Person",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 1, 17, 42, 47, 833, DateTimeKind.Local).AddTicks(512),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 2, 2, 8, 13, 27, 628, DateTimeKind.Local).AddTicks(4074));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "Department",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 1, 17, 42, 47, 832, DateTimeKind.Local).AddTicks(6986),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 2, 2, 8, 13, 27, 627, DateTimeKind.Local).AddTicks(9832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "CoachTrainingCourse",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 1, 17, 42, 47, 832, DateTimeKind.Local).AddTicks(6075),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 2, 2, 8, 13, 27, 627, DateTimeKind.Local).AddTicks(8867));

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Department_DepartmentID",
                table: "Person",
                column: "DepartmentID",
                principalTable: "Department",
                principalColumn: "DepartmentID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
