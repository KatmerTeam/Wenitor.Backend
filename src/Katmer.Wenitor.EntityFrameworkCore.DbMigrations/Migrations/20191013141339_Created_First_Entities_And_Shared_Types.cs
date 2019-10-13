using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Katmer.Wenitor.Migrations
{
    public partial class Created_First_Entities_And_Shared_Types : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppScheduleChecks",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExtraProperties = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    ScheduleType = table.Column<int>(nullable: false),
                    Duration = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppScheduleChecks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppTargetSources",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExtraProperties = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Title = table.Column<string>(maxLength: 256, nullable: false),
                    WebURL = table.Column<string>(maxLength: 512, nullable: false),
                    ScheduleCheckId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppTargetSources", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppTargetSources_AppScheduleChecks_ScheduleCheckId",
                        column: x => x.ScheduleCheckId,
                        principalTable: "AppScheduleChecks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AppAlerts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExtraProperties = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    AlertType = table.Column<int>(nullable: false),
                    Detail1 = table.Column<string>(maxLength: 512, nullable: false),
                    Detail2 = table.Column<string>(nullable: true),
                    Detail3 = table.Column<string>(nullable: true),
                    TargetSourceId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAlerts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppAlerts_AppTargetSources_TargetSourceId",
                        column: x => x.TargetSourceId,
                        principalTable: "AppTargetSources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AppTargetSelectors",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExtraProperties = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    SelectorType = table.Column<int>(nullable: false),
                    ExpressionString = table.Column<string>(maxLength: 512, nullable: false),
                    TargetSourceId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppTargetSelectors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppTargetSelectors_AppTargetSources_TargetSourceId",
                        column: x => x.TargetSourceId,
                        principalTable: "AppTargetSources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppAlerts_TargetSourceId",
                table: "AppAlerts",
                column: "TargetSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_AppTargetSelectors_TargetSourceId",
                table: "AppTargetSelectors",
                column: "TargetSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_AppTargetSources_ScheduleCheckId",
                table: "AppTargetSources",
                column: "ScheduleCheckId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppAlerts");

            migrationBuilder.DropTable(
                name: "AppTargetSelectors");

            migrationBuilder.DropTable(
                name: "AppTargetSources");

            migrationBuilder.DropTable(
                name: "AppScheduleChecks");
        }
    }
}
