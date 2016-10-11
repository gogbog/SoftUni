using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            var dragonMassive = new Dictionary<string, Dictionary<string, int[]>>();
            string[] defaultValues = new string[] { "250", "45", "10" };

            int times = int.Parse(Console.ReadLine());

            for (int i = 0; i < times; i++)
            {
                string[] inputedInfo = Console.ReadLine().Split();

                string dragonType = inputedInfo[0];
                string dragonName = inputedInfo[1];
                string dragonDamage = inputedInfo[2];
                string dragonHealth = inputedInfo[3];
                string dragonArmor = inputedInfo[4];

                //validation
                if (dragonDamage == "null")
                {
                    dragonDamage = defaultValues[1];
                }

                if (dragonHealth == "null")
                {
                    dragonHealth = defaultValues[0];
                }

                if (dragonArmor == "null")
                {
                    dragonArmor = defaultValues[2];
                }

                //checks if the massive exists 
                if (!dragonMassive.ContainsKey(dragonType))
                {
                    dragonMassive.Add(dragonType, new Dictionary<string, int[]>());
                }

                if (!dragonMassive[dragonType].ContainsKey(dragonName))
                {
                    dragonMassive[dragonType].Add(dragonName, new int[] { 0, 0, 0 });
                }

                //start the injection
                int[] statsData = new int[] { int.Parse(dragonDamage),
                                              int.Parse(dragonHealth),
                                              int.Parse(dragonArmor) };

                dragonMassive[dragonType][dragonName] = statsData;
            }

            foreach (var dragonMassiveData in dragonMassive)
            {
                var dragonsList = dragonMassiveData.Value.OrderBy(x => x.Key).ToList();

                double[] aproxValues = AproxValues(dragonsList);

                Console.WriteLine("{0}::({1:F2}/{2:F2}/{3:F2})", dragonMassiveData.Key, aproxValues[0], aproxValues[1], aproxValues[2]);

                foreach (var dragonData in dragonsList)
                {
                    var dragonName = dragonData.Key;
                    int[] dragonStats = dragonData.Value;

                    Console.WriteLine($"-{dragonName} -> damage: {dragonStats[0]}, health: {dragonStats[1]}, armor: {dragonStats[2]}");
                }
            }
        }

        private static double[] AproxValues(List<KeyValuePair<string, int[]>> dragonsList)
        {
            double damage = 0.0;
            double health = 0.0;
            double armor = 0.0;
            int count = 0; //moje da suzdade problem

            foreach (var dragonData in dragonsList)
            {
                int[] dragonStats = dragonData.Value;

                damage += dragonStats[0];
                health += dragonStats[1];
                armor += dragonStats[2];
                count++;
            }

            damage = damage / count;
            health = health / count;
            armor = armor / count;

            double[] result = new double[] { damage, health, armor };

            return result;
        }
    }
}
