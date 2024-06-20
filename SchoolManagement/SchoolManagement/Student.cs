using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace SchoolManagement;

public abstract class Student
{
    protected int _id { get; private set; }
    protected string _name { get; private set; }

    private Dictionary<string, double> _grades;

    protected Student(string name, int id)
    {
        _name = name;
        _id = id;
        this._grades = new Dictionary<string, double>();
    }
    public void AddGrade(string className, double score)
    {
        this._grades[className] = score;
    }

    protected virtual double CalculateAverage()
    {
        return this._grades.Values.Average();
    }
    public abstract void Show();

}