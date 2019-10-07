﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APIEducagame.Migrations
{
    public partial class Ponto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ponto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    campo1 = table.Column<int>(nullable: false),
                    campo2 = table.Column<int>(nullable: false),
                    campo3 = table.Column<int>(nullable: false),
                    campo4 = table.Column<int>(nullable: false),
                    campo5 = table.Column<int>(nullable: false),
                    campo6 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ponto", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ponto");
        }
    }
}
