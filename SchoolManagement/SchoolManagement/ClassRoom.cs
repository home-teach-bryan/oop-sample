namespace SchoolManagement;

public class ClassRoom
{
    private readonly IRollCall _rollCall;
    
    private readonly List<Student> _students;
    public string Name { get; private set; }
    
    public ClassRoom(string name, IRollCall rollCall)
    {
        this._rollCall = rollCall;
        this.Name = name;
        this._students = new List<Student>();
    }

    public void RollCall()
    {
        foreach (var student in _students)
        {
            this._rollCall.RollCall(student);
        }
    }

    public void AddStudent(Student student)
    {
        this._students.Add(student);
    }
    
    public List<Student> GetAllStudents()
    {
        return _students;
    }
}