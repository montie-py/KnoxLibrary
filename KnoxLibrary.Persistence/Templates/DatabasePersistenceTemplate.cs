using KnoxLibrary.Persistence.Entities;
using KnoxLibrary.Persistence.Services;
using KnoxLibrary.Persistence.Services.DB;

namespace KnoxLibrary.Persistence.Templates;

public class DatabasePersistenceTemplate : IPersistenceTemplate
{
    public IPersistenceService GetEntryInstance()
    {
        return new DbEntry();
    }

    public IPersistenceService GetGenreInstance()
    {
        return new DbGenre();
    }

    public IPersistenceService GetLiturgicalSessionInstance()
    {
        return new DbLiturgicalSession();
    }
}