using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] specialWords = File.ReadAllText("words.txt").Split();
            string[] text = File.ReadAllText("text.txt").ToLower()
            .Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' },
            StringSplitOptions.RemoveEmptyEntries);

            var wordCount = new Dictionary<string, int>();

            for (int i = 0; i < text.Length; i++)
            {
                string word = text[i];

                for (int z = 0; z < specialWords.Length; z++)
                {
                    if (word == specialWords[z])
                    {
                        if (!wordCount.ContainsKey(word))
                        {
                            wordCount.Add(word, 0);
                        }

                        wordCount[word]++;
                    }
                }
            }

            foreach (var wordData in wordCount)
            {
                File.AppendAllText("output.txt", $"{wordData.Key} - {wordData.Value} {Environment.NewLine}");
            }
        }
    }
}
