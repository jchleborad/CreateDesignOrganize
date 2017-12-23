using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CreateDesignOrganize.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dots",
                table: "Template");

            migrationBuilder.DropColumn(
                name: "Lines",
                table: "Template");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Template");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Template");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Template");

            migrationBuilder.DropColumn(
                name: "Day",
                table: "Planner");

            migrationBuilder.DropColumn(
                name: "Month",
                table: "Planner");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Planner");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Planner");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Planner");

            migrationBuilder.DropColumn(
                name: "Week",
                table: "Planner");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Planner");

            migrationBuilder.DropColumn(
                name: "IsBlank",
                table: "Lifestyle");

            migrationBuilder.DropColumn(
                name: "IsChart",
                table: "Lifestyle");

            migrationBuilder.DropColumn(
                name: "IsToDoList",
                table: "Lifestyle");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Lifestyle");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Lifestyle");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Lifestyle");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Exercise");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Exercise");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Exercise");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Template",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Interval",
                table: "Planner",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "List",
                table: "Lifestyle",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Template");

            migrationBuilder.DropColumn(
                name: "Interval",
                table: "Planner");

            migrationBuilder.DropColumn(
                name: "List",
                table: "Lifestyle");

            migrationBuilder.AddColumn<string>(
                name: "Dots",
                table: "Template",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lines",
                table: "Template",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "Template",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Template",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Template",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Day",
                table: "Planner",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Month",
                table: "Planner",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "Planner",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Planner",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Planner",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Week",
                table: "Planner",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Year",
                table: "Planner",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsBlank",
                table: "Lifestyle",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsChart",
                table: "Lifestyle",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsToDoList",
                table: "Lifestyle",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "Lifestyle",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Lifestyle",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Lifestyle",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "Exercise",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Exercise",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Exercise",
                nullable: true);
        }
    }
}
