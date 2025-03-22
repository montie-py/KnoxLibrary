using KnoxLibrary.Persistence.Services;

namespace KnoxLibrary.Persistence.Templates;

public interface IPersistenceTemplate
{
    public IPersistenceService GetEntryInstance();
    public IPersistenceService GetGenreInstance();
    public IPersistenceService GetLiturgicalSessionInstance();
}