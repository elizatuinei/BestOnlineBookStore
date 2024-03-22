namespace BestOnlineBookStore.Models
{
    public interface IBookstoreRepo
    {
        public IQueryable<Book> Books { get; }
    }
}
