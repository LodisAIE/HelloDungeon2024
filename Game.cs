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
            bool playerIsAlive = health > 0;
            float damage = 10;
            float powerLevel = 0;

            //Assigns name variable based on user input.
            Console.WriteLine("Please input a name.");
            name = Console.ReadLine();

            //Class selection menu
            Console.WriteLine("Welcome " + name + "!!!");
            Console.WriteLine("Please select a class");
            Console.WriteLine("Thief");
            Console.WriteLine("Warrior");
            Console.WriteLine("Mage");

            string choice = Console.ReadLine();

            if (choice == "Thief")
            {
                health = 50;
                damage = 15;
            }
            else if (choice == "Warrior")
            {
                health = 150;
                damage = 4550;
            }
            else if (choice == "Mage")
            {
                health = 2;
                damage = 2;
            }

            Console.WriteLine("Stats");

            Console.Write("Name: ");
            Console.WriteLine(name);

            Console.Write("Class:");
            Console.WriteLine(choice);

            Console.Write("Health: ");
            Console.WriteLine(health);

            Console.Write("Damage: ");
            Console.WriteLine(damage);

            powerLevel = health * damage;
            Console.Write("Power Level:");
            Console.WriteLine(powerLevel);
        }
    }
}
