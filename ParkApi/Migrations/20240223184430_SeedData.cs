using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Campground", "City", "Description", "Designation", "EntryFee", "FeeType", "LatLong", "Name", "PhotoUrl", "State", "WebUrl", "YearEst" },
                values: new object[,]
                {
                    { 1, true, "West Glacier", "A showcase of melting glaciers, alpine meadows, carved valleys, and spectacular lakes. With over 700 miles of trails, Glacier is a paradise for adventurous visitors seeking wilderness steeped in human history. Relive the days of old through historic chalets, lodges, and the famous Going-to-the-Sun Road.", "Federal", true, "$35/day, $80/year", "lat:48.6962778, long:-113.7178611", "Glacier National Park", "https://roadtrippers.com/wp-content/uploads/2020/03/shutterstock_1141638494-1160x921.jpg", "MT", "https://www.nps.gov/glac/index.htm", 1910 },
                    { 2, true, "Silverton", "People call it the “crown jewel” of the Oregon State Parks system, and once you visit, you know why. Silver Falls State Park is the kind of standout scenic treasure that puts Oregon firmly onto the national—and international—stage. Its beauty, boundless recreational opportunities and historic presence keep it there.", "State", true, "$5/day, $30/year", "lat:	44.8766667, long:-122.6480556", "Silver Falls", "https://d3qvqlc701gzhm.cloudfront.net/thumbs/511bb60fa282965497501298dad4a5ca594a7786ce875bafd7fa1d8d376fc01f-750.jpg", "OR", "https://stateparks.oregon.gov/index.cfm?do=park.profile&parkId=151", 1933 },
                    { 3, true, "Twentynine Palms,", "Two distinct desert ecosystems, the Mojave and the Colorado, come together in Joshua Tree National Park. A fascinating variety of plants and animals make their homes in a land sculpted by strong winds and occasional torrents of rain. Dark night skies, a rich cultural history, and surreal geologic features add to the wonder of this vast wilderness in southern California", "Federal", true, "$30/day, $55/year", "lat:33.881866, long:-115.900650", "Joshua Tree", "https://www.nps.gov/jotr/planyourvisit/images/lost-horse-valley_2.jpg?maxwidth=1300&autorotate=false&quality=78&format=webp", "CA", "https://www.nps.gov/jotr/index.htm", 1994 },
                    { 4, true, "East Haddam", "860 acres of rocky forest, crisscrossed by hiking trails & highlighted by 60-ft.-high Chapman Falls.", "State", false, "", "lat:41.4795000, long:-072.3416000", "Devil's Hopyard", "", "CT", "https://ctparks.com/parks/devils-hopyard-state-park", 1919 },
                    { 5, true, "Hawaii National Park", "Hawai‘i Volcanoes National Park protects some of the most unique geological, biological, and cherished cultural landscapes in the world. Extending from sea level to 13,680 feet, the park encompasses the summits of two of the world's most active volcanoes - Kīlauea and Mauna Loa - and is a designated International Biosphere Reserve and UNESCO World Heritage Site. ", "Federal", true, "$30/day, $80/year", "lat:19.4288889, long:-155.2563889", "Hawai'i Volcanoes", "https://national-park.com/wp-content/uploads/2016/04/Welcome-to-Hawaii-Volcanoes-National-Park.jpg", "HI", "https://www.nps.gov/havo/index.htm", 1910 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5);
        }
    }
}
