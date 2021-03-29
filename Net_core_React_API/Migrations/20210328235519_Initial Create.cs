﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Net_core_React_API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DCandidates",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fullName = table.Column<string>(type: "nVarchar(100)", nullable: true),
                    mobile = table.Column<string>(type: "nVarchar(100)", nullable: true),
                    email = table.Column<string>(type: "nVarchar(100)", nullable: true),
                    age = table.Column<int>(type: "int", nullable: false),
                    bloodGroup = table.Column<string>(type: "nVarchar(5)", nullable: true),
                    address = table.Column<string>(type: "nVarchar(500)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DCandidates", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DCandidates");
        }
    }
}
