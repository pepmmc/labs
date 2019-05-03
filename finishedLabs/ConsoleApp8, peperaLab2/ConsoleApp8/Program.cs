using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            //strict adherence to instructions

            Person p1 = new Person();
            Person p2 = new Person();
       
            Person.SumOfAllAges = 0;
            Person.Count = 0;



            p1.GatherPersonInfo();
            p1.CreateSpouse();
            System.Console.WriteLine("Thank you kindly " +p1.FirstName);
            System.Console.WriteLine();
            System.Console.WriteLine("Would Person Number 2 please answer the following");
            System.Console.WriteLine();


            p2.GatherPersonInfo();
            p2.CreateSpouse();
            System.Console.WriteLine("Thank you for your assistance " + p2.FirstName);
            System.Console.WriteLine();
            p1.PrintNameAndAge();
            p2.PrintNameAndAge();

            System.Console.Write("Total Age= " + Person.SumOfAllAges);
            System.Console.WriteLine();
            System.Console.WriteLine("Average Age= " + Person.SumOfAllAges / Person.Count);
            System.Console.WriteLine();

            //just clunky way to check spouse property is assigned appropriately

            System.Console.WriteLine();
            if(p1.Spouse != null)
            { System.Console.WriteLine(p1.GetFullName() + " is married to " + p1.Spouse.GetFullName());
                System.Console.Write(p1.Spouse.FirstName + " is married to " + p1.FirstName);
            }
            System.Console.WriteLine();
            if (p2.Spouse != null)
            { System.Console.WriteLine(p2.GetFullName() + " is married to " + p2.Spouse.GetFullName());
                System.Console.Write(p2.Spouse.FirstName + " is married to " + p2.FirstName);
            }
            System.Console.ReadLine();


            
        }
    }
}
