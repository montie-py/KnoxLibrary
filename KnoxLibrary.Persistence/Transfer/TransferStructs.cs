namespace KnoxLibrary.Persistence.Transfer
{
    public interface IPersistenceTransferStruct
    {
        
    }
    
    public struct EntityDTO : IPersistenceTransferStruct
    {
        public string CatalogueLocation { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public GenreDTO Genre { get; set; }
        public string Arranger { get; set; }
        public string Voices { get; set; }
        public LiturgicalSeasonDTO LiturgicalSeason { get; set; }
        public string File { get; set; }
    }

    public struct GenreDTO : IPersistenceTransferStruct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ISet<EntityDTO> Entities { get; set; }
    }

    public struct LiturgicalSeasonDTO : IPersistenceTransferStruct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ISet<EntityDTO> Entities { get; set; }
    }
}

