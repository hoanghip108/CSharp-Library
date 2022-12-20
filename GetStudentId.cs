namespace Minhanh
{
    public class GetStudentId
    {
        public static int ID{get;set;}
        private static int id = 1;
static int generateId()
{
    return id++;
}
        public GetStudentId()
        {   
            ID = generateId();
        }
        public GetStudentId(int id)
        {
            ID = id;
        }
    }
}