namespace RepositoryWithMVC.Data
{
    public interface IRepository<T> where T : class
    {
        // CREATE
        void Add(T entity);

        // READ
        T Get(int id);
        T Get(Func<T, bool> firstFunction);
        ICollection<T> GetAll();
        ICollection<T> GetList(Func<T, bool> whereFunction);

        // UPDATE
        void Update(T entity);

        // DELETE
        void Delete(T entity);

        void Save();
    }
}
