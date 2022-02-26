using Microsoft.EntityFrameworkCore;
using BookAPI.Models;

namespace BookAPI.Rebositories
{
    public class BookRebository : IBookRebository
    {
        private readonly BookContext _context;

        public BookRebository(BookContext context)
        {
            _context = context;
        }

        public async Task<Book> Create(Book Book)
        {
            _context.Books.Add(Book);
            await _context.SaveChangesAsync();
            return Book;
        }

        public async Task Delete(int id)
        {
            var bookToDelete = await _context.Books.FindAsync(id);
            _context.Books.Remove(bookToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Book>> Get()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task<Book> Get(int id)
        {
            return await _context.Books.FindAsync(id);
        }

        public async Task Update(Book Book)
        {
            _context.Entry(Book).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
