namespace SchoolManagement;

public class GraduateStudent : Student
{
    private string _graduateSchool;
    public GraduateStudent(string id, string name, string graduateSchool) : base(id, name)
    {
        this._graduateSchool = graduateSchool;
    }

    protected override double CalculateScore()
    {
        return base.CalculateScore() + 5d;
    }

    public override void Show()
    {
        Console.WriteLine(
            $"{nameof(ID)}:{this.ID}, {nameof(this.Name)}:{this.Name}, Score:{this.CalculateScore()}, GradeSchool:{this._graduateSchool}");

    }
}