namespace Patterns.AbstractFactory;

public class RepositoryFactory : IRepositoryFactory
{
    private readonly IServiceProvider _serviceProvider;

    public RepositoryFactory(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    // No refernces, so code shows errors
    public TRepository? Create<TEntity, TRepository>() 
        where TEntity : class 
        where TRepository : class
    {
        switch (typeof(TEntity))
        {
            case var type when type == typeof(Recipe):
                return _serviceProvider.GetRequiredService<IRecipeRepository>() as TRepository;
            case var type when type == typeof(Comment):
                return new SomeReposiory as TRepository;
            default:
                throw new ArgumentException($"Repository for entity type {typeof(TEntity)} not found");
        }
    }
}