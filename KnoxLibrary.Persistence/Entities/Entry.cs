using System.ComponentModel.DataAnnotations;

namespace KnoxLibrary.Persistence.Entities;

internal class Entry
{
    [Key]
    public required string CatalogueLocation { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public Genre Genre { get; set; }
    public int GenreId { get; set; }
    public string Arranger { get; set; }
    public string Voices { get; set; }
    public LiturgicalSeason LiturgicalSeason { get; set; }
    public int LiturgicalSeasonId { get; set; }
    public string File { get; set; }
}
