using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoKolcsonzo.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder builder)
        {
            builder.Sql(
                "INSERT INTO Cars (make, type, year, fuel) VALUES " +
                "('Renault', 'Thalia', 2003, 'dízel')," +
                "('Opel', 'Corsa', 2006, 'Benzin');"
            );

            builder.Sql(
                "INSERT INTO Renters (Name, Address, IsRegular) VALUES " +
                "('Egri Patrik', '2131 Göd, Petőfi Sándor utca 48.', 1)," +
                "('Farkas Balázs', '1139 Budapest, Üteg utca 13.', 0);"
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
