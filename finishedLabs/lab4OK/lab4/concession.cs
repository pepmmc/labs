using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class concession
    {  //establishing concession variables and pseudo variables (fluxuating constants)

        public static double PriceSmallSoda = 3.5;
        public static double PriceLargeSoda = 5.99;
        public static double PriceHotDog = 3.99;
        public static double PricePopcorn = 4.5;
        public static double PriceCandy = 1.99;
        private int QtyLargeSoda;
        private int QtySmallSoda;
        private int QtyHotDogs;
        private int QtyPopcorn;
        private int QtyCandy;

        private double TotalConcessionCost = 0;
        private double CandyDiscount;
        private double PopCornSodaSpecial;

        //establishing movie prices and variables
        public static double MatineeChild = 3.99;
        public static double MatineeAdult = 5.99;
        public static double MatineeSenior = 4.50;
        public static double EveningChild = 6.99;
        public static double EveningAdult = 10.99;
        public static double EveningSenior = 8.50;
        private double TotalMovieCost = 0;
        private int QtyChild;
        private int QtyAdult;
        private int QtySenior;



        public void GetOrderConcession()
        {
            System.Console.Write("How many Small Sodas would you like?  ");
            this.QtySmallSoda = int.Parse(System.Console.ReadLine());
            this.TotalConcessionCost += (this.QtySmallSoda * concession.PriceSmallSoda);
            System.Console.Write("How many Large Sodas would you like?  ");
            this.QtyLargeSoda = int.Parse(System.Console.ReadLine());
            this.TotalConcessionCost += (this.QtyLargeSoda * concession.PriceLargeSoda);
            System.Console.Write("How many Hot Dogs would you like?  ");
            this.QtyHotDogs = int.Parse(System.Console.ReadLine());
            this.TotalConcessionCost += (this.QtyHotDogs * concession.PriceHotDog);
            System.Console.Write("How many Popcorns would you like?  ");
            this.QtyPopcorn = int.Parse(System.Console.ReadLine());
            this.TotalConcessionCost += (this.QtyPopcorn * concession.PricePopcorn);
            System.Console.Write("How many Candy would you like?  ");
            this.QtyCandy = int.Parse(System.Console.ReadLine());
            this.TotalConcessionCost += (this.QtyCandy * concession.PriceCandy);

        }

        public void GetMovieOrder()
        {
            System.Console.Write("How many Children's tickets would you like?  ");
            this.QtyChild = int.Parse(System.Console.ReadLine());
            System.Console.Write("How many Adult tickets would you like?  ");
            this.QtyAdult = int.Parse(System.Console.ReadLine());
            System.Console.Write("How many Senior tickets would you like?  ");
            this.QtySenior = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine();
            System.Console.Write("Will you be attending an evening or a matinee?  ");
            string input = System.Console.ReadLine();
            System.Console.WriteLine();
            if (input.ToLower().Contains("evening"))
            {
                this.TotalMovieCost += this.QtyChild * concession.EveningChild;
                this.TotalMovieCost += this.QtyAdult * concession.EveningAdult;
                this.TotalMovieCost += this.QtySenior * concession.EveningSenior;
            }
            else
            {
                this.TotalMovieCost += this.QtyChild * concession.MatineeChild;
                this.TotalMovieCost += this.QtyAdult * concession.MatineeAdult;
                this.TotalMovieCost += this.QtySenior * concession.MatineeSenior;
            }



        }
        public void DiscountCandy()
        {
            if (this.QtyCandy >= 31)
            //experimenting with crude but deeply nested if else, setting arbitrary maximum candy discount amount 
            {
                System.Console.WriteLine("You have received our maximum candy discount of $" + 8 * 1.99);

                this.CandyDiscount = 8 * 1.99;

                this.TotalConcessionCost -= 8 * 1.99;
            }
            else if (this.QtyCandy >= 27)
            {
                this.TotalConcessionCost -= 7 * 1.99;
                this.CandyDiscount = 7 * 1.99;
            }

            else if (this.QtyCandy >= 23)
            {
                this.TotalConcessionCost -= 6 * .199;
                this.CandyDiscount = 6 * 1.99;

            }

            else if (this.QtyCandy >= 19)
            {
                this.TotalConcessionCost -= 5 * 1.99;
                this.CandyDiscount = 5 * 1.99;
            }
            else if (this.QtyCandy >= 15)
            {
                this.TotalConcessionCost -= 4 * 1.99;
                this.CandyDiscount = 4 * 1.99;
            }
            else if (this.QtyCandy >= 11)
            {
                this.TotalConcessionCost -= 3 * 1.99;
                this.CandyDiscount = 3 * 1.99;
            }
            else if (this.QtyCandy >= 7)
            {
                this.TotalConcessionCost -= 2 * 1.99;
                this.CandyDiscount = 2 * 1.99;
            }
            else if (this.QtyCandy >= 3)
            {
                this.TotalConcessionCost -= 1.99;
                this.CandyDiscount = 1.99;

            }


        }

        public void TicketSodaDiscount()
        {
            if (this.QtyPopcorn >= 1 && this.QtyLargeSoda >= 1)
            {
                this.PopCornSodaSpecial = (2 * Math.Min(this.QtyPopcorn, this.QtyLargeSoda));

            }
        }


        public void RepeatOrderBack()
        {
          
            System.Console.WriteLine(this.QtyLargeSoda + " Large Sodas @ $" + concession.PriceLargeSoda + "ea......." + (concession.PriceLargeSoda * this.QtyLargeSoda));
            System.Console.WriteLine(this.QtySmallSoda + " Small Sodas @ $" + concession.PriceSmallSoda + "ea......" + (concession.PriceSmallSoda * this.QtySmallSoda));
            System.Console.WriteLine(this.QtyHotDogs + " Hot Dogs @ $" + concession.PriceHotDog + "ea......." + (concession.PriceHotDog * this.QtyHotDogs));
            System.Console.WriteLine(this.QtyPopcorn + " Pop Corns @ $" + concession.PricePopcorn + "ea....." + (concession.PricePopcorn * this.QtyPopcorn));
            System.Console.WriteLine(this.QtyCandy + " Candy @ $" + concession.PriceCandy + "ea....." + (concession.PriceCandy * this.QtyCandy));
            System.Console.WriteLine();
            if (this.QtyCandy >= 3)
            {
                System.Console.WriteLine("You received a discount of $" + this.CandyDiscount + " on your candy purchase.");
                System.Console.WriteLine();

            }
            System.Console.WriteLine();
            System.Console.WriteLine("Your entire concession purchase, including discounts so far, comes to $" + this.TotalConcessionCost);
            System.Console.WriteLine();

            if (this.PopCornSodaSpecial >= 1)
            {
                System.Console.WriteLine("You will also receive a discount on your movie tickets of $" + this.PopCornSodaSpecial);
            }





        }

        public void RepeatMovieOrder()
        {
            System.Console.WriteLine("Your movie tickets cost a total of $" + this.TotalMovieCost);
            bool freePopcorn;
            freePopcorn = ((this.QtyAdult + this.QtyChild + this.QtySenior) >= 3 && this.QtyPopcorn >= 1);
            if (this.PopCornSodaSpecial > 0)
            {
                System.Console.WriteLine("You received a discount on your movie tickets of  $" + this.PopCornSodaSpecial);
                this.TotalMovieCost -= this.PopCornSodaSpecial;
            }

            if (freePopcorn)
            {
                System.Console.WriteLine("You also received a free popcorn, so that will be an additional $" + concession.PricePopcorn + " off your concession bill");
                this.TotalConcessionCost -= concession.PricePopcorn;
            }


            else if ((this.QtyAdult + this.QtyChild + this.QtySenior) >= 3)
            {
                System.Console.WriteLine("You also receive a free popcorn!!!");
            }
            System.Console.WriteLine();
            System.Console.WriteLine("your total cost for movie tickets is  $" + this.TotalMovieCost);
            System.Console.WriteLine("Your total cost for concession items is $" + this.TotalConcessionCost);

        }
    }
}
 