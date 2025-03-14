namespace KnoxLibrary.Persistence.Entities;

internal class LiturgicalSeason
{
    public required int Id { get; set; }
    public required string Name { get; set; }
    public required ISet<Entry> Entries { get; set; }
}