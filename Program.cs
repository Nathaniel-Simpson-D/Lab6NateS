using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab7RegularExpressionsNateS
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                string name = VerifyNames("What is your Name?");
                string email = VerifyEmail("What is you email?");
                string phonNum = VerifyPhoneNumber("What is your Phone#?");
                string Bdate = VerifyDate("what is your Bdate");
                string favWeb = VerifyHTML("what is your favorite website?");
                string[] userdata = { name, email, phonNum, Bdate, favWeb };
                foreach (string data in userdata)
                {
                    Console.WriteLine(data);
                }
            } while (GetYesNo("Do you want to continue?"));
        }
        public static string VerifyEmail(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            if (Regex.IsMatch(input, @"^(\w{4,30})\@(\w{5,15})\.([a-z]{2,3})$"))
            {
                return input;
            }
            else
            {
                return VerifyEmail("Not Valid!");
            }
        }
        public static string VerifyNames(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            if (Regex.IsMatch(input, @"^((\w{3,20})\s(\w{0,20}))$"))
            {
                return input;
            }
            else
            {
                return VerifyNames("Not Valid!");
            }
        }
        public static string VerifyPhoneNumber(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("Format as XXX-XXX-XXXX");
            string input = Console.ReadLine();
            if(Regex.IsMatch(input, @"^((\d{3})\-(\d{3})\-(\d{4}))"))
            {
                return input;
            }
            else
            {
                return VerifyPhoneNumber("Not Valid!");
            }
        }
        public static string VerifyDate(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("Format as DD/MM/YYYY");
            string inputS = Console.ReadLine();
            if (Regex.IsMatch(inputS, @"^((\d{2})\/(\d{2})\/(\d{4}))$"))
            {
                return inputS;
            }
            else
            {
                return VerifyPhoneNumber("Not Valid!");
            }
        }
        public static string VerifyHTML(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            if (Regex.IsMatch(input, @"^((\w{0,}\d{0,})\.(\w{2,3}))$"))
            {
                return input;
            }
            else
            {
                return VerifyHTML("Not Valid!");
            }
        }
        public static bool GetYesNo(string message)
        {
            Console.WriteLine($"{message}(Y/N)");
            if (Console.ReadKey(true).Key == ConsoleKey.Y)
            {
                return true;
            }
            else if (Console.ReadKey(true).Key == ConsoleKey.N)
            {
                return false;
            }
            else
            {
                return GetYesNo("Not Valid");
            }
        }
    }
}
