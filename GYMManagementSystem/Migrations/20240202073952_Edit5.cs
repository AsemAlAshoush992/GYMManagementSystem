using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GYMManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class Edit5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "TrainingCourseSubscription",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 2, 10, 39, 52, 25, DateTimeKind.Local).AddTicks(4433),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 2, 2, 8, 13, 27, 628, DateTimeKind.Local).AddTicks(9663));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "TrainingCourse",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 2, 10, 39, 52, 25, DateTimeKind.Local).AddTicks(3408),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 2, 2, 8, 13, 27, 628, DateTimeKind.Local).AddTicks(8117));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "Subscription",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 2, 10, 39, 52, 25, DateTimeKind.Local).AddTicks(2033),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 2, 2, 8, 13, 27, 628, DateTimeKind.Local).AddTicks(6522));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "Person",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 2, 10, 39, 52, 24, DateTimeKind.Local).AddTicks(9580),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 2, 2, 8, 13, 27, 628, DateTimeKind.Local).AddTicks(4074));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "Department",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 2, 10, 39, 52, 24, DateTimeKind.Local).AddTicks(7063),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 2, 2, 8, 13, 27, 627, DateTimeKind.Local).AddTicks(9832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "CoachTrainingCourse",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 2, 10, 39, 52, 24, DateTimeKind.Local).AddTicks(6267),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 2, 2, 8, 13, 27, 627, DateTimeKind.Local).AddTicks(8867));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "TrainingCourseSubscription",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 2, 8, 13, 27, 628, DateTimeKind.Local).AddTicks(9663),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 2, 2, 10, 39, 52, 25, DateTimeKind.Local).AddTicks(4433));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "TrainingCourse",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 2, 8, 13, 27, 628, DateTimeKind.Local).AddTicks(8117),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 2, 2, 10, 39, 52, 25, DateTimeKind.Local).AddTicks(3408));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "Subscription",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 2, 8, 13, 27, 628, DateTimeKind.Local).AddTicks(6522),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 2, 2, 10, 39, 52, 25, DateTimeKind.Local).AddTicks(2033));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "Person",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 2, 8, 13, 27, 628, DateTimeKind.Local).AddTicks(4074),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 2, 2, 10, 39, 52, 24, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "Department",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 2, 8, 13, 27, 627, DateTimeKind.Local).AddTicks(9832),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 2, 2, 10, 39, 52, 24, DateTimeKind.Local).AddTicks(7063));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "CoachTrainingCourse",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 2, 8, 13, 27, 627, DateTimeKind.Local).AddTicks(8867),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 2, 2, 10, 39, 52, 24, DateTimeKind.Local).AddTicks(6267));
        }
    }
}
