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
         listbook.AddRange(new List<Book>
            {
                new Book("In Search of Lost Time","Marcel Proust","abc"),
                new Book("Ulysses","James Joyce","abc"),
                new Book("Don Quixote","Miguel de Cervantes","abc"),
                new Book("One Hundred Years of Solitude","Gabriel Garcia Marquez","abc"),
                new Book("The Great Gatsby","F. Scott Fitzgerald","abc"),
            }
            );
    }
    public Book(string title,string author,string description)
    {
        this.title = title;
        this.author = author;
        this.description = description;
    }
    }
}