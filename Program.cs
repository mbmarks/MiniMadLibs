using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play MAD LIBS!\n");

            string nounOne, adjectiveOne, nounTwo, numberOne, adjectiveTwo,
                pluralNounOne, pluralNounTwo, pluralNounThree, verbPresentTense,
                verbPastTense;

            Console.Write("I need a noun: ");
            nounOne = Console.ReadLine();

            Console.Write("\nNow I need an adjective: ");
            adjectiveOne = Console.ReadLine();

            Console.Write("\nAnother noun: ");
            nounTwo = Console.ReadLine();

            Console.Write("\nAnd a number: ");
            numberOne = Console.ReadLine();

            Console.Write("\nAnother adjective: ");
            adjectiveTwo = Console.ReadLine();

            Console.Write("\nA plural noun: ");
            pluralNounOne = Console.ReadLine();

            Console.Write("\nAnother one: ");
            pluralNounTwo = Console.ReadLine();

            Console.Write("\nOne more: ");
            pluralNounThree = Console.ReadLine();

            Console.Write("\nA verb (infinitive form): ");
            verbPresentTense = Console.ReadLine();

            Console.Write("\nSame verb (past participle): ");
            verbPastTense = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("*** NOW LETS GET MAD (libs) ***");
            Console.WriteLine($"{nounOne}: the {adjectiveOne} frontier. These are the voyages of the " +
                $"starship {nounTwo}. Its {numberOne}-year mission: to explore {adjectiveTwo} {pluralNounOne}, to seek " +
                $"out {adjectiveTwo} {pluralNounTwo} and {adjectiveTwo} {pluralNounThree}, to boldly " +
                $"{verbPresentTense} where no one has {verbPastTense} before.");

            Console.ReadLine();
            // Adding a comment to see if I can commit this
        }
    }
}
