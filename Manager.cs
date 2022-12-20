namespace Minhanh
{
    public class Manager:MenuProgram
    {
        public string username{get;set;}
        public string password{get;set;}
        public bool checkLogin=false;
        public List<Student> listStudent = new List<Student>();
        public List<Book> listbook = new List<Book>();
        
        
        public Manager()
        {
            username = "admin1";
            password = "123456";
            listStudent =  new List<Student>();
            listStudent.AddRange(new List<Student> { new Student((new GetStudentId(1)), new GetName("Hoang"), new GetClass("12a4"), new GetGender("Male"), new GetAge(20)),
                new Student((new GetStudentId(2)), new GetName("Huy"), new GetClass("12a1"), new GetGender("Male"), new GetAge(22))
            });
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
        protected override void PrintMenu()
        {
            System.Console.WriteLine("1. Register");
            System.Console.WriteLine("2. Add new book");
            System.Console.WriteLine("3. Delete book");
            System.Console.WriteLine("4. View all book");
            System.Console.WriteLine("5. Rent book");
            System.Console.WriteLine("6. Return book");
            System.Console.WriteLine("7. View all book rented ");
            System.Console.WriteLine("0. Exit");           
        }

        protected override void DoTask(int choice)
        {
            switch (choice)
            {
                case 1: AddnewStudent();                       break;
                case 2: AddNewBook();                          break;
                case 3: DelBook();                             break;
                case 4: ViewBooks();                           break;
                case 5: RentBook();                            break;
                case 6: ReturnBook();                          break;
                case 7: ViewRentedBook();                        break;
                case 0: Console.WriteLine("Bye!");             break;
                default: Console.WriteLine("Invalid choice!"); break;                
            }           
        }
        void AddnewStudent()
        {
            StudentBuilder builder = new StudentBuilder().AddId(new GetStudentId())
                                                        .AddFullname(new GetName())
                                                        .AddClass(new GetClass())
                                                        .AddGender(new GetGender())
                                                        .AddAge(new GetAge());
            Student student = builder.Build();
            listStudent.Add(student);   
        }
        void ViewRentedBook()
        {           
            foreach(var book in Student.rent)
            {
                Console.WriteLine(book.title);
            }
        }
        bool check()
        {
            System.Console.Write("Enter Username: ");
            string usr = Console.ReadLine();
            System.Console.Write("Enter Password: ");
            string pwd = Console.ReadLine();
            if(usr==username && pwd==password)
            {               
                return true;
            }
            return false;
        }
        void AddNewBook()
        {
            
            if(check()==true)
            {
                System.Console.Write("Enter title: ");
                string title = Console.ReadLine();
                System.Console.Write("Enter author: ");
                string author = Console.ReadLine();
                System.Console.Write("Enter description: ");
                string description = Console.ReadLine();
                listbook.Add(new Book(title,author,description));
            }
            else
            {
                System.Console.WriteLine("Wrong username or password");
            }
        }
        void DelBook(){
            if(check()==true)
            {
                System.Console.WriteLine("Enter name of book: ");
                string? name = Console.ReadLine();
                listbook.Remove( listbook.Single( s => s.title == name ) );
                System.Console.WriteLine("successfully!");
            }
            else
            {
                System.Console.WriteLine("Wrong username or password");
            }
        }
        void ViewBooks()
        {
            foreach(var book in listbook)
            {
                System.Console.Write("title: ");
                System.Console.WriteLine(book.title);
                System.Console.Write("author: ");
                System.Console.WriteLine(book.author);
                System.Console.Write("description: ");
                System.Console.WriteLine(book.description);
                System.Console.WriteLine("**********");
            }
        }
        void RentBook()
        {
                System.Console.WriteLine("Enter name of book: ");
                string title = Console.ReadLine();
                
            if(listbook.Exists(x => x.title == title))
            {
                foreach (var book in listbook) 
                {
                    
                    if(title==book.title)
                    {
                        string author = book.author;
                        string description = book.description;
                        Student.rent.Add(new Book(title, author,description));
                        System.Console.WriteLine("Rent successfully!");                        
                    }
                }
            }
            else
            {
                System.Console.WriteLine("We currently don't have that book!");
            }
                
        }
        void ReturnBook()
        {
             System.Console.WriteLine("Enter name of book want to return: ");
                string? title = Console.ReadLine();
            if (Student.rent.Exists(x => x.title == title))
            {
                Student.rent.RemoveAll(s => s.title == title);
                Console.WriteLine("return success");
            }
            else
            {
                System.Console.WriteLine("You did not borrow that book ");
            }
        }
    }
}