namespace SchoolManagement;

public class ClassRoom
{
    private readonly IRollCall _rollCall;
    public string Name { get; private set; }

    private List<Student> _students = new List<Student>();
    
    public ClassRoom(string name, IRollCall rollCall)
    {
        _rollCall = rollCall;
        Name = name;
    }

    public void AddStudent(Student student)
    {
        this._students.Add(student);
    }

    public List<Student> GetAllStudents()
    {
        return this._students;
    }

    public void RollCall()
    {
        Console.WriteLine($"{this.Name} Beginning Roll Call...");
        foreach (var student in _students)
        {
            this._rollCall.RollCall(student);
        }
    }
}