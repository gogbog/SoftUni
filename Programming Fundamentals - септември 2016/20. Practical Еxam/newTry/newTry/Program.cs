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
            string[] names = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None);
            List<Dragon> dragons = new List<Dragon>();

            for (int i = 0; i < names.Length; i++)
            {


                decimal damage = 0;
                decimal health = 0;
                int multiply = names[i].Count(x => x == '*');
                int devide = names[i].Count(x => x == '/');

                string numberRgx = @"[a-zA-ZäöüßÄÖÜ]";
                string letterRgx = @"\D";

                Regex regexNumber = new Regex(numberRgx);
                Regex regexLetter = new Regex(letterRgx);

                MatchCollection numbers = regexNumber.Matches(names[i]);
                MatchCollection letters = regexLetter.Matches(names[i]);


                foreach (var letter in letters)
                {
                    char character = letter.ToString().ToCharArray().First();
                    health += (int)character;
                }

                foreach (var data in numbers)
                {
                    decimal number = decimal.Parse(data.ToString());
                    damage += number;
                }


                for (int z = 0; z < multiply; z++)
                {
                    damage *= 2;
                }

                for (int z = 0; z < devide; z++)
                {
                    damage /= 2;
                }

                Dragon dragon = new Dragon();
                dragon.name = names[i];
                dragon.damage = damage;
                dragon.health = health;

                dragons.Add(dragon);

            }


            foreach (var dragon in dragons.OrderBy(x => x.name))
            {
                Console.WriteLine("{0} - {1} health, {2:F2} damage", dragon.name, dragon.health, dragon.damage);
            }

        }
    }

    class Dragon
    {
        public string name { get; set; }
        public decimal damage { get; set; }
        public decimal health { get; set; }
    }
}
