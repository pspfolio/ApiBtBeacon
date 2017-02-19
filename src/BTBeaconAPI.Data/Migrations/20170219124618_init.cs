using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BTBeaconAPI.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Beacons",
                table: "Beacons");

            migrationBuilder.RenameTable(
                name: "Beacons",
                newName: "Beacon");

            migrationBuilder.AddColumn<int>(
                name: "MessageId",
                table: "Beacon",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Beacon",
                table: "Beacon",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Content = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Beacon_MessageId",
                table: "Beacon",
                column: "MessageId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Beacon_Message_MessageId",
                table: "Beacon",
                column: "MessageId",
                principalTable: "Message",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beacon_Message_MessageId",
                table: "Beacon");

            migrationBuilder.DropTable(
                name: "Message");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Beacon",
                table: "Beacon");

            migrationBuilder.DropIndex(
                name: "IX_Beacon_MessageId",
                table: "Beacon");

            migrationBuilder.DropColumn(
                name: "MessageId",
                table: "Beacon");

            migrationBuilder.RenameTable(
                name: "Beacon",
                newName: "Beacons");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Beacons",
                table: "Beacons",
                column: "Id");
        }
    }
}
