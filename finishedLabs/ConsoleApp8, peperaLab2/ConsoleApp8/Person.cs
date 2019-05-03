using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;
        public Person Spouse;
        public static double SumOfAllAges;
        public static int Count;

        public string GetFullName()
        { return this.FirstName + " " + this.LastName;
        }

        public void PrintNameAndAge()
        {
            System.Console.WriteLine(this.GetFullName() + " Age: " + this.Age);
            if (this.Spouse != null)
            {
                System.Console.WriteLine(this.Spouse.GetFullName() + "  Age:" + this.Spouse.Age);

            }
                }


        public void GatherPersonInfo()
        { System.Console.Write("What is your first name? ");
            this.FirstName = System.Console.ReadLine();
            System.Console.Write("What is your last name? ");
            this.LastName = System.Console.ReadLine();
            System.Console.Write("What is your age? ");
            this.Age = int.Parse(System.Console.ReadLine());
            Person.Count ++;
            Person.SumOfAllAges += this.Age;
            System.Console.WriteLine();

        }

       

        public void CreateSpouse()
        { System.Console.Write("Are you married (y or n)?");
            if (System.Console.ReadLine().ToLower().StartsWith("y"))
            {
                this.Spouse = new Person();
                System.Console.Write("Good for you, what is your spouse's first name? ");
                    this.Spouse.FirstName = System.Console.ReadLine();
                this.Spouse.LastName = this.LastName;
                System.Console.Write("What is your spouse's age? ");
                this.Spouse.Age = int.Parse(System.Console.ReadLine());
                Person.Count++;
                Person.SumOfAllAges += this.Spouse.Age;
                this.Spouse.Spouse = this;
                System.Console.WriteLine();
            }
        }

    }
}
