namespace SchoolManagement;

/*
## 請實作一個學校管理系統，主要的功能如下
### 學校
- 紀錄學校名稱、班級 V
- 學校可以加入班級 V
- 學校可列出所有學生的姓名與學號 V

## 班級
- 紀錄班級名稱，總共有A班與B班 V
- 所有學生都可以加入A班或B班，本科生與研究生可在同一班級 V
- 班級有點名功能，但方式不同 V
  - A班點名使用點名簿 V
  - B班點名使用線上點名 V
  - 點名時，本科生介紹姓名、學號、平均分數，研究生介紹姓名、學號、畢業學校、平均分數 V

## 學生
- 學生分為本科生與研究生 V
- 紀錄學號、姓名、與各科的成績，研究生需多紀錄畢業學校 V
- 所有學生都可以記錄各科的成績 V
- 所有學生都可以列出平均分數，研究生的平均分數需+5分 V
*/
class Program
{    
    static void Main(string[] args)
    {
        var school = new School("學校1");
        
        IRollCall onlineRollCall = new OnlineRollCall();
        IRollCall paperRollCall = new PaperRollCall();
        
        var classRoom = new ClassRoom("國文課", onlineRollCall);
        var classRoom2 = new ClassRoom("英文課", paperRollCall);
        var student = new NormalStudent("1", "學生1");
        student.AddGrade("科目1", 50);
        student.AddGrade("科目2", 60);
        
        var student2 = new GraduateStudent("2", "學生2", "畢業學校1");
        student2.AddGrade("科目1", 80);
        student2.AddGrade("科目2", 60);
        
        
        var student3 = new NormalStudent("3", "學生3");
        student3.AddGrade("科目1", 40);
        student3.AddGrade("科目2", 80);
        
        var student4 = new GraduateStudent("4", "學生4", "畢業學校2");
        student4.AddGrade("科目1", 20);
        student4.AddGrade("科目2", 50);
        
        classRoom.AddStudent(student);
        classRoom.AddStudent(student2);
        classRoom2.AddStudent(student3);
        classRoom2.AddStudent(student4);
        school.AddClassRoom(classRoom);
        school.AddClassRoom(classRoom2);
        //school.ShowAllStudents();
        classRoom.RollCall();
        Console.Read();


    }
}