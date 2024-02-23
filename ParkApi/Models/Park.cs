namespace ParkApi.Models;

public class Park
{
  public int ParkId { get; set; }
  public string Name { get; set; }
  public string Designation { get; set; }
  public string Description { get; set; }
  public string City { get; set; }
  public string State { get; set; }
  public string WebUrl { get; set; }
  public string PhotoUrl { get; set; }
  public bool EntryFee { get; set; }
  public string FeeType { get; set; }
  public bool Campground { get; set; }
  public string LatLong { get; set; }
  public int YearEst { get; set; }
}