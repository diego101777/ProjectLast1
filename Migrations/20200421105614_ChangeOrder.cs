using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Site.Models;

namespace Site.Migrations
{
    public partial class ChangeOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
              name: "FK_Orders_Readers_ReaderId",
              table: "Orders",
              schema: null
              );

            migrationBuilder.DropIndex(
              name: "IX_Orders_ReaderId",
              table: "Orders",
              schema: null);

            migrationBuilder.AddColumn<string>(
     name: "FIO",
     table: "Orders",
     nullable: false);

            migrationBuilder.AddColumn<string>(
     name: "Email",
     table: "Orders",
     nullable: false);

            migrationBuilder.DropColumn(
    name: "ReaderId",
    table: "Orders");

          

          


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
     name: "FIO",
     table: "Orders");
        }
    }
}
