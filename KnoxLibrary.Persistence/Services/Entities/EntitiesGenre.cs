using KnoxLibrary.Persistence.Entities;
using KnoxLibrary.Persistence.Transfer;

namespace KnoxLibrary.Persistence.Services.Entities;

internal class EntitiesGenre : DatabasePersistenceService
{
    public override async Task<bool> AddEntity(IPersistenceTransferStruct transferStruct)
    {
        throw new NotImplementedException();
    }

    public override async Task<ICollection<IPersistenceTransferStruct>> GetAllDTOs()
    {
        throw new NotImplementedException();
    }

    public override async Task<IPersistenceTransferStruct?> GetDTOByKey<T>(T key)
    {
        throw new NotImplementedException();
    }

    public override async Task<bool> RemoveEntity<T>(T key)
    {
        throw new NotImplementedException();
    }

    public override async Task<bool> ReplaceEntity<T>(T key, IPersistenceTransferStruct transferStruct)
    {
        throw new NotImplementedException();
    }

    protected override IPersistenceTransferStruct GetDtoFromTransfer(IPersistenceTransferStruct transferStruct)
    {
        throw new NotImplementedException();
    }

    protected override IPersistenceTransferStruct GetDtoFromEntity(IEntity entity)
    {
        throw new NotImplementedException();
    }
}