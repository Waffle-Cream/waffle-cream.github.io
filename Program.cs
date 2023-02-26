using System;
namespace GG
{
    class program
    {
        static void Main()
        {
            string one = "1";
            string two = "2";
            string three = "3";
            string four = "4";
            string five = "5";
            string six = "6";
            string seven = "7";
            string eight = "8";
            string nine = "9";

            Console.WriteLine($"|{one}|{two}|{three}|\n|{four}|{five}|{six}|\n|{seven}|{eight}|{nine}|");
            Console.WriteLine("O's Turn");
           int OInput = Convert.ToInt16(Console.ReadKey());
            do
            {
                if(OInput == 1)
                {
                    one = "O";
                }
                if(OInput == 2)
                {
                    one = "O";
                }
                if(OInput == 3)
                {
                    one = "O";
                }
                if(OInput == 4)
                {
                    one = "O";
                }
                if(OInput == 5)
                {
                    one = "O";
                }
                if(OInput == 6)
                {
                    one = "O";
                }
                if(OInput == 7)
                {
                    one = "O";
                }
                if(OInput == 8)
                {
                    one = "O";
                }
                if(OInput == 9)
                {
                    one = "O";
                }
                
            }
            while(OInput !<= 9 && OInput !>= 1);

            }
        }
    }
