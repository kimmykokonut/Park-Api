using System.ComponentModel.DataAnnotations;

namespace ParkApi.Models;

public class Park
{
  public int ParkId { get; set; }
  [Required]
  [StringLength(255)]
  public string Name { get; set; }
  [Required]
  [StringLength(7)]
  public string Designation { get; set; }
  public string Description { get; set; }
  public string City { get; set; }
  [Required]
  [StringLength(2)]
  public string State { get; set; }
  public string WebUrl { get; set; }
  public string PhotoUrl { get; set; }
  public bool EntryFee { get; set; }
  public string FeeType { get; set; }
  public bool Campground { get; set; }
  public string LatLong { get; set; }
  [Range(1872, 2024, ErrorMessage = "No parks were established in the US until 1872.")]
  public int YearEst { get; set; }
}