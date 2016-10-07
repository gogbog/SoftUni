using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Hands_of_cards
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] {':',',',' '};
            var types = new Dictionary<string, int>() { { "S", 4 }, { "H", 3}, { "D", 2 }, { "C", 1 }};
            var cardsValues = new Dictionary<string, int>() {{ "2", 2 }, { "3", 3 }, { "4", 4 },
            { "5", 5 }, { "6", 6 }, { "7", 7 }, { "8", 8 }, { "9", 9 }, { "10", 10 }, { "J", 11 },
            { "Q", 12 }, { "K", 13 }, { "A", 14 }};
            var playersCards = new Dictionary<string, List<string>>();

           


            while (true)
            {
                var playerInfo = Console.ReadLine().Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var name = playerInfo[0];

                if (name == "JOKER")
                {
                    break;
                }

                var cards = playerInfo[1].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(c => c.Trim()).ToArray();

                if (!playersCards.ContainsKey(name))
                {
                    playersCards.Add(name, new List<string>());
                }

                playersCards[name].AddRange(cards);

            }

            foreach (var playerData in playersCards)
            {
                string playerName = playerData.Key;

                var cards = playerData.Value.Distinct().ToList();
                int sum = 0;

                foreach (var card in cards)
                {
                    //10A
                    //3B
                    string rank = card.Substring(0, card.Length - 1);
                    string type = card.Substring(card.Length - 1);

                    sum += cardsValues[rank] * types[type];
                }

                Console.WriteLine($"{playerName}: {sum}");
            }
            
        }
    }
}
