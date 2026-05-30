using Microsoft.AspNetCore.Mvc;
using ApiRestEstudos.Api.Models;
using ApiRestEstudos.Api.Dtos;
using ApiRestEstudos.Api.Data;
using Microsoft.EntityFrameworkCore;

namespace ApiRestEstudos.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class LocationsController : ControllerBase
{

    private readonly AppDbContext _context;

    public LocationsController(AppDbContext context)
    {
        _context = context;
    }
    [HttpGet]
    public ActionResult<IEnumerable<Location>> Get()
    {

        return Ok(_context.Locations.ToList());
    }
    [HttpPut("{id}")]
    public ActionResult Update(int id, [FromBody] UpdateLocationDto dto)
    {
        var location = _context.Locations.FirstOrDefault(x => x.Id == id);

        if (location == null)
            return NotFound();

        location.Nome = dto.Nome;
        location.Categoria = dto.Categoria;
        location.Latitude = dto.Latitude;
        location.Longitude = dto.Longitude;

        _context.SaveChanges();

        return NoContent();
    }
    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        var location = _context.Locations.FirstOrDefault(x => x.Id == id);

        if (location == null)
            return NotFound();

        _context.Locations.Remove(location);
        _context.SaveChanges();

        return NoContent();
    }
    [HttpPost]
    public ActionResult<Location> Create(CreateLocationDto dto)
    {
        var location = new Location
        {
            Nome = dto.Nome,
            Categoria = dto.Categoria,
            Latitude = dto.Latitude,
            Longitude = dto.Longitude
        };

        _context.Locations.Add(location);
        _context.SaveChanges();

        return Ok(location);
    }
}