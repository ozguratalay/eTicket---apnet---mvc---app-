using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTicket.Migrations
{
    public partial class ProducerName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProfileName",
                table: "Producers",
                newName: "FullName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Producers",
                newName: "ProfileName");
        }
    }
}
