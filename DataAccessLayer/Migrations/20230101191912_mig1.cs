using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "Workers",
                newName: "WorkerID");

            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "Communicates",
                newName: "ContactID");

            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "Comments",
                newName: "CommentID");

            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "Categories",
                newName: "CategoryID");

            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "Abouts",
                newName: "AboutID");

            migrationBuilder.AddColumn<string>(
                name: "WorkerAbout",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkerMail",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkerName",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkerPassword",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "WorkerStatus",
                table: "Workers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ContactDate",
                table: "Communicates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ContactEmail",
                table: "Communicates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactMessage",
                table: "Communicates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ContactStatus",
                table: "Communicates",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ContactSubject",
                table: "Communicates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactUserName",
                table: "Communicates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CommentContent",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CommentDate",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "CommentStatus",
                table: "Comments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "CommentTitle",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CommentUserName",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CategoryDescription",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CategoryName",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "CategoryStatus",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "AboutDetails1",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AboutDetails2",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AboutImage",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AboutMapLocation",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "AboutStatus",
                table: "Abouts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    BlogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogThumbnailImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogCreateDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.BlogID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropColumn(
                name: "WorkerAbout",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "WorkerMail",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "WorkerName",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "WorkerPassword",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "WorkerStatus",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "ContactDate",
                table: "Communicates");

            migrationBuilder.DropColumn(
                name: "ContactEmail",
                table: "Communicates");

            migrationBuilder.DropColumn(
                name: "ContactMessage",
                table: "Communicates");

            migrationBuilder.DropColumn(
                name: "ContactStatus",
                table: "Communicates");

            migrationBuilder.DropColumn(
                name: "ContactSubject",
                table: "Communicates");

            migrationBuilder.DropColumn(
                name: "ContactUserName",
                table: "Communicates");

            migrationBuilder.DropColumn(
                name: "CommentContent",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CommentDate",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CommentStatus",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CommentTitle",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CommentUserName",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CategoryDescription",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CategoryName",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CategoryStatus",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "AboutDetails1",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "AboutDetails2",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "AboutImage",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "AboutMapLocation",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "AboutStatus",
                table: "Abouts");

            migrationBuilder.RenameColumn(
                name: "WorkerID",
                table: "Workers",
                newName: "MyProperty");

            migrationBuilder.RenameColumn(
                name: "ContactID",
                table: "Communicates",
                newName: "MyProperty");

            migrationBuilder.RenameColumn(
                name: "CommentID",
                table: "Comments",
                newName: "MyProperty");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Categories",
                newName: "MyProperty");

            migrationBuilder.RenameColumn(
                name: "AboutID",
                table: "Abouts",
                newName: "MyProperty");

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    MyProperty = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.MyProperty);
                });
        }
    }
}
