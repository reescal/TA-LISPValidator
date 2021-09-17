using System;
using System.Linq;

namespace LISPValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine($"Input LISP code and press enter: ");
                var validationResult = Validator.ValidateLISP(Console.ReadLine());
                Console.WriteLine($"The input is {(validationResult ? "valid" : "invalid")}.");
                Console.WriteLine("\nTo exit press CTRL+C\n");
            }
        }

    }
}
