using RepositoryWithMVC.Models;

namespace RepositoryWithMVC.Data
{
    public class AccountRepository: IRepository<Account>
    {
        public RepositoryWithMVCContext Context { get; set; }

        public AccountRepository(RepositoryWithMVCContext context)
        {
            Context = context;
        }

        // Create
        public void Add(Account account)
        {
            Context.Account.Add(account);
        }

        // READ
        public Account Get(int id)
        {
            return Context.Account.First(a => a.Id == id);
        }

        public Account Get(Func<Account, bool> firstFunction)
        {
            return Context.Account.First(firstFunction);
        }

        public ICollection<Account> GetAll()
        {
            return Context.Account.ToList();
        }

        public ICollection<Account> GetList(Func<Account, bool> whereFunction)
        {
            return Context.Account.Where(whereFunction).ToList();
        }

        // Update
        public void Update(Account account)
        {
            Context.Account.Update(account);
        }

        // Delete
        public void Delete(Account account)
        {
            Context.Account.Remove(account);
        }

        public void Save()
        {
            Context.SaveChanges();
        }

    }
}
