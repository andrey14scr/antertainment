namespace Antertainment.DAL.Repositories.Abstraction;

public abstract class BaseRepository : ITransactionalRepository
{
    protected readonly DatabaseContext Сontext;

    protected BaseRepository(DatabaseContext сontext)
    {
        Сontext = сontext;
    }

    public async Task SaveChanges()
    {
        await Сontext.SaveChangesAsync();
    }
}