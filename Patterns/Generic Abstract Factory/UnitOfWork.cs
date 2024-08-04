namespace Patterns.AbstractFactory;

public class UnitOfWork : IUnitOfWork
{
    // also no references, so errors in log

    private RecipePlatformDbContext Context { get; }
    public IRepositoryFactory RepositoryFactory { get; }

    public UnitOfWork(
        IRepositoryFactory repositoryFactory,
        RecipePlatformDbContext context)
    {
        Context = context;
        RepositoryFactory = repositoryFactory;
    }
    
    public TRepository GetRepository<TEntity, TRepository>() where TEntity : class where TRepository : class
    {
        return RepositoryFactory.Create<TEntity, TRepository>()!;
    }

    public async Task SaveAsync()
    {
        try
        {
            await Context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw ex.InnerException!;
        }
    }
}