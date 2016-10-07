﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Program
    {
        static void Main()
        {
            var phonebook = new Dictionary<string, string>();
            while (true)
            {
                string[] recievedString = Console.ReadLine().Split().ToArray();
                string command = recievedString[0];
                string name = "";

                if(command == "A")
                {
                    //ADD
                    name = recievedString[1];
                    string number = recievedString[2];
                    
                    if (!phonebook.ContainsKey(name))
                    {
                        phonebook.Add(name, number);
                    }
                    else
                    {
                        phonebook[name] = number;
                    }

                }
                else if(command == "S")
                {
                    name = recievedString[1];

                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                else if (command == "ListAll")
                {
                    var list = phonebook.Keys.ToList();
                    list.Sort();

                    foreach (var data in list)
                    {
                        Console.WriteLine($"{data} -> {phonebook[data]}");
                    }
                }
                else if (command == "END")
                {
                        break;
                }
            }
        }
    }
}
