using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _3pMetricsTask.Repositories.Migrations
{
    public partial class errors_fixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 3, 23, 18, 49, 7, 439, DateTimeKind.Local).AddTicks(5497));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 3, 23, 18, 49, 7, 439, DateTimeKind.Local).AddTicks(5499));

            migrationBuilder.UpdateData(
                table: "EmissionFactors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "EffectiveEndDate", "EffectiveStartDate" },
                values: new object[] { new DateTime(2024, 3, 23, 18, 49, 7, 439, DateTimeKind.Local).AddTicks(5837), new DateTime(2024, 3, 26, 18, 49, 7, 439, DateTimeKind.Local).AddTicks(5834), new DateTime(2024, 3, 23, 18, 49, 7, 439, DateTimeKind.Local).AddTicks(5834) });

            migrationBuilder.UpdateData(
                table: "EmissionFactors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "EffectiveEndDate", "EffectiveStartDate" },
                values: new object[] { new DateTime(2024, 3, 23, 18, 49, 7, 439, DateTimeKind.Local).AddTicks(5840), new DateTime(2024, 3, 28, 18, 49, 7, 439, DateTimeKind.Local).AddTicks(5839), new DateTime(2024, 3, 23, 18, 49, 7, 439, DateTimeKind.Local).AddTicks(5839) });

            migrationBuilder.UpdateData(
                table: "EmissionFactors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "EffectiveEndDate", "EffectiveStartDate" },
                values: new object[] { new DateTime(2024, 3, 23, 18, 49, 7, 439, DateTimeKind.Local).AddTicks(5842), new DateTime(2024, 3, 31, 18, 49, 7, 439, DateTimeKind.Local).AddTicks(5842), new DateTime(2024, 3, 23, 18, 49, 7, 439, DateTimeKind.Local).AddTicks(5841) });

            migrationBuilder.UpdateData(
                table: "EmissionPoints",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 3, 24, 18, 49, 7, 439, DateTimeKind.Local).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "EmissionPoints",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 3, 26, 18, 49, 7, 439, DateTimeKind.Local).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "EmissionPoints",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 3, 25, 18, 49, 7, 439, DateTimeKind.Local).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "EmissionPoints",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 3, 25, 18, 49, 7, 439, DateTimeKind.Local).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "EmissionSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 3, 23, 18, 49, 7, 439, DateTimeKind.Local).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "EmissionSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 3, 23, 18, 49, 7, 439, DateTimeKind.Local).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "EmissionSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 3, 23, 18, 49, 7, 439, DateTimeKind.Local).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "EmissionSourcesUnits",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 3, 25, 18, 49, 7, 439, DateTimeKind.Local).AddTicks(6725));

            migrationBuilder.UpdateData(
                table: "EmissionSourcesUnits",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 3, 23, 18, 49, 7, 439, DateTimeKind.Local).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "EmissionSourcesUnits",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 3, 26, 18, 49, 7, 439, DateTimeKind.Local).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "EmissionSourcesUnits",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 3, 24, 18, 49, 7, 439, DateTimeKind.Local).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "EmissionSourcesUnits",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2024, 3, 24, 18, 49, 7, 439, DateTimeKind.Local).AddTicks(6730));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 3, 23, 16, 15, 21, 991, DateTimeKind.Local).AddTicks(6927));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 3, 23, 16, 15, 21, 991, DateTimeKind.Local).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "EmissionFactors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "EffectiveEndDate", "EffectiveStartDate" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 15, 21, 991, DateTimeKind.Local).AddTicks(7238), new DateTime(2024, 3, 26, 16, 15, 21, 991, DateTimeKind.Local).AddTicks(7235), new DateTime(2024, 3, 23, 16, 15, 21, 991, DateTimeKind.Local).AddTicks(7234) });

            migrationBuilder.UpdateData(
                table: "EmissionFactors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "EffectiveEndDate", "EffectiveStartDate" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 15, 21, 991, DateTimeKind.Local).AddTicks(7241), new DateTime(2024, 3, 28, 16, 15, 21, 991, DateTimeKind.Local).AddTicks(7241), new DateTime(2024, 3, 23, 16, 15, 21, 991, DateTimeKind.Local).AddTicks(7240) });

            migrationBuilder.UpdateData(
                table: "EmissionFactors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "EffectiveEndDate", "EffectiveStartDate" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 15, 21, 991, DateTimeKind.Local).AddTicks(7243), new DateTime(2024, 3, 31, 16, 15, 21, 991, DateTimeKind.Local).AddTicks(7243), new DateTime(2024, 3, 23, 16, 15, 21, 991, DateTimeKind.Local).AddTicks(7242) });

            migrationBuilder.UpdateData(
                table: "EmissionPoints",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 3, 24, 16, 15, 21, 991, DateTimeKind.Local).AddTicks(7651));

            migrationBuilder.UpdateData(
                table: "EmissionPoints",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 3, 26, 16, 15, 21, 991, DateTimeKind.Local).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "EmissionPoints",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 3, 25, 16, 15, 21, 991, DateTimeKind.Local).AddTicks(7656));

            migrationBuilder.UpdateData(
                table: "EmissionPoints",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 3, 25, 16, 15, 21, 991, DateTimeKind.Local).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "EmissionSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 3, 23, 16, 15, 21, 991, DateTimeKind.Local).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "EmissionSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 3, 23, 16, 15, 21, 991, DateTimeKind.Local).AddTicks(7871));

            migrationBuilder.UpdateData(
                table: "EmissionSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 3, 23, 16, 15, 21, 991, DateTimeKind.Local).AddTicks(7872));

            migrationBuilder.UpdateData(
                table: "EmissionSourcesUnits",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 3, 25, 16, 15, 21, 991, DateTimeKind.Local).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "EmissionSourcesUnits",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 3, 23, 16, 15, 21, 991, DateTimeKind.Local).AddTicks(8058));

            migrationBuilder.UpdateData(
                table: "EmissionSourcesUnits",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 3, 26, 16, 15, 21, 991, DateTimeKind.Local).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "EmissionSourcesUnits",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 3, 24, 16, 15, 21, 991, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "EmissionSourcesUnits",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2024, 3, 24, 16, 15, 21, 991, DateTimeKind.Local).AddTicks(8061));
        }
    }
}
