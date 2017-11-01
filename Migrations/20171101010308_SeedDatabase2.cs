using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace rafi.Migrations
{
    public partial class SeedDatabase2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert Into Makes(Name) Values 'Buick'");
                 migrationBuilder.Sql("Insert Into Makes(Name) Values 'Ferrari'");
                 migrationBuilder.Sql("Insert Into Models(Name, MakeID) Values ('Lacrosse', 1)");
                 migrationBuilder.Sql("Insert Into Models(Name, MakeId) Values ('s65xp', 2)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
