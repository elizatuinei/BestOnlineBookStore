namespace BestOnlineBookStore.Models.ViewModels
{
    public class BookViewModel
    {
        public required IQueryable<Book> Books { get; set;}

        public PaginationInfo PaginationInfo { get; set;} = new PaginationInfo();
    }
}
