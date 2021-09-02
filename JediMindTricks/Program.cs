using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace JediMindTricks
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> people = new Dictionary<string, int>(); //Opgave 1
            people.Add("Julie", 33); //Opgave 2
            people["Sienna"] = 5;
            people["Han"] = 29;

            Console.WriteLine(people.First());
            people.Remove("Han"); //Opgave 3

            foreach(var person in people) //Opgave 4
            {
                Console.WriteLine(person.Value);
            }
            

                
        }

        
    }
}
