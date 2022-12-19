namespace Minhanh
{
    public class GetGender
    {
        public static string Gender{get;set;}
        public GetGender()
        {
            Console.Write("Enter Gender: ");
            Gender = Console.ReadLine();
        }
    }
}