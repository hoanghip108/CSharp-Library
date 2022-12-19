namespace Minhanh
{
    public class Student
    {
        public GetStudentId Id {get;set; }
        public GetName FullName {get;set; }
        public GetClass Class {get;set; }
        public GetGender Gender {get;set; }
        public GetAge Age{get;set;}
        public static List<Book> rent = new List<Book>();
        public Student (GetStudentId id,GetName fullname,GetClass clas,GetGender gender,GetAge age)
        {
            Id = id;
            FullName=fullname;
            Class = clas;
            Gender = gender;
            Age = age;
        }
         public override string ToString()
    {
      var content = "";
      content += $"Student ID:    \t {GetStudentId.ID}\n";
      content += $"Student Name: \t {GetName.FullName}\n";
      content += $"Class:               \t {GetClass.Class}\n";
      content += $"Gender:    \t {GetGender.Gender}\n";
      content += $"Age:              \t {Age}";
      return content;
    }
        
    }
}