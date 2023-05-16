using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalloFlix.Models;
public class Movie{
    [Key] // Define a propriedade como Chave Primária
    public int    Id            { get; set; }
    // -------------------------------------------------------------------------------------------------------
    [Required] // Requerido - Not Null (No banco de dados); Validação
    [StringLength(100)] // Definindo quantidade de caracteres (tamanho máximo da propriedade)
    public string Title         { get; set; }
    // -------------------------------------------------------------------------------------------------------
    [Required]
    [StringLength(100)]
    public string OriginalTitle { get; set; }
    // -------------------------------------------------------------------------------------------------------
    [Required]
    [StringLength(8000)]
    public string Synopsis      { get; set; }
    // -------------------------------------------------------------------------------------------------------
    [Column(TypeName = "Year")] // Específica que é uma coluna do banco de dados
    public Int16  MovieYear     { get; set; }
    // -------------------------------------------------------------------------------------------------------
    [Required]
    public Int16  Duration      { get; set; }
    // -------------------------------------------------------------------------------------------------------
    [Required]
    public byte   AgeRating     { get; set; } = 0;
    // -------------------------------------------------------------------------------------------------------
    [StringLength(200)]
    public string Image         { get; set; }
    // -------------------------------------------------------------------------------------------------------
    [NotMapped]
    public string HourDuration  { get {
        return TimeSpan.FromMinutes(Duration).ToString(@"%h' h 'mm' min'");
    } }
}
