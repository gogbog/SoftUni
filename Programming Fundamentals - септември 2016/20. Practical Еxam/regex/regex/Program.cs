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
                int health = 0;


                char[] allChars = names[i].ToCharArray();


                for (int z = 0; z < allChars.Length; z++)
                {
                    if (Char.IsLetter(allChars[z]))
                    {
                        health += (int)allChars[z];
                    }

                    if (Char.IsNumber(allChars[z]))
                    {

                        decimal number = int.Parse(allChars[z].ToString());

                        if (z < names.Length - 1)
                        {
                            if (allChars[z + 1] == '.')
                            {

                                decimal secondNumber = decimal.Parse(allChars[z + 2].ToString()) / 10;
                                number = number + secondNumber;
                                damage += number;
                                z += 2;

                            }
                        }

                        Console.WriteLine(number);

                    }

                    if (allChars[z] == '/')
                    {
                        damage /= 2;
                    }

                    if (allChars[z] == '*')
                    {
                        damage *= 2;
                    }

                }

                Console.WriteLine(health);
                Console.WriteLine(damage);

                /*

                Dragon dragon = new Dragon();
                dragon.name = names[i];
                dragon.damage = damage;
                dragon.health = health;

                dragons.Add(dragon);
                */

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
        public int health { get; set; }
    }
}
