using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Antertainment.DAL.Migrations
{
    public partial class SeedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
@"USE [Antertainment]
GO

INSERT INTO [dbo].[Roles] ([Id],[RoleName]) VALUES ('01FD5F33-5B52-4290-AB9B-17401EE1E511', 'admin')
INSERT INTO [dbo].[Roles] ([Id],[RoleName]) VALUES ('01FD5F33-5B52-4290-AB9B-17401EE1E512', 'user')
GO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DELETE FROM [dbo].[Roles]");
        }
    }
}
