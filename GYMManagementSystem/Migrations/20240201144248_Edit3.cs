using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GYMManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class Edit3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_Subscription_SubscriptionID",
                table: "Person");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "TrainingCourseSubscription",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 1, 17, 42, 47, 833, DateTimeKind.Local).AddTicks(5531),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 2, 1, 17, 35, 18, 501, DateTimeKind.Local).AddTicks(199));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "TrainingCourse",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 1, 17, 42, 47, 833, DateTimeKind.Local).AddTicks(4331),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 2, 1, 17, 35, 18, 500, DateTimeKind.Local).AddTicks(8733));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "Subscription",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 1, 17, 42, 47, 833, DateTimeKind.Local).AddTicks(3172),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 2, 1, 17, 35, 18, 500, DateTimeKind.Local).AddTicks(7419));

            migrationBuilder.AlterColumn<int>(
                name: "SubscriptionID",
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
                defaultValue: new DateTime(2024, 2, 1, 17, 42, 47, 833, DateTimeKind.Local).AddTicks(512),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 2, 1, 17, 35, 18, 500, DateTimeKind.Local).AddTicks(3893));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "Department",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 1, 17, 42, 47, 832, DateTimeKind.Local).AddTicks(6986),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 2, 1, 17, 35, 18, 499, DateTimeKind.Local).AddTicks(9391));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "CoachTrainingCourse",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 1, 17, 42, 47, 832, DateTimeKind.Local).AddTicks(6075),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 2, 1, 17, 35, 18, 499, DateTimeKind.Local).AddTicks(8487));

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Subscription_SubscriptionID",
                table: "Person",
                column: "SubscriptionID",
                principalTable: "Subscription",
                principalColumn: "SubscriptionID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_Subscription_SubscriptionID",
                table: "Person");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "TrainingCourseSubscription",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 1, 17, 35, 18, 501, DateTimeKind.Local).AddTicks(199),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 2, 1, 17, 42, 47, 833, DateTimeKind.Local).AddTicks(5531));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "TrainingCourse",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 1, 17, 35, 18, 500, DateTimeKind.Local).AddTicks(8733),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 2, 1, 17, 42, 47, 833, DateTimeKind.Local).AddTicks(4331));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "Subscription",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 1, 17, 35, 18, 500, DateTimeKind.Local).AddTicks(7419),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 2, 1, 17, 42, 47, 833, DateTimeKind.Local).AddTicks(3172));

            migrationBuilder.AlterColumn<int>(
                name: "SubscriptionID",
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
                defaultValue: new DateTime(2024, 2, 1, 17, 35, 18, 500, DateTimeKind.Local).AddTicks(3893),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 2, 1, 17, 42, 47, 833, DateTimeKind.Local).AddTicks(512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "Department",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 1, 17, 35, 18, 499, DateTimeKind.Local).AddTicks(9391),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 2, 1, 17, 42, 47, 832, DateTimeKind.Local).AddTicks(6986));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateionDate",
                table: "CoachTrainingCourse",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 1, 17, 35, 18, 499, DateTimeKind.Local).AddTicks(8487),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 2, 1, 17, 42, 47, 832, DateTimeKind.Local).AddTicks(6075));

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Subscription_SubscriptionID",
                table: "Person",
                column: "SubscriptionID",
                principalTable: "Subscription",
                principalColumn: "SubscriptionID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
