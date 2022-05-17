using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SocialSecurityNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string ssn;
            string pattern = @"^(?!000)(?!666)(?!9[0-9][0-9])\d{3}[- ]?(?!00)\d{2}[- ]?(?!0000)\d{4}$";
            Regex re= new Regex(pattern);
            Console.WriteLine("Enter your SSN");
            ssn = Console.ReadLine();
            var Matching = re.IsMatch(ssn);
            Console.WriteLine(Matching);

            if (ssn == null)
            {
                Console.WriteLine("False");
            }
        }
    }
}