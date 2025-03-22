namespace KnoxLibrary.Persistence.Entities;

internal class Genre : IEntity
{
    public required int Id { get; set; }
    public required string Name { get; set; }
    public ISet<Entry> Entries { get; set; }
}