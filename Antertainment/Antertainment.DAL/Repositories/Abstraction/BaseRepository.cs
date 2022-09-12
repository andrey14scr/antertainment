namespace Antertainment.DAL.Repositories.Abstraction;

public abstract class BaseRepository : ITransactionalRepository
{
    protected readonly DatabaseContext _databaseContext;

    protected BaseRepository(DatabaseContext databaseContext)
    {
        _databaseContext = databaseContext;
    }

    public async Task SaveChanges()
    {
        await _databaseContext.SaveChangesAsync();
    }
}