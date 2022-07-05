using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerceUdemy.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film. ", "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg", 9.99m, "The Hitchhiker's Guide to the Galaxy" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "The Restaurant at the End of the Universe is the second book in the Hitchhiker's Guide to the Galaxy comedy science fiction 'trilogy of six books' by Douglas Adams, and is a sequel. It was originally published by Pan Books as a paperback in 1980. The book was inspired by the song 'Grand Hotel' by British rock band Procol Harum.[1] The book title refers to Milliways, the Restaurant at the End of the Universe, one of the settings of the book. ", "https://upload.wikimedia.org/wikipedia/en/9/98/RestaurantAtTheEndOfTheUniverse.jpg", 5.99m, "The Restaurant at the End of the Universe" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Life, the Universe and Everything (1982, ISBN 0-345-39182-9) is the third book in the six-volume Hitchhiker's Guide to the Galaxy science fiction 'trilogy of six books'' by British writer Douglas Adams. The title refers to the Answer to Life, the Universe, and Everything. ", "https://upload.wikimedia.org/wikipedia/en/d/d3/Life%2C_The_Universe_and_Everything_cover.jpg", 4.99m, "Life, the Universe and Everything" });
        }

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
