namespace Patterns.AbstractFactory;

public interface IUnitOfWork
{
    IRepositoryFactory RepositoryFactory { get; }

    TRepository GetRepository<TEntity, TRepository>() where TEntity : class where TRepository : class;
    Task SaveAsync();
}