﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingApp.API.Migrations
{
    public partial class AddedIntroandLookingForColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Introduction",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LookingFor",
                table: "Users",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Introduction",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LookingFor",
                table: "Users");
        }
    }
}
