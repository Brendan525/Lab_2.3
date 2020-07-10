using System;
using System.Text.RegularExpressions;

namespace Lab_2._3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a valid name: ");
            string name = Console.ReadLine();

            Regex entry = new Regex(@"^[A-Z][A-Za-z][^0-9|@|!|#|$|%|^|&|*|(|)|-|=|+|_|[|\]|\|\||,|<|.|>|/|\|?|]{1,30}$");

            bool matched = entry.IsMatch(name);

            if (matched)
            {
                Console.WriteLine("This name is valid");
            }
            else
            {
                Console.WriteLine("Name is not valid");
            }

            Console.Write("\n");



            Console.WriteLine("Please enter a valid email: ");
            string email = Console.ReadLine();

            Regex address = new Regex(@"^\w{5,30}@\w{5,10}\.\w{2,3}$");


            bool matched2 = address.IsMatch(email);

            if (matched2)
            {
                Console.WriteLine("This email is valid");
            }
            else
            {
                Console.WriteLine("Email is not valid");
            }

            Console.Write("\n");


            Console.WriteLine("Please enter a valid phone number: ");
            string number = Console.ReadLine();

            Regex reg = new Regex(@"\(?\d{3}\)?[.,-]\d{3}[.,-]\d{4}");

            bool matched3 = reg.IsMatch(number);

            if (matched3)
            {
                Console.WriteLine("The phone number is valid");
            }
            else
            {
                Console.WriteLine("The phone number doesnt work");
            }

            Console.Write("\n");


            Console.WriteLine("Please enter a valid date: ");
            Console.WriteLine("Use the mm/dd/yyyy format");
            string date = Console.ReadLine();

            Regex day = new Regex(@"(0[1-9]|1[1-2])[/](3[01]|[12][0-9]|[0][1-9])[/]\d{2,4}");

            bool matched4 = day.IsMatch(date);

            if (matched4)
            {
                Console.WriteLine("This date is valid");
            }
            else
            {
                Console.WriteLine("Date is not valid");
            }

            Console.Write("\n");

            Console.WriteLine("Please enter a valid HTML element: ");
            string html = Console.ReadLine();

            Regex element = new Regex(@"^<([A-Za-z0-9]+)>.*<\/\1>$"); // ^(must start with) < ([A-Za-z0-9]+) means looks for a leter or number 0-9 (searches for) > after (. means matches anything besides a line break) (* means matches 0 or more of the preceding token) (\/ means only look for /) (\# look for that previous group)

            bool matched5 = element.IsMatch(html);

            if (matched5)
            {
                Console.WriteLine("This HTML element is valid");
            }
            else
            {
                Console.WriteLine("HTML elment is not valid");
            }
        }
    }
}
