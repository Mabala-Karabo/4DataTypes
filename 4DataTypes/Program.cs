using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaration of a string, an integer, a boolean, and a decimal
            string name = "Karabo";
            string surname = "Mabala";
            int age = 34;
            bool isTall = true;
            double weight = 23.5;
            char initial = 'A'; // this one takes only one character

            //printing to console
            Console.WriteLine("His name is " + name + " and he's " + age + "  it is " + isTall + " that he is tall");
            Console.WriteLine("He weights " + weight + "kg and initialized " + initial);

            //changing the variable assignment
            name = name + " " + surname;
            age = age - 12;
            isTall = false;
            weight = weight + 52;
            initial = 'P';

            Console.WriteLine("His name is " + name + " and he's " + age + "  it is " + isTall + " that he is tall");
            Console.WriteLine("He weights " + weight + "kg and initialized " + initial);
            //freeze to console
            Console.ReadLine();

        }
    }
}
