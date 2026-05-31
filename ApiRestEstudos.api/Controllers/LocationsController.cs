using Microsoft.AspNetCore.Mvc;
using ApiRestEstudos.Api.Models;
using ApiRestEstudos.Api.Dtos;
using ApiRestEstudos.Api.Data;

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
    public ActionResult<IEnumerable<Location>> Get(
        [FromQuery] string? nome,
        [FromQuery] string? categoria,
        [FromQuery] int page = 1,
        [FromQuery] int pageSize = 10)
    {
        var query = _context.Locations.AsQueryable();

        if (!string.IsNullOrWhiteSpace(nome))
            query = query.Where(x => x.Nome.Contains(nome));

        if (!string.IsNullOrWhiteSpace(categoria))
            query = query.Where(x => x.Categoria.Contains(categoria));

        var result = query
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToList();

        return Ok(result);
    }

    [HttpPost]
    public ActionResult<Location> Create([FromBody] CreateLocationDto dto)
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

        return CreatedAtAction(nameof(Get), new { id = location.Id }, location);
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
}