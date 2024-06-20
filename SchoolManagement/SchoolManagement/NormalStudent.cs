namespace SchoolManagement;

public class NormalStudent :Student
{
    public NormalStudent(string name, int id) : base(name, id)
    {
    }

    public override void Show()
    {
        Console.WriteLine($"{nameof(_name)}:{_name}, {nameof(_id)}: {_id}, Average:{base.CalculateAverage()}");
    }
}