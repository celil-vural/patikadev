using Repositoriy.Concrate.Ef;

namespace BookStore.BookOperations.DeleteBook
{
    public class DeleteBookCommand
    {
        private readonly EfRepositoryContext _context;
        public int BookId { get; set; }
        public DeleteBookCommand(EfRepositoryContext context)
        {
            _context = context;
        }
        public void Handle()
        {
            var book = _context.Books.FirstOrDefault(e => e.Id == BookId);
            if (book is null)
            {
                throw new InvalidOperationException("Silinecek kitap bulunamadı.");
            }
            _context.Books.Remove(book);
            _context.SaveChanges();
        }
    }
}
