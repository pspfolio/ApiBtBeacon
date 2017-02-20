using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BTBeaconAPI.Data.Migrations
{
    public partial class GuidToPrimaryKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Beacons_BeaconId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_BeaconId",
                table: "Messages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Beacons",
                table: "Beacons");

            migrationBuilder.DropColumn(
                name: "BeaconId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Beacons");

            migrationBuilder.AddColumn<Guid>(
                name: "BeaconGuid",
                table: "Messages",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Beacons",
                table: "Beacons",
                column: "Guid");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_BeaconGuid",
                table: "Messages",
                column: "BeaconGuid",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Beacons_BeaconGuid",
                table: "Messages",
                column: "BeaconGuid",
                principalTable: "Beacons",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Beacons_BeaconGuid",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_BeaconGuid",
                table: "Messages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Beacons",
                table: "Beacons");

            migrationBuilder.DropColumn(
                name: "BeaconGuid",
                table: "Messages");

            migrationBuilder.AddColumn<int>(
                name: "BeaconId",
                table: "Messages",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Beacons",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Beacons",
                table: "Beacons",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_BeaconId",
                table: "Messages",
                column: "BeaconId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Beacons_BeaconId",
                table: "Messages",
                column: "BeaconId",
                principalTable: "Beacons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
