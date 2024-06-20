namespace SchoolManagement;

public class School
{
    public string Name { get; private set; }

    private List<ClassRoom> _classRooms;

    public School(string name)
    {
        this.Name = name;
        this._classRooms = new List<ClassRoom>();
    }
    public void AddClassRoom(ClassRoom classRoom)
    {
        this._classRooms.Add(classRoom);
    }
    public void ShowAllStudents()
    {
        foreach (var classRoom in _classRooms)
        {
            var students = classRoom.GetAllStudents();
            foreach (var student in students)
            {
                student.Show();
            }
        }
    }
}