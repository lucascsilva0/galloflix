using System.ComponentModel.DataAnnotations;
namespace GalloFlix.Models;
public class Movie{
    [Key] // Define a propriedade como Chave Primária
    public int    Id            { get; set; }
    [Required] // Requerido - Not Null (No banco de dados); Validação
    [StringLength(30)] // Definindo quantidade de caracteres (tamanho máximo da propriedade)
    public string Title         { get; set; }
    public string OriginalTitle { get; set; }
    public string Synopsis      { get; set; }
    public Int16  MovieYear     { get; set; }
    public Int16  Duration      { get; set; }
    public byte   AgeRating     { get; set; } = 0;
    public string Image         { get; set; }
    public string HourDuration  { get {
        return TimeSpan.FromMinutes(Duration).ToString(@"%h' h 'mm' min'");
    } }
}