﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JwtWithdatabase.Migrations
{
    public partial class initialsghn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_user",
                table: "user");

            migrationBuilder.RenameTable(
                name: "user",
                newName: "users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "user");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user",
                table: "user",
                column: "Id");
        }
    }
}
