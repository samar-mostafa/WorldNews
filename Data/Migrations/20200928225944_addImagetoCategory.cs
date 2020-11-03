﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace WorldNews.Data.Migrations
{
    public partial class addImagetoCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CatImg",
                table: "Categories",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CatImg",
                table: "Categories");
        }
    }
}
