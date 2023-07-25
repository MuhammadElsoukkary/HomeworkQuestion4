using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkQuestion4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String Letter;
            Console.WriteLine("Please enter a letter");
            Letter = Console.ReadLine();
            switch (Letter)
            {
                case "A":
                case "E":
                case "I":
                case "O":
                case "U":
                Console.WriteLine("This is a vowel");
                    break;
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                Console.WriteLine("This is a vowel");
                    break;
                default:
                    Console.WriteLine("Invalid letter entered");
                    break;
            }
            Console.ReadKey();


        }
    }
}
