using BookAPI.Models;

namespace BookAPI.Rebositories
{
    public interface IBookRebository
    {
        Task<IEnumerable<Book>> Get();
        Task<Book> Get(int id);
        Task<Book> Create(Book Book);
        Task Update(Book Book);
        Task Delete(int id);
    }
}
