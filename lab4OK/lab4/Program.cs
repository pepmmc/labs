using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {


            concession FirstOrder = new concession();
            FirstOrder.GetOrderConcession();
            System.Console.WriteLine();
            FirstOrder.DiscountCandy();
            System.Console.WriteLine();
            FirstOrder.TicketSodaDiscount();
            FirstOrder.RepeatOrderBack();
            FirstOrder.GetMovieOrder();
            FirstOrder.RepeatMovieOrder();
            
            
            System.Console.ReadLine();









            //calculating discount








        }
    }
}


