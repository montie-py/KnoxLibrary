namespace KnoxLibrary.Persistence.Entities;

internal class Genre
{
    public required int Id { get; set; }
    public required string Name { get; set; }
    public ISet<Entry> Entries { get; set; }
}