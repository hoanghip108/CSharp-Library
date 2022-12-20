namespace Minhanh
{
    public class Book
    {
        public string title {get;set;}
        public string author {get;set;}
        public string description{get;set;}
        public List<Book> listbook;
        
    public Book()
    {
         listbook = new List<Book>();
        
    }
    public Book(string title,string author,string description)
    {
        this.title = title;
        this.author = author;
        this.description = description;
    }
    }
}