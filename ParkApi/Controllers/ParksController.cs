using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParkApi.Models;
using Microsoft.AspNetCore.JsonPatch;

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
    public async Task<ActionResult<IEnumerable<Park>>> Get()
    {
      return await _db.Parks.ToListAsync();
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
        patchDoc.ApplyTo(parkToEdit, ModelState);

        if (!ModelState.IsValid)
        {
          return BadRequest(ModelState);
        }
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
        return BadRequest(ModelState);
      }
    }



  }
}