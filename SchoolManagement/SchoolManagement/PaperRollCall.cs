namespace SchoolManagement;

public class PaperRollCall : IRollCall
{
    public void RollCall(Student student)
    {
        Console.WriteLine("Use Paper Roll Call");
        student.Show();
    }
}