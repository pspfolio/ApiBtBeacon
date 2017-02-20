using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BTBeaconAPI.Data.Migrations
{
    public partial class nullableDateTimeToRemovedDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beacon_Message_MessageId",
                table: "Beacon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Message",
                table: "Message");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Beacon",
                table: "Beacon");

            migrationBuilder.RenameTable(
                name: "Message",
                newName: "Messages");

            migrationBuilder.RenameTable(
                name: "Beacon",
                newName: "Beacons");

            migrationBuilder.RenameIndex(
                name: "IX_Beacon_MessageId",
                table: "Beacons",
                newName: "IX_Beacons_MessageId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RemovedDate",
                table: "Beacons",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Messages",
                table: "Messages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Beacons",
                table: "Beacons",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Beacons_Messages_MessageId",
                table: "Beacons",
                column: "MessageId",
                principalTable: "Messages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beacons_Messages_MessageId",
                table: "Beacons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Messages",
                table: "Messages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Beacons",
                table: "Beacons");

            migrationBuilder.RenameTable(
                name: "Messages",
                newName: "Message");

            migrationBuilder.RenameTable(
                name: "Beacons",
                newName: "Beacon");

            migrationBuilder.RenameIndex(
                name: "IX_Beacons_MessageId",
                table: "Beacon",
                newName: "IX_Beacon_MessageId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RemovedDate",
                table: "Beacon",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Message",
                table: "Message",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Beacon",
                table: "Beacon",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Beacon_Message_MessageId",
                table: "Beacon",
                column: "MessageId",
                principalTable: "Message",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
