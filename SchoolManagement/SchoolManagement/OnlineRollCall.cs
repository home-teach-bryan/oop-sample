namespace SchoolManagement;

public class OnlineRollCall : IRollCall
{
    public void RollCall(Student student)
    {
        Console.WriteLine("Use Online Roll Call");
        student.Show();
    }
}