namespace Minhanh
{
    interface IStudentBuilder
    {

        StudentBuilder AddId(GetStudentId id);
        StudentBuilder AddFullname(GetName fullName);
        StudentBuilder AddClass(GetClass clas);
        StudentBuilder AddGender(GetGender gender);
        StudentBuilder AddAge(GetAge age);
        
        Student Build();
    }
}