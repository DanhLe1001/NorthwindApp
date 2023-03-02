namespace NorthwindApp.Data.Interfaces
{
    public interface IRepository<T> where T : class
    {
        T GetById(Guid Id);
        IQueryable<T> GetAll();
        T Insert(T entity);
        T Update(T entity);
        void Delete(Guid entity);
    }
}
