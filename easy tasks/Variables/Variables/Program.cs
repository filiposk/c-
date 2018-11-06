using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("What is your name?");
            Console.Write("Type your first name: ");
            string FirstName;
            FirstName = Console.ReadLine();

            
            string LastName;
            Console.Write("Type is your last name: ");
            LastName = Console.ReadLine();

            Console.WriteLine("Hello, " + FirstName + " " + LastName);
            Console.ReadLine();
        }
    }
}
