namespace Minhanh
{
    public class GetAge
    {
        public static int Age { get; set; }
        public GetAge()
        {
            Console.Write("Enter Age: ");
            Age = int.Parse(Console.ReadLine());
        }
        public GetAge(int age)
        {
            
            Age = age;
        }
    }
}