using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Admin_Tool.Migrations
{
    public partial class AddedAppUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "AppUser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Login = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: false),
                    FullName = table.Column<string>(nullable: true),
                    Superuser = table.Column<bool>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    Telephone = table.Column<string>(nullable: true),
                    Token = table.Column<string>(nullable: true),
                    IsAdmin = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUser", x => x.Id);
                });

                migrationBuilder.Sql("INSERT INTO AppUser (Password,Email,IsAdmin) VALUES ('$D4bz}V/', 'sales@ekobit.hr', 'TRUE');");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUser");


        }
    }
}
