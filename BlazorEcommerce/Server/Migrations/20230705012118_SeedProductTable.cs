using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorEcommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUlr", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Dune is a 1965 epic science fiction novel by American author Frank Herbert, originally published as two separate serials in Analog magazine. It tied with Roger Zelazny's This Immortal for the Hugo Award in 1966 and it won the inaugural Nebula Award for Best Novel. It is the first installment of the Dune Chronicles. In 2003, it was described as the world's best-selling science fiction novel.", "https://upload.wikimedia.org/wikipedia/en/thumb/d/de/Dune-Frank_Herbert_%281965%29_First_edition.jpg/220px-Dune-Frank_Herbert_%281965%29_First_edition.jpg", 9.99m, "Dune" },
                    { 2, "Foundation is a science fiction novel by American writer Isaac Asimov. It is the first published in his Foundation Trilogy (later expanded into the Foundation series). ", "https://upload.wikimedia.org/wikipedia/en/thumb/2/25/Foundation_gnome.jpg/220px-Foundation_gnome.jpg", 9.99m, "Foundation" },
                    { 3, "The Hobbit, or There and Back Again is a children's fantasy novel by English author J. R. R. Tolkien. It was published in 1937 to wide critical acclaim, being nominated for the Carnegie Medal and awarded a prize from the New York Herald Tribune for best juvenile fiction.", "https://upload.wikimedia.org/wikipedia/en/thumb/4/4a/TheHobbit_FirstEdition.jpg/220px-TheHobbit_FirstEdition.jpg", 9.99m, "Hobbit" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
