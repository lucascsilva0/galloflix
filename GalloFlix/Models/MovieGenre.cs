
namespace GalloFlix.Models;
public class MovieGenre{
    public int   MovieId { get; set; }
    public Movie Movie   { get; set; } // propriedade de navegação
    public byte  GenreId { get; set; }
    public Genre Genre   { get; set; }
}