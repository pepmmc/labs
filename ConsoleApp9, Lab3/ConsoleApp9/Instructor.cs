class Instructor
    {
        private string Name { get; set; }
        private string CourseName { get; set; }
        public Instructor(string name, string courseName)
        {
            this.Name = name;
            this.CourseName = courseName;
        }
        public void SetStudentGrade(Student student, int grade)
        {
            student.SetGrade(grade);


        }
// cant figure out how to pass private variable across class
    public string TeacherName
    {

        get { return this.Name; }
        set { TeacherName = this.Name; }
    }
        public void Print()
        {
            System.Console.WriteLine(this.Name + " " + this.CourseName);

        }
    }





