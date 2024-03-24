using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _3pMetricsTask.Repositories.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Catalogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CatalogIdHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatorId = table.Column<int>(type: "int", nullable: false),
                    CatalogName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmissionMappings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmissionSourceId = table.Column<int>(type: "int", nullable: false),
                    EmissionPointId = table.Column<int>(type: "int", nullable: false),
                    SourcesUnitId = table.Column<int>(type: "int", nullable: false),
                    EmissionFactorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmissionMappings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmissionSources",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SourceIdHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatorId = table.Column<int>(type: "int", nullable: false),
                    SourceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourceIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmissionSources", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmissionSourcesUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitIdHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatorId = table.Column<int>(type: "int", nullable: false),
                    UnitTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitSymbol = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmissionSourcesUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmissionFactors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmissionIdHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CatalogId = table.Column<int>(type: "int", nullable: false),
                    CreatorId = table.Column<int>(type: "int", nullable: false),
                    EmissionFactorTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmissionFactorValue = table.Column<double>(type: "float", nullable: false),
                    EffectiveStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EffectiveEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmissionFactors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmissionFactors_Catalogs_CatalogId",
                        column: x => x.CatalogId,
                        principalTable: "Catalogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmissionPoints",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PointIdHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmissionSourcesUnitId = table.Column<int>(type: "int", nullable: false),
                    CreatorId = table.Column<int>(type: "int", nullable: false),
                    PointName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PointDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PointIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmissionPoints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmissionPoints_EmissionSourcesUnits_EmissionSourcesUnitId",
                        column: x => x.EmissionSourcesUnitId,
                        principalTable: "EmissionSourcesUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Catalogs",
                columns: new[] { "Id", "CatalogIdHash", "CatalogName", "CreationDate", "CreatorId" },
                values: new object[,]
                {
                    { 1, "5c46ab9ac03397da3f2aa22445b460bf54d968a1cf8084e3e252ff2d209e8bf4", "3P EFDB", new DateTime(2024, 3, 23, 16, 15, 21, 991, DateTimeKind.Local).AddTicks(6927), 1 },
                    { 2, "38d5680b88846d2f2640fb561bfb07318039b80b480e298117334522e4c1a454", "Defra", new DateTime(2024, 3, 23, 16, 15, 21, 991, DateTimeKind.Local).AddTicks(6929), 1 }
                });

            migrationBuilder.InsertData(
                table: "EmissionMappings",
                columns: new[] { "Id", "EmissionFactorId", "EmissionPointId", "EmissionSourceId", "SourcesUnitId" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 4 },
                    { 2, 1, 3, 1, 1 },
                    { 3, 2, 2, 2, 2 },
                    { 4, 3, 4, 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "EmissionSources",
                columns: new[] { "Id", "CreationDate", "CreatorId", "SourceIcon", "SourceIdHash", "SourceName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 23, 16, 15, 21, 991, DateTimeKind.Local).AddTicks(7869), 1, "naturalgas.png", "81fe3ee86f53385ce50467730e7193b9ceac0d234e97356e754d5a25cc27d976", "Doğalgaz" },
                    { 2, new DateTime(2024, 3, 23, 16, 15, 21, 991, DateTimeKind.Local).AddTicks(7871), 1, "diesel.png", "6810ed4e69870ffdffab5c39f555eaa33bf1a02f4da074a220ed1d32c123599e", "Dizel" },
                    { 3, new DateTime(2024, 3, 23, 16, 15, 21, 991, DateTimeKind.Local).AddTicks(7872), 1, "petrol.png", "1fe5079c6104aa8e1b6f415a1c60c4239d44236f24604d413f9adc7d596f7c6d", "Benzin" }
                });

            migrationBuilder.InsertData(
                table: "EmissionSourcesUnits",
                columns: new[] { "Id", "CreationDate", "CreatorId", "UnitIdHash", "UnitSymbol", "UnitTitle" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 25, 16, 15, 21, 991, DateTimeKind.Local).AddTicks(8056), 1, "e6a874d555fefd3686b70114687a7f03ae4dc2c46d56509f59a223ef6c225f9a", 0, "Litre" },
                    { 2, new DateTime(2024, 3, 23, 16, 15, 21, 991, DateTimeKind.Local).AddTicks(8058), 1, "adba1db0a09fda86bf0ac887088a33f4042bd29c80132e7443c33e3098cf02de", 1, "Ton" },
                    { 3, new DateTime(2024, 3, 26, 16, 15, 21, 991, DateTimeKind.Local).AddTicks(8059), 1, "da8ea261cc933a43d3650d9cbfdf9af41c4c6fabf08e480ae0f7371fb70051b8", 0, "Litre" },
                    { 4, new DateTime(2024, 3, 24, 16, 15, 21, 991, DateTimeKind.Local).AddTicks(8060), 1, "58e822cfb67cb3edfd7ac6674867e6a0cf1210e6834051d34eddbfdac16271f4", 2, "m3" },
                    { 5, new DateTime(2024, 3, 24, 16, 15, 21, 991, DateTimeKind.Local).AddTicks(8061), 1, "d672643d8cae9ff7933f7fffac4b22048162022a04adaf1b6ae120eae2dac6ae", 3, "kwh" }
                });

            migrationBuilder.InsertData(
                table: "EmissionFactors",
                columns: new[] { "Id", "CatalogId", "CreationDate", "CreatorId", "EffectiveEndDate", "EffectiveStartDate", "EmissionFactorTitle", "EmissionFactorValue", "EmissionIdHash" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 3, 23, 16, 15, 21, 991, DateTimeKind.Local).AddTicks(7238), 1, new DateTime(2024, 3, 26, 16, 15, 21, 991, DateTimeKind.Local).AddTicks(7235), new DateTime(2024, 3, 23, 16, 15, 21, 991, DateTimeKind.Local).AddTicks(7234), "Doğalgaz NRM", 2.00054, "2f6e474a6b719109f4a92d67caa6d9d5b0e3b0fbdcdf70d0f621a693bf6dafff" },
                    { 2, 1, new DateTime(2024, 3, 23, 16, 15, 21, 991, DateTimeKind.Local).AddTicks(7241), 1, new DateTime(2024, 3, 28, 16, 15, 21, 991, DateTimeKind.Local).AddTicks(7241), new DateTime(2024, 3, 23, 16, 15, 21, 991, DateTimeKind.Local).AddTicks(7240), "Diesel Ton", 1.8E-05, "90835cced12fe2db8e2b28217c36224ce6426317b3795db708c0ee7e2a886d32" },
                    { 3, 1, new DateTime(2024, 3, 23, 16, 15, 21, 991, DateTimeKind.Local).AddTicks(7243), 1, new DateTime(2024, 3, 31, 16, 15, 21, 991, DateTimeKind.Local).AddTicks(7243), new DateTime(2024, 3, 23, 16, 15, 21, 991, DateTimeKind.Local).AddTicks(7242), "Doğalgaz Tren", 2.8E-05, "90835cced12fe2db8e2b28217c36224ce6426317b3795db708c0ee7e2a886d32" }
                });

            migrationBuilder.InsertData(
                table: "EmissionPoints",
                columns: new[] { "Id", "CreationDate", "CreatorId", "EmissionSourcesUnitId", "PointDescription", "PointIcon", "PointIdHash", "PointName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 24, 16, 15, 21, 991, DateTimeKind.Local).AddTicks(7651), 1, 1, "Kombilerde tüketilen enerji", "kombi.png", "c22cf6c32975aa7e8fd5b9c77de2e9083233743023abaa6f42a6ce65e712a29c", "Kombi" },
                    { 2, new DateTime(2024, 3, 26, 16, 15, 21, 991, DateTimeKind.Local).AddTicks(7654), 1, 2, "Binek araçlarda tüketilen yakıtlar", "car.png", "57a58df97aa1b8a380429c3402ceb34ccab2d7275380feb63f65a3af4c94e78e", "Binek Araç" },
                    { 3, new DateTime(2024, 3, 25, 16, 15, 21, 991, DateTimeKind.Local).AddTicks(7656), 1, 1, "Fabrikalarda kullanılan enerji", "industry.png", "25fafd96f2830e1b3a3c88a8f4234e120ee9b41b3b5824f175586a50894458fa", "Fabrika" },
                    { 4, new DateTime(2024, 3, 25, 16, 15, 21, 991, DateTimeKind.Local).AddTicks(7657), 1, 2, "Kamyonlarda tüketilen yakıt", "truck.png", "f3acbbdf3f3df94df27bc57f350016b7dd52ebd6dcd6b218caf9645302cbaeb0", "Kamyon" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmissionFactors_CatalogId",
                table: "EmissionFactors",
                column: "CatalogId");

            migrationBuilder.CreateIndex(
                name: "IX_EmissionPoints_EmissionSourcesUnitId",
                table: "EmissionPoints",
                column: "EmissionSourcesUnitId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmissionFactors");

            migrationBuilder.DropTable(
                name: "EmissionMappings");

            migrationBuilder.DropTable(
                name: "EmissionPoints");

            migrationBuilder.DropTable(
                name: "EmissionSources");

            migrationBuilder.DropTable(
                name: "Catalogs");

            migrationBuilder.DropTable(
                name: "EmissionSourcesUnits");
        }
    }
}
