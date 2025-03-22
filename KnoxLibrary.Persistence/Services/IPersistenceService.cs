using KnoxLibrary.Persistence.Transfer;

namespace KnoxLibrary.Persistence.Services;

public interface IPersistenceService
{
    public Task<bool> AddEntity(IPersistenceTransferStruct transferStruct); 
    public Task<ICollection<IPersistenceTransferStruct>> GetAllDTOs();
    public Task<IPersistenceTransferStruct?> GetDTOByKey<T>(T key);
    public Task<bool> RemoveEntity<T>(T key);
    public Task<bool> ReplaceEntity<T>(T key, IPersistenceTransferStruct transferStruct);
}