namespace ApiRestEstudos.Api.Dtos;

public class CreateLocationDto
{
    public string Nome { get; set; } = string.Empty;

    public string Categoria { get; set; } = string.Empty;

    public double Latitude { get; set; }

    public double Longitude { get; set; }
}