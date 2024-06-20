namespace SchoolManagement;

/*
請實作一個學校管理系統，主要的功能如下
學校:
紀錄學校名稱、班級
學校可以加入班級
學校可列出所有學生的姓名與學號

班級:
紀錄班級名稱，總共有A班與B班
所有學生都可以加入A班或B班，本科生與研究生可在同一班級
班級有點名功能，但方式不同
    A班點名使用點名簿
    B班點名使用線上點名
    點名時，本科生介紹姓名、學號、平均分數，研究生介紹姓名、學號、畢業學校、平均分數

學生:
學生分為本科生與研究生
紀錄學號、姓名、與各科的成績，研究生需多紀錄畢業學校
所有學生都可以記錄各科的成績
所有學生都可以列出平均分數，研究生的平均分數需+5分

*/
class Program
{    
    static void Main(string[] args)
    {
        var school = new School("學校1");
        var classRoomA = new ClassRoom("A班", new OnlineRollCall());
        var classRoomB = new ClassRoom("B班", new PaperRollCall());
        var student1 =  new NormalStudent("本科生1", 1);
        student1.AddGrade("國文", 50);
        student1.AddGrade("英文", 30);
        classRoomA.AddStudent(student1);
        var student2 = new GraduateStudent("研究生1", 2, "學校2");
        student2.AddGrade("國文", 10);
        student2.AddGrade("英文", 40);
        classRoomA.AddStudent(student2);
        school.AddClassRoom(classRoomA);
        
        
        var student3 =  new GraduateStudent("研究生2", 3, "學校2");
        student3.AddGrade("國文", 100);
        student3.AddGrade("英文", 40);
        classRoomB.AddStudent(student3);
        var student4 = new GraduateStudent("研究生3", 4, "學校3");
        student4.AddGrade("國文", 10);
        student4.AddGrade("英文", 40);
        classRoomB.AddStudent(student4);
        school.AddClassRoom(classRoomB);
        school.ShowAllStudents();
        classRoomA.RollCall();
        classRoomB.RollCall();
        Console.Read();
    }
}