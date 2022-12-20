namespace Minhanh
{
    public class GetName
    {
        public static string FullName{get;set;}
        public GetName()
        {
            Console.Write("Enter Fullname: ");
            FullName = Console.ReadLine();
        }
        public GetName(string name)
        {
            
            FullName = name;
        }
    }
}