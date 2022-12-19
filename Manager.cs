namespace Minhanh
{
    public class Manager:MenuProgram
    {
        public string username{get;set;}
        public string password{get;set;}
        public bool checkLogin=false;
        public List<Student> listStudent;
        Book listbook = new Book();
        public Manager()
        {
            username = "admin1";
            password = "123456";
            listStudent =  new List<Student>();
        }
        protected override void PrintMenu()
        {
            System.Console.WriteLine("1. Register");
            System.Console.WriteLine("2. View All Student");
            System.Console.WriteLine("3. Add new book");
            System.Console.WriteLine("4. Delete book");
            System.Console.WriteLine("5. View all book");
            System.Console.WriteLine("6. Rent book");
            System.Console.WriteLine("7. Return book");
            System.Console.WriteLine("0. Exit");           
        }

        protected override void DoTask(int choice)
        {
            switch (choice)
            {
                case 1: AddnewStudent();                       break;
                case 2: ViewStudents();                        break;
                case 3: AddNewBook();                          break;
                case 4: DelBook();                             break;
                case 5: ViewBooks(); break;
                case 6: RentBook(); break;
                case 7: ReturnBook(); break;
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
            listStudent.Add(builder.Build());   
        }
        void ViewStudents()
        {            
            foreach(var item in listStudent)
            {
                var content = "";
                content += $"Student ID:   \t {GetStudentId.ID}\n";
                content += $"Student Name: \t {GetName.FullName}\n";
                content += $"Class:        \t {GetClass.Class}\n";
                content += $"Gender:       \t {GetGender.Gender}\n";
                content += $"Age:          \t {GetAge.Age}";
                System.Console.WriteLine(content);
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
                listbook.listbook.Add(new Book(title,author,description));
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
                listbook.listbook.Remove( listbook.listbook.Single( s => s.title == name ) );
                System.Console.WriteLine("successfully!");
            }
            else
            {
                System.Console.WriteLine("Wrong username or password");
            }
        }
        void ViewBooks()
        {
            foreach(var book in listbook.listbook)
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
                foreach (var book in listbook.listbook) 
                {
                    
                    if(title==book.title)
                    {
                        string author = book.author;
                        string description = book.description;
                        Student.rent.Add(new Book(title, author,description));
                        System.Console.WriteLine("Rent successfully!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Our library does not contains that book!");
                        break;
                    }
                }
        }
        void ReturnBook()
        {
             System.Console.WriteLine("Enter name of book want to return: ");
                string? title = Console.ReadLine();
                foreach (var book in Student.rent) 
                {
                    if(title==book.title)
                    {
                        Student.rent.Remove( Student.rent.Single( s => s.title == title ) );
                        System.Console.WriteLine("Return successfully!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("you did borrow that book!");
                        break;
                    }
                }
        }
    }
}