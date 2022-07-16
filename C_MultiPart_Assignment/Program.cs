using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_MultiPart_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            duplicateCheck();
            pauseLine();
            birdLister();
            pauseLine();
            presidentQuotes();
            pauseLine();
            loopRelationalOperator();
            pauseLine();
            stringArray();
            pauseLine();
            infinityLoop();
            pauseLine();
        }

        static void pauseLine()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("Hit ENTER to end current Program");
            Console.ReadLine();
        }

        static void duplicateCheck() // PART 6
        {
            List<string> birds = new List<string>()
            {"penguin", "stork", "pigeon", "stork", "robin", "sparrow", "parakeet", "flipper", "crow", "raven", "peacock", "kingfisher", "egret", "ibis", "hummingbird", "bluebird", "blackbird"};
            List<string> emptyList = new List<string>();



            Console.WriteLine("going thru list and checking for duplicates.");

            foreach (string item in birds)
            {
                if (emptyList.Contains(item))
                {
                    Console.WriteLine(item + " - DUPLICATE");
                } else
                {
                    Console.WriteLine(item + " - unique");
                }

                emptyList.Add(item);
            }

        }

        static void birdLister() //PART 5
        {
            List<string> birds = new List<string>()
            {"penguin", "stork", "pigeon", "stork", "robin", "sparrow", "parakeet", "crow", "raven", "peacock", "kingfisher", "egret", "ibis", "hummingbird", "bluebird", "blackbird"};

            Console.WriteLine("Enter a bird to search the list");
            string searchTerm = Console.ReadLine();

            bool foundTerm = false;
            for (int i = 0; i < birds.Count; i++)
            {
                string item = birds[i];
                if (item.Contains(searchTerm))
                {
                    foundTerm = true;
                    Console.WriteLine("At index " + i + " we found the Bird: " + item);
                }
            }
            if (!foundTerm)
            {
                Console.WriteLine("sorry, didnt find that bird.");
            }

        }

        static void presidentQuotes() {
            List<string> prezQuotes = new List<string>() { 
                "the only thing to fear is fear itself", 
                "grab her by the #####", 
                "poor kids are just as smart as white kids", 
                "I am not a crook", 
                "I'll wait until hell freezes over for your answer", 
                "that depends on what the definition of is is",
                "fool me once, shame on me"};

            Console.WriteLine("Welcome to the presidential quotes library. input a short search term to pull up your quote.");
            string searchterm = Console.ReadLine();

            bool foundTerm = false;
            for (int i = 0; i < prezQuotes.Count; i++)
            {
                string item = prezQuotes[i];
                if (item.Contains(searchterm))
                {
                    foundTerm = true;
                    Console.WriteLine("At index " +i+ " we found the quote: " +item);
                    break;
                }
            }
            if (!foundTerm)
            {
                Console.WriteLine("sorry, didnt find that term.");
            }

        }



        static void loopRelationalOperator() //PART 3
        {
            int money = 0;
            Console.WriteLine("Look at that great hat for sale!");
            while (money < 5)
            {
                Console.WriteLine("you're too poor to buy this hat. It costs $5.00. You have $" + money);
                Console.WriteLine("Press enter to work at the mines for $1.00 / day");
                Console.ReadLine();
                money++;
            }
            Console.WriteLine("You have enough to buy the hat. Buy it? enter y for yes, n for no.");
            if (Console.ReadLine() == "y")
            {
                Console.WriteLine("You bought the hat");
                money -= 5;
            } else
            {
                Console.WriteLine("Saving up for smething better, huh?");
            }


            Console.WriteLine("This better hat is even better.");
            Console.ReadLine();
            while (money <= 19)
            {

                Console.WriteLine("you're too poor to buy this hat. It costs $20.00. You have $" + money);
                Console.WriteLine("Press enter to work at Google for $5.00 / day");
                Console.ReadLine();
                money+=5;
            }
            Console.WriteLine("You bought the better hat!");


        }

        static void infinityLoop() // PART 2
        {
            bool infinite = true;
            Console.WriteLine("Welcome to the Infinity Loop. To Escape, you must enter the 6 digit number I am thinking of.");

            while (infinite)
            {
                Console.WriteLine("Enter some text");
                string yourText = Console.ReadLine();
                

                if (yourText.Length == 6)
                {
                    Console.WriteLine("Wow, you guessed it on the first try!");
                    infinite = false; //this line allows you to escape the loop
                } else
                {
                    Console.WriteLine("That's not 6 digits, try again");
                }
            }
        }


        static void stringArray() //PART 1
        {
            string[] stringies = { "flib", "bilf", "lifb" };
            Console.WriteLine("Enter some text");
            string inputText = Console.ReadLine();

            for (int i = 0; i < stringies.Length; i++)
            {
                stringies[i] = stringies[i] + " " + inputText;
            }

            foreach (string i in stringies)
            {
                Console.WriteLine(i);
            }
        }


    }
}
