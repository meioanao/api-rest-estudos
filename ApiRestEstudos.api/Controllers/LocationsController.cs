using Microsoft.AspNetCore.Mvc;
using ApiRestEstudos.Api.Models;
using ApiRestEstudos.Api.Dtos; 

namespace ApiRestEstudos.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class LocationsController : ControllerBase
{
    [HttpGet]
    public ActionResult<List<Location>> Get()
    {
        var locations = new List<Location>
        {
            new()
            {
                Id = 1,
                Nome = "Praça Central",
                Categoria = "Lazer",
                Latitude = -22.9068,
                Longitude = -43.1729
            },
            new()
            {
                Id = 2,
                Nome = "Biblioteca Municipal",
                Categoria = "Educação",
                Latitude = -22.9030,
                Longitude = -43.1800
            }
        };

        return Ok(locations);
    }

    [HttpPost]
    public ActionResult<Location> Create(CreateLocationDto dto)
    {
        var location = new Location
        {
            Id = 999,
            Nome = dto.Nome,
            Categoria = dto.Categoria,
            Latitude = dto.Latitude,
            Longitude = dto.Longitude
        };

        return CreatedAtAction(
            nameof(Get),
            new { id = location.Id },
            location);
    }
}