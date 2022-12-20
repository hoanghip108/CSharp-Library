namespace Minhanh
{
    public class StudentBuilder:IStudentBuilder
    {
        public GetStudentId Id {get;set; }
        public GetName FullName {get;set; }
        public GetClass Class {get;set; }
        public GetGender Gender {get;set; }
        public GetAge Age{get;set;}
        public StudentBuilder AddId(GetStudentId id)
        {
            Id = id;
            return this;
        }
        public StudentBuilder AddFullname(GetName fullName)
        {
            FullName = fullName;
            return this;
        }
        public StudentBuilder AddClass(GetClass clas)
        {
            Class = clas;
            return this;
        }
        public StudentBuilder AddGender(GetGender gender)
        {
            Gender = gender;
            return this;
        }
        public StudentBuilder AddAge(GetAge age)
        {
            Age = age;
            return this;
        }
        public Student Build()
        {
            return new Student(Id,FullName,Class,Gender,Age);
        }
    }
}