using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3__lab3
{
    class Student
    {
        private string Name;
        private int Grade;
        private Instructor Teacher;
        int Sgrade;
        //property that is used to access private int Grade;
        public int grade
        {
            get { return Grade; }

            set { Grade = value; }
        }

     
        
       public string name
        { get { return Name; }
            set { name = value; }

        }

         

        public Student (string name, Instructor teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
            Grade = 0;
        }

       
        public void SetGrade()
        {
            this.Teacher.SetStudentGrade(this, 100);
        }


        public void Printst()
        {
            System.Console.WriteLine(this.Name + " is enrolled in " + this.Teacher.coursename + ", instructor " + this.Teacher.name + ".  Grade: " + this.Grade);

            
            System.Console.WriteLine();
            
         

        }












    }

}


