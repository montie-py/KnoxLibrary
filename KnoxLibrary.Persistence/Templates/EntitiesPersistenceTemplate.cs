using KnoxLibrary.Persistence.Services;
using KnoxLibrary.Persistence.Services.Entities;

namespace KnoxLibrary.Persistence.Templates;

public class EntitiesPersistenceTemplate : IPersistenceTemplate
{
    public IPersistenceService GetEntryInstance()
    {
        return new EntitiesEntry();
    }

    public IPersistenceService GetGenreInstance()
    {
        return new EntitiesGenre();
    }

    public IPersistenceService GetLiturgicalSessionInstance()
    {
        return new EntitiesLiturgicalSession();
    }
}