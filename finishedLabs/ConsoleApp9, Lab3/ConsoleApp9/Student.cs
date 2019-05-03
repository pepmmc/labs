
class Student
{
    private string Name { get; set; }
    private int Grade { get; set; }
    private Instructor Teacher { get; set; }
    private string TeacherName {
        get { return this.Teacher; }
        set { TeacherName = ToString(this.Teacher)}

    public Student(string name, Instructor teacher)
    {
        this.Name = name;
        this.Teacher = teacher;
        this.Grade = 0;
      
    }

   
    public void SetGrade(int grade)
    {
        this.Grade = grade;
    }

    public void Print()
    {
        System.Console.WriteLine(this.Name + "  Grade= " + this.Grade + " " + this.TeacherName);


    }
}

