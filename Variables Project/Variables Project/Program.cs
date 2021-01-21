using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_Project

{
    class Program
    {
        static void Main(string[] args)
        {
            char myCharacter = 'a';

            string dogName = "Fido";

            int dogAge = 5;

            bool isSmall = true;

            double weight = 5.2;

            decimal length = 10.2m;

            Console.WriteLine($"My dogs name is {dogName}, He is {dogAge} years old");
            Console.WriteLine($"He is {myCharacter}, type of Terrier");
            Console.WriteLine($"He makes me happy");
            Console.WriteLine($"He is small." + " " + isSmall);
            Console.WriteLine($"He weighs" + " " + weight + " " + "pounds.");
            Console.WriteLine($"He is" + " " + length + " " + "inches long.");
        }
    }
}