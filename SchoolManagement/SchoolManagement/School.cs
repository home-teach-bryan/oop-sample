namespace SchoolManagement;

public class School
{
    private List<ClassRoom> _classRooms = new List<ClassRoom>();
    public string Name { get; private set; }

    public School(string name)
    {
        Name = name;
    }

    public void AddClassRoom(ClassRoom classRoom)
    {
        this._classRooms.Add(classRoom);
    }

    public void ShowAllStudents()
    {
        foreach (var classRoom in _classRooms)
        {
            foreach (var student in classRoom.GetAllStudents())
            {
                Console.WriteLine($"Student {nameof(student.Name)}:{student.Name}, {nameof(student.ID)}:{student.ID}");
            }
        }
    }
    
    
    
}