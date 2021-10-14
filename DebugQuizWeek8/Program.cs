using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DebugQuizWeek8
{
    class Program
    {
        static void Main(string[] args)
        {
            const string ITEM209 = "209";
            const string ITEM312 = "312";
            const string ITEM414 = "414";
            const double PRICE209 = 12.99, PRICE312 = 16.77, PRICE414 = 109.07;
            double price;
            string stockNum;
            Write("Please enter the stock number of the item you want ");
            stockNum = ReadLine();
            while (stockNum != ITEM209 || stockNum != ITEM312 || stockNum != ITEM414)
            {
                WriteLine("Invalid stock number. Please enter again. ");
                stockNum = ConsoleReadLine();
            }
            if (stockNum == ITEM209)
                price = PRICE209;
            else
               if (stockNum == ITEM312)
                price = PRICE414;
            else
                price = PRICE312;
            WriteLine("The price for item # {0} is {1}}", stockNum, price.ToString("C"));
        }
    }
}