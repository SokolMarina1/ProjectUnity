using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Program
    {
        class House
        {
            public string street;
            public int number;

            public void Print()
            {
                Console.WriteLine($"{street}, {number}");
            }
        }
    static void Main(string[] args)
        {
            House tower = new House();
            tower.street = "Красная";
            tower.number = 50;

            tower.Print();

        }
    }
}

