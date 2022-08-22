using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    { 
        public void Run()
        {
            
            //Initialize base stats.
            string name = "";
            float health = 100;
            bool isAlive = true;
            float damage = 10;

            //Assigns name variable based on user input.
            Console.WriteLine("Please input a name.");
            name = Console.ReadLine();

            //Prints all stats of current player.
            Console.WriteLine("Welcome!");
            Console.WriteLine("Stats");
            Console.Write("Name: ");
            Console.WriteLine(name);
            Console.Write("Health: ");
            Console.WriteLine(health);
            Console.Write("Damage: ");
            Console.WriteLine(damage);

        }
    }
}
