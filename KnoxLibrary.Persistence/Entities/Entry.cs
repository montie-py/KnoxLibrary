using System.ComponentModel.DataAnnotations;

namespace KnoxLibrary.Persistence.Entities;

internal class Entry
{
    [Key]
    internal required string CatalogueLocation { get; set; }
    internal required string Title { get; set; }
    internal required string Author { get; set; }
    internal required Genre Genre { get; set; }
    internal required string Arranger { get; set; }
    internal required ISet<Voice> Voices { get; set; }
    internal required LiturgicalSeason LiturgicalSeason { get; set; }
    internal string File { get; set; }
}
