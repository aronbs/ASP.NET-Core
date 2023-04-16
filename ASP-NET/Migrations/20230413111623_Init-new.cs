using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASP_NET.Migrations
{
    /// <inheritdoc />
    public partial class Initnew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "Name" },
                values: new object[,]
                {
                    { 1, "H22-FK1" },
                    { 2, "H22-FK2" },
                    { 3, "H22-FK3" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "SubjectId", "Title" },
                values: new object[,]
                {
                    { 1, "Forritun" },
                    { 2, "Hönnun" },
                    { 3, "Gagnagrunnur" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Hjörtur", "Pálmi" },
                    { 2, "Fannar", "asdfasdf" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "GroupId", "LastName" },
                values: new object[,]
                {
                    { 1, "Arnar", 1, "asdf1" },
                    { 2, "Björn", 2, "asdf2" },
                    { 3, "Helga", 3, "asdf3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 3);
        }
    }
}
