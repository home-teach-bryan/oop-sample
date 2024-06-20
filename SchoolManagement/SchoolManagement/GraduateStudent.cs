namespace SchoolManagement;

public class GraduateStudent : Student
{
    private string _graduateSchool;
    
    public GraduateStudent(string name, int id, string graduateSchool) : base(name, id)
    {
        _graduateSchool = graduateSchool;
    }
    public override void Show()
    {
        Console.WriteLine(
            $"Name:{this._name}, ID: {this._id}, Average:{this.CalculateAverage()}, GraduateSchool:{this._graduateSchool} ");
    }
    protected override double CalculateAverage()
    {
        return base.CalculateAverage() + 5;
    }
}