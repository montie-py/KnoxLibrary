using KnoxLibrary.Persistence.Entities;
using KnoxLibrary.Persistence.Transfer;

namespace KnoxLibrary.Persistence.Services;

internal abstract class DatabasePersistenceService : IPersistenceService
{
    protected readonly AppDbContext _dbContext;
    protected readonly string fileType = "application/pdf";
    protected string FileName { get; init; }
    
    public abstract Task<bool> AddEntity(IPersistenceTransferStruct transferStruct);

    public abstract Task<ICollection<IPersistenceTransferStruct>> GetAllDTOs();

    public abstract Task<IPersistenceTransferStruct?> GetDTOByKey<T>(T key);

    public abstract Task<bool> RemoveEntity<T>(T key);

    public abstract Task<bool> ReplaceEntity<T>(T key, IPersistenceTransferStruct transferStruct);
    
    protected abstract IPersistenceTransferStruct GetDtoFromTransfer(IPersistenceTransferStruct transferStruct);
    protected abstract IPersistenceTransferStruct GetDtoFromEntity(IEntity entity);
}