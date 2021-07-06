using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class MyMigratio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "gg_user_info",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    role_username = table.Column<string>(maxLength: 100, nullable: false),
                    role_password = table.Column<string>(maxLength: 100, nullable: false),
                    api_key = table.Column<string>(maxLength: 100, nullable: false),
                    secret_key = table.Column<string>(maxLength: 100, nullable: false),
                    user_name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gg_user_info", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gg_user_info");
        }
    }
}
