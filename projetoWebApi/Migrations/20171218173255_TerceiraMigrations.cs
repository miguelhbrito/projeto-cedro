using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace projetoWebApi.Migrations
{
    public partial class TerceiraMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "Pratos");

            migrationBuilder.AddColumn<int>(
                name: "RestauranteId",
                table: "Pratos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pratos_RestauranteId",
                table: "Pratos",
                column: "RestauranteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pratos_Restaurantes_RestauranteId",
                table: "Pratos",
                column: "RestauranteId",
                principalTable: "Restaurantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pratos_Restaurantes_RestauranteId",
                table: "Pratos");

            migrationBuilder.DropIndex(
                name: "IX_Pratos_RestauranteId",
                table: "Pratos");

            migrationBuilder.DropColumn(
                name: "RestauranteId",
                table: "Pratos");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Pratos",
                nullable: false,
                defaultValue: 0);
        }
    }
}
