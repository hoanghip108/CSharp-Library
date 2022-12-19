namespace Minhanh
{
    public class GetClass
    {
        public static string Class { get; set; }
        public GetClass()
        {
            Console.Write("Enter Class: ");
            Class = Console.ReadLine();
        }
    }
}