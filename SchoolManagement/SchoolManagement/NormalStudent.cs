using System.Runtime.CompilerServices;

namespace SchoolManagement;

public class NormalStudent : Student
{
    public NormalStudent(string id, string name) : base(id, name)
    {
    }

    public override void Show()
    {
        Console.WriteLine($"{nameof(ID)}:{this.ID}, {nameof(this.Name)}:{this.Name}, Score:{this.CalculateScore()}");
    }
}