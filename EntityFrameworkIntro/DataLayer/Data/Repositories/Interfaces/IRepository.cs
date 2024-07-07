using DataLayer.Entities;

namespace DataLayer.Data.Repositories.Interfaces
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        Task Delete(Guid Id);
        Task<TEntity> Update(TEntity entity);
        Task<TEntity> Create(TEntity entity);
        Task<TEntity> Find(Guid id);
        IQueryable<TEntity> GetAll();
    }
}
