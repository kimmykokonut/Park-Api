using Microsoft.EntityFrameworkCore;

namespace ParkApi.Models;

public class ParkApiContext : DbContext
{
  public DbSet<Park> Parks { get; set; }

  public ParkApiContext(DbContextOptions<ParkApiContext> options) : base(options)
  {
  }

  protected override void OnModelCreating(ModelBuilder builder)
  {
    builder.Entity<Park>()
      .HasData(
        new Park { ParkId = 1, Name = "Glacier National Park", Designation = "Federal", Description = "A showcase of melting glaciers, alpine meadows, carved valleys, and spectacular lakes. With over 700 miles of trails, Glacier is a paradise for adventurous visitors seeking wilderness steeped in human history. Relive the days of old through historic chalets, lodges, and the famous Going-to-the-Sun Road.", City = "West Glacier", State = "MT", WebUrl = "https://www.nps.gov/glac/index.htm", PhotoUrl = "https://roadtrippers.com/wp-content/uploads/2020/03/shutterstock_1141638494-1160x921.jpg", EntryFee = true, FeeType = "$35/day, $80/year", Campground = true, LatLong = "lat:48.6962778, long:-113.7178611", YearEst = 1910 },

        new Park { ParkId = 2, Name = "Silver Falls", Designation = "State", Description = "People call it the “crown jewel” of the Oregon State Parks system, and once you visit, you know why. Silver Falls State Park is the kind of standout scenic treasure that puts Oregon firmly onto the national—and international—stage. Its beauty, boundless recreational opportunities and historic presence keep it there.", City = "Silverton", State = "OR", WebUrl = "https://stateparks.oregon.gov/index.cfm?do=park.profile&parkId=151", PhotoUrl = "https://d3qvqlc701gzhm.cloudfront.net/thumbs/511bb60fa282965497501298dad4a5ca594a7786ce875bafd7fa1d8d376fc01f-750.jpg", EntryFee = true, FeeType = "$5/day, $30/year", Campground = true, LatLong = "lat:	44.8766667, long:-122.6480556", YearEst = 1933 },

        new Park { ParkId = 3, Name = "Joshua Tree", Designation = "Federal", Description = "Two distinct desert ecosystems, the Mojave and the Colorado, come together in Joshua Tree National Park. A fascinating variety of plants and animals make their homes in a land sculpted by strong winds and occasional torrents of rain. Dark night skies, a rich cultural history, and surreal geologic features add to the wonder of this vast wilderness in southern California", City = "Twentynine Palms,", State = "CA", WebUrl = "https://www.nps.gov/jotr/index.htm", PhotoUrl = "https://www.nps.gov/jotr/planyourvisit/images/lost-horse-valley_2.jpg?maxwidth=1300&autorotate=false&quality=78&format=webp", EntryFee = true, FeeType = "$30/day, $55/year", Campground = true, LatLong = "lat:33.881866, long:-115.900650", YearEst = 1994 },

        new Park { ParkId = 4, Name = "Devil's Hopyard", Designation = "State", Description = "860 acres of rocky forest, crisscrossed by hiking trails & highlighted by 60-ft.-high Chapman Falls.", City = "East Haddam", State = "CT", WebUrl = "https://ctparks.com/parks/devils-hopyard-state-park", PhotoUrl = "", EntryFee = false, FeeType = "", Campground = true, LatLong = "lat:41.4795000, long:-072.3416000", YearEst = 1919 },

        new Park { ParkId = 5, Name = "Hawai'i Volcanoes", Designation = "Federal", Description = "Hawai‘i Volcanoes National Park protects some of the most unique geological, biological, and cherished cultural landscapes in the world. Extending from sea level to 13,680 feet, the park encompasses the summits of two of the world's most active volcanoes - Kīlauea and Mauna Loa - and is a designated International Biosphere Reserve and UNESCO World Heritage Site. ", City = "Hawaii National Park", State = "HI", WebUrl = "https://www.nps.gov/havo/index.htm", PhotoUrl = "https://national-park.com/wp-content/uploads/2016/04/Welcome-to-Hawaii-Volcanoes-National-Park.jpg", EntryFee = true, FeeType = "$30/day, $80/year", Campground = true, LatLong = "lat:19.4288889, long:-155.2563889", YearEst = 1910 }
    );
  }
}