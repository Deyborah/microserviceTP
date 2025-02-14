using BookService.Models;
using BookService.Repositories;

namespace BookService.Services
{
    public class BooksService
    {
        private readonly IBookRepository _repository;

        public BooksService(IBookRepository bookRepository)
        {
            _repository = bookRepository;
        }

        public async Task<IEnumerable<Book>> GetAllBooksAsync() =>
            await _repository.GetAllAsync();

        public async Task<Book?> GetBookByIdAsync(int id) =>
            await _repository.GetByIdAsync(id);

        public async Task AddBookAsync(Book book) =>
            await _repository.AddAsync(book);

        public async Task UpdateBookAsync(Book book) =>
            await _repository.UpdateAsync(book);

        public async Task DeleteBookAsync(int id) =>
            await _repository.DeleteAsync(id);
    }
}
