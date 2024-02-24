using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParkApi.Models;
using Microsoft.AspNetCore.JsonPatch;
using System.ComponentModel.DataAnnotations;

namespace ParkApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ParksController : ControllerBase
  {
    private readonly ParkApiContext _db;
    public ParksController(ParkApiContext db)
    {
      _db = db;
    }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Park>>> Get(string name, string designation, string city, string state, bool free, bool campground, int over100years, int pageNumber = 1, int pageSize = 10)
    {
      pageSize = Math.Min(pageSize, 100);

      IQueryable<Park> q = _db.Parks.AsQueryable();
      if (name != null)
      {
        q = q.Where(e => e.Name.Contains(name));
      }
      if (designation != null)
      {
        q = q.Where(e => e.Designation == designation);
      }
      if (city != null)
      {
        q = q.Where(e => e.City == city);
      }
      if (state != null)
      {
        q = q.Where(e => e.State == state);
      }
      if (free == true)
      {
        q = q.Where(e => e.EntryFee == false);
      }
      if (campground == true)
      {
        q = q.Where(e => e.Campground == campground);
      }
      if (over100years > 0)
      {
        q = q.Where(e => (DateTime.Now.Year - e.YearEst) >= 100);
      }
      int totalItems = await q.CountAsync();
      int totalPages = (int)Math.Ceiling((double)totalItems/ pageSize);

      pageNumber = Math.Min(pageNumber, totalPages);
      pageNumber = Math.Max(pageNumber, 1);

      return await q.Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToListAsync();
    }
    [HttpGet("{id}")]
    public async Task<ActionResult<Park>> GetPark(int id)
    {
      Park park = await _db.Parks.FindAsync(id);

      if (park == null)
      {
        return NotFound();
      }
      return park;
    }
    [HttpPost]
    public async Task<ActionResult<Park>> Post(Park park)
    {
      _db.Parks.Add(park);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetPark), new { id = park.ParkId }, park);
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Park park)
    {
      if (id != park.ParkId)
      {
        return BadRequest();
      }
      _db.Parks.Update(park);

      try 
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ParkExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }
      return NoContent();
    }
    private bool ParkExists(int id)
    {
      return _db.Parks.Any(e => e.ParkId == id);
    }
    [HttpPatch("{id}")]
    public async Task<IActionResult> JsonPatchWithModelState(int id, [FromBody] JsonPatchDocument<Park> patchDoc)
    {
      if (patchDoc != null)
      {
        Park parkToEdit = await _db.Parks.FindAsync(id);

        if (parkToEdit == null)
        {
          return NotFound();
        }
        patchDoc.ApplyTo(parkToEdit);

        try
        {
          await _db.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
          if (!ParkExists(id))
          {
            return NotFound();
          }
          else
          {
            throw;
          }
        }
        return Ok(parkToEdit);
      }
      else
      {
        return BadRequest();
      }
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePark(int id)
    {
      Park park = await _db.Parks.FindAsync(id);
      if (park == null)
      {
        return NotFound();
      }
      _db.Parks.Remove(park);
      await _db.SaveChangesAsync();

      return NoContent();
    }



  }
}