﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Edura.Repository.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isHome",
                table: "Products",
                newName: "IsHome");

            migrationBuilder.RenameColumn(
                name: "isFeatured",
                table: "Products",
                newName: "IsFeatured");

            migrationBuilder.RenameColumn(
                name: "isAppreoved",
                table: "Products",
                newName: "IsAppreoved");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdded",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HtmlContent",
                table: "Products",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Attributes",
                columns: table => new
                {
                    ProductAttributeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Attribute = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attributes", x => x.ProductAttributeId);
                    table.ForeignKey(
                        name: "FK_Attributes_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ImageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageName = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ImageId);
                    table.ForeignKey(
                        name: "FK_Images_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attributes_ProductId",
                table: "Attributes",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_ProductId",
                table: "Images",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attributes");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "HtmlContent",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "IsHome",
                table: "Products",
                newName: "isHome");

            migrationBuilder.RenameColumn(
                name: "IsFeatured",
                table: "Products",
                newName: "isFeatured");

            migrationBuilder.RenameColumn(
                name: "IsAppreoved",
                table: "Products",
                newName: "isAppreoved");
        }
    }
}
