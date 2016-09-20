using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesSlide22
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
Create a the following Dictionary:
Dictionary<string, int> animals = new Dictionary<string, int>();
Add 6 animals in the following format
animals.Add("Bear", 4);
animals.Add("Squid", 10);
animals.Add("Bird", 2);
“ ”
“ ”
“ ”
Run queries against the dictionary in the following format. Test different animals. Try animals that aren’t in the dictionary.

if (dictionary.ContainsKey("Bear"))
{
	int value = dictionary["Bear"];
	 Console.WriteLine(“Bear has ” + value + ” legs.”);
}


How can we make the previous queries more efficient to use?
*/
            Dictionary<string, int> animals = new Dictionary<string, int>();
            {
                animals.Add("Cat", 4);
                animals.Add("Squirrel", 4);
                animals.Add("Turtle", 4);
                animals.Add("Lobster", 6);
                animals.Add("Elephant", 4);
                animals.Add("Lion", 4);
            };
                if (animals.ContainsKey("Lion"))
                {
                    int value = animals["Lion"];
                string animal = "Lion";
                    Console.WriteLine("The " + animal + " has " + value + " legs.");
                }
            

        }
    }
}
