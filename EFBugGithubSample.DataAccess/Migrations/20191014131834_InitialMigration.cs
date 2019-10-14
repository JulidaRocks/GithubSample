using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFBugGithubSample.DataAccess.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(nullable: true),
                    ModifiedById = table.Column<Guid>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Level",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(nullable: true),
                    ModifiedById = table.Column<Guid>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    Rank = table.Column<int>(nullable: false),
                    RequiredPoints = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Level", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Level_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Stat",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(nullable: true),
                    ModifiedById = table.Column<Guid>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PointsPerValue = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stat_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Badge",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(nullable: true),
                    ModifiedById = table.Column<Guid>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Hint = table.Column<string>(nullable: true),
                    RequiredValue = table.Column<float>(nullable: false),
                    StatId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Badge", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Badge_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Badge_Stat_StatId",
                        column: x => x.StatId,
                        principalTable: "Stat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StatEntry",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(nullable: true),
                    ModifiedById = table.Column<Guid>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    StatId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    Value = table.Column<float>(nullable: false),
                    QueryDate = table.Column<DateTime>(nullable: false),
                    ReferenceKey = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatEntry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StatEntry_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StatEntry_Stat_StatId",
                        column: x => x.StatId,
                        principalTable: "Stat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StatEntry_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAdvancement",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    AdvancementType = table.Column<int>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    BadgeId = table.Column<Guid>(nullable: true),
                    LevelId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAdvancement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAdvancement_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAdvancement_Badge_BadgeId",
                        column: x => x.BadgeId,
                        principalTable: "Badge",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAdvancement_Level_LevelId",
                        column: x => x.LevelId,
                        principalTable: "Level",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Level",
                columns: new[] { "Id", "Deleted", "ModifiedAt", "ModifiedById", "Rank", "RequiredPoints" },
                values: new object[] { new Guid("94ad7946-3acc-4b54-80d6-954fff8802a4"), false, null, null, 1, 0f });

            migrationBuilder.InsertData(
                table: "Stat",
                columns: new[] { "Id", "Deleted", "ModifiedAt", "ModifiedById", "Name", "PointsPerValue" },
                values: new object[] { new Guid("44e93117-dbad-47b2-bc8c-e672ea1fb5be"), false, null, null, "Name", 1f });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Deleted", "Email", "ModifiedAt", "ModifiedById", "Name" },
                values: new object[] { new Guid("1af91c5c-d954-4830-9c21-2ef87b0f133b"), false, "test@test.com", null, null, "Test User" });

            migrationBuilder.InsertData(
                table: "Badge",
                columns: new[] { "Id", "Deleted", "Hint", "ModifiedAt", "ModifiedById", "Name", "RequiredValue", "StatId" },
                values: new object[] { new Guid("4c8ba004-21fa-4533-803e-096a80022ce9"), false, "Hint", null, null, "Name", 1f, new Guid("44e93117-dbad-47b2-bc8c-e672ea1fb5be") });

            migrationBuilder.InsertData(
                table: "UserAdvancement",
                columns: new[] { "Id", "AdvancementType", "Date", "Discriminator", "UserId", "LevelId" },
                values: new object[] { new Guid("94b1563d-6d42-4955-a822-f54439932719"), 1, new DateTime(2019, 10, 14, 0, 0, 0, 0, DateTimeKind.Local), "UserLevelAdvancement", new Guid("1af91c5c-d954-4830-9c21-2ef87b0f133b"), new Guid("94ad7946-3acc-4b54-80d6-954fff8802a4") });

            migrationBuilder.CreateIndex(
                name: "IX_Badge_ModifiedById",
                table: "Badge",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Badge_StatId",
                table: "Badge",
                column: "StatId");

            migrationBuilder.CreateIndex(
                name: "IX_Level_ModifiedById",
                table: "Level",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Stat_ModifiedById",
                table: "Stat",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_StatEntry_ModifiedById",
                table: "StatEntry",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_StatEntry_QueryDate",
                table: "StatEntry",
                column: "QueryDate");

            migrationBuilder.CreateIndex(
                name: "IX_StatEntry_StatId",
                table: "StatEntry",
                column: "StatId");

            migrationBuilder.CreateIndex(
                name: "IX_StatEntry_UserId",
                table: "StatEntry",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Email",
                table: "User",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_User_ModifiedById",
                table: "User",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_UserAdvancement_UserId",
                table: "UserAdvancement",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAdvancement_BadgeId",
                table: "UserAdvancement",
                column: "BadgeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAdvancement_LevelId",
                table: "UserAdvancement",
                column: "LevelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StatEntry");

            migrationBuilder.DropTable(
                name: "UserAdvancement");

            migrationBuilder.DropTable(
                name: "Badge");

            migrationBuilder.DropTable(
                name: "Level");

            migrationBuilder.DropTable(
                name: "Stat");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
