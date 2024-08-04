namespace Patterns.AbstractFactory;

public interface IRepositoryFactory
{
    TRepository? Create<TEntity, TRepository>() where TEntity : class where TRepository : class;
}