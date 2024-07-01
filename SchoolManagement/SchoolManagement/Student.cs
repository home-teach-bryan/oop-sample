namespace SchoolManagement;

public abstract class Student 
{
    public string ID { get; private set; }
    
    public string Name { get; private set; }

    protected Dictionary<string, int> _grades = new Dictionary<string, int>();

    protected Student(string id, string name)
    {
        ID = id;
        Name = name;
    }

    public void AddGrade(string name, int score)
    {
        this._grades.Add(name, score);
    }

    protected virtual double CalculateScore()
    {
        return this._grades.Values.Average();
    }

    public abstract void Show();
}