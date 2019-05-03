using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1pepera
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string middleInitial;
            string lastName;
            string fullName;
            int age;
            bool isCitizen;
            bool canVote;
            int heightFeet;
            double heightInches;
            double totalHeightCM;

            //going for input

            System.Console.Write("What is your first name? ");
            firstName = System.Console.ReadLine();
            System.Console.Write("What is your middle initial? ");
            middleInitial = System.Console.ReadLine();
            System.Console.Write("What is your last name? ");
            lastName = System.Console.ReadLine();
            fullName = firstName + " " + middleInitial + ". " + lastName;
            System.Console.WriteLine();
            System.Console.Write("How many feet tall are you  " + fullName + "? ");
            heightFeet = int.Parse(System.Console.ReadLine());
            System.Console.Write("How many inches do you extend beyond your base height? ");
            heightInches = double.Parse(System.Console.ReadLine());
            totalHeightCM = ((heightFeet * 12) + heightInches) * 2.54;
            System.Console.WriteLine();
            System.Console.Write("How old are you " + firstName + "? ");
            age = int.Parse(System.Console.ReadLine());
            System.Console.Write("Are you a citizen " + firstName + "? (please enter true or false)  ");
            isCitizen = bool.Parse(System.Console.ReadLine());
            canVote = isCitizen && age >= 18;

            //going for output

            System.Console.WriteLine();
            System.Console.WriteLine(fullName);
            System.Console.WriteLine(totalHeightCM +"cm ");
            System.Console.WriteLine(canVote);

            System.Console.ReadLine();

        }
    }
}
