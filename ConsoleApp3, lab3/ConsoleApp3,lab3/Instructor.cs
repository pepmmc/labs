using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3__lab3
{
    class Instructor
    {
        private string Name;
        private string CourseName;
        private int Grade;
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }

        public string coursename
        { get { return CourseName; }
            set { CourseName = value; } }
      
            

        
        public Instructor (string name, string coursename)
        {
            this.Name = name;
            this.CourseName = coursename;
        }

        public int SetStudentGrade(Student changeThis, int grade)
        {

            changeThis.grade = grade;
            return grade;

        }

           public void PrintNamestuff()
        {
            System.Console.WriteLine(this.Name + " " + this.CourseName + " ");
            System.Console.WriteLine();
        }

      


    }
}
