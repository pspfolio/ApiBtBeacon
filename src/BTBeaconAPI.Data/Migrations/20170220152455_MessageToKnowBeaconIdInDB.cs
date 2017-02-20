using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BTBeaconAPI.Data.Migrations
{
    public partial class MessageToKnowBeaconIdInDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beacons_Messages_MessageId",
                table: "Beacons");

            migrationBuilder.DropIndex(
                name: "IX_Beacons_MessageId",
                table: "Beacons");

            migrationBuilder.DropColumn(
                name: "MessageId",
                table: "Beacons");

            migrationBuilder.AddColumn<int>(
                name: "BeaconId",
                table: "Messages",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Beacons_BeaconId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_BeaconId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "BeaconId",
                table: "Messages");

            migrationBuilder.AddColumn<int>(
                name: "MessageId",
                table: "Beacons",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Beacons_MessageId",
                table: "Beacons",
                column: "MessageId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Beacons_Messages_MessageId",
                table: "Beacons",
                column: "MessageId",
                principalTable: "Messages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
