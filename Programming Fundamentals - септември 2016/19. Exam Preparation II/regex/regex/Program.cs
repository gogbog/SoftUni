using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace regex
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();

            string rgx = "(\\D+)(\\d+)";
            Regex regex = new Regex(rgx);

            StringBuilder elements = new StringBuilder();
            StringBuilder output = new StringBuilder();

            MatchCollection collection = regex.Matches(input);

            foreach (Match match in collection)
            {
                //count += match.Groups[1].ToString().Distinct().Count();
                elements.Append(match.Groups[1]);
                
                for (int i = 0; i < int.Parse(match.Groups[2].ToString()); i++)
                {
                    output.Append(match.Groups[1]);
                }
            }

            int count = output.ToString().Distinct().Count();

            Console.WriteLine("Unique symbols used: {0}", count);
            Console.WriteLine(output);
        }
    }
}
